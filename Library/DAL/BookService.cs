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
            string sql = "select BarCode,BookName,Author,BookImage,BookCount,BookPosition,PublisherName,CategoryName from Books";
            sql += " inner join Categories on Books.BookCategoryId=Categories.CategoryId";
            sql += " inner join Publishers on Books.PublisherId=Publishers.PublisherId where BarCode=@BarCode";




            return null;


        }



        #endregion


    }
}
