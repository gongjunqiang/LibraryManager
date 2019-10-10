using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DBUtility;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    /// <summary>
    /// 图书借阅数据访问类
    /// </summary>
    public class BorrowService
    {
        public int GetBorrowCount(string readingCare)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter( "ReadingCard",readingCare)
            };
            return Convert.ToInt32(SqlHelper.ExecuteScalar("usp_QueryBorrowBookInfoByReadingCard", sqlParameters, true));
        }





    }
}
