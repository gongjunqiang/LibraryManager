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
using MyVideo;

namespace Library
{
    public partial class FrmBookManage : Form
    {
        private BookManager bookManager = new BookManager();
        private List<Book> books = new List<Book>();
        private Video objVideo = null; //定义摄像头操作类
        public FrmBookManage()
        {
            InitializeComponent();

            #region 数据初始化
            var categorylist = bookManager.GetAllCategory();
            this.cbo_BookCategory.DataSource = bookManager.GetAllCategory();
            this.cbo_BookCategory.DisplayMember = "CategoryName";
            this.cbo_BookCategory.ValueMember = "CategoryId";
            this.cbo_BookCategory.SelectedIndex = -1; //默认不选中
            categorylist.Insert(0,new Category(){ CategoryId = -1,CategoryName = ""});
            this.cboCategory.DataSource = categorylist;
            this.cboCategory.DisplayMember = "CategoryName";
            this.cboCategory.ValueMember = "CategoryId";
//            this.cboCategory.SelectedIndex = -1; //默认不选中
            this.cbo_Publisher.DataSource = bookManager.GetAllPublisher();
            this.cbo_Publisher.DisplayMember = "PublisherName";
            this.cbo_Publisher.ValueMember = "PublisherId";
            this.cbo_Publisher.SelectedIndex = -1; //默认不选中
      

            this.btnDel.Enabled = false;
            //禁用拍照
            this.btnTake.Enabled = false;
            this.btnCloseVideo.Enabled = false;

            this.btnSave.Enabled = false;
    
            this.dgvBookList.AutoGenerateColumns = false;
            DataGridViewStyle.DgvStyle1(this.dgvBookList);
            #endregion

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 组合查询
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            this.dgvBookList.SelectionChanged-=new EventHandler(this.DgvBookList_SelectionChanged);
            if ((this.cboCategory.SelectedIndex==-1||this.cboCategory.SelectedValue.ToString() == "-1") && this.txtBarCode.Text.Trim().Length == 0 &&
                this.txtBookName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请至少选择一个查询条件", "查询提示");
                return;
            }

            try
            {
                 books = bookManager.QueryBook(this.cboCategory.SelectedValue.ToString(), this.txtBarCode.Text.Trim(),
                    this.txtBookName.Text.Trim());
                //数据展示
                this.dgvBookList.DataSource = null;
                this.dgvBookList.DataSource = books;
                if (this.dgvBookList.RowCount != 0)
                {
             
                    this.btnDel.Enabled = true;
                    this.btnSave.Enabled = true;
                }
                else
                {
                    this.btnDel.Enabled = false;
                    this.btnSave.Enabled = false;
                }
                this.dgvBookList.SelectionChanged += new EventHandler(this.DgvBookList_SelectionChanged);
                DgvBookList_SelectionChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作异常:" + ex.Message, "异常提示");
            }
        }
        #endregion

        private void DgvBookList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvBookList,e);
        }

        //dgv选择的行变化时触发同步展示图书信息
        private void DgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvBookList.RowCount == 0)
            {
                return;
            }
            //展示信息
            var barCode = this.dgvBookList.CurrentRow.Cells["BarCode"].Value.ToString();
            var book = books.Where(o => o.BarCode == barCode).FirstOrDefault();
            this.txt_BookName.Text = book.BookName;
            this.txt_UnitPrice.Text = book.UnitPrice.ToString();
            this.txt_Author.Text = book.Author;
            this.txt_BookPosition.Text = book.BookPosition;
            this.lbl_BarCode.Text = book.BarCode;
            this.dtp_PublishDate.Value = book.PublishDate;
            this.lbl_BookCount.Text = book.BookCount.ToString();
            this.lbl_BookId.Text = book.BookId.ToString();
            this.cbo_BookCategory.SelectedValue = book.BookCategoryId;
            this.cbo_Publisher.SelectedValue = book.PublisherId;
            this.pbCurrentImage.Image = book.BookImage.Length==0?null:(Image) SerializeObjectToString.DeserializeObject(book.BookImage);
        }

        //选择图片
        private void BtnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.pbCurrentImage.Image = Image.FromFile(openFile.FileName);
            }
        }

        //保存修改
        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region 数据校验
            #endregion
            #region 对象封装
            Book book = new Book
            {
                BookId = Convert.ToInt32(this.lbl_BookId.Text.Trim()),
                BookName = this.txt_BookName.Text.Trim(),
                Author = this.txt_Author.Text.Trim(),
                PublisherId = Convert.ToInt32(this.cbo_Publisher.SelectedValue.ToString()),
                PublishDate = this.dtp_PublishDate.Value,
                //                PublishDate = Convert.ToDateTime(this.dtpPublishDate.Text),
                BookCategoryId = Convert.ToInt32(this.cbo_BookCategory.SelectedValue.ToString()),
                UnitPrice = Convert.ToDouble(this.txt_UnitPrice.Text.Trim()),
                BookPosition = this.txt_BookPosition.Text.Trim(),
                BookImage = SerializeObjectToString.SerializeObject(this.pbCurrentImage.Image),
            };
            #endregion

            //调用后台
            try
            {
                bookManager.UpdateBookInfoByBarCode(book);
                MessageBox.Show("修改成功", "修改提示");
                Book currentBook = books.Where(o => o.BookId == book.BookId).First();
                currentBook.BookName = book.BookName;
                currentBook.Author = book.Author;
                currentBook.PublisherId = book.PublisherId;
                currentBook.PublishDate = book.PublishDate;
                currentBook.BookCategoryId = book.BookCategoryId;
                currentBook.UnitPrice = book.UnitPrice;
                currentBook.BookPosition = book.BookPosition;
                currentBook.BookImage = book.BookImage;
                this.dgvBookList.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("操作异常:" + ex.Message, "异常提示");
            }
        }

        //删除图书
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvBookList.CurrentRow == null)
            {
                MessageBox.Show("请选择需要删除的图书", "删除提示");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("确认删除此图书吗？", "删除提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel) return;
            this.dgvBookList.SelectionChanged -= new EventHandler(this.DgvBookList_SelectionChanged);
            try
            {
                var result = bookManager.DeleteBookByBookId(this.lbl_BookId.Text.Trim());
                if (result == 1)
                {

                    Book book = books.Where(o => o.BookId == Convert.ToInt32(this.lbl_BookId.Text.Trim())).First();
                    books.Remove(book);
                    this.dgvBookList.DataSource = null;
                    this.dgvBookList.DataSource = books;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作异常:" + ex.Message, "异常提示");
            }
            finally
            {
                this.dgvBookList.SelectionChanged += new EventHandler(this.DgvBookList_SelectionChanged);
                DgvBookList_SelectionChanged(null, null);
            }
        }
    }
}
