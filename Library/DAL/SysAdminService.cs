using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtility;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 管理员数据访问类
    /// </summary>
    public class SysAdminService
    {
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin admin)
        {
            string sql = "select AdminName,StatusId,RoleId from SysAdmins where AdminId=@AdminId and LoginPwd=@LoginPwd";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@AdminId",admin.AdminId),
                new SqlParameter("@LoginPwd",admin.LoginPwd), 
            };

            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(sql, sqlParameters);
                if (reader.Read())
                {
                    admin.AdminName = reader["AdminName"].ToString();
                    admin.RoleId = Convert.ToInt32(reader["RoleId"]);
                    admin.StatusId = Convert.ToInt32(reader["StatusId"]);
                }
                else
                {
                    admin = null;
                }
                reader.Close();
                return admin;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="pwd"></param>
        /// <param name="adminId"></param>
        /// <returns></returns>
        public int MoifyPwd(string pwd, string adminId)
        {
            string sql = "update SysAdmins set LoginPwd=@LoginPwd where AdminId=@AdminId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LoginPwd",pwd),
                new SqlParameter("@AdminId",adminId)
            };
            return SqlHelper.ExecuteNonQuery(sql, sqlParameters);
        }
    }
}
