using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Library
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.tssl_AdminName.Text = Program.CurrentAdmin.AdminName;
        }


        #region 子窗体嵌入
        private void OpenForm(Form from)
        {
            foreach (Control item in this.splitContainer1.Panel2.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            from.TopLevel = false;
            from.Parent = this.splitContainer1.Panel2;
            from.Dock = DockStyle.Fill;
            from.FormBorderStyle = FormBorderStyle.None;
            from.Show();
        }
        #endregion

        //新增图书
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            FrmAddBook frmAddBook = new FrmAddBook();
            OpenForm(frmAddBook);
            this.lblOperationName.Text = "新增图书";
        }

        //图书上架
        private void BtnBookNew_Click(object sender, EventArgs e)
        {
            FrmNewBook frmNewBook = new FrmNewBook();
            OpenForm(frmNewBook);
            this.lblOperationName.Text = "图书上架";
        }

        //图书归还
        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            FrmReturnBook frmReturnBook = new FrmReturnBook();
            OpenForm(frmReturnBook);
            this.lblOperationName.Text = "图书归还";
        }

        //图书管理
        private void BtnBookManage_Click(object sender, EventArgs e)
        {
            FrmBookManage frmBookManage = new FrmBookManage();
            OpenForm(frmBookManage);
            this.lblOperationName.Text = "图书管理";
        }

        //会员管理
        private void BtnReaderManager_Click(object sender, EventArgs e)
        {
            FrmReaderManger frmReaderManger = new FrmReaderManger();
            OpenForm(frmReaderManger);
            this.lblOperationName.Text = "会员管理";
        }

        //图书借阅
        private void BtnBorrowBook_Click(object sender, EventArgs e)
        {
            FrmBorrowBook frmBorrowBook = new FrmBorrowBook();
            OpenForm(frmBorrowBook);
            this.lblOperationName.Text = "图书借阅";
        }

        //密码修改
        private void BtnModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd frmModifyPwd = new FrmModifyPwd();
            frmModifyPwd.ShowDialog();
        }

        //退出系统
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //退出系统时的询问
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("确认退出系统吗？", "退出询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;//取消窗体关闭操作
            }
        }
    }
}
