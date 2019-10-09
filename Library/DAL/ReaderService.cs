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
        //会员办证（添加读者信息）
//        public int AddNewReader(Reader reader)
//        {
//
//        }


        //修改读者信息

        //借阅证挂失

        //会员角色查询
        public List<ReaderRole> GetAllReaderRoles()
        {
            string sql = "select RoleId,RoleName,AllowDay,AllowCounts from ReaderRoles";
            List < ReaderRole > roleList = new List<ReaderRole>();
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

        //根据省份证号与借阅证号查询

        //根据角色查询

    }
}
