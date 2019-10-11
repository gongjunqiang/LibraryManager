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
    /// <summary>
    /// 图书借阅业务类
    /// </summary>
    public class BorrowManager
    {
        private BorrowService borrowService = new BorrowService();

        #region 借书
        public int GetBorrowCount(string readingCare)
        {
            return borrowService.GetBorrowCount(readingCare);
        }

        /// <summary>
        /// 确认借书
        /// </summary>
        /// <param name="readingCare"></param>
        /// <returns></returns>
        public bool BorrowBookConfirm(BorrowInfo borrowInfo, List<BorrowDetail> details)
        {
            return borrowService.BorrowBookConfirm(borrowInfo, details);
        }
        #endregion

        #region 还书
        /// <summary>
        /// 查询借阅详细信息
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public List<BorrowDetail> QueryBorrowInfoByReadingCard(string readingCard)
        {
            return borrowService.QueryBorrowInfoByReadingCard(readingCard);
        }

        /// <summary>
        /// 确认还书
        /// </summary>
        /// <param name="returnList">还书对象集合</param>
        /// <param name="nonReturnList">为还书对象集合</param>
        /// <param name="adminName_R">当前管理员</param>
        /// <returns></returns>
        public bool ReturnBook(List<BorrowDetail> returnList, List<BorrowDetail> nonReturnList,string adminName_R)
        {
            List<ReturnBook> list = new List<ReturnBook>();
            foreach (BorrowDetail returnBook in returnList)
            {
                int returnCount = returnBook.ReturnCount;
                var borrowDetails = nonReturnList.Where(o => o.BarCode == returnBook.BarCode).ToList();
                foreach (BorrowDetail borrowDetail in borrowDetails)
                {
                    if (returnCount <= borrowDetail.NonReturnCount)
                    {
                        list.Add(new ReturnBook
                        {
                            BorrowDetailId = borrowDetail.BorrowDetailId,
                            ReturnCount = returnCount,
                            AdminName_R = adminName_R,
                        });
                        break;
                    }
                    else
                    {
                        list.Add(new ReturnBook
                        {
                            BorrowDetailId = borrowDetail.BorrowDetailId,
                            ReturnCount = returnCount,
                            AdminName_R = adminName_R,
                        });
                        returnCount -= borrowDetail.NonReturnCount;
                    }
                }
            }
            return borrowService.ReturnBook(list);
        }
        #endregion

    }


}
