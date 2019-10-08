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
using Models;

namespace Library
{
    public partial class FrmAdminLogin : Form
    {
        private SysAdminManager  adminManager = new SysAdminManager();
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //数据校验

            //封装对象
            SysAdmin admin = new SysAdmin
            {
                AdminId = Convert.ToInt32(this.txtAdminId.Text.Trim()),
                LoginPwd = this.txtLoginPwd.Text.Trim()
            };

            try
            {
                admin = adminManager.AdminLogin(admin);
                if (admin != null)
                {
                    if (admin.StatusId == 1)
                    {
                        Program.CurrentAdmin = admin;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("当前账号被禁用，无法登录，请联系管理员！","登录提示");
                    }
                }
                else
                {
                    MessageBox.Show("登录账号或密码错误！", "登录提示");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("登录异常，"+ ex.Message, "登录提示");
            }
        }

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
