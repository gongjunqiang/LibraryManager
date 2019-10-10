using System;
using System.Collections.Generic;
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
        public int GetBorrowCount(string readingCare)
        {
            return borrowService.GetBorrowCount(readingCare);
        }


    }
}
