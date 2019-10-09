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
    public class BookManager
    {
        private BookService bookService = new BookService();
        #region 获取图书分类
        /// <summary>
        /// 获取所有图书分类
        /// </summary>
        /// <returns></returns>
        public List<Category> GetAllCategory()
        {
            return bookService.GetAllCategory();
        }
        #endregion

        #region 获取出版社
        /// <summary>
        /// 获取所有出版社信息
        /// </summary>
        /// <returns></returns>
        public List<Publisher> GetAllPublisher()
        {
            return bookService.GetAllPublisher();
        }
        #endregion

        #region 新增图书
        /// <summary>
        /// 判断图书是否存在
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool IsExistsByBookCode(string bookCode)
        {
            var result = bookService.IsExistsByBookCode(bookCode);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 新增图书(基于存储过程)
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int AddNewBook(Book book)
        {
            return bookService.AddNewBook(book);
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
            return bookService.GetBookInfoByBarCode(barCode);
        }

        /// <summary>
        /// 根据图书编号更新图书数量
        /// </summary>
        /// <param name="barCode"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public int UpdateBookCount(string barCode, int count)
        {
            return bookService.UpdateBookCount(barCode, count);
        }
        #endregion
    }
}
