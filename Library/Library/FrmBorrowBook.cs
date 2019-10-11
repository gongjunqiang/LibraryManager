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
        private BookManager bookManager = new BookManager();
        private Reader reader = null;

        private List<BorrowDetail> borrowList = new List<BorrowDetail>();

        public FrmBorrowBook()
        {
            InitializeComponent();
            this.txtBarCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnDel.Enabled = false;
            this.dgvBookList.AutoGenerateColumns = false;
            DataGridViewStyle.DgvStyle1(this.dgvBookList);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 查询借阅信息
        private void TxtReadingCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TxtReadingCard_Leave(null, null);
            }
        }

        /// <summary>
        /// 查询借阅信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtReadingCard_Leave(object sender, EventArgs e)
        {
            if (this.txtReadingCard.Text.Trim().Length != 0)
            {
                //查询读者信息
                try
                {
                    reader = readerManager.QueryReaderInfoByReadingCard(this.txtReadingCard.Text.Trim());
                }
                catch (Exception ex)
                {

                }
                
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
                        if (borrowCount < reader.AllowCounts)
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
            this.txtReadingCard.Text = "";
            this.txtReadingCard.SelectAll();
            this.txtReadingCard.Focus();
        }
        #endregion

        #region 借阅
        /// <summary>
        /// 扫描图书条码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TxtBarCode_Leave(null, null);
            }
        }

        /// <summary>
        /// 条码框失去焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBarCode_Leave(object sender, EventArgs e)
        {
            if (this.txtBarCode.Text.Trim().Length != 0)
            {
                //3判断是否达到借阅上限
                if (borrowList.Select(o => o.BorrowCount).Sum() == Convert.ToInt32(this.lbl_Remainder.Text.Trim()))
                {
                    MessageBox.Show("当前借阅证已达到借阅上限了哦！", "借阅提示");
                    return;
                }
                Book book = null;
                try
                {
                    //1.查询图书信息
                    book = bookManager.GetBookInfoByBarCode(this.txtBarCode.Text.Trim());
                }
                catch (Exception exception)
                {
                    MessageBox.Show("查询异常："+exception.Message, "异常提示");
                }
                if (book == null)
                {
                    MessageBox.Show("未查询到当前图书", "借阅提示");
                    return;
                }
                //2.保存到列表中
                var borrowDetail = borrowList.Where(o => o.BookId == book.BookId).FirstOrDefault();
                if (borrowDetail != null)
                {
                    borrowDetail.BorrowCount++;
                    this.dgvBookList.Refresh();
                }
                else
                {
                    borrowList.Add(new BorrowDetail
                    {
                        BookId = book.BookId,
                        BookName = book.BookName,
                        BarCode = book.BarCode,
                        BorrowCount = 1,
                        Expire = DateTime.Now.AddDays(reader.AllowDay)
                    });
                    this.dgvBookList.DataSource = null;
                    this.dgvBookList.DataSource = borrowList;
                    this.btnDel.Enabled = true;
                    this.btnSave.Enabled = true;
                }
            }
        }


        #endregion

        private void DgvBookList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvBookList,e);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvBookList.CurrentRow != null)
            {
                //1找到需要删除的图书
                var borrowBook = borrowList.Where(o => o.BarCode == this.dgvBookList.CurrentRow.Cells["BarCode"].Value.ToString()).FirstOrDefault();
                //2.从列表中删除
                borrowList.Remove(borrowBook);
                //3.刷新列表
                this.dgvBookList.DataSource = null;
                this.dgvBookList.DataSource = borrowList;
                if (this.dgvBookList.RowCount == 0)
                {
                    this.btnDel.Enabled = false;
                    this.btnSave.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("请选择需要删除的图书！", "借阅提示");
            }
        }

        /// <summary>
        /// 保存借阅信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //创建对象
            BorrowInfo borrowInfo = new BorrowInfo
            {
                BorrowId = CreateBorrowId(),
                ReaderId = reader.ReaderId,
                AdminName_B = Program.CurrentAdmin.AdminId.ToString()
            };
            for (int i = 0; i < borrowList.Count; i++)
            {

                borrowList[i].BorrowId = borrowInfo.BorrowId;
                borrowList[i].NonReturnCount = borrowList[i].BorrowCount;
            }
            try
            {
                borrowManager.BorrowBookConfirm(borrowInfo, borrowList);
                MessageBox.Show("借阅成功！", "异常提示");
                //数据复位：
                this.txtBarCode.Clear();
                this.txtBarCode.Enabled = false;
                this.dgvBookList.DataSource = null;
                this.borrowList = null;
                this.btnSave.Enabled = false;
                this.btnDel.Enabled = false;
                this.lblBorrowCount.Text = "";
                this.lbl_Remainder.Text = "";
                this.txtReadingCard.Text = "";
                this.lblRoleName.Text = "";
                this.lblReaderName.Text = "";
                this.lblAllowCounts.Text = "";
                this.pbReaderImage.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("借书异常:"+ex.Message, "异常提示");
            }
        }

        private string CreateBorrowId()
        {
            string borrowId = DateTime.Now.ToString("yyyyMMddHHmmssms");
            Random random =new Random();
            borrowId += random.Next(10, 99).ToString();
            return borrowId;
        }
    }
}
