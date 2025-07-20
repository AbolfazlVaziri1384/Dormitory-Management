namespace Final
{
    partial class frmRepairRoomAssetsRequest
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
            pictureBox6 = new PictureBox();
            btnRepair = new Button();
            btnPrint = new Button();
            pictureBox2 = new PictureBox();
            btnDelete = new Button();
            pictureBox5 = new PictureBox();
            dgvRequsts = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Guid = new DataGridViewTextBoxColumn();
            PartNumber = new DataGridViewTextBoxColumn();
            AssetNumber = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Discription = new DataGridViewTextBoxColumn();
            RequestDate = new DataGridViewTextBoxColumn();
            IsRepair = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            stiRepairPrint = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequsts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.pl;
            pictureBox6.Location = new Point(1066, 268);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // btnRepair
            // 
            btnRepair.BackColor = Color.AliceBlue;
            btnRepair.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnRepair.ForeColor = Color.MediumSeaGreen;
            btnRepair.Location = new Point(888, 268);
            btnRepair.Name = "btnRepair";
            btnRepair.Size = new Size(178, 38);
            btnRepair.TabIndex = 30;
            btnRepair.Text = "تغییر وضعیت درخواست";
            btnRepair.UseVisualStyleBackColor = false;
            btnRepair.Click += btnRepair_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.DarkOrchid;
            btnPrint.Location = new Point(179, 268);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(141, 38);
            btnPrint.TabIndex = 33;
            btnPrint.Text = "چاپ";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(320, 268);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(549, 268);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 38);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "حذف درخواست";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.trash;
            pictureBox5.Location = new Point(696, 268);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // dgvRequsts
            // 
            dgvRequsts.AllowUserToAddRows = false;
            dgvRequsts.AllowUserToDeleteRows = false;
            dgvRequsts.BackgroundColor = Color.AliceBlue;
            dgvRequsts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequsts.Columns.AddRange(new DataGridViewColumn[] { Id, Guid, PartNumber, AssetNumber, Status, Discription, RequestDate, IsRepair, FullName });
            dgvRequsts.Location = new Point(12, 72);
            dgvRequsts.Name = "dgvRequsts";
            dgvRequsts.ReadOnly = true;
            dgvRequsts.RightToLeft = RightToLeft.Yes;
            dgvRequsts.RowHeadersWidth = 51;
            dgvRequsts.Size = new Size(1174, 155);
            dgvRequsts.TabIndex = 36;
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
            // Guid
            // 
            Guid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Guid.HeaderText = "شماره پیگیری";
            Guid.MinimumWidth = 6;
            Guid.Name = "Guid";
            Guid.ReadOnly = true;
            Guid.Width = 110;
            // 
            // PartNumber
            // 
            PartNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartNumber.HeaderText = "پارت نامبر دستگاه";
            PartNumber.MinimumWidth = 6;
            PartNumber.Name = "PartNumber";
            PartNumber.ReadOnly = true;
            PartNumber.Width = 137;
            // 
            // AssetNumber
            // 
            AssetNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AssetNumber.HeaderText = "شماره سریال دستگاه";
            AssetNumber.MinimumWidth = 6;
            AssetNumber.Name = "AssetNumber";
            AssetNumber.ReadOnly = true;
            AssetNumber.Width = 154;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.HeaderText = "وضعیت";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 89;
            // 
            // Discription
            // 
            Discription.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Discription.HeaderText = "توضیحات";
            Discription.MinimumWidth = 6;
            Discription.Name = "Discription";
            Discription.ReadOnly = true;
            Discription.Width = 98;
            // 
            // RequestDate
            // 
            RequestDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RequestDate.HeaderText = "تاریخ درخواست";
            RequestDate.MinimumWidth = 6;
            RequestDate.Name = "RequestDate";
            RequestDate.ReadOnly = true;
            RequestDate.Width = 123;
            // 
            // IsRepair
            // 
            IsRepair.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IsRepair.HeaderText = "وضعیت تعمیر";
            IsRepair.MinimumWidth = 6;
            IsRepair.Name = "IsRepair";
            IsRepair.ReadOnly = true;
            IsRepair.Width = 117;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FullName.HeaderText = "نام درخواست دهنده";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 151;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(450, 12);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(253, 34);
            txtSearch.TabIndex = 39;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(825, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(700, 13);
            label1.Name = "label1";
            label1.Size = new Size(132, 29);
            label1.TabIndex = 37;
            label1.Text = ":جستجوی درخواست";
            // 
            // stiRepairPrint
            // 
            stiRepairPrint.CookieContainer = null;
            stiRepairPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            stiRepairPrint.HttpHeadersContainer = null;
            stiRepairPrint.Key = "36dfd10d117a4405b7eb754760c57a7e";
            stiRepairPrint.ReferencedAssemblies = new string[]
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
            stiRepairPrint.ReportAlias = "Report";
            stiRepairPrint.ReportGuid = "fa5cca2df00e4d0cbfd5a3a3f406b5a9";
            stiRepairPrint.ReportName = "Report";
            stiRepairPrint.ReportSource = null;
            stiRepairPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            stiRepairPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            stiRepairPrint.UseProgressInThread = false;
            // 
            // frmRepairRoomAssetsRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 357);
            Controls.Add(txtSearch);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dgvRequsts);
            Controls.Add(btnDelete);
            Controls.Add(pictureBox5);
            Controls.Add(btnPrint);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox6);
            Controls.Add(btnRepair);
            MinimizeBox = false;
            Name = "frmRepairRoomAssetsRequest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "درخواست تعمیر";
            Load += frmRepairRoomAssetsRequest_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequsts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox6;
        private Button btnRepair;
        private Button btnPrint;
        private PictureBox pictureBox2;
        private Button btnDelete;
        private PictureBox pictureBox5;
        private DataGridView dgvRequsts;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Guid;
        private DataGridViewTextBoxColumn PartNumber;
        private DataGridViewTextBoxColumn AssetNumber;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Discription;
        private DataGridViewTextBoxColumn RequestDate;
        private DataGridViewTextBoxColumn IsRepair;
        private DataGridViewTextBoxColumn FullName;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private Label label1;
        private Stimulsoft.Report.StiReport stiRepairPrint;
    }
}