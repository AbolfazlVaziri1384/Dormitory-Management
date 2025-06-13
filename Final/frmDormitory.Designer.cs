namespace Final
{
    partial class frmDormitory
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
            txtSearch = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvDormitory = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            NowCapacity = new DataGridViewTextBoxColumn();
            Owner = new DataGridViewTextBoxColumn();
            DormitoryGender = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            pictureBox2 = new PictureBox();
            btnStudentPrint = new Button();
            pictureBox3 = new PictureBox();
            btnPrint = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnEdit = new Button();
            btnDelete = new Button();
            pictureBox6 = new PictureBox();
            btnSetDormitory = new Button();
            pictureBox7 = new PictureBox();
            btnSetBlock = new Button();
            pictureBox8 = new PictureBox();
            btnAddOwner = new Button();
            btnDeleteOwner = new Button();
            pictureBox9 = new PictureBox();
            btnShowBlocks = new Button();
            btnBackToMain = new Button();
            stiDormitoryPrint = new Stimulsoft.Report.StiReport();
            stiStudentPrint = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDormitory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(261, 45);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.RightToLeft = RightToLeft.Yes;
            txtSearch.Size = new Size(222, 39);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(487, 54);
            label1.Name = "label1";
            label1.Size = new Size(117, 29);
            label1.TabIndex = 1;
            label1.Text = ":جستجوی خوابگاه";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(596, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dgvDormitory
            // 
            dgvDormitory.AllowUserToAddRows = false;
            dgvDormitory.AllowUserToDeleteRows = false;
            dgvDormitory.BackgroundColor = Color.AliceBlue;
            dgvDormitory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDormitory.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Capacity, NowCapacity, Owner, DormitoryGender, Address });
            dgvDormitory.Location = new Point(95, 113);
            dgvDormitory.Name = "dgvDormitory";
            dgvDormitory.ReadOnly = true;
            dgvDormitory.RightToLeft = RightToLeft.Yes;
            dgvDormitory.RowHeadersWidth = 51;
            dgvDormitory.Size = new Size(641, 119);
            dgvDormitory.TabIndex = 3;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Name.HeaderText = "نام";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 56;
            // 
            // Capacity
            // 
            Capacity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Capacity.HeaderText = "ظرفیت اصلی";
            Capacity.MinimumWidth = 6;
            Capacity.Name = "Capacity";
            Capacity.ReadOnly = true;
            Capacity.Width = 124;
            // 
            // NowCapacity
            // 
            NowCapacity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NowCapacity.HeaderText = "ظرفیت فعلی";
            NowCapacity.MinimumWidth = 6;
            NowCapacity.Name = "NowCapacity";
            NowCapacity.ReadOnly = true;
            NowCapacity.Width = 122;
            // 
            // Owner
            // 
            Owner.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Owner.HeaderText = "مسئول";
            Owner.MinimumWidth = 6;
            Owner.Name = "Owner";
            Owner.ReadOnly = true;
            Owner.Width = 83;
            // 
            // DormitoryGender
            // 
            DormitoryGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DormitoryGender.HeaderText = "نوع";
            DormitoryGender.MinimumWidth = 6;
            DormitoryGender.Name = "DormitoryGender";
            DormitoryGender.ReadOnly = true;
            DormitoryGender.Width = 60;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Address.HeaderText = "آدرس";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 73;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(700, 273);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // btnStudentPrint
            // 
            btnStudentPrint.BackColor = Color.AliceBlue;
            btnStudentPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnStudentPrint.ForeColor = Color.MediumOrchid;
            btnStudentPrint.Location = new Point(476, 273);
            btnStudentPrint.Name = "btnStudentPrint";
            btnStudentPrint.Size = new Size(218, 38);
            btnStudentPrint.TabIndex = 11;
            btnStudentPrint.Text = "چاپ تاریخچه اسکان دانشجویان";
            btnStudentPrint.UseVisualStyleBackColor = false;
            btnStudentPrint.Click += btnStudentPrint_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.printer;
            pictureBox3.Location = new Point(700, 328);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.MediumOrchid;
            btnPrint.Location = new Point(476, 328);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(218, 38);
            btnPrint.TabIndex = 13;
            btnPrint.Text = "چاپ لیست خوابگاه ها";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pen;
            pictureBox4.Location = new Point(205, 273);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.trash;
            pictureBox5.Location = new Point(199, 328);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.AliceBlue;
            btnEdit.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnEdit.ForeColor = Color.Orange;
            btnEdit.Location = new Point(95, 273);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(104, 38);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(95, 328);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 38);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.pl;
            pictureBox6.Location = new Point(401, 273);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // btnSetDormitory
            // 
            btnSetDormitory.BackColor = Color.AliceBlue;
            btnSetDormitory.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetDormitory.ForeColor = Color.MediumSeaGreen;
            btnSetDormitory.Location = new Point(277, 273);
            btnSetDormitory.Name = "btnSetDormitory";
            btnSetDormitory.Size = new Size(118, 38);
            btnSetDormitory.TabIndex = 19;
            btnSetDormitory.Text = "ثبت خوابگاه";
            btnSetDormitory.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.pl;
            pictureBox7.Location = new Point(401, 328);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(43, 38);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // btnSetBlock
            // 
            btnSetBlock.BackColor = Color.AliceBlue;
            btnSetBlock.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetBlock.ForeColor = Color.MediumSeaGreen;
            btnSetBlock.Location = new Point(277, 328);
            btnSetBlock.Name = "btnSetBlock";
            btnSetBlock.Size = new Size(118, 38);
            btnSetBlock.TabIndex = 21;
            btnSetBlock.Text = "ثبت بلوک";
            btnSetBlock.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.personal;
            pictureBox8.Location = new Point(700, 383);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 35);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 22;
            pictureBox8.TabStop = false;
            // 
            // btnAddOwner
            // 
            btnAddOwner.BackColor = Color.AliceBlue;
            btnAddOwner.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnAddOwner.ForeColor = Color.MediumSeaGreen;
            btnAddOwner.Location = new Point(581, 380);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(113, 38);
            btnAddOwner.TabIndex = 23;
            btnAddOwner.Text = "افزودن مسئول";
            btnAddOwner.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOwner
            // 
            btnDeleteOwner.BackColor = Color.AliceBlue;
            btnDeleteOwner.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDeleteOwner.ForeColor = Color.Crimson;
            btnDeleteOwner.Location = new Point(476, 380);
            btnDeleteOwner.Name = "btnDeleteOwner";
            btnDeleteOwner.Size = new Size(105, 38);
            btnDeleteOwner.TabIndex = 24;
            btnDeleteOwner.Text = "حذف مسئول";
            btnDeleteOwner.UseVisualStyleBackColor = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.block;
            pictureBox9.Location = new Point(399, 380);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(43, 38);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 25;
            pictureBox9.TabStop = false;
            // 
            // btnShowBlocks
            // 
            btnShowBlocks.BackColor = Color.AliceBlue;
            btnShowBlocks.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnShowBlocks.ForeColor = Color.DeepPink;
            btnShowBlocks.Location = new Point(277, 380);
            btnShowBlocks.Name = "btnShowBlocks";
            btnShowBlocks.Size = new Size(116, 38);
            btnShowBlocks.TabIndex = 26;
            btnShowBlocks.Text = "نمایش بلوک‌ها";
            btnShowBlocks.UseVisualStyleBackColor = false;
            // 
            // btnBackToMain
            // 
            btnBackToMain.BackColor = Color.AliceBlue;
            btnBackToMain.Font = new Font("B Koodak", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnBackToMain.ForeColor = Color.MediumBlue;
            btnBackToMain.Location = new Point(12, 405);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(67, 33);
            btnBackToMain.TabIndex = 27;
            btnBackToMain.Text = "بازگشت";
            btnBackToMain.UseVisualStyleBackColor = false;
            // 
            // stiDormitoryPrint
            // 
            stiDormitoryPrint.CookieContainer = null;
            stiDormitoryPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            stiDormitoryPrint.HttpHeadersContainer = null;
            stiDormitoryPrint.Key = "b653ab34b6fe4395b2ec11c0b293c3de";
            stiDormitoryPrint.ReferencedAssemblies = new string[]
    {
    "System.Dll",
    "System.Drawing.Dll",
    "System.Windows.Forms.Dll",
    "System.Data.Dll",
    "System.Xml.Dll",
    "Stimulsoft.Controls.Dll",
    "Stimulsoft.Base.Dll",
    "Stimulsoft.Report.Dll"
    };
            stiDormitoryPrint.ReportAlias = "Report";
            stiDormitoryPrint.ReportGuid = "348918718e244e72ac5f0a685fda8741";
            stiDormitoryPrint.ReportName = "Report";
            stiDormitoryPrint.ReportSource = null;
            stiDormitoryPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            stiDormitoryPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            stiDormitoryPrint.UseProgressInThread = false;
            // 
            // stiStudentPrint
            // 
            stiStudentPrint.CookieContainer = null;
            stiStudentPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            stiStudentPrint.HttpHeadersContainer = null;
            stiStudentPrint.Key = "a5804cfe5375482e81e19259660a4733";
            stiStudentPrint.ReferencedAssemblies = new string[]
    {
    "System.Dll",
    "System.Drawing.Dll",
    "System.Windows.Forms.Dll",
    "System.Data.Dll",
    "System.Xml.Dll",
    "Stimulsoft.Controls.Dll",
    "Stimulsoft.Base.Dll",
    "Stimulsoft.Report.Dll"
    };
            stiStudentPrint.ReportAlias = "Report";
            stiStudentPrint.ReportGuid = "b59ce40466a5457facc308c9f8b078c6";
            stiStudentPrint.ReportName = "Report";
            stiStudentPrint.ReportSource = null;
            stiStudentPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            stiStudentPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            stiStudentPrint.UseProgressInThread = false;
            // 
            // frmDormitory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackToMain);
            Controls.Add(btnShowBlocks);
            Controls.Add(pictureBox9);
            Controls.Add(btnDeleteOwner);
            Controls.Add(btnAddOwner);
            Controls.Add(pictureBox8);
            Controls.Add(btnSetBlock);
            Controls.Add(pictureBox7);
            Controls.Add(btnSetDormitory);
            Controls.Add(pictureBox6);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(btnPrint);
            Controls.Add(pictureBox3);
            Controls.Add(btnStudentPrint);
            Controls.Add(pictureBox2);
            Controls.Add(dgvDormitory);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            //Name = "frmDormitory";
            Text = "خوابگاه ها";
            Load += frmDormitory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDormitory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvDormitory;
        private PictureBox pictureBox2;
        private Button btnStudentPrint;
        private PictureBox pictureBox3;
        private Button btnPrint;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button btnEdit;
        private Button btnDelete;
        private PictureBox pictureBox6;
        private Button btnSetDormitory;
        private PictureBox pictureBox7;
        private Button btnSetBlock;
        private PictureBox pictureBox8;
        private Button btnAddOwner;
        private Button btnDeleteOwner;
        private PictureBox pictureBox9;
        private Button btnShowBlocks;
        private Button btnBackToMain;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn NowCapacity;
        private DataGridViewTextBoxColumn Owner;
        private DataGridViewTextBoxColumn DormitoryGender;
        private DataGridViewTextBoxColumn Address;
        private Stimulsoft.Report.StiReport stiDormitoryPrint;
        private Stimulsoft.Report.StiReport stiStudentPrint;
    }
}