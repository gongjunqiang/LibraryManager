using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using DBUtility;

namespace DAL
{
    /// <summary>
    /// 读者数据访问类
    /// </summary>
    public class ReaderService
    {
        #region 增、删、改
        /// <summary>
        /// 会员办证（添加读者信息）
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public int AddNewReader(Reader reader)
        {
            SqlParameter[] sqlParameters =new SqlParameter[]
            {
                new SqlParameter("@ReadingCard",reader.ReadingCard),
                new SqlParameter("@ReaderName",reader.ReaderName),
                new SqlParameter("@Gender",reader.Gender),
                new SqlParameter("@IDCard",reader.IDCard),
                new SqlParameter("@ReaderAddress",reader.ReaderAddress),
                new SqlParameter("@PostCode",reader.PostCode),
                new SqlParameter("@PhoneNumber",reader.PhoneNumber),
                new SqlParameter("@RoleId",reader.RoleId),
                new SqlParameter("@ReaderImage",reader.ReaderImage),
                new SqlParameter("@ReaderPwd",reader.ReaderPwd),
                new SqlParameter("@AdminId",reader.AdminId),
            };

            try
            {
                return SqlHelper.ExecuteNonQuery("usp_AddNewReader", sqlParameters, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 修改读者信息
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public int EditReader(Reader reader)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ReadingCard",reader.ReadingCard),
                new SqlParameter("@ReaderName",reader.ReaderName),
                new SqlParameter("@Gender",reader.Gender),
                new SqlParameter("@ReaderAddress",reader.ReaderAddress),
                new SqlParameter("@PostCode",reader.PostCode),
                new SqlParameter("@PhoneNumber",reader.PhoneNumber),
                new SqlParameter("@RoleId",reader.RoleId),
                new SqlParameter("@ReaderImage",reader.ReaderImage),
            };

            try
            {
                return SqlHelper.ExecuteNonQuery("usp_EditReader", sqlParameters, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 借阅证挂失
        /// </summary>
        /// <param name="readerId"></param>
        /// <returns></returns>
        public int ForbiddenReadingCard(string readerId)
        {
            string sql = "update Readers set StatusId=0 where ReaderId=@ReaderId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ReaderId",readerId)
            };

            try
            {
                return SqlHelper.ExecuteNonQuery(sql, sqlParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 会员角色查询
        /// <summary>
        /// 会员角色查询
        /// </summary>
        /// <returns></returns>
        public List<ReaderRole> GetAllReaderRoles()
        {
            string sql = "select RoleId,RoleName,AllowDay,AllowCounts from ReaderRoles";
            List<ReaderRole> roleList = new List<ReaderRole>();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(sql);
                while (reader.Read())
                {
                    roleList.Add(new ReaderRole
                    {
                        RoleId = Convert.ToInt32(reader["RoleId"]),
                        RoleName = reader["RoleName"].ToString(),
                        AllowDay = Convert.ToInt32(reader["AllowDay"]),
                        AllowCounts = Convert.ToInt32(reader["AllowCounts"]),
                    });
                }
                reader.Close();
                return roleList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 返回DataSet数据集
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllReaderRole()
        {
            string sql = "select RoleId,RoleName,AllowDay,AllowCounts from ReaderRoles";
            return SqlHelper.GetDataSet(sql);
        }


        #endregion

        #region 根据身份证号与借阅证号查询
        /// <summary>
        /// 根据身份证号查询
        /// </summary>
        /// <param name="idCard"></param>
        /// <returns></returns>
        public Reader QueryReaderInfoByIdCard(string idCard)
        {
            string sql = " where IDCard=@IDCard";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@IDCard",idCard),
            };
            return QueryReaderInfo(sqlParameters, sql);
        }

        /// <summary>
        /// 根据借阅证号查询
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public Reader QueryReaderInfoByReadingCard(string readingCard)
        {
            string sql = " where ReadingCard=@ReadingCard";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ReadingCard",readingCard),
            };
            return QueryReaderInfo(sqlParameters, sql);
        }

        private Reader QueryReaderInfo(SqlParameter[] sqlParameters,string sqlWhere)
        {
            string sql = "select ReaderId,ReadingCard,ReaderName,Gender,IDCard,ReaderAddress,PostCode,PhoneNumber,ReaderRoles.RoleId,ReaderImage,StatusId,RoleName from Readers";
            sql += " inner join ReaderRoles on Readers.RoleId=ReaderRoles.RoleId";
            SqlDataReader objReader = SqlHelper.ExecuteReader(sql+ sqlWhere, sqlParameters);
            Reader reader = null;
            if (objReader.Read())
            {
                reader = new Reader
                {
                    ReaderId = Convert.ToInt32(objReader["ReaderId"]),
                    ReadingCard = objReader["ReadingCard"].ToString(),
                    ReaderName = objReader["ReaderName"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    IDCard = objReader["IDCard"].ToString(),
                    ReaderAddress = objReader["ReaderAddress"].ToString(),
                    PostCode = objReader["PostCode"].ToString(),
                    PhoneNumber = objReader["PhoneNumber"].ToString(),
                    RoleId = Convert.ToInt32(objReader["RoleId"]),
                    ReaderImage = objReader["ReaderImage"] is null ? "" : objReader["ReaderImage"].ToString(),
                    RoleName = objReader["RoleName"].ToString(),
                    StatusId = Convert.ToInt32(objReader["StatusId"])
                };
            }
            objReader.Close();
            return reader;
        }



        #endregion

        #region 根据会员角色查询读者信息
        /// <summary>
        /// 根据会员角色查询读者信息
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="readercount"></param>
        /// <returns></returns>
        public List<Reader> GetReaderByRoleId(string roleId, out int readercount)
        {
            string sql = "select ReaderId,ReadingCard,ReaderName,Gender,ReaderAddress,PostCode,PhoneNumber,RoleId,RegTime,StatusId from Readers";
            sql += " where RoleId=@RoleId;";
            sql += " select ReaderCount=count(1) from Readers where RoleId=@RoleId;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@RoleId",roleId), 
            };
            List<Reader> readers = new List<Reader>();
            int count = 0;
            try
            {
                SqlDataReader objReader = SqlHelper.ExecuteReader(sql, sqlParameters);
                while (objReader.Read())
                {
                    readers.Add(new Reader
                    {
                        ReaderId = Convert.ToInt32(objReader["ReaderId"]),
                        ReadingCard = objReader["ReadingCard"].ToString(),
                        ReaderName = objReader["ReaderName"].ToString(),
                        Gender = objReader["Gender"].ToString(),
                        ReaderAddress = objReader["ReaderAddress"].ToString(),
                        PostCode = objReader["PostCode"].ToString(),
                        PhoneNumber = objReader["PhoneNumber"].ToString(),
                        StatusId = Convert.ToInt32(objReader["StatusId"]),
                        RegTime = Convert.ToDateTime(objReader["RegTime"])
                    });
                }
                if (objReader.NextResult())
                {
                    if (objReader.Read())
                    {
                        count = Convert.ToInt32(objReader["ReaderCount"]);
                    }
                }
                objReader.Close();
                readercount = count;
                return readers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
