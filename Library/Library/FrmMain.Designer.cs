﻿namespace Library
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.商品管理PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiBookManage = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBorrowBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMemberManage = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAdminName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_AdminName = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnReaderManager = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOperationName = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnModifyPwd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnBookNew = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnBookManage = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem,
            this.商品管理PToolStripMenuItem,
            this.销售管理XToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModifyPwd,
            this.toolStripSeparator3,
            this.tsmiExit});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.系统SToolStripMenuItem.Text = "系统(&S)";
            // 
            // tsmiModifyPwd
            // 
            this.tsmiModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiModifyPwd.Image")));
            this.tsmiModifyPwd.Name = "tsmiModifyPwd";
            this.tsmiModifyPwd.Size = new System.Drawing.Size(139, 22);
            this.tsmiModifyPwd.Text = "修改密码(&P)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(136, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExit.Image")));
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(139, 22);
            this.tsmiExit.Text = "退出系统(&E)";
            // 
            // 商品管理PToolStripMenuItem
            // 
            this.商品管理PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddBook,
            this.tsmiBookNew,
            this.toolStripSeparator1,
            this.tsmiBookManage});
            this.商品管理PToolStripMenuItem.Name = "商品管理PToolStripMenuItem";
            this.商品管理PToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.商品管理PToolStripMenuItem.Text = "图书管理(&B)";
            // 
            // tsmiAddBook
            // 
            this.tsmiAddBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddBook.Image")));
            this.tsmiAddBook.Name = "tsmiAddBook";
            this.tsmiAddBook.Size = new System.Drawing.Size(168, 22);
            this.tsmiAddBook.Text = "添加新书(&A)";
            // 
            // tsmiBookNew
            // 
            this.tsmiBookNew.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBookNew.Image")));
            this.tsmiBookNew.Name = "tsmiBookNew";
            this.tsmiBookNew.Size = new System.Drawing.Size(168, 22);
            this.tsmiBookNew.Text = "图书上架(&I)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // tsmiBookManage
            // 
            this.tsmiBookManage.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBookManage.Image")));
            this.tsmiBookManage.Name = "tsmiBookManage";
            this.tsmiBookManage.Size = new System.Drawing.Size(168, 22);
            this.tsmiBookManage.Text = "图书信息维护(&M)";
            // 
            // 销售管理XToolStripMenuItem
            // 
            this.销售管理XToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBorrowBook,
            this.tsmiReturnBook,
            this.tsmiMemberManage});
            this.销售管理XToolStripMenuItem.Name = "销售管理XToolStripMenuItem";
            this.销售管理XToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.销售管理XToolStripMenuItem.Text = "会员借还书(&B)";
            // 
            // tsmiBorrowBook
            // 
            this.tsmiBorrowBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBorrowBook.Image")));
            this.tsmiBorrowBook.Name = "tsmiBorrowBook";
            this.tsmiBorrowBook.Size = new System.Drawing.Size(144, 22);
            this.tsmiBorrowBook.Text = "图书出借(&B)";
            // 
            // tsmiReturnBook
            // 
            this.tsmiReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReturnBook.Image")));
            this.tsmiReturnBook.Name = "tsmiReturnBook";
            this.tsmiReturnBook.Size = new System.Drawing.Size(144, 22);
            this.tsmiReturnBook.Text = "图书归还(&R)";
            // 
            // tsmiMemberManage
            // 
            this.tsmiMemberManage.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMemberManage.Image")));
            this.tsmiMemberManage.Name = "tsmiMemberManage";
            this.tsmiMemberManage.Size = new System.Drawing.Size(144, 22);
            this.tsmiMemberManage.Text = "会员管理(&M)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblAdminName,
            this.tssl_AdminName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(149, 17);
            this.toolStripStatusLabel1.Text = "[图书借阅管理系统]  V2.0 ";
            // 
            // lblAdminName
            // 
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(80, 17);
            this.lblAdminName.Text = "【管理员】：";
            // 
            // tssl_AdminName
            // 
            this.tssl_AdminName.Name = "tssl_AdminName";
            this.tssl_AdminName.Size = new System.Drawing.Size(20, 17);
            this.tssl_AdminName.Text = "无";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnReaderManager);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblOperationName);
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
            this.splitContainer1.Panel1.Controls.Add(this.btnModifyPwd);
            this.splitContainer1.Panel1.Controls.Add(this.btnExit);
            this.splitContainer1.Panel1.Controls.Add(this.btnReturnBook);
            this.splitContainer1.Panel1.Controls.Add(this.btnBookNew);
            this.splitContainer1.Panel1.Controls.Add(this.btnBorrowBook);
            this.splitContainer1.Panel1.Controls.Add(this.btnBookManage);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddBook);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Size = new System.Drawing.Size(1264, 682);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 14;
            // 
            // btnReaderManager
            // 
            this.btnReaderManager.Image = ((System.Drawing.Image)(resources.GetObject("btnReaderManager.Image")));
            this.btnReaderManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReaderManager.Location = new System.Drawing.Point(126, 444);
            this.btnReaderManager.Name = "btnReaderManager";
            this.btnReaderManager.Size = new System.Drawing.Size(82, 41);
            this.btnReaderManager.TabIndex = 5;
            this.btnReaderManager.Text = "会员管理";
            this.btnReaderManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReaderManager.UseVisualStyleBackColor = true;
            this.btnReaderManager.Click += new System.EventHandler(this.BtnReaderManager_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(23, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 3);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(24, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 3);
            this.label1.TabIndex = 3;
            // 
            // lblOperationName
            // 
            this.lblOperationName.Font = new System.Drawing.Font("微软雅黑 Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOperationName.ForeColor = System.Drawing.Color.Maroon;
            this.lblOperationName.Location = new System.Drawing.Point(9, 43);
            this.lblOperationName.Name = "lblOperationName";
            this.lblOperationName.Size = new System.Drawing.Size(220, 49);
            this.lblOperationName.TabIndex = 4;
            this.lblOperationName.Text = "欢迎使用";
            this.lblOperationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 115);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // btnModifyPwd
            // 
            this.btnModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyPwd.Image")));
            this.btnModifyPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyPwd.Location = new System.Drawing.Point(25, 594);
            this.btnModifyPwd.Name = "btnModifyPwd";
            this.btnModifyPwd.Size = new System.Drawing.Size(82, 41);
            this.btnModifyPwd.TabIndex = 7;
            this.btnModifyPwd.Text = "密码修改";
            this.btnModifyPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyPwd.UseVisualStyleBackColor = true;
            this.btnModifyPwd.Click += new System.EventHandler(this.BtnModifyPwd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(125, 594);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 41);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退出系统";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnBook.Image")));
            this.btnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.Location = new System.Drawing.Point(125, 505);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(82, 41);
            this.btnReturnBook.TabIndex = 9;
            this.btnReturnBook.Text = "图书归还";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.BtnReturnBook_Click);
            // 
            // btnBookNew
            // 
            this.btnBookNew.Image = ((System.Drawing.Image)(resources.GetObject("btnBookNew.Image")));
            this.btnBookNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookNew.Location = new System.Drawing.Point(125, 360);
            this.btnBookNew.Name = "btnBookNew";
            this.btnBookNew.Size = new System.Drawing.Size(82, 41);
            this.btnBookNew.TabIndex = 10;
            this.btnBookNew.Text = " 图书上架";
            this.btnBookNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookNew.UseVisualStyleBackColor = true;
            this.btnBookNew.Click += new System.EventHandler(this.BtnBookNew_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrowBook.Image")));
            this.btnBorrowBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowBook.Location = new System.Drawing.Point(24, 505);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(82, 41);
            this.btnBorrowBook.TabIndex = 11;
            this.btnBorrowBook.Text = "图书借阅";
            this.btnBorrowBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.BtnBorrowBook_Click);
            // 
            // btnBookManage
            // 
            this.btnBookManage.Image = ((System.Drawing.Image)(resources.GetObject("btnBookManage.Image")));
            this.btnBookManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookManage.Location = new System.Drawing.Point(24, 444);
            this.btnBookManage.Name = "btnBookManage";
            this.btnBookManage.Size = new System.Drawing.Size(82, 41);
            this.btnBookManage.TabIndex = 12;
            this.btnBookManage.Text = "图书管理";
            this.btnBookManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookManage.UseVisualStyleBackColor = true;
            this.btnBookManage.Click += new System.EventHandler(this.BtnBookManage_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Image")));
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.Location = new System.Drawing.Point(25, 359);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(82, 41);
            this.btnAddBook.TabIndex = 13;
            this.btnAddBook.Text = "新增图书";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[图书借阅管理系统]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyPwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem 商品管理PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookManage;
        private System.Windows.Forms.ToolStripMenuItem 销售管理XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBorrowBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiReturnBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiMemberManage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblAdminName;
        private System.Windows.Forms.ToolStripStatusLabel tssl_AdminName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnReaderManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperationName;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnModifyPwd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnBookNew;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnBookManage;
        private System.Windows.Forms.Button btnAddBook;
    }
}