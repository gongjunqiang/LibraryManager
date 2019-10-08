using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //禁止一个客户端打开多个
            int currentProcess = 0;
            Process[] processesArray = Process.GetProcesses();
            foreach (Process process in processesArray)
            {
                if (process.ProcessName == Process.GetCurrentProcess().ProcessName)
                {
                    currentProcess++;
                }
            }
            if (currentProcess > 1)
            {
                Application.Exit();
                return;
            }
            //登录窗体与主窗体切换
            FrmAdminLogin frmAdminLogin = new FrmAdminLogin();
            DialogResult dialogResult = frmAdminLogin.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }
        }

        public static SysAdmin CurrentAdmin = null;
    }
}
