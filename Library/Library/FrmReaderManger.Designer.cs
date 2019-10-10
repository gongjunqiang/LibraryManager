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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCloseVideo = new System.Windows.Forms.Button();
            this.pbReaderPhoto = new System.Windows.Forms.PictureBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.pbReaderVideo = new System.Windows.Forms.PictureBox();
            this.btnStartVideo = new System.Windows.Forms.Button();
            this.cboReaderRole = new System.Windows.Forms.ComboBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtReadingCard = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderVideo)).BeginInit();
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
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
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
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
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
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.txtIdCard);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.btnCloseVideo);
            this.tabPage2.Controls.Add(this.pbReaderPhoto);
            this.tabPage2.Controls.Add(this.btnTake);
            this.tabPage2.Controls.Add(this.pbReaderVideo);
            this.tabPage2.Controls.Add(this.btnStartVideo);
            this.tabPage2.Controls.Add(this.cboReaderRole);
            this.tabPage2.Controls.Add(this.rdoFemale);
            this.tabPage2.Controls.Add(this.rdoMale);
            this.tabPage2.Controls.Add(this.txtReaderName);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.txtPhone);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.txtReadingCard);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.txtPostcode);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "会员办证";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtIdCard
            // 
            this.txtIdCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdCard.Location = new System.Drawing.Point(809, 171);
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(143, 21);
            this.txtIdCard.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(738, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 57;
            this.label5.Text = "身份证号：";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(382, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 39);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "确认添加";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCloseVideo
            // 
            this.btnCloseVideo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseVideo.Location = new System.Drawing.Point(381, 62);
            this.btnCloseVideo.Name = "btnCloseVideo";
            this.btnCloseVideo.Size = new System.Drawing.Size(89, 39);
            this.btnCloseVideo.TabIndex = 56;
            this.btnCloseVideo.Text = "关闭摄像头";
            this.btnCloseVideo.UseVisualStyleBackColor = true;
            // 
            // pbReaderPhoto
            // 
            this.pbReaderPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReaderPhoto.Location = new System.Drawing.Point(202, 15);
            this.pbReaderPhoto.Name = "pbReaderPhoto";
            this.pbReaderPhoto.Size = new System.Drawing.Size(159, 180);
            this.pbReaderPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReaderPhoto.TabIndex = 52;
            this.pbReaderPhoto.TabStop = false;
            // 
            // btnTake
            // 
            this.btnTake.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTake.Location = new System.Drawing.Point(382, 108);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(88, 39);
            this.btnTake.TabIndex = 55;
            this.btnTake.Text = "选择照片";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.BtnTake_Click);
            // 
            // pbReaderVideo
            // 
            this.pbReaderVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReaderVideo.Location = new System.Drawing.Point(21, 15);
            this.pbReaderVideo.Name = "pbReaderVideo";
            this.pbReaderVideo.Size = new System.Drawing.Size(159, 180);
            this.pbReaderVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReaderVideo.TabIndex = 51;
            this.pbReaderVideo.TabStop = false;
            // 
            // btnStartVideo
            // 
            this.btnStartVideo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartVideo.Location = new System.Drawing.Point(381, 16);
            this.btnStartVideo.Name = "btnStartVideo";
            this.btnStartVideo.Size = new System.Drawing.Size(88, 39);
            this.btnStartVideo.TabIndex = 53;
            this.btnStartVideo.Text = "启动摄像头";
            this.btnStartVideo.UseVisualStyleBackColor = true;
            // 
            // cboReaderRole
            // 
            this.cboReaderRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReaderRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboReaderRole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboReaderRole.FormattingEnabled = true;
            this.cboReaderRole.Location = new System.Drawing.Point(811, 77);
            this.cboReaderRole.Name = "cboReaderRole";
            this.cboReaderRole.Size = new System.Drawing.Size(142, 20);
            this.cboReaderRole.TabIndex = 50;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoFemale.Location = new System.Drawing.Point(626, 79);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 48;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoMale.Location = new System.Drawing.Point(575, 79);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 49;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtReaderName
            // 
            this.txtReaderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReaderName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReaderName.Location = new System.Drawing.Point(575, 25);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(142, 21);
            this.txtReaderName.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(504, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 36;
            this.label17.Text = "读者姓名：";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Location = new System.Drawing.Point(810, 126);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(142, 21);
            this.txtPhone.TabIndex = 46;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Location = new System.Drawing.Point(574, 172);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(143, 21);
            this.txtAddress.TabIndex = 47;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(739, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 37;
            this.label18.Text = "联系电话：";
            // 
            // txtReadingCard
            // 
            this.txtReadingCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadingCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReadingCard.Location = new System.Drawing.Point(810, 25);
            this.txtReadingCard.Name = "txtReadingCard";
            this.txtReadingCard.Size = new System.Drawing.Size(143, 21);
            this.txtReadingCard.TabIndex = 44;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(503, 176);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 38;
            this.label19.Text = "现在住址：";
            // 
            // txtPostcode
            // 
            this.txtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostcode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPostcode.Location = new System.Drawing.Point(575, 126);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(142, 21);
            this.txtPostcode.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(504, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 39;
            this.label20.Text = "邮政编码：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(739, 81);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 40;
            this.label21.Text = "会员角色：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(516, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 41;
            this.label22.Text = "性别：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(727, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 12);
            this.label23.TabIndex = 42;
            this.label23.Text = "借阅证编号：";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "people.ico");
            this.imageList1.Images.SetKeyName(1, "BOOK02.ICO");
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
            this.btnQueryReader.Click += new System.EventHandler(this.BtnQueryReader_Click);
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
            this.btnEnable.Click += new System.EventHandler(this.BtnEnable_Click);
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
            this.lvReader.FullRowSelect = true;
            this.lvReader.GridLines = true;
            this.lvReader.HideSelection = false;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderVideo)).EndInit();
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCloseVideo;
        private System.Windows.Forms.PictureBox pbReaderPhoto;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.PictureBox pbReaderVideo;
        private System.Windows.Forms.Button btnStartVideo;
        private System.Windows.Forms.ComboBox cboReaderRole;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtReadingCard;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtIdCard;
        private System.Windows.Forms.Label label5;
    }
}