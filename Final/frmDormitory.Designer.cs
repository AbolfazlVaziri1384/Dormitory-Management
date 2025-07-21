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
            txtSearch.Location = new Point(215, 15);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(440, 16);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 1;
            label1.Text = ":جستجوی خوابگاه";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(536, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 22);
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
            dgvDormitory.Location = new Point(83, 55);
            dgvDormitory.Margin = new Padding(3, 2, 3, 2);
            dgvDormitory.Name = "dgvDormitory";
            dgvDormitory.ReadOnly = true;
            dgvDormitory.RightToLeft = RightToLeft.Yes;
            dgvDormitory.RowHeadersWidth = 51;
            dgvDormitory.Size = new Size(561, 119);
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
            Name.Width = 46;
            // 
            // Capacity
            // 
            Capacity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Capacity.HeaderText = "ظرفیت اصلی";
            Capacity.MinimumWidth = 6;
            Capacity.Name = "Capacity";
            Capacity.ReadOnly = true;
            Capacity.Width = 99;
            // 
            // NowCapacity
            // 
            NowCapacity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NowCapacity.HeaderText = "ظرفیت فعلی";
            NowCapacity.MinimumWidth = 6;
            NowCapacity.Name = "NowCapacity";
            NowCapacity.ReadOnly = true;
            NowCapacity.Width = 97;
            // 
            // Owner
            // 
            Owner.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Owner.HeaderText = "مسئول";
            Owner.MinimumWidth = 6;
            Owner.Name = "Owner";
            Owner.ReadOnly = true;
            Owner.Width = 67;
            // 
            // DormitoryGender
            // 
            DormitoryGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DormitoryGender.HeaderText = "نوع";
            DormitoryGender.MinimumWidth = 6;
            DormitoryGender.Name = "DormitoryGender";
            DormitoryGender.ReadOnly = true;
            DormitoryGender.Width = 49;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Address.HeaderText = "آدرس";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 59;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(612, 205);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // btnStudentPrint
            // 
            btnStudentPrint.BackColor = Color.AliceBlue;
            btnStudentPrint.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnStudentPrint.ForeColor = Color.MediumOrchid;
            btnStudentPrint.Location = new Point(416, 205);
            btnStudentPrint.Margin = new Padding(3, 2, 3, 2);
            btnStudentPrint.Name = "btnStudentPrint";
            btnStudentPrint.Size = new Size(191, 28);
            btnStudentPrint.TabIndex = 11;
            btnStudentPrint.Text = "چاپ تاریخچه اسکان دانشجویان";
            btnStudentPrint.UseVisualStyleBackColor = false;
            btnStudentPrint.Click += btnStudentPrint_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.printer;
            pictureBox3.Location = new Point(612, 246);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.MediumOrchid;
            btnPrint.Location = new Point(416, 246);
            btnPrint.Margin = new Padding(3, 2, 3, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(191, 28);
            btnPrint.TabIndex = 13;
            btnPrint.Text = "چاپ لیست خوابگاه ها";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pen;
            pictureBox4.Location = new Point(179, 205);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.trash;
            pictureBox5.Location = new Point(174, 246);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.AliceBlue;
            btnEdit.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnEdit.ForeColor = Color.Orange;
            btnEdit.Location = new Point(83, 205);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(91, 28);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(83, 246);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 28);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.pl;
            pictureBox6.Location = new Point(351, 205);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 28);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // btnSetDormitory
            // 
            btnSetDormitory.BackColor = Color.AliceBlue;
            btnSetDormitory.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetDormitory.ForeColor = Color.MediumSeaGreen;
            btnSetDormitory.Location = new Point(242, 205);
            btnSetDormitory.Margin = new Padding(3, 2, 3, 2);
            btnSetDormitory.Name = "btnSetDormitory";
            btnSetDormitory.Size = new Size(103, 28);
            btnSetDormitory.TabIndex = 19;
            btnSetDormitory.Text = "ثبت خوابگاه";
            btnSetDormitory.UseVisualStyleBackColor = false;
            btnSetDormitory.Click += btnSetDormitory_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.pl;
            pictureBox7.Location = new Point(351, 246);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(38, 28);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // btnSetBlock
            // 
            btnSetBlock.BackColor = Color.AliceBlue;
            btnSetBlock.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetBlock.ForeColor = Color.MediumSeaGreen;
            btnSetBlock.Location = new Point(242, 246);
            btnSetBlock.Margin = new Padding(3, 2, 3, 2);
            btnSetBlock.Name = "btnSetBlock";
            btnSetBlock.Size = new Size(103, 28);
            btnSetBlock.TabIndex = 21;
            btnSetBlock.Text = "ثبت بلوک";
            btnSetBlock.UseVisualStyleBackColor = false;
            btnSetBlock.Click += btnSetBlock_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.personal;
            pictureBox8.Location = new Point(612, 287);
            pictureBox8.Margin = new Padding(3, 2, 3, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(32, 26);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 22;
            pictureBox8.TabStop = false;
            // 
            // btnAddOwner
            // 
            btnAddOwner.BackColor = Color.AliceBlue;
            btnAddOwner.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnAddOwner.ForeColor = Color.MediumSeaGreen;
            btnAddOwner.Location = new Point(508, 285);
            btnAddOwner.Margin = new Padding(3, 2, 3, 2);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(99, 28);
            btnAddOwner.TabIndex = 23;
            btnAddOwner.Text = "افزودن مسئول";
            btnAddOwner.UseVisualStyleBackColor = false;
            btnAddOwner.Click += btnAddOwner_Click;
            // 
            // btnDeleteOwner
            // 
            btnDeleteOwner.BackColor = Color.AliceBlue;
            btnDeleteOwner.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDeleteOwner.ForeColor = Color.Crimson;
            btnDeleteOwner.Location = new Point(416, 285);
            btnDeleteOwner.Margin = new Padding(3, 2, 3, 2);
            btnDeleteOwner.Name = "btnDeleteOwner";
            btnDeleteOwner.Size = new Size(92, 28);
            btnDeleteOwner.TabIndex = 24;
            btnDeleteOwner.Text = "حذف مسئول";
            btnDeleteOwner.UseVisualStyleBackColor = false;
            btnDeleteOwner.Click += btnDeleteOwner_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.block;
            pictureBox9.Location = new Point(349, 285);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(38, 28);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 25;
            pictureBox9.TabStop = false;
            // 
            // btnShowBlocks
            // 
            btnShowBlocks.BackColor = Color.AliceBlue;
            btnShowBlocks.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnShowBlocks.ForeColor = Color.DeepPink;
            btnShowBlocks.Location = new Point(242, 285);
            btnShowBlocks.Margin = new Padding(3, 2, 3, 2);
            btnShowBlocks.Name = "btnShowBlocks";
            btnShowBlocks.Size = new Size(102, 28);
            btnShowBlocks.TabIndex = 26;
            btnShowBlocks.Text = "نمایش بلوک‌ها";
            btnShowBlocks.UseVisualStyleBackColor = false;
            btnShowBlocks.Click += btnShowBlocks_Click;
            // 
            // btnBackToMain
            // 
            btnBackToMain.BackColor = Color.AliceBlue;
            btnBackToMain.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnBackToMain.ForeColor = Color.MediumBlue;
            btnBackToMain.Location = new Point(10, 304);
            btnBackToMain.Margin = new Padding(3, 2, 3, 2);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(59, 25);
            btnBackToMain.TabIndex = 27;
            btnBackToMain.Text = "بازگشت";
            btnBackToMain.UseVisualStyleBackColor = false;
            btnBackToMain.Click += btnBackToMain_Click;
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
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