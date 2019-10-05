namespace Library
{
    partial class FrmReaderManger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReaderManger));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.rdoIDCard = new System.Windows.Forms.RadioButton();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.txt_IDCard = new System.Windows.Forms.TextBox();
            this.lblReadingCard = new System.Windows.Forms.Label();
            this.rdoReadingCard = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.txt_ReadingCard = new System.Windows.Forms.TextBox();
            this.pbReaderImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnQueryReader = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblReaderCount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lvReader = new System.Windows.Forms.ListView();
            this.ReaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReadingCard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 241);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.lblPhone);
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Controls.Add(this.btnQuery);
            this.tabPage1.Controls.Add(this.lblPostCode);
            this.tabPage1.Controls.Add(this.rdoIDCard);
            this.tabPage1.Controls.Add(this.lblRoleName);
            this.tabPage1.Controls.Add(this.txt_IDCard);
            this.tabPage1.Controls.Add(this.lblReadingCard);
            this.tabPage1.Controls.Add(this.rdoReadingCard);
            this.tabPage1.Controls.Add(this.lblGender);
            this.tabPage1.Controls.Add(this.lblReaderName);
            this.tabPage1.Controls.Add(this.txt_ReadingCard);
            this.tabPage1.Controls.Add(this.pbReaderImg);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "会员查询";
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "会员办证";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "people.ico");
            this.imageList1.Images.SetKeyName(1, "BOOK02.ICO");
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(164, 151);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 37);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "修改信息 ";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhone.Location = new System.Drawing.Point(793, 103);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(142, 24);
            this.lblPhone.TabIndex = 48;
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddress.Location = new System.Drawing.Point(562, 145);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(373, 24);
            this.lblAddress.TabIndex = 47;
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuery
            // 
            this.btnQuery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(38, 151);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(107, 37);
            this.btnQuery.TabIndex = 38;
            this.btnQuery.Text = "提交查询  ";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // lblPostCode
            // 
            this.lblPostCode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPostCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPostCode.Location = new System.Drawing.Point(562, 103);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(142, 24);
            this.lblPostCode.TabIndex = 46;
            this.lblPostCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoIDCard
            // 
            this.rdoIDCard.AutoSize = true;
            this.rdoIDCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoIDCard.Location = new System.Drawing.Point(38, 69);
            this.rdoIDCard.Name = "rdoIDCard";
            this.rdoIDCard.Size = new System.Drawing.Size(83, 16);
            this.rdoIDCard.TabIndex = 40;
            this.rdoIDCard.Text = "身份证号：";
            this.rdoIDCard.UseVisualStyleBackColor = true;
            // 
            // lblRoleName
            // 
            this.lblRoleName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRoleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoleName.Location = new System.Drawing.Point(793, 61);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(142, 24);
            this.lblRoleName.TabIndex = 45;
            this.lblRoleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_IDCard
            // 
            this.txt_IDCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IDCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_IDCard.Location = new System.Drawing.Point(133, 66);
            this.txt_IDCard.Name = "txt_IDCard";
            this.txt_IDCard.Size = new System.Drawing.Size(126, 21);
            this.txt_IDCard.TabIndex = 37;
            // 
            // lblReadingCard
            // 
            this.lblReadingCard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReadingCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReadingCard.Location = new System.Drawing.Point(793, 20);
            this.lblReadingCard.Name = "lblReadingCard";
            this.lblReadingCard.Size = new System.Drawing.Size(142, 24);
            this.lblReadingCard.TabIndex = 44;
            this.lblReadingCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoReadingCard
            // 
            this.rdoReadingCard.AutoSize = true;
            this.rdoReadingCard.Checked = true;
            this.rdoReadingCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoReadingCard.Location = new System.Drawing.Point(38, 22);
            this.rdoReadingCard.Name = "rdoReadingCard";
            this.rdoReadingCard.Size = new System.Drawing.Size(95, 16);
            this.rdoReadingCard.TabIndex = 41;
            this.rdoReadingCard.TabStop = true;
            this.rdoReadingCard.Text = "借阅证编号：";
            this.rdoReadingCard.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGender.Location = new System.Drawing.Point(562, 61);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(142, 24);
            this.lblGender.TabIndex = 49;
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReaderName
            // 
            this.lblReaderName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReaderName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReaderName.Location = new System.Drawing.Point(562, 20);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(142, 24);
            this.lblReaderName.TabIndex = 43;
            this.lblReaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ReadingCard
            // 
            this.txt_ReadingCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReadingCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ReadingCard.Location = new System.Drawing.Point(133, 17);
            this.txt_ReadingCard.Name = "txt_ReadingCard";
            this.txt_ReadingCard.Size = new System.Drawing.Size(126, 21);
            this.txt_ReadingCard.TabIndex = 35;
            // 
            // pbReaderImg
            // 
            this.pbReaderImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReaderImg.Location = new System.Drawing.Point(283, 17);
            this.pbReaderImg.Name = "pbReaderImg";
            this.pbReaderImg.Size = new System.Drawing.Size(178, 174);
            this.pbReaderImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReaderImg.TabIndex = 42;
            this.pbReaderImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "读者姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(722, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "联系电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "借阅证编号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "现在住址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "邮政编码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(722, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "会员角色：";
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(131, 271);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(126, 20);
            this.cboRole.TabIndex = 31;
            // 
            // btnQueryReader
            // 
            this.btnQueryReader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQueryReader.Image = ((System.Drawing.Image)(resources.GetObject("btnQueryReader.Image")));
            this.btnQueryReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQueryReader.Location = new System.Drawing.Point(280, 261);
            this.btnQueryReader.Name = "btnQueryReader";
            this.btnQueryReader.Size = new System.Drawing.Size(119, 39);
            this.btnQueryReader.TabIndex = 32;
            this.btnQueryReader.Text = "按照角色查询 ";
            this.btnQueryReader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQueryReader.UseVisualStyleBackColor = true;
            // 
            // btnEnable
            // 
            this.btnEnable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnable.Image = ((System.Drawing.Image)(resources.GetObject("btnEnable.Image")));
            this.btnEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnable.Location = new System.Drawing.Point(797, 261);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(102, 37);
            this.btnEnable.TabIndex = 33;
            this.btnEnable.Text = "挂失借阅证 ";
            this.btnEnable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnable.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(905, 261);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 37);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblReaderCount
            // 
            this.lblReaderCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReaderCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReaderCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReaderCount.Location = new System.Drawing.Point(522, 269);
            this.lblReaderCount.Name = "lblReaderCount";
            this.lblReaderCount.Size = new System.Drawing.Size(126, 24);
            this.lblReaderCount.TabIndex = 35;
            this.lblReaderCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(20, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 12);
            this.label16.TabIndex = 29;
            this.label16.Text = "按照会员角色查询：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(427, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 30;
            this.label14.Text = "对应会员总数：";
            // 
            // lvReader
            // 
            this.lvReader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReaderId,
            this.ReadingCard,
            this.ReaderName,
            this.Gender,
            this.PhoneNumber,
            this.RegTime,
            this.StatusDesc,
            this.ReaderAddress});
            this.lvReader.GridLines = true;
            this.lvReader.Location = new System.Drawing.Point(16, 314);
            this.lvReader.Name = "lvReader";
            this.lvReader.Size = new System.Drawing.Size(975, 348);
            this.lvReader.TabIndex = 36;
            this.lvReader.UseCompatibleStateImageBehavior = false;
            this.lvReader.View = System.Windows.Forms.View.Details;
            // 
            // ReaderId
            // 
            this.ReaderId.Text = "读者编号";
            // 
            // ReadingCard
            // 
            this.ReadingCard.Text = "借阅证编号";
            this.ReadingCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReadingCard.Width = 150;
            // 
            // ReaderName
            // 
            this.ReaderName.Text = "姓名";
            this.ReaderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReaderName.Width = 100;
            // 
            // Gender
            // 
            this.Gender.Text = "性别";
            this.Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "联系电话";
            this.PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumber.Width = 150;
            // 
            // RegTime
            // 
            this.RegTime.Text = "办证时间";
            this.RegTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RegTime.Width = 150;
            // 
            // StatusDesc
            // 
            this.StatusDesc.Text = "会员状态";
            this.StatusDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StatusDesc.Width = 100;
            // 
            // ReaderAddress
            // 
            this.ReaderAddress.Text = "通信地址";
            this.ReaderAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReaderAddress.Width = 260;
            // 
            // FrmReaderManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 685);
            this.Controls.Add(this.lvReader);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.btnQueryReader);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblReaderCount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReaderManger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[会员管理]";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.RadioButton rdoIDCard;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txt_IDCard;
        private System.Windows.Forms.Label lblReadingCard;
        private System.Windows.Forms.RadioButton rdoReadingCard;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.TextBox txt_ReadingCard;
        private System.Windows.Forms.PictureBox pbReaderImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Button btnQueryReader;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblReaderCount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView lvReader;
        private System.Windows.Forms.ColumnHeader ReaderId;
        private System.Windows.Forms.ColumnHeader ReadingCard;
        private System.Windows.Forms.ColumnHeader ReaderName;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader RegTime;
        private System.Windows.Forms.ColumnHeader StatusDesc;
        private System.Windows.Forms.ColumnHeader ReaderAddress;
    }
}