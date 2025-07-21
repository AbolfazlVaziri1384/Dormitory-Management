namespace Final
{
    partial class frmSetUser
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
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            chkShowPassword = new CheckBox();
            grpLoginInfo = new GroupBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            txtAddress = new TextBox();
            grpPersonalInfo = new GroupBox();
            radWoman = new RadioButton();
            radMen = new RadioButton();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            mskBirthDay = new MaskedTextBox();
            numNationalCode = new NumericUpDown();
            numStu_Per_Code = new NumericUpDown();
            numPhone = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            grpIdentityInfo = new GroupBox();
            pictureBox2 = new PictureBox();
            btnSave = new Button();
            grpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNationalCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStu_Per_Code).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPhone).BeginInit();
            grpIdentityInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(235, 43);
            label1.Name = "label1";
            label1.Size = new Size(29, 26);
            label1.TabIndex = 0;
            label1.Text = ":نام";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(104, 40);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.RightToLeft = RightToLeft.Yes;
            txtFirstName.Size = new Size(125, 37);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(235, 89);
            label2.Name = "label2";
            label2.Size = new Size(79, 26);
            label2.TabIndex = 2;
            label2.Text = ":نام خانوادگی";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(104, 86);
            txtLastName.Name = "txtLastName";
            txtLastName.RightToLeft = RightToLeft.Yes;
            txtLastName.Size = new Size(125, 37);
            txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            label3.Location = new Point(176, 41);
            label3.Name = "label3";
            label3.Size = new Size(69, 26);
            label3.TabIndex = 4;
            label3.Text = ":نام کاربری";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            label4.Location = new Point(176, 89);
            label4.Name = "label4";
            label4.Size = new Size(60, 26);
            label4.TabIndex = 5;
            label4.Text = ":رمز عبور";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            label5.Location = new Point(176, 134);
            label5.Name = "label5";
            label5.Size = new Size(92, 26);
            label5.TabIndex = 6;
            label5.Text = ":تکرار رمز عبور";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(45, 38);
            txtUserName.MaxLength = 50;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 37);
            txtUserName.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(45, 86);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 37);
            txtPassword.TabIndex = 8;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(45, 128);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(125, 37);
            txtConfirmPassword.TabIndex = 9;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(21, 92);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(18, 17);
            chkShowPassword.TabIndex = 10;
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // grpLoginInfo
            // 
            grpLoginInfo.Controls.Add(pictureBox3);
            grpLoginInfo.Controls.Add(txtPassword);
            grpLoginInfo.Controls.Add(chkShowPassword);
            grpLoginInfo.Controls.Add(label3);
            grpLoginInfo.Controls.Add(txtConfirmPassword);
            grpLoginInfo.Controls.Add(label4);
            grpLoginInfo.Controls.Add(label5);
            grpLoginInfo.Controls.Add(txtUserName);
            grpLoginInfo.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            grpLoginInfo.ForeColor = Color.MediumBlue;
            grpLoginInfo.Location = new Point(63, 231);
            grpLoginInfo.Name = "grpLoginInfo";
            grpLoginInfo.Size = new Size(302, 193);
            grpLoginInfo.TabIndex = 11;
            grpLoginInfo.TabStop = false;
            grpLoginInfo.Text = "اطلاعات ورود";
            grpLoginInfo.Enter += grpLoginInfo_Enter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.log;
            pictureBox3.Location = new Point(253, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(235, 222);
            label6.Name = "label6";
            label6.Size = new Size(48, 26);
            label6.TabIndex = 12;
            label6.Text = ":آدرس";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(47, 222);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.RightToLeft = RightToLeft.Yes;
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(182, 64);
            txtAddress.TabIndex = 13;
            // 
            // grpPersonalInfo
            // 
            grpPersonalInfo.Controls.Add(radWoman);
            grpPersonalInfo.Controls.Add(radMen);
            grpPersonalInfo.Controls.Add(pictureBox1);
            grpPersonalInfo.Controls.Add(label11);
            grpPersonalInfo.Controls.Add(label10);
            grpPersonalInfo.Controls.Add(mskBirthDay);
            grpPersonalInfo.Controls.Add(txtFirstName);
            grpPersonalInfo.Controls.Add(txtAddress);
            grpPersonalInfo.Controls.Add(label1);
            grpPersonalInfo.Controls.Add(label6);
            grpPersonalInfo.Controls.Add(label2);
            grpPersonalInfo.Controls.Add(txtLastName);
            grpPersonalInfo.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            grpPersonalInfo.ForeColor = Color.MediumBlue;
            grpPersonalInfo.Location = new Point(397, 37);
            grpPersonalInfo.Name = "grpPersonalInfo";
            grpPersonalInfo.Size = new Size(334, 317);
            grpPersonalInfo.TabIndex = 14;
            grpPersonalInfo.TabStop = false;
            grpPersonalInfo.Text = "مشخصات فردی";
            // 
            // radWoman
            // 
            radWoman.AutoSize = true;
            radWoman.Location = new Point(169, 174);
            radWoman.Name = "radWoman";
            radWoman.Size = new Size(60, 33);
            radWoman.TabIndex = 25;
            radWoman.TabStop = true;
            radWoman.Text = "خانم";
            radWoman.UseVisualStyleBackColor = true;
            // 
            // radMen
            // 
            radMen.AutoSize = true;
            radMen.Location = new Point(104, 174);
            radMen.Name = "radMen";
            radMen.Size = new Size(50, 33);
            radMen.TabIndex = 24;
            radMen.TabStop = true;
            radMen.Text = "آقا";
            radMen.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.personal;
            pictureBox1.Location = new Point(285, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            label11.ForeColor = Color.RoyalBlue;
            label11.Location = new Point(235, 178);
            label11.Name = "label11";
            label11.Size = new Size(54, 26);
            label11.TabIndex = 17;
            label11.Text = ":جنسیت";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            label10.ForeColor = Color.RoyalBlue;
            label10.Location = new Point(235, 135);
            label10.Name = "label10";
            label10.Size = new Size(67, 26);
            label10.TabIndex = 15;
            label10.Text = ":تاریخ تولد";
            // 
            // mskBirthDay
            // 
            mskBirthDay.Location = new Point(104, 131);
            mskBirthDay.Mask = "0000/00/00";
            mskBirthDay.Name = "mskBirthDay";
            mskBirthDay.Size = new Size(125, 37);
            mskBirthDay.TabIndex = 14;
            mskBirthDay.TextAlign = HorizontalAlignment.Center;
            mskBirthDay.ValidatingType = typeof(DateTime);
            // 
            // numNationalCode
            // 
            numNationalCode.Location = new Point(20, 34);
            numNationalCode.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numNationalCode.Name = "numNationalCode";
            numNationalCode.Size = new Size(150, 37);
            numNationalCode.TabIndex = 15;
            // 
            // numStu_Per_Code
            // 
            numStu_Per_Code.Location = new Point(20, 77);
            numStu_Per_Code.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numStu_Per_Code.Name = "numStu_Per_Code";
            numStu_Per_Code.Size = new Size(150, 37);
            numStu_Per_Code.TabIndex = 16;
            // 
            // numPhone
            // 
            numPhone.Location = new Point(20, 120);
            numPhone.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numPhone.Name = "numPhone";
            numPhone.Size = new Size(150, 37);
            numPhone.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(176, 36);
            label7.Name = "label7";
            label7.Size = new Size(50, 26);
            label7.TabIndex = 18;
            label7.Text = ":کد ملی";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(176, 79);
            label8.Name = "label8";
            label8.Size = new Size(99, 26);
            label8.TabIndex = 19;
            label8.Text = ":شماره دانشجویی";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(176, 122);
            label9.Name = "label9";
            label9.Size = new Size(77, 26);
            label9.TabIndex = 20;
            label9.Text = ":شماره تماس";
            // 
            // grpIdentityInfo
            // 
            grpIdentityInfo.Controls.Add(pictureBox2);
            grpIdentityInfo.Controls.Add(numStu_Per_Code);
            grpIdentityInfo.Controls.Add(label9);
            grpIdentityInfo.Controls.Add(label7);
            grpIdentityInfo.Controls.Add(numPhone);
            grpIdentityInfo.Controls.Add(numNationalCode);
            grpIdentityInfo.Controls.Add(label8);
            grpIdentityInfo.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            grpIdentityInfo.ForeColor = Color.MediumBlue;
            grpIdentityInfo.Location = new Point(63, 37);
            grpIdentityInfo.Name = "grpIdentityInfo";
            grpIdentityInfo.Size = new Size(302, 179);
            grpIdentityInfo.TabIndex = 21;
            grpIdentityInfo.TabStop = false;
            grpIdentityInfo.Text = "اطلاعات شناسایی";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ide;
            pictureBox2.Location = new Point(253, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.AliceBlue;
            btnSave.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.MediumBlue;
            btnSave.Location = new Point(471, 382);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 42);
            btnSave.TabIndex = 22;
            btnSave.Text = "ثبت اطلاعات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmSetUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(grpIdentityInfo);
            Controls.Add(grpPersonalInfo);
            Controls.Add(grpLoginInfo);
            MaximizeBox = false;
            Name = "frmSetUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ثبت کاربرد جدید";
            Load += frmSetUser_Load;
            grpLoginInfo.ResumeLayout(false);
            grpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpPersonalInfo.ResumeLayout(false);
            grpPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNationalCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStu_Per_Code).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPhone).EndInit();
            grpIdentityInfo.ResumeLayout(false);
            grpIdentityInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private CheckBox chkShowPassword;
        private GroupBox grpLoginInfo;
        private Label label6;
        private TextBox txtAddress;
        private GroupBox grpPersonalInfo;
        private NumericUpDown numNationalCode;
        private NumericUpDown numStu_Per_Code;
        private NumericUpDown numPhone;
        private Label label7;
        private Label label8;
        private Label label9;
        private MaskedTextBox mskBirthDay;
        private Label label10;
        private Label label11;
        private GroupBox grpIdentityInfo;
        private Button btnSave;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private RadioButton radWoman;
        private RadioButton radMen;
    }
}