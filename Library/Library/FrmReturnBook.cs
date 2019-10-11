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
    public partial class FrmReturnBook : Form
    {
        private BorrowManager borrowManager = new BorrowManager();
        private ReaderManager readerManager = new ReaderManager();
        private BookManager bookManager = new BookManager();
        private Reader reader = null;
        private List<BorrowDetail> borrowList = null;
//        private List<ReturnBook> returnBookList = null;
        private List<BorrowDetail> returnList = new List<BorrowDetail>();
        public FrmReturnBook()
        {
            InitializeComponent();
            this.dgvNonReturnList.AutoGenerateColumns = false;
            this.dgvReturnList.AutoGenerateColumns = false;
            DataGridViewStyle.DgvStyle1(this.dgvNonReturnList);
            DataGridViewStyle.DgvStyle1(this.dgvReturnList);

            //加粗数字
            this.dgvNonReturnList.Columns["BorrowCount"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            this.dgvNonReturnList.Columns["BorrowCount"].DefaultCellStyle.Font =
                new Font("微软雅黑",14);

            this.dgvNonReturnList.Columns["ReturnCount"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            this.dgvNonReturnList.Columns["ReturnCount"].DefaultCellStyle.Font =
                new Font("微软雅黑", 14);

            this.dgvNonReturnList.Columns["NonReturnCount"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            this.dgvNonReturnList.Columns["NonReturnCount"].DefaultCellStyle.Font =
                new Font("微软雅黑", 14);

            this.dgvReturnList.Columns["ReturnCount_"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            this.dgvReturnList.Columns["ReturnCount_"].DefaultCellStyle.Font =
                new Font("微软雅黑", 14);
        }

        #region 查询
        private void TxtReadingCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TxtReadingCard_Leave(null, null);
            }
        }

        private void TxtReadingCard_Leave(object sender, EventArgs e)
        {
            if (this.txtReadingCard.Text.Trim().Length != 0)
            {
                //查询读者信息
                reader = readerManager.QueryReaderInfoByReadingCard(this.txtReadingCard.Text.Trim());
                borrowList = borrowManager.QueryBorrowInfoByReadingCard(this.txtReadingCard.Text.Trim());
                this.dgvNonReturnList.DataSource = null;
                this.dgvNonReturnList.DataSource = borrowList;
                if (reader != null)
                {
                    if (reader.StatusId == 1)
                    {

                        this.lblReaderName.Text = reader.ReaderName;
                        this.lblRoleName.Text = reader.RoleName;
                        this.lblAllowCounts.Text = reader.AllowCounts.ToString();
                        var borrowCount = borrowManager.GetBorrowCount(this.txtReadingCard.Text.Trim());
                        this.lblBorrowCount.Text = borrowCount.ToString();
                        this.lbl_Remainder.Text = (reader.AllowCounts - borrowCount).ToString();
                        this.pbReaderImage.Image = reader.ReaderImage == "" ? null : (Image)SerializeObjectToString.DeserializeObject(reader.ReaderImage);
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
            this.txtReadingCard.Text = "";
            this.txtReadingCard.SelectAll();
            this.txtReadingCard.Focus();
        }
        #endregion

        #region 还书
        private void TxtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TxtReadingCard_Leave(null, null);
            }
        }

        private void TxtBarCode_Leave(object sender, EventArgs e)
        {
            if (this.txtBarCode.Text.Trim().Length != 0)
            {
                //1.检查图书是否在借书列表中
                var borrowbook = borrowList.Where(o => o.BarCode == this.txtBarCode.Text.Trim()).FirstOrDefault();
                if (borrowbook != null)
                {
                    //2检查还书是否在还书列表中
                    var retrnBook = returnList.Where(o => o.BarCode == borrowbook.BarCode).FirstOrDefault();
                    if (retrnBook != null)//在列表中
                    {
                        var count = borrowList.Where(o => o.BarCode == this.txtBarCode.Text.Trim())
                            .Select(o => o.NonReturnCount).Sum();
                        if (retrnBook.ReturnCount == count)
                        {
                            MessageBox.Show("还书总数不能大于借书总数!", "提示信息");
                            this.txtBarCode.Text = "";
                            this.txtBarCode.Focus();
                            return;
                        }
                        else
                        {
                            retrnBook.ReturnCount++;
                            this.dgvReturnList.Refresh();
                        }
                    }
                    else//不在列表
                    {
                        returnList.Add(new BorrowDetail
                        {
                            BorrowDetailId = borrowbook.BorrowDetailId,
                            ReturnCount = 1,
                            BookName = borrowbook.BookName,
                            BarCode = this.txtBarCode.Text.Trim(),
                        });
                        this.dgvReturnList.DataSource = null;
                        this.dgvReturnList.DataSource = returnList;
                    }
                    this.lblReturnCount.Text = returnList.Select(o => o.ReturnCount).Sum().ToString();
                    this.txtBarCode.Text = "";
                    this.txtBarCode.Focus();
                    this.btnConfirmReturn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("当前图书不在借阅列表中,请确认!", "提示信息");
                    this.txtBarCode.Text = "";
                    this.txtBarCode.Focus();
                }
            }

        }


        //确认还书
        private void BtnConfirmReturn_Click(object sender, EventArgs e)
        {
            if (this.dgvReturnList.RowCount != 0)
            {
                try
                {
                    borrowManager.ReturnBook(returnList, borrowList,Program.CurrentAdmin.AdminName);
                    MessageBox.Show("还书成功!", "提示信息");
                    //清空数据
                    returnList.Clear();
                    borrowList = null;
                    this.txtBarCode.Enabled = false;
                    this.btnConfirmReturn.Enabled = false;
                    this.lblReturnCount.Text = "0";
                    this.dgvNonReturnList.DataSource = null;
                    this.dgvReturnList.DataSource = null;
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("操作异常："+ex.Message, "异常提示");
                }
            }
            else
            {
                MessageBox.Show("请选择需要归还的图书！!", "提示信息");
            }
        }
        #endregion

        private void DgvNonReturnList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvNonReturnList,e);
        }

        private void DgvReturnList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvReturnList, e);
        }

    }
}
