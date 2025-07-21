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
            mnufrmSetRoomAssets = new ToolStripMenuItem();
            لیستوسایلتخصیصیافتهToolStripMenuItem = new ToolStripMenuItem();
            لیستتعویضلوازمدانشجوToolStripMenuItem = new ToolStripMenuItem();
            ثبتفردجدیدToolStripMenuItem = new ToolStripMenuItem();
            LowMenu = new ToolStripMenuItem();
            مشاهدهلیستدرخواستهایتعمیرToolStripMenuItem = new ToolStripMenuItem();
            mnufrmSetStudentAssets = new ToolStripMenuItem();
            ثبتانتقالوسیلهToolStripMenuItem = new ToolStripMenuItem();
            مشاهدهلیستدروسایلمنToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            HighMenu.DropDownItems.AddRange(new ToolStripItem[] { mnuFrmDormitory, mnuSetDormitory, mnufrmRepairRoomAssetsRequest, mnuFrmRoomAssets, mnuSetManager, mnufrmSetRoomAssets, لیستوسایلتخصیصیافتهToolStripMenuItem, لیستتعویضلوازمدانشجوToolStripMenuItem, ثبتفردجدیدToolStripMenuItem });
            HighMenu.Name = "HighMenu";
            HighMenu.Size = new Size(86, 24);
            HighMenu.Text = "امور اداری";
            // 
            // mnuFrmDormitory
            // 
            mnuFrmDormitory.Name = "mnuFrmDormitory";
            mnuFrmDormitory.Size = new Size(293, 26);
            mnuFrmDormitory.Text = "لیست خوابگاه ها";
            mnuFrmDormitory.Click += mnuFrmDormitory_Click;
            // 
            // mnuSetDormitory
            // 
            mnuSetDormitory.Name = "mnuSetDormitory";
            mnuSetDormitory.Size = new Size(293, 26);
            mnuSetDormitory.Text = "ثبت خوابگاه جدید";
            mnuSetDormitory.Click += mnuSetDormitory_Click;
            // 
            // mnufrmRepairRoomAssetsRequest
            // 
            mnufrmRepairRoomAssetsRequest.Name = "mnufrmRepairRoomAssetsRequest";
            mnufrmRepairRoomAssetsRequest.Size = new Size(293, 26);
            mnufrmRepairRoomAssetsRequest.Text = "لیست همه درخواست های تعمیر";
            mnufrmRepairRoomAssetsRequest.Click += mnufrmRepairRoomAssetsRequest_Click;
            // 
            // mnuFrmRoomAssets
            // 
            mnuFrmRoomAssets.Name = "mnuFrmRoomAssets";
            mnuFrmRoomAssets.Size = new Size(293, 26);
            mnuFrmRoomAssets.Text = "لیست لوازم خوابگاه";
            mnuFrmRoomAssets.Click += mnuFrmRoomAssets_Click;
            // 
            // mnuSetManager
            // 
            mnuSetManager.Name = "mnuSetManager";
            mnuSetManager.Size = new Size(293, 26);
            mnuSetManager.Text = "ثبت نقش مدیر";
            mnuSetManager.Click += mnuSetManager_Click;
            // 
            // mnufrmSetRoomAssets
            // 
            mnufrmSetRoomAssets.Name = "mnufrmSetRoomAssets";
            mnufrmSetRoomAssets.Size = new Size(293, 26);
            mnufrmSetRoomAssets.Text = "ثبت لوازم خوابگاه جدید";
            mnufrmSetRoomAssets.Click += mnufrmSetRoomAssets_Click;
            // 
            // لیستوسایلتخصیصیافتهToolStripMenuItem
            // 
            لیستوسایلتخصیصیافتهToolStripMenuItem.Name = "لیستوسایلتخصیصیافتهToolStripMenuItem";
            لیستوسایلتخصیصیافتهToolStripMenuItem.Size = new Size(293, 26);
            لیستوسایلتخصیصیافتهToolStripMenuItem.Text = "لیست وسایل تخصیص یافته";
            // 
            // لیستتعویضلوازمدانشجوToolStripMenuItem
            // 
            لیستتعویضلوازمدانشجوToolStripMenuItem.Name = "لیستتعویضلوازمدانشجوToolStripMenuItem";
            لیستتعویضلوازمدانشجوToolStripMenuItem.Size = new Size(293, 26);
            لیستتعویضلوازمدانشجوToolStripMenuItem.Text = "لیست تعویض لوازم دانشجو";
            // 
            // ثبتفردجدیدToolStripMenuItem
            // 
            ثبتفردجدیدToolStripMenuItem.Name = "ثبتفردجدیدToolStripMenuItem";
            ثبتفردجدیدToolStripMenuItem.Size = new Size(293, 26);
            ثبتفردجدیدToolStripMenuItem.Text = "ثبت فرد جدید";
            // 
            // LowMenu
            // 
            LowMenu.DropDownItems.AddRange(new ToolStripItem[] { mnufrmSetStudentAssets, مشاهدهلیستدرخواستهایتعمیرToolStripMenuItem, ثبتانتقالوسیلهToolStripMenuItem, مشاهدهلیستدروسایلمنToolStripMenuItem });
            LowMenu.Name = "LowMenu";
            LowMenu.Size = new Size(120, 24);
            LowMenu.Text = "امور دانشجویی";
            // 
            // مشاهدهلیستدرخواستهایتعمیرToolStripMenuItem
            // 
            مشاهدهلیستدرخواستهایتعمیرToolStripMenuItem.Name = "مشاهدهلیستدرخواستهایتعمیرToolStripMenuItem";
            مشاهدهلیستدرخواستهایتعمیرToolStripMenuItem.Size = new Size(345, 26);
            مشاهدهلیستدرخواستهایتعمیرToolStripMenuItem.Text = " مشاهده لیست درخواست های تعمیر من";
            // 
            // mnufrmSetStudentAssets
            // 
            mnufrmSetStudentAssets.Name = "mnufrmSetStudentAssets";
            mnufrmSetStudentAssets.Size = new Size(345, 26);
            mnufrmSetStudentAssets.Text = "ثبت وسیله دانشجویی جدید";
            mnufrmSetStudentAssets.Click += mnufrmSetStudentAssets_Click;
            // 
            // ثبتانتقالوسیلهToolStripMenuItem
            // 
            ثبتانتقالوسیلهToolStripMenuItem.Name = "ثبتانتقالوسیلهToolStripMenuItem";
            ثبتانتقالوسیلهToolStripMenuItem.Size = new Size(345, 26);
            ثبتانتقالوسیلهToolStripMenuItem.Text = "ثبت انتقال وسیله";
            // 
            // مشاهدهلیستدروسایلمنToolStripMenuItem
            // 
            مشاهدهلیستدروسایلمنToolStripMenuItem.Name = "مشاهدهلیستدروسایلمنToolStripMenuItem";
            مشاهدهلیستدروسایلمنToolStripMenuItem.Size = new Size(345, 26);
            مشاهدهلیستدروسایلمنToolStripMenuItem.Text = "مشاهده لیست وسایل من";
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
            lblFullName.Location = new Point(41, 73);
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
            lblLogin.Location = new Point(41, 164);
            lblLogin.Name = "lblLogin";
            lblLogin.RightToLeft = RightToLeft.Yes;
            lblLogin.Size = new Size(59, 34);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "time";
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
            lblTimer.Location = new Point(114, 73);
            lblTimer.Name = "lblTimer";
            lblTimer.RightToLeft = RightToLeft.Yes;
            lblTimer.Size = new Size(59, 34);
            lblTimer.TabIndex = 6;
            lblTimer.Text = "time";
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
            lblDate.Location = new Point(114, 164);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.Yes;
            lblDate.Size = new Size(59, 34);
            lblDate.TabIndex = 8;
            lblDate.Text = "time";
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
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lblTimer);
            groupBox2.Controls.Add(lblDate);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("B Koodak", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            groupBox2.Location = new Point(12, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(299, 242);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "تاریخ و ساعت";
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
        private ToolStripMenuItem مشاهدهلیستدرخواستهایتعمیرToolStripMenuItem;
        private ToolStripMenuItem mnuFrmRoomAssets;
        private ToolStripMenuItem mnuSetDormitory;
        private ToolStripMenuItem mnuSetManager;
        private ToolStripMenuItem mnufrmSetRoomAssets;
        private ToolStripMenuItem لیستوسایلتخصیصیافتهToolStripMenuItem;
        private ToolStripMenuItem لیستتعویضلوازمدانشجوToolStripMenuItem;
        private ToolStripMenuItem ثبتفردجدیدToolStripMenuItem;
        private ToolStripMenuItem mnufrmSetStudentAssets;
        private ToolStripMenuItem ثبتانتقالوسیلهToolStripMenuItem;
        private ToolStripMenuItem مشاهدهلیستدروسایلمنToolStripMenuItem;
    }
}