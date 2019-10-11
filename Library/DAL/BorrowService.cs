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


        #region 借书
        /// <summary>
        /// 根据借阅证号查询借阅信息
        /// </summary>
        /// <param name="readingCare"></param>
        /// <returns></returns>
        public int GetBorrowCount(string readingCare)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter( "ReadingCard",readingCare)
            };
            return Convert.ToInt32(SqlHelper.ExecuteScalar("usp_QueryBorrowBookInfoByReadingCard", sqlParameters, true));
        }

        /// <summary>
        /// 确认借书
        /// </summary>
        /// <param name="readingCare"></param>
        /// <returns></returns>
        public bool BorrowBookConfirm(BorrowInfo borrowInfo, List<BorrowDetail> details)
        {
            SqlParameter[] mainParam = new SqlParameter[]
            {
                new SqlParameter( "@BorrowId",borrowInfo.BorrowId),
                new SqlParameter( "@ReaderId",borrowInfo.ReaderId),
                new SqlParameter( "@AdminName_B",borrowInfo.AdminName_B),
            };

            string sqlMain = "insert into BorrowInfo(BorrowId,ReaderId,AdminName_B) values(@BorrowId,@ReaderId,@AdminName_B)";
            string sqlDetail = "insert into BorrowDetail(BorrowId,BookId,BorrowCount,NonReturnCount, Expire) values(@BorrowId,@BookId,@BorrowCount,@NonReturnCount,@Expire)";
            List<SqlParameter[]> detailParam = new List<SqlParameter[]>();
            foreach (BorrowDetail detail in details)
            {
                detailParam.Add(new SqlParameter[]
                {
                    new SqlParameter( "@BorrowId",detail.BorrowId),
                    new SqlParameter( "@BookId",detail.BookId),
                    new SqlParameter( "@BorrowCount",detail.BorrowCount),
                    new SqlParameter( "@NonReturnCount",detail.BorrowCount),
                    new SqlParameter( "@Expire",detail.Expire),
                });
            }
            return SqlHelper.ExecuteTransaction(sqlMain, mainParam, sqlDetail, detailParam);
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
            List<BorrowDetail> list = new List<BorrowDetail>();
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ReadingCard", readingCard),
            };
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader("usp_QueryBorrowInfoByReadingCard", sqlParameters, true);
                while (reader.Read())
                {
                    list.Add(new BorrowDetail
                    {
                        ReadingCard = reader["ReadingCard"].ToString(),
                        BookName = reader["BookName"].ToString(),
                        BorrowDetailId = Convert.ToInt32(reader["BorrowDetailId"]),
                        BorrowId = reader["BorrowId"].ToString(),
                        BookId = Convert.ToInt32(reader["BookId"]),
                        BarCode = reader["BarCode"].ToString(),
                        BorrowCount = Convert.ToInt32(reader["BorrowCount"]),
                        ReturnCount = Convert.ToInt32(reader["ReturnCount"]),
                        NonReturnCount = Convert.ToInt32(reader["NonReturnCount"]),
                        BorrowDate = Convert.ToDateTime(reader["BorrowDate"]),
                        Expire = Convert.ToDateTime(reader["Expire"]),
                        StatusDesc = reader["StatusDesc"].ToString(),
                    });
                }
                reader.Close();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 确认还书
        /// </summary>
        /// <param name="returnBooks"></param>
        /// <returns></returns>
        public bool ReturnBook(List<ReturnBook> returnBooks)
        {
            List<SqlParameter[]> sqlParameterses = new List<SqlParameter[]>();
            foreach (ReturnBook returnBook in returnBooks)
            {
                sqlParameterses.Add(new SqlParameter[]
                {
                    new SqlParameter("@BorrowDetailId",returnBook.BorrowDetailId),
                    new SqlParameter("@ReturnCount",returnBook.ReturnCount),
                    new SqlParameter("@AdminName_R",returnBook.AdminName_R),
                });
            }

            return SqlHelper.ExecuteTransaction("usp_ReturnBook", sqlParameterses);
        }

        #endregion



    }
}
