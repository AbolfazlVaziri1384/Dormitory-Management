namespace Final
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            HighMenu = new ToolStripMenuItem();
            mnuFrmDormitory = new ToolStripMenuItem();
            mnuSetDormitory = new ToolStripMenuItem();
            mnufrmRepairRoomAssetsRequest = new ToolStripMenuItem();
            mnuFrmRoomAssets = new ToolStripMenuItem();
            mnuSetManager = new ToolStripMenuItem();
            frmSetUser = new ToolStripMenuItem();
            mnufrmSetRoomAssets = new ToolStripMenuItem();
            mnufrmSubstituteStudentAssets = new ToolStripMenuItem();
            mnuFrmUser = new ToolStripMenuItem();
            mnuFrmEditUser = new ToolStripMenuItem();
            mnuFrmManagers = new ToolStripMenuItem();
            mnufrmDormitoryOwner = new ToolStripMenuItem();
            mnufrmBlockOwner = new ToolStripMenuItem();
            LowMenu = new ToolStripMenuItem();
            mnufrmSetStudentAssets = new ToolStripMenuItem();
            mnufrmStudentAssets = new ToolStripMenuItem();
            mnuFrmSetUser = new ToolStripMenuItem();
            AboutMenu = new ToolStripMenuItem();
            ExitMenu = new ToolStripMenuItem();
            label1 = new Label();
            lblFullName = new Label();
            lblLogin = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            label4 = new Label();
            lblDate = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { HighMenu, LowMenu, AboutMenu, ExitMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(643, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // HighMenu
            // 
            HighMenu.DropDownItems.AddRange(new ToolStripItem[] { mnuFrmUser, mnuFrmManagers, mnufrmDormitoryOwner, mnufrmBlockOwner, mnuFrmDormitory, mnuFrmRoomAssets, mnufrmRepairRoomAssetsRequest, mnufrmSubstituteStudentAssets, frmSetUser, mnuSetManager, mnuSetDormitory, mnufrmSetRoomAssets, mnuFrmEditUser });
            HighMenu.Name = "HighMenu";
            HighMenu.Size = new Size(86, 24);
            HighMenu.Text = "امور اداری";
            // 
            // mnuFrmDormitory
            // 
            mnuFrmDormitory.Name = "mnuFrmDormitory";
            mnuFrmDormitory.Size = new Size(306, 26);
            mnuFrmDormitory.Text = "لیست خوابگاه ها";
            mnuFrmDormitory.Click += mnuFrmDormitory_Click;
            // 
            // mnuSetDormitory
            // 
            mnuSetDormitory.Name = "mnuSetDormitory";
            mnuSetDormitory.Size = new Size(306, 26);
            mnuSetDormitory.Text = "ثبت خوابگاه جدید";
            mnuSetDormitory.Click += mnuSetDormitory_Click;
            // 
            // mnufrmRepairRoomAssetsRequest
            // 
            mnufrmRepairRoomAssetsRequest.Name = "mnufrmRepairRoomAssetsRequest";
            mnufrmRepairRoomAssetsRequest.Size = new Size(306, 26);
            mnufrmRepairRoomAssetsRequest.Text = "لیست همه درخواست های تعمیر";
            mnufrmRepairRoomAssetsRequest.Click += mnufrmRepairRoomAssetsRequest_Click;
            // 
            // mnuFrmRoomAssets
            // 
            mnuFrmRoomAssets.Name = "mnuFrmRoomAssets";
            mnuFrmRoomAssets.Size = new Size(306, 26);
            mnuFrmRoomAssets.Text = "لیست لوازم خوابگاه";
            mnuFrmRoomAssets.Click += mnuFrmRoomAssets_Click;
            // 
            // mnuSetManager
            // 
            mnuSetManager.Name = "mnuSetManager";
            mnuSetManager.Size = new Size(306, 26);
            mnuSetManager.Text = "ثبت نقش مدیر";
            mnuSetManager.Click += mnuSetManager_Click;
            // 
            // frmSetUser
            // 
            frmSetUser.Name = "frmSetUser";
            frmSetUser.Size = new Size(306, 26);
            frmSetUser.Text = "ثبت کاربر جدید";
            frmSetUser.Click += frmSetUser_Click;
            // 
            // mnufrmSetRoomAssets
            // 
            mnufrmSetRoomAssets.Name = "mnufrmSetRoomAssets";
            mnufrmSetRoomAssets.Size = new Size(306, 26);
            mnufrmSetRoomAssets.Text = "ثبت لوازم خوابگاه جدید";
            mnufrmSetRoomAssets.Click += mnufrmSetRoomAssets_Click;
            // 
            // mnufrmSubstituteStudentAssets
            // 
            mnufrmSubstituteStudentAssets.Name = "mnufrmSubstituteStudentAssets";
            mnufrmSubstituteStudentAssets.Size = new Size(306, 26);
            mnufrmSubstituteStudentAssets.Text = "تاریخچه تعویض وسایل دانشجویان";
            mnufrmSubstituteStudentAssets.Click += mnufrmSubstituteStudentAssets_Click;
            // 
            // mnuFrmUser
            // 
            mnuFrmUser.Name = "mnuFrmUser";
            mnuFrmUser.Size = new Size(306, 26);
            mnuFrmUser.Text = "لیست کاربران";
            mnuFrmUser.Click += mnuFrmUser_Click;
            // 
            // mnuFrmEditUser
            // 
            mnuFrmEditUser.Name = "mnuFrmEditUser";
            mnuFrmEditUser.Size = new Size(306, 26);
            mnuFrmEditUser.Text = "ویرایش اطلاعات شخصی";
            mnuFrmEditUser.Click += mnuFrmEditUser_Click;
            // 
            // mnuFrmManagers
            // 
            mnuFrmManagers.Name = "mnuFrmManagers";
            mnuFrmManagers.Size = new Size(306, 26);
            mnuFrmManagers.Text = "لیست مدیران";
            mnuFrmManagers.Click += mnuFrmManagers_Click;
            // 
            // mnufrmDormitoryOwner
            // 
            mnufrmDormitoryOwner.Name = "mnufrmDormitoryOwner";
            mnufrmDormitoryOwner.Size = new Size(306, 26);
            mnufrmDormitoryOwner.Text = "لیست مسئولان خوابگاه";
            mnufrmDormitoryOwner.Click += mnufrmDormitoryOwner_Click;
            // 
            // mnufrmBlockOwner
            // 
            mnufrmBlockOwner.Name = "mnufrmBlockOwner";
            mnufrmBlockOwner.Size = new Size(306, 26);
            mnufrmBlockOwner.Text = "لیست مسئولان بلوک";
            mnufrmBlockOwner.Click += mnufrmBlockOwner_Click;
            // 
            // LowMenu
            // 
            LowMenu.DropDownItems.AddRange(new ToolStripItem[] { mnufrmSetStudentAssets, mnufrmStudentAssets, mnuFrmSetUser });
            LowMenu.Name = "LowMenu";
            LowMenu.Size = new Size(120, 24);
            LowMenu.Text = "امور دانشجویی";
            // 
            // mnufrmSetStudentAssets
            // 
            mnufrmSetStudentAssets.Name = "mnufrmSetStudentAssets";
            mnufrmSetStudentAssets.Size = new Size(263, 26);
            mnufrmSetStudentAssets.Text = "ثبت وسیله دانشجویی جدید";
            mnufrmSetStudentAssets.Click += mnufrmSetStudentAssets_Click;
            // 
            // mnufrmStudentAssets
            // 
            mnufrmStudentAssets.Name = "mnufrmStudentAssets";
            mnufrmStudentAssets.Size = new Size(263, 26);
            mnufrmStudentAssets.Text = "لیست وسایل من";
            mnufrmStudentAssets.Click += mnufrmStudentAssets_Click;
            // 
            // mnuFrmSetUser
            // 
            mnuFrmSetUser.Name = "mnuFrmSetUser";
            mnuFrmSetUser.Size = new Size(263, 26);
            mnuFrmSetUser.Text = "ویرایش اطلاعات شخصی";
            mnuFrmSetUser.Click += mnuFrmSetUser_Click;
            // 
            // AboutMenu
            // 
            AboutMenu.Name = "AboutMenu";
            AboutMenu.Size = new Size(59, 24);
            AboutMenu.Text = "درباره";
            AboutMenu.Click += AboutMenu_Click;
            // 
            // ExitMenu
            // 
            ExitMenu.Name = "ExitMenu";
            ExitMenu.Size = new Size(55, 24);
            ExitMenu.Text = "خروج";
            ExitMenu.Click += ExitMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(234, 38);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(59, 34);
            label1.TabIndex = 1;
            label1.Text = "مالک :";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("B Koodak", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblFullName.Location = new Point(54, 69);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(108, 34);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "full name";
            lblFullName.Click += lblFullName_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("B Koodak", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblLogin.Location = new Point(72, 179);
            lblLogin.Name = "lblLogin";
            lblLogin.RightToLeft = RightToLeft.Yes;
            lblLogin.Size = new Size(59, 34);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "time";
            lblLogin.Click += lblLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Koodak", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.Location = new Point(179, 122);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(114, 34);
            label3.TabIndex = 3;
            label3.Text = "آخرین بازدید :";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("B Koodak", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblTimer.Location = new Point(102, 71);
            lblTimer.Name = "lblTimer";
            lblTimer.RightToLeft = RightToLeft.Yes;
            lblTimer.Size = new Size(59, 34);
            lblTimer.TabIndex = 6;
            lblTimer.Text = "time";
            lblTimer.Click += lblTimer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("B Koodak", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.Location = new Point(229, 38);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(64, 34);
            label4.TabIndex = 5;
            label4.Text = "ساعت :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("B Koodak", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblDate.Location = new Point(95, 179);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.Yes;
            lblDate.Size = new Size(59, 34);
            lblDate.TabIndex = 8;
            lblDate.Text = "time";
            lblDate.Click += lblDate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("B Koodak", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label5.Location = new Point(194, 122);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(99, 34);
            label5.TabIndex = 7;
            label5.Text = "تاریخ امروز :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblFullName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblLogin);
            groupBox1.Font = new Font("B Koodak", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            groupBox1.Location = new Point(317, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(299, 242);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات پنل کاربری";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lblDate);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(lblTimer);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Font = new Font("B Koodak", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            groupBox2.Location = new Point(12, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(299, 242);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "تاریخ و ساعت";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.calendar1;
            pictureBox2.Location = new Point(28, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.digital_clock;
            pictureBox1.Location = new Point(28, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 362);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("B Koodak", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صفحه اصلی";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem HighMenu;
        private ToolStripMenuItem LowMenu;
        private ToolStripMenuItem AboutMenu;
        private ToolStripMenuItem ExitMenu;
        private Label label1;
        private Label lblFullName;
        private Label lblLogin;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
        private Label label4;
        private Label lblDate;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStripMenuItem mnuFrmDormitory;
        private ToolStripMenuItem mnufrmRepairRoomAssetsRequest;
        private ToolStripMenuItem mnuFrmRoomAssets;
        private ToolStripMenuItem mnuSetDormitory;
        private ToolStripMenuItem mnuSetManager;
        private ToolStripMenuItem mnufrmSetRoomAssets;
        private ToolStripMenuItem mnufrmSubstituteStudentAssets;
        private ToolStripMenuItem frmSetUser;
        private ToolStripMenuItem mnufrmSetStudentAssets;
        private ToolStripMenuItem mnufrmStudentAssets;
        private ToolStripMenuItem mnuFrmUser;
        private ToolStripMenuItem mnuFrmSetUser;
        private ToolStripMenuItem mnuFrmEditUser;
        private ToolStripMenuItem mnuFrmManagers;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolStripMenuItem mnufrmDormitoryOwner;
        private ToolStripMenuItem mnufrmBlockOwner;
    }
}