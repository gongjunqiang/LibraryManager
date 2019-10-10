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
    public partial class FrmEidtReader : Form
    {
        private ReaderManager readerManager = new ReaderManager();
        private int roleId = 0;

        public FrmEidtReader(Reader reader,DataTable dt)
        {
            InitializeComponent();
            #region 数据初始化
            this.txtAddress.Text = reader.ReaderAddress;
            this.txtPhone.Text = reader.PhoneNumber;
            this.txtPostcode.Text = reader.PostCode;
            this.txtReaderName.Text = reader.ReaderName;
            this.txtReadingCard.Text = reader.ReadingCard;
            this.pbReaderPhoto.Image = reader.ReaderImage == "" ? null : (Image)SerializeObjectToString.DeserializeObject(reader.ReaderImage);
            if (reader.Gender == "男")
            {
                this.rdoMale.Checked = true;
            }
            else
            {
                this.rdoFemale.Checked = true;
            }
            this.cboReaderRole.DataSource = dt;
            this.cboReaderRole.DisplayMember = "RoleName";
            this.cboReaderRole.ValueMember = "RoleId";
            this.cboReaderRole.SelectedValue = reader.RoleId;
            roleId = reader.RoleId;
            #endregion

        }

        /// <summary>
        /// 提交修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //数据校验
            Reader reader = new Reader
            {
                ReaderId = roleId,
                ReadingCard = this.txtReadingCard.Text.Trim(),
                ReaderName = this.txtReaderName.Text.Trim(),
                Gender = rdoMale.Checked ? "男" : "女",
                ReaderAddress = this.txtAddress.Text.Trim(),
                PostCode = this.txtPostcode.Text.Trim(),
                PhoneNumber = this.txtPhone.Text.Trim(),
                RoleId = Convert.ToInt32(this.cboReaderRole.SelectedValue),
                ReaderImage = this.pbReaderPhoto.Image == null ? "" : SerializeObjectToString.SerializeObject(this.pbReaderPhoto.Image),
            };

            try
            {
                readerManager.EditReader(reader);
                MessageBox.Show("修改成功！:" , "修改提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作异常:" + ex.Message, "异常提示");
            }

        }
    }
}
