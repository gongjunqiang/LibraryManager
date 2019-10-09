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


namespace Library
{
    public partial class FrmReaderManger : Form
    {
        private ReaderManager readerManager = new ReaderManager();
        public FrmReaderManger()
        {
            InitializeComponent();

            #region 数据初始化
            var roleList = readerManager.GetAllReaderRoles();
            this.cboRole.DataSource = roleList;
            this.cboRole.DisplayMember = "RoleName";
            this.cboRole.ValueMember = "RoleId";

            this.cboReaderRole.DataSource = roleList;
            this.cboReaderRole.DisplayMember = "RoleName";
            this.cboReaderRole.ValueMember = "RoleId";

            #endregion
        }
    }
}
