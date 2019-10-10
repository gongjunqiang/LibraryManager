namespace Library
{
    partial class FrmEidtReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEidtReader));
            this.btnSave = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(385, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 39);
            this.btnSave.TabIndex = 75;
            this.btnSave.Text = "提交修改";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCloseVideo
            // 
            this.btnCloseVideo.Location = new System.Drawing.Point(384, 73);
            this.btnCloseVideo.Name = "btnCloseVideo";
            this.btnCloseVideo.Size = new System.Drawing.Size(89, 39);
            this.btnCloseVideo.TabIndex = 77;
            this.btnCloseVideo.Text = "关闭摄像头";
            this.btnCloseVideo.UseVisualStyleBackColor = true;
            // 
            // pbReaderPhoto
            // 
            this.pbReaderPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReaderPhoto.Location = new System.Drawing.Point(205, 26);
            this.pbReaderPhoto.Name = "pbReaderPhoto";
            this.pbReaderPhoto.Size = new System.Drawing.Size(159, 180);
            this.pbReaderPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReaderPhoto.TabIndex = 73;
            this.pbReaderPhoto.TabStop = false;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(385, 119);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(88, 39);
            this.btnTake.TabIndex = 76;
            this.btnTake.Text = "开始拍照";
            this.btnTake.UseVisualStyleBackColor = true;
            // 
            // pbReaderVideo
            // 
            this.pbReaderVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReaderVideo.Location = new System.Drawing.Point(24, 26);
            this.pbReaderVideo.Name = "pbReaderVideo";
            this.pbReaderVideo.Size = new System.Drawing.Size(159, 180);
            this.pbReaderVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReaderVideo.TabIndex = 72;
            this.pbReaderVideo.TabStop = false;
            // 
            // btnStartVideo
            // 
            this.btnStartVideo.Location = new System.Drawing.Point(384, 27);
            this.btnStartVideo.Name = "btnStartVideo";
            this.btnStartVideo.Size = new System.Drawing.Size(88, 39);
            this.btnStartVideo.TabIndex = 74;
            this.btnStartVideo.Text = "启动摄像头";
            this.btnStartVideo.UseVisualStyleBackColor = true;
            // 
            // cboReaderRole
            // 
            this.cboReaderRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReaderRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboReaderRole.FormattingEnabled = true;
            this.cboReaderRole.Location = new System.Drawing.Point(332, 289);
            this.cboReaderRole.Name = "cboReaderRole";
            this.cboReaderRole.Size = new System.Drawing.Size(142, 20);
            this.cboReaderRole.TabIndex = 71;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(147, 291);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 69;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(96, 291);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 70;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtReaderName
            // 
            this.txtReaderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReaderName.Location = new System.Drawing.Point(96, 237);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(142, 21);
            this.txtReaderName.TabIndex = 64;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 57;
            this.label17.Text = "读者姓名：";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(331, 338);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(142, 21);
            this.txtPhone.TabIndex = 67;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(95, 384);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(378, 21);
            this.txtAddress.TabIndex = 68;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(260, 342);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 58;
            this.label18.Text = "联系电话：";
            // 
            // txtReadingCard
            // 
            this.txtReadingCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadingCard.Enabled = false;
            this.txtReadingCard.Location = new System.Drawing.Point(331, 237);
            this.txtReadingCard.Name = "txtReadingCard";
            this.txtReadingCard.Size = new System.Drawing.Size(143, 21);
            this.txtReadingCard.TabIndex = 65;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 388);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 59;
            this.label19.Text = "现在住址：";
            // 
            // txtPostcode
            // 
            this.txtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostcode.Location = new System.Drawing.Point(96, 338);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(142, 21);
            this.txtPostcode.TabIndex = 66;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 342);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 60;
            this.label20.Text = "邮政编码：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(260, 293);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 61;
            this.label21.Text = "会员角色：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(37, 293);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 62;
            this.label22.Text = "性别：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(248, 241);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 12);
            this.label23.TabIndex = 63;
            this.label23.Text = "借阅证编号：";
            // 
            // FrmEidtReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 431);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCloseVideo);
            this.Controls.Add(this.pbReaderPhoto);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.pbReaderVideo);
            this.Controls.Add(this.btnStartVideo);
            this.Controls.Add(this.cboReaderRole);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.txtReaderName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtReadingCard);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Name = "FrmEidtReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[修改读者信息]";
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
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
    }
}