using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    /// <summary>
    /// 读者业务类
    /// </summary>
    public class ReaderManager
    {
        private ReaderService readerService = new ReaderService();
        #region 查询会员角色

        //会员角色查询
        public List<ReaderRole> GetAllReaderRoles()
        {
            return readerService.GetAllReaderRoles();
        }

        #endregion


    }
}
