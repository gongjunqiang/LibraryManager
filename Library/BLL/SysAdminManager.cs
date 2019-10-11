using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class SysAdminManager
    {
        private SysAdminService adminService = new SysAdminService();

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin admin)
        {
            return adminService.AdminLogin(admin);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="pwd"></param>
        /// <param name="adminId"></param>
        /// <returns></returns>
        public int MoifyPwd(string pwd, string adminId)
        {
            return adminService.MoifyPwd(pwd, adminId);
        }
    }
}
