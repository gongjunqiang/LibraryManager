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

namespace Library
{
    public partial class FrmModifyPwd : Form
    {
        private SysAdminManager adminManager = new SysAdminManager();
        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (this.txtOldPwd.Text.Trim() != Program.CurrentAdmin.LoginPwd)
            {
                MessageBox.Show("原密码错误，请确认！","修改提示");
                return;
            }

            if (this.txtNewPwd.Text.Trim() != this.txtNewPwdConfirm.Text.Trim())
            {
                MessageBox.Show("新密码不一致！", "修改提示");
                return;
            }

            try
            {
                adminManager.MoifyPwd(this.txtNewPwd.Text.Trim(), Program.CurrentAdmin.AdminId.ToString());
                MessageBox.Show("密码修改成功！", "修改提示");
                Program.CurrentAdmin.LoginPwd = this.txtNewPwd.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("操作异常！", "异常提示");
            }
        }
    }
}
