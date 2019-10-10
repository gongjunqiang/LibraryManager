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
    public partial class FrmBorrowBook : Form
    {

        private BorrowManager borrowManager = new BorrowManager();
        private ReaderManager readerManager = new ReaderManager();
        private Reader reader = null;
        public FrmBorrowBook()
        {
            InitializeComponent();
            this.txtBarCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnDel.Enabled = false;

        }


        private void TxtReadingCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TxtReadingCard_Leave(null,null);
            }
           
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtReadingCard_Leave(object sender, EventArgs e)
        {
            if (this.txtReadingCard.Text.Trim().Length != 0)
            {
                //查询读者信息
                reader = readerManager.QueryReaderInfoByReadingCard(this.txtReadingCard.Text.Trim());
                if (reader != null)
                {
                    if (reader.StatusId == 1)
                    {
                        this.lblReaderName.Text = reader.ReaderName;
                        this.lblRoleName.Text = reader.RoleName;
                        this.lblAllowCounts.Text = reader.AllowCount.ToString();
                        var borrowCount = borrowManager.GetBorrowCount(this.txtReadingCard.Text.Trim());
                        this.lblBorrowCount.Text = borrowCount.ToString();
                        this.lbl_Remainder.Text = (reader.AllowCount - borrowCount).ToString();
                        this.pbReaderImage.Image = reader.ReaderImage == "" ? null : (Image)SerializeObjectToString.DeserializeObject(reader.ReaderImage);
                        if (borrowCount < reader.AllowCount)
                        {
                            this.txtBarCode.Enabled = true;
                            this.txtBarCode.Focus();
                        }
                        else
                        {
                            MessageBox.Show("当前读者借书已达到上限，请归还后继续借书！", "查询提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("当前借阅证号已被挂失，请联系管理员！", "查询提示");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("借阅证号错误，请核对借阅证号码是否正确！", "查询提示");
                    Clear();
                }
            }
        }

        //清除界面信息
        private void Clear()
        {
            this.lblReaderName.Text = "";
            this.lblRoleName.Text = "";
            this.lblAllowCounts.Text = "0";
            this.lblBorrowCount.Text = "0";
            this.lbl_Remainder.Text = "0";
            this.pbReaderImage.Image = null;
            this.txtReadingCard.SelectAll();
            this.txtReadingCard.Focus();
        }

    }
}
