using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    /// <summary>
    /// 还书实体类
    /// </summary>
    [Serializable]
    public class ReturnBook
    {
        public int ReturnId { get; set; }
        public int BorrowDetailId { get; set; }
        public int ReturnCount { get; set; }
        public DateTime ReturnDate { get; set; }
        public string AdminName_R { get; set; }




    }
}
