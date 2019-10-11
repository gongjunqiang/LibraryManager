using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Common;
using Models;


namespace Library
{
    public partial class FrmNewBook : Form
    {
        private BookManager bookManager = new BookManager();
        private List<Book> books = new List<Book>();

        public FrmNewBook()
        {
            InitializeComponent();

            #region 初始化
            this.dgvBookList.AutoGenerateColumns = false;
            this.txtAddCount.Enabled = false;
            this.btnSave.Enabled = false;
            this.txtBarCode.Focus();
            DataGridViewStyle.DgvStyle1(this.dgvBookList);
            #endregion


        }

        #region 根据图书条码查询图书信息
        private void TxtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TxtBarCode_Leave(null, null);
            }
        }

        //TxtBarCode失去焦点
        private void TxtBarCode_Leave(object sender, EventArgs e)
        {
            if (this.txtBarCode.Text.Trim().Length != 0)
            {
                try
                {
                    var bookInfo = bookManager.GetBookInfoByBarCode(this.txtBarCode.Text.Trim());
                    if (bookInfo == null)
                    {
                        MessageBox.Show("未查询到该图书信息", "查询信息");
                        this.txtBarCode.SelectAll();
                        this.txtBarCode.Focus();
                    }
                    else
                    {
                        this.lblBookName.Text = bookInfo.BookName;
                        this.lblCategory.Text = bookInfo.CategoryName;
                        this.lblBookPosition.Text = bookInfo.BookPosition;
                        this.lblBookId.Text = bookInfo.BookId.ToString();
                        this.lblBookCount.Text = bookInfo.BookCount.ToString();
                        this.pbImage.Image = (Image)SerializeObjectToString.DeserializeObject(bookInfo.BookImage);
                        this.txtAddCount.Enabled = true;
                        this.btnSave.Enabled = true;
                        this.txtAddCount.Focus();
                        var isExists = books.Where(o => o.BarCode == bookInfo.BarCode).Count();
                        if (isExists == 0)
                        {
                            books.Add(bookInfo);
                            this.dgvBookList.DataSource = null;
                            this.dgvBookList.DataSource = books;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询图书信息异常：" + ex.Message, "异常提示");
                }
               
            }
        }
        #endregion


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 更新图书数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.txtAddCount.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入新增图书总数", "新增提示");
                this.txtAddCount.SelectAll();
                this.txtAddCount.Focus();
                return;
            }

            if (!DataValidate.IsInteger(this.txtAddCount.Text.Trim()))
            {
                MessageBox.Show("新增图书总数必须是正整数！", "新增提示");
                this.txtAddCount.SelectAll();
                this.txtAddCount.Focus();
                return;
            }


            try
            {
                var result = bookManager.UpdateBookCount(this.txtBarCode.Text.Trim(), Convert.ToInt32(this.txtAddCount.Text.Trim()));
                if (result == 1)
                {
                    var book = books.Where(o => o.BarCode == this.txtBarCode.Text.Trim()).First();
                    book.BookCount += Convert.ToInt32(this.txtAddCount.Text.Trim());
                    this.dgvBookList.Refresh();

                    MessageBox.Show("新增成功，是否需要继续更新该图书数量？", "新增提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    //if (dialogResult == DialogResult.OK)
                    //{
                    //    this.txtAddCount.Text = string.Empty;
                    //    this.txtAddCount.Focus();
                    //    return;
                    //}
                    //清除其他信息：
                    this.lblBookName.Text = string.Empty;
                    this.lblCategory.Text = string.Empty;
                    this.lblBookPosition.Text = string.Empty;
                    this.lblBookId.Text = string.Empty;
                    this.lblBookCount.Text = string.Empty;
                    this.pbImage.Image = null;
                    this.txtAddCount.Text= string.Empty;
                    this.txtAddCount.Enabled = false;
                    this.btnSave.Enabled = false;
                    this.txtBarCode.Clear();
                    this.txtBarCode.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新图书数量异常："+ex.Message, "异常提示");
            }
        }

        private void TxtAddCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                BtnSave_Click(null, null);
            }

       
        }

        private void DgvBookList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvBookList,e);
        }
    }
}
