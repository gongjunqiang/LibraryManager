using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public DataTable GetAllReaderRole()
        {
            return readerService.GetAllReaderRole().Tables[0];
        }
        #endregion

        #region 增、删、改
        /// <summary>
        /// 会员办证（添加读者信息）
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public int AddNewReader(Reader reader)
        {
            return readerService.AddNewReader(reader);
        }


        /// <summary>
        /// 修改读者信息
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public int EditReader(Reader reader)
        {
            return readerService.EditReader(reader);
        }

        /// <summary>
        /// 借阅证挂失
        /// </summary>
        /// <param name="readerId"></param>
        /// <returns></returns>
        public int ForbiddenReadingCard(string readerId)
        {
            return readerService.ForbiddenReadingCard(readerId);
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
            return readerService.QueryReaderInfoByIdCard(idCard);
        }

        /// <summary>
        /// 根据借阅证号查询
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public Reader QueryReaderInfoByReadingCard(string readingCard)
        {
            return readerService.QueryReaderInfoByReadingCard(readingCard);
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
            var list =readerService.GetReaderByRoleId(roleId, out readercount);
            foreach (Reader reader in list)
            {
                switch (reader.StatusId)
                {
                    case 1:
                        reader.StatusDesc = "正常";
                        break;
                    default:
                        reader.StatusDesc = "禁用";
                        break;
                }
            }
            return list;
        }
        #endregion






    }
}
