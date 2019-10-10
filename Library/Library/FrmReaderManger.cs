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
using BLL;
using Common;


namespace Library
{
    public partial class FrmReaderManger : Form
    {
        private ReaderManager readerManager = new ReaderManager();
        public Reader reader = null;
        public FrmReaderManger()
        {
            InitializeComponent();
            #region 数据初始化
            DataTable dt = readerManager.GetAllReaderRole();
            this.cboRole.DataSource = dt;
            this.cboRole.DisplayMember = "RoleName";
            this.cboRole.ValueMember = "RoleId";

            this.cboReaderRole.DataSource = dt.Copy();//复制DataTable在赋值给oReaderRole.DataSource ，防止数据源一起变化
            this.cboReaderRole.DisplayMember = "RoleName";
            this.cboReaderRole.ValueMember = "RoleId";

            this.btnEnable.Enabled = false;
            this.btnEdit.Enabled = false;

            #endregion
        }

        /// <summary>
        /// 确认添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Reader reader = new Reader
            {
                ReadingCard = this.txtReadingCard.Text.Trim(),
                ReaderName = this.txtReaderName.Text.Trim(),
                Gender = rdoMale.Checked?"男":"女",
                IDCard = this.txtIdCard.Text.Trim(),
                ReaderAddress = this.txtAddress.Text.Trim(),
                PostCode = this.txtPostcode.Text.Trim(),
                PhoneNumber = this.txtPhone.Text.Trim(),
                RoleId = Convert.ToInt32(this.cboReaderRole.SelectedValue),
                ReaderImage = this.pbReaderPhoto.Image==null?"": SerializeObjectToString.SerializeObject(this.pbReaderPhoto.Image),
                ReaderPwd = "123456",
                AdminId = Program.CurrentAdmin.AdminId
            };

            try
            {
                readerManager.AddNewReader(reader);
                MessageBox.Show("办证成功", "新增提示");
                //清除信息
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作异常:" + ex.Message, "异常提示");
            }

        }

        /// <summary>
        /// 无法拍照，以选择照片未基础
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTake_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.pbReaderPhoto.Image =Image.FromFile(openFileDialog.FileName);
            }
        }

        //按照角色查询
        private void BtnQueryReader_Click(object sender, EventArgs e)
        {
            this.lvReader.Items.Clear();
            try
            {
                int readercount = 0;
                List<Reader> list = readerManager.GetReaderByRoleId(this.cboRole.SelectedValue.ToString(), out readercount);
                //绑定数据源
                foreach (Reader reader in list)
                {
                    //创建一个listview项
                    ListViewItem lviItem = new ListViewItem(reader.ReaderId.ToString());
                    //向创建一个listview项添加ListViewItem对象
                    this.lvReader.Items.Add(lviItem);
                    //在当前ListViewItem中添加子项
                    lviItem.SubItems.AddRange(new string[]
                    {
                        reader.ReadingCard,
                        reader.ReaderName,
                        reader.Gender,
                        reader.PhoneNumber,
                        reader.RegTime.ToShortDateString(),
                        reader.StatusDesc,
                        reader.ReaderAddress
                    });
                }

                this.lblReaderCount.Text = readercount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("操作异常:" + ex.Message, "异常提示");
            }
        }

        /// <summary>
        /// 提交查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            if (this.txt_IDCard.Text.Trim().Length == 0 && this.txt_ReadingCard.Text.Trim().Length == 0)
            {
                MessageBox.Show("查询条件不能为空!", "查询提示");
                return;
            }
            try
            {
                if (this.rdoReadingCard.Checked)
                {
                    reader = readerManager.QueryReaderInfoByReadingCard(this.txt_ReadingCard.Text.Trim());
                    DataDisplay(reader);
                    this.txt_IDCard.Clear();
                }
                else
                {
                    reader = readerManager.QueryReaderInfoByIdCard(this.txt_IDCard.Text.Trim());
                    DataDisplay(reader);
                    this.txt_ReadingCard.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作异常:" + ex.Message, "异常提示");
            }
        }

        private void DataDisplay(Reader reader)
        {
            if (reader != null)
            {
                if (reader.StatusId != 0)
                {
                    this.btnEnable.Enabled = true;
                    this.btnEdit.Enabled = true;
                }
                this.lblReaderName.Text = reader.ReaderName;
                this.lblReadingCard.Text = reader.ReadingCard;
                this.lblGender.Text = reader.Gender;
                this.lblRoleName.Text = reader.RoleName;
                this.lblPostCode.Text = reader.PostCode;
                this.lblPhone.Text = reader.PhoneNumber;
                this.lblAddress.Text = reader.ReaderAddress;
                this.pbReaderImg.Image = reader.ReaderImage==""?null:(Image) SerializeObjectToString.DeserializeObject(reader.ReaderImage);
            }
            else
            {
                MessageBox.Show("未查询到会员信息，请核查询条件!", "查询提示");
                Clear();
            }
        }

        /// <summary>
        /// 借阅证挂失
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnable_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否挂失当前借阅证？", "确认提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    readerManager.ForbiddenReadingCard(reader.ReaderId.ToString());
                    MessageBox.Show("挂失成功","挂失提示");
                    //清空
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("操作异常:" + ex.Message, "异常提示");
                }
            }
        }

        private void Clear()
        {
            this.lblPhone.Text = "";
            this.lblAddress.Text = "";
            this.lblPostCode.Text = "";
            this.lblGender.Text = "";
            this.lblRoleName.Text = "";
            this.lblReaderName.Text = "";
            this.lblReadingCard.Text = "";
            this.pbReaderImg.Image = null;
            this.txt_IDCard.Text = "";
            this.txt_ReadingCard.Clear();
            this.btnEnable.Enabled = false;
            this.btnEdit.Enabled = false;
        }
    }
}
