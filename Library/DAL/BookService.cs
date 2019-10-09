using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Sockets;
using Models;
using DBUtility;

namespace DAL
{
    /// <summary>
    /// 图书数据访问类
    /// </summary>
    public class BookService
    {
        #region 获取图书分类
        /// <summary>
        /// 获取所有图书分类
        /// </summary>
        /// <returns></returns>
        public List<Category> GetAllCategory()
        {
            string sql = "select CategoryId,CategoryName from Categories";
            List<Category>  list = new List<Category>();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(sql);
                while (reader.Read())
                {
                    list.Add(new Category
                    {
                        CategoryId = Convert.ToInt32(reader["CategoryId"]),
                        CategoryName = reader["CategoryName"].ToString()
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
        #endregion

        #region 获取出版社
        /// <summary>
        /// 获取所有出版社信息
        /// </summary>
        /// <returns></returns>
        public List<Publisher> GetAllPublisher()
        {
            string sql = "select PublisherId,PublisherName from Publishers";
            List<Publisher> list = new List<Publisher>();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(sql);
                while (reader.Read())
                {
                    list.Add(new Publisher
                    {
                        PublisherId = Convert.ToInt32(reader["PublisherId"]),
                        PublisherName = reader["PublisherName"].ToString()
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
        #endregion

        #region 新增图书
        /// <summary>
        /// 根据图书条码判断图书是否已经添加
        /// </summary>
        /// <param name="bookCode"></param>
        /// <returns></returns>
        public int IsExistsByBookCode(string bookCode)
        {
            string sql = "select count(1) from Books where BarCode=@BarCode";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@BarCode",bookCode) 
            };
            try
            {
                return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, sqlParameters));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 新增图书
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int AddNewBook(Book book)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@BarCode",book.BarCode),
                new SqlParameter("@BookName",book.BookName),
                new SqlParameter("@Author",book.Author),
                new SqlParameter("@PublisherId",book.PublisherId),
                new SqlParameter("@PublishDate",book.PublishDate),
                new SqlParameter("@BookCategoryId",book.BookCategoryId),
                new SqlParameter("@UnitPrice",book.UnitPrice),
                new SqlParameter("@BookImage",book.BookImage),
                new SqlParameter("@BookCount",book.BookCount),
                new SqlParameter("@Remainder",book.Remainder),
                new SqlParameter("@BookPosition",book.BookPosition),
            };
            try
            {
                return Convert.ToInt32(SqlHelper.ExecuteNonQuery("usp_AddNewBook", sqlParameters,true));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 图书上架
        /// <summary>
        /// 根据图书条码获取图书信息
        /// </summary>
        /// <param name="barCode"></param>
        /// <returns></returns>
        public Book GetBookInfoByBarCode(string barCode)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@BarCode",barCode), 
            };
            Book booInfo = null;
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader("usp_QueryBookInfo", sqlParameters,true);
                if (reader.Read())
                {
                    booInfo =new Book
                    {
                        BookId=Convert.ToInt32(reader["BookId"]),
                        BarCode = reader["BarCode"].ToString(),
                        BookName = reader["BookName"].ToString(),
                        Author = reader["Author"].ToString(),
                        PublisherId = Convert.ToInt32(reader["PublisherId"]),
                        PublishDate = Convert.ToDateTime(reader["PublishDate"]),
                        BookCategoryId = Convert.ToInt32(reader["BookCategoryId"]),
                        UnitPrice = Convert.ToDouble(reader["UnitPrice"]),
                        BookImage = reader["BookImage"] is null?"": reader["BookImage"].ToString(),
                        BookCount = Convert.ToInt32(reader["BookCount"]),
                        Remainder = Convert.ToInt32(reader["Remainder"]),
                        BookPosition = reader["BookPosition"].ToString(),
                        RegTime = Convert.ToDateTime(reader["RegTime"]),
                        PublisherName = reader["PublisherName"].ToString(),
                        CategoryName = reader["CategoryName"].ToString()
                    };
                }
                reader.Close();
                return booInfo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据图书编号更新图书数量
        /// </summary>
        /// <param name="barCode"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public int UpdateBookCount(string barCode,int count)
        {
            string sql = "update Books set BookCount=BookCount+@BookCount where BarCode=@BarCode";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@BarCode",barCode),
                new SqlParameter("@BookCount",count),
            };
            try
            {
                return SqlHelper.ExecuteNonQuery(sql,sqlParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 图书管理
        //组合查询图书信息
        public List<Book> QueryBook(string categoryId, string barCode, string bookName)
        {
            string sql ="select BookId, BarCode, BookName, Author, Books.PublisherId, PublishDate, BookCategoryId, UnitPrice, BookImage, BookCount, Remainder, BookPosition,RegTime,PublisherName,CategoryName from Books";
            sql += " inner join Categories on Books.BookCategoryId = Categories.CategoryId";
            sql += " inner join Publishers on Books.PublisherId = Publishers.PublisherId where 1=1";
            List<SqlParameter> paramList = new List<SqlParameter>();
            List<Book> booklist=new List<Book>();
            if (!string.IsNullOrEmpty(barCode))
            {
                sql += " and barCode=@BarCode";
                paramList.Add(new SqlParameter("@BarCode", barCode));
            }
            else
            {
                if (!string.IsNullOrEmpty(categoryId) && categoryId != "-1")
                {
                    sql += " and Categories.CategoryId=@CategoryId";
                    paramList.Add(new SqlParameter("@CategoryId", categoryId));
                }
                if (!string.IsNullOrEmpty(bookName))
                {
                    sql += " and BookName like @BookName";
                    paramList.Add(new SqlParameter("@BookName", "%"+bookName+ "%"));
                }
            }

            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(sql, paramList.ToArray());
                while (reader.Read())
                {
                    booklist.Add(new Book
                    {
                        BookId = Convert.ToInt32(reader["BookId"]),
                        BarCode = reader["BarCode"].ToString(),
                        BookName = reader["BookName"].ToString(),
                        Author = reader["Author"].ToString(),
                        PublisherId = Convert.ToInt32(reader["PublisherId"]),
                        PublishDate = Convert.ToDateTime(reader["PublishDate"]),
                        BookCategoryId = Convert.ToInt32(reader["BookCategoryId"]),
                        UnitPrice = Convert.ToDouble(reader["UnitPrice"]),
                        BookImage = reader["BookImage"] is null ? "" : reader["BookImage"].ToString(),
                        BookCount = Convert.ToInt32(reader["BookCount"]),
                        Remainder = Convert.ToInt32(reader["Remainder"]),
                        BookPosition = reader["BookPosition"].ToString(),
                        RegTime = Convert.ToDateTime(reader["RegTime"]),
                        PublisherName = reader["PublisherName"].ToString(),
                        CategoryName = reader["CategoryName"].ToString()
                    });
                }
                reader.Close();
                return booklist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据图书编码删除图书
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public int DeleteBookByBookId(string bookId)
        {
            string sql = "delete from Books where BookId=@BookId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@BookId",bookId),
            };
            try
            {

                return SqlHelper.ExecuteNonQuery(sql, sqlParameters);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new Exception("该图书已经被借阅，不能删除！");
                }
                else
                {
                    throw new Exception("删除图书出现异常："+ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据图书Id更新图书信息
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int UpdateBookInfoByBarCode(Book book)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@BookId",book.BookId),
                new SqlParameter("@BookName",book.BookName),
                new SqlParameter("@Author",book.Author),
                new SqlParameter("@PublisherId",book.PublisherId),
                new SqlParameter("@PublishDate",book.PublishDate),
                new SqlParameter("@BookCategoryId",book.BookCategoryId),
                new SqlParameter("@UnitPrice",book.UnitPrice),
                new SqlParameter("@BookImage",book.BookImage),
                new SqlParameter("@BookPosition",book.BookPosition),
            };

            try
            {
                return SqlHelper.ExecuteNonQuery("usp_UpdateBookInfoByBookId", sqlParameters, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}
