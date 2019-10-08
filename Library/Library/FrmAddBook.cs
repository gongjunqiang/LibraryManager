using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using MyVideo;
using Models;
using Common;

namespace Library
{
    public partial class FrmAddBook : Form
    {
        private BookManager bookManager = new BookManager();
        private Video objVideo = null; //定义摄像头操作类
        private List<Book> books = new List<Book>();

        public FrmAddBook()
        {
            InitializeComponent();

            #region 数据初始化
            this.cboBookCategory.DataSource = bookManager.GetAllCategory();
            this.cboBookCategory.DisplayMember = "CategoryName";
            this.cboBookCategory.ValueMember = "CategoryId";
            this.cboBookCategory.SelectedIndex = -1; //默认不选中
            this.cboPublisher.DataSource = bookManager.GetAllPublisher();
            this.cboPublisher.DisplayMember = "PublisherName";
            this.cboPublisher.ValueMember = "PublisherId";
            this.cboPublisher.SelectedIndex = -1; //默认不选中
            //禁用拍照
            this.btnTake.Enabled = false;
            this.btnCloseVideo.Enabled = false;
            this.dgvBookList.AutoGenerateColumns = false;
            DataGridViewStyle.DgvStyle1(this.dgvBookList);
            #endregion
    }

    //关闭窗体
    private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //选择照片
        private void BtnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult dialogResult = openFile.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var picturePath = openFile.FileName;
                var ext = Path.GetExtension(picturePath).Substring(1);
                if (ext != "jpg")
                {
                    MessageBox.Show("请选择图片！", "提示信息");
                    return;
                }

                this.pbCurrentImage.Image = Image.FromFile(picturePath);
            }
        }

        //清除照片
        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.pbCurrentImage.Image = null;
        }

        //启动摄像头
        private void BtnStartVideo_Click(object sender, EventArgs e)
        {
            try
            {
                //创建摄像头操作类
                this.objVideo = new Video(this.pbImage.Handle, this.pbImage.Left, this.pbImage.Top, this.pbImage.Width,
                    (short) this.pbImage.Height);
                //打开摄像头
                objVideo.OpenVideo();
                this.btnStartVideo.Enabled = false;
                this.btnTake.Enabled = true;
                this.btnCloseVideo.Enabled = true;

                this.btnCloseVideo.BackColor = Color.Red;
                this.btnCloseVideo.ForeColor = Color.White;
                this.btnTake.BackColor = Color.YellowGreen;
                this.btnTake.ForeColor = Color.White;
            }
            catch (Exception exception)
            {
                MessageBox.Show("摄像头打开异常", "提示信息");
            }
        }

        //关闭摄像头
        private void BtnCloseVideo_Click(object sender, EventArgs e)
        {
            this.objVideo.CloseVideo();
            this.btnStartVideo.Enabled = true;
            this.btnTake.Enabled = false;
            this.btnCloseVideo.Enabled = false;

            this.btnStartVideo.BackColor = Color.Green;
            this.btnStartVideo.ForeColor = Color.White;

            this.btnCloseVideo.BackColor = Color.Gray;
            this.btnCloseVideo.ForeColor = Color.White;
            this.btnTake.BackColor = Color.Gray;
            this.btnTake.ForeColor = Color.White;
        }

        //开始拍照
        private void BtnTake_Click(object sender, EventArgs e)
        {
            this.pbImage.Image = this.objVideo.CatchVideo();
        }

        //确认添加
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            #region 数据校验
            //基础数据校验
            #endregion

            #region 对象封装
            Book book = new Book
            {
                BarCode= this.txtBarCode.Text.Trim(),
                BookName = this.txtBookName.Text.Trim(),
                Author = this.txtAuthor.Text.Trim(),
                PublisherId = Convert.ToInt32(this.cboPublisher.SelectedValue),
                PublishDate = this.dtpPublishDate.Value,
//                PublishDate = Convert.ToDateTime(this.dtpPublishDate.Text),
                BookCategoryId = Convert.ToInt32(this.cboBookCategory.SelectedValue),
                UnitPrice = Convert.ToDouble(this.txtUnitPrice.Text.Trim()),
                BookCount = Convert.ToInt32(this.txtBookCount.Text.Trim()),
                Remainder = Convert.ToInt32(this.txtBookCount.Text.Trim()),
                BookPosition = this.txtBookPosition.Text.Trim(),
                BookImage = SerializeObjectToString.SerializeObject(this.pbCurrentImage.Image),
                PublisherName = this.cboPublisher.Text
            };
            #endregion
            #region 调用后台
            try
            {
               bookManager.AddNewBook(book);
               books.Add(book);
                this.dgvBookList.DataSource = null;
                this.dgvBookList.DataSource = books;
                DialogResult dialogResult = MessageBox.Show("添加成功，是否继续添加？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    //清空数据
                    this.pbImage.Image = null;
                    foreach (Control item in this.gbBook.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text=String.Empty;
                        }
                        else if(item is ComboBox)
                        {
                            ((ComboBox) item).SelectedIndex = -1;
                        }
                    }
                    this.txtBookName.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库异常："+ex.Message,"错误提示");
            }
            #endregion

        }

        //图书条码判断
        private void TxtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TxtBarCode_Leave(null, null);
            }
        }

        //图书条码数去焦点
        private void TxtBarCode_Leave(object sender, EventArgs e)
        {
            if (this.txtBarCode.Text.Trim().Length != 0)
            {
                if (bookManager.IsExistsByBookCode(this.txtBarCode.Text.Trim()))
                {
                    MessageBox.Show("该图书已经存在！", "提示信息");
                    this.txtBarCode.SelectAll();
                    this.txtBarCode.Focus();
                }
            }
        }

        //添加行号
        private void DgvBookList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvBookList,e);
        }
    }
}

