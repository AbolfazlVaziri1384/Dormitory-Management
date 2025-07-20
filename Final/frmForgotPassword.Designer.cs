namespace Final
{
    partial class frmForgotPassword
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
            txtStu_Per_Code = new TextBox();
            label2 = new Label();
            txtNationalCode = new TextBox();
            btnVerify = new Button();
            label3 = new Label();
            txtNewPassword = new TextBox();
            label4 = new Label();
            txtConfirmPassword = new TextBox();
            btnSubmit = new Button();
            chkShowPassword = new CheckBox();
            btnBackToLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(416, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 29);
            label1.TabIndex = 0;
            label1.Text = ":شماره پرسنلی / دانشجویی";
            // 
            // txtStu_Per_Code
            // 
            txtStu_Per_Code.Location = new Point(248, 58);
            txtStu_Per_Code.Margin = new Padding(4, 3, 4, 3);
            txtStu_Per_Code.Name = "txtStu_Per_Code";
            txtStu_Per_Code.Size = new Size(161, 27);
            txtStu_Per_Code.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(416, 111);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 29);
            label2.TabIndex = 2;
            label2.Text = ":کد ملی";
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(248, 113);
            txtNationalCode.Margin = new Padding(4, 3, 4, 3);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(161, 27);
            txtNationalCode.TabIndex = 1;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.AliceBlue;
            btnVerify.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnVerify.ForeColor = Color.MediumBlue;
            btnVerify.Location = new Point(248, 168);
            btnVerify.Margin = new Padding(4, 3, 4, 3);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(161, 34);
            btnVerify.TabIndex = 2;
            btnVerify.Text = "بررسی اطلاعات";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(416, 233);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 29);
            label3.TabIndex = 5;
            label3.Text = ":رمز عبور جدید";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Enabled = false;
            txtNewPassword.Location = new Point(248, 235);
            txtNewPassword.Margin = new Padding(4, 3, 4, 3);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(161, 27);
            txtNewPassword.TabIndex = 3;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(416, 286);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 29);
            label4.TabIndex = 7;
            label4.Text = ":تکرار رمز عبور";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Enabled = false;
            txtConfirmPassword.Location = new Point(248, 288);
            txtConfirmPassword.Margin = new Padding(4, 3, 4, 3);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(161, 27);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.AliceBlue;
            btnSubmit.Enabled = false;
            btnSubmit.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSubmit.ForeColor = Color.MediumBlue;
            btnSubmit.Location = new Point(248, 346);
            btnSubmit.Margin = new Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(161, 34);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "ثبت اطلاعات";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Enabled = false;
            chkShowPassword.Location = new Point(221, 241);
            chkShowPassword.Margin = new Padding(4, 3, 4, 3);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(18, 17);
            chkShowPassword.TabIndex = 4;
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.AliceBlue;
            btnBackToLogin.Font = new Font("B Koodak", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnBackToLogin.ForeColor = Color.MediumBlue;
            btnBackToLogin.Location = new Point(14, 404);
            btnBackToLogin.Margin = new Padding(4, 3, 4, 3);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(122, 34);
            btnBackToLogin.TabIndex = 7;
            btnBackToLogin.Text = "بازگشت به ورود";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // frmForgotPassword
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(752, 450);
            Controls.Add(btnBackToLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(btnSubmit);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label4);
            Controls.Add(txtNewPassword);
            Controls.Add(label3);
            Controls.Add(btnVerify);
            Controls.Add(txtNationalCode);
            Controls.Add(label2);
            Controls.Add(txtStu_Per_Code);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmForgotPassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "فراموشی رمز عبور";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStu_Per_Code;
        private Label label2;
        private TextBox txtNationalCode;
        private Button btnVerify;
        private Label label3;
        private TextBox txtNewPassword;
        private Label label4;
        private TextBox txtConfirmPassword;
        private Button btnSubmit;
        private CheckBox chkShowPassword;
        private Button btnBackToLogin;
    }
}