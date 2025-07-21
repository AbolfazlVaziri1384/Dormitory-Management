namespace Final
{
    partial class frmStudentAssets
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
            dgvStudentAssets = new DataGridView();
            pictureBox4 = new PictureBox();
            btnDelete = new Button();
            pictureBox2 = new PictureBox();
            btnPrint = new Button();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnSetStudentAsset = new Button();
            pictureBox7 = new PictureBox();
            btnSetTransfer = new Button();
            btnRepairRoomAsset = new Button();
            groupBox1 = new GroupBox();
            dgvRoomAssets = new DataGridView();
            groupBox2 = new GroupBox();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Guid = new DataGridViewTextBoxColumn();
            OwnerName = new DataGridViewTextBoxColumn();
            TransferDate = new DataGridViewTextBoxColumn();
            Discription = new DataGridViewTextBoxColumn();
            Id2 = new DataGridViewTextBoxColumn();
            PartNumber = new DataGridViewTextBoxColumn();
            AssetNumber = new DataGridViewTextBoxColumn();
            CreateOn = new DataGridViewTextBoxColumn();
            CreateBy = new DataGridViewTextBoxColumn();
            stiAssetPrint = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)dgvStudentAssets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomAssets).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudentAssets
            // 
            dgvStudentAssets.AllowUserToAddRows = false;
            dgvStudentAssets.AllowUserToDeleteRows = false;
            dgvStudentAssets.BackgroundColor = Color.AliceBlue;
            dgvStudentAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentAssets.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Guid, OwnerName, TransferDate, Discription });
            dgvStudentAssets.Location = new Point(11, 36);
            dgvStudentAssets.Name = "dgvStudentAssets";
            dgvStudentAssets.ReadOnly = true;
            dgvStudentAssets.RightToLeft = RightToLeft.Yes;
            dgvStudentAssets.RowHeadersWidth = 51;
            dgvStudentAssets.Size = new Size(612, 148);
            dgvStudentAssets.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.trash;
            pictureBox4.Location = new Point(261, 484);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(106, 488);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 40);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(260, 428);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.MediumOrchid;
            btnPrint.Location = new Point(106, 428);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(149, 40);
            btnPrint.TabIndex = 18;
            btnPrint.Text = "چاپ لیست";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.wrench;
            pictureBox5.Location = new Point(506, 547);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.devices;
            pictureBox6.Location = new Point(506, 426);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(59, 42);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // btnSetStudentAsset
            // 
            btnSetStudentAsset.BackColor = Color.AliceBlue;
            btnSetStudentAsset.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetStudentAsset.ForeColor = Color.ForestGreen;
            btnSetStudentAsset.Location = new Point(351, 428);
            btnSetStudentAsset.Name = "btnSetStudentAsset";
            btnSetStudentAsset.Size = new Size(149, 40);
            btnSetStudentAsset.TabIndex = 22;
            btnSetStudentAsset.Text = "ثبت لوازم جدید";
            btnSetStudentAsset.UseVisualStyleBackColor = false;
            btnSetStudentAsset.Click += btnSetStudentAsset_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.room;
            pictureBox7.Location = new Point(506, 481);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(59, 46);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // btnSetTransfer
            // 
            btnSetTransfer.BackColor = Color.AliceBlue;
            btnSetTransfer.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetTransfer.ForeColor = Color.SaddleBrown;
            btnSetTransfer.Location = new Point(351, 487);
            btnSetTransfer.Name = "btnSetTransfer";
            btnSetTransfer.Size = new Size(149, 40);
            btnSetTransfer.TabIndex = 24;
            btnSetTransfer.Text = "انتقال مالکیت";
            btnSetTransfer.UseVisualStyleBackColor = false;
            btnSetTransfer.Click += btnSetTransfer_Click;
            // 
            // btnRepairRoomAsset
            // 
            btnRepairRoomAsset.BackColor = Color.AliceBlue;
            btnRepairRoomAsset.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnRepairRoomAsset.ForeColor = Color.Orange;
            btnRepairRoomAsset.Location = new Point(351, 547);
            btnRepairRoomAsset.Name = "btnRepairRoomAsset";
            btnRepairRoomAsset.Size = new Size(149, 40);
            btnRepairRoomAsset.TabIndex = 25;
            btnRepairRoomAsset.Text = "درخواست تعمیر";
            btnRepairRoomAsset.UseVisualStyleBackColor = false;
            btnRepairRoomAsset.Click += btnRepairRoomAsset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvRoomAssets);
            groupBox1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(89, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(556, 193);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "لوازم خوابگاه";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgvRoomAssets
            // 
            dgvRoomAssets.AllowUserToAddRows = false;
            dgvRoomAssets.AllowUserToDeleteRows = false;
            dgvRoomAssets.BackgroundColor = Color.AliceBlue;
            dgvRoomAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomAssets.Columns.AddRange(new DataGridViewColumn[] { Id2, PartNumber, AssetNumber, CreateOn, CreateBy });
            dgvRoomAssets.Location = new Point(17, 36);
            dgvRoomAssets.Name = "dgvRoomAssets";
            dgvRoomAssets.ReadOnly = true;
            dgvRoomAssets.RightToLeft = RightToLeft.Yes;
            dgvRoomAssets.RowHeadersWidth = 51;
            dgvRoomAssets.Size = new Size(525, 137);
            dgvRoomAssets.TabIndex = 28;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvStudentAssets);
            groupBox2.Font = new Font("B Koodak", 10.2F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(633, 190);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "لوازم شخصی";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 60;
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
            // Guid
            // 
            Guid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Guid.HeaderText = "شماره سریال";
            Guid.MinimumWidth = 6;
            Guid.Name = "Guid";
            Guid.ReadOnly = true;
            Guid.Width = 114;
            // 
            // OwnerName
            // 
            OwnerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OwnerName.HeaderText = "نام مالک";
            OwnerName.MinimumWidth = 6;
            OwnerName.Name = "OwnerName";
            OwnerName.ReadOnly = true;
            OwnerName.Width = 90;
            // 
            // TransferDate
            // 
            TransferDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TransferDate.HeaderText = "تاریخ انتقال";
            TransferDate.MinimumWidth = 6;
            TransferDate.Name = "TransferDate";
            TransferDate.ReadOnly = true;
            TransferDate.Width = 106;
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
            // Id2
            // 
            Id2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id2.HeaderText = "Id";
            Id2.MinimumWidth = 6;
            Id2.Name = "Id2";
            Id2.ReadOnly = true;
            Id2.Visible = false;
            Id2.Width = 60;
            // 
            // PartNumber
            // 
            PartNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartNumber.HeaderText = "پارت نامبر";
            PartNumber.MinimumWidth = 6;
            PartNumber.Name = "PartNumber";
            PartNumber.ReadOnly = true;
            PartNumber.Width = 102;
            // 
            // AssetNumber
            // 
            AssetNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AssetNumber.HeaderText = "شماره سریال";
            AssetNumber.MinimumWidth = 6;
            AssetNumber.Name = "AssetNumber";
            AssetNumber.ReadOnly = true;
            AssetNumber.Width = 114;
            // 
            // CreateOn
            // 
            CreateOn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CreateOn.HeaderText = "تاریخ ثبت";
            CreateOn.MinimumWidth = 6;
            CreateOn.Name = "CreateOn";
            CreateOn.ReadOnly = true;
            CreateOn.Width = 99;
            // 
            // CreateBy
            // 
            CreateBy.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CreateBy.HeaderText = "ثبت کننده";
            CreateBy.MinimumWidth = 6;
            CreateBy.Name = "CreateBy";
            CreateBy.ReadOnly = true;
            CreateBy.Width = 101;
            // 
            // stiAssetPrint
            // 
            stiAssetPrint.CookieContainer = null;
            stiAssetPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            stiAssetPrint.HttpHeadersContainer = null;
            stiAssetPrint.Key = "1b458a6878634c579acea89e3f9e83a2";
            stiAssetPrint.ReferencedAssemblies = new string[]
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
            stiAssetPrint.ReportAlias = "Report";
            stiAssetPrint.ReportGuid = "ec33c81a9e194519a92391b23c23a9a9";
            stiAssetPrint.ReportName = "Report";
            stiAssetPrint.ReportSource = null;
            stiAssetPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            stiAssetPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            stiAssetPrint.UseProgressInThread = false;
            // 
            // frmStudentAssets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 618);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnRepairRoomAsset);
            Controls.Add(btnSetTransfer);
            Controls.Add(pictureBox7);
            Controls.Add(btnSetStudentAsset);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(btnPrint);
            Controls.Add(pictureBox4);
            Controls.Add(btnDelete);
            MaximizeBox = false;
            Name = "frmStudentAssets";
            StartPosition = FormStartPosition.CenterParent;
            Text = "لوازم دانشجو";
            Load += frmStudentAssets_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentAssets).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoomAssets).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudentAssets;
        private PictureBox pictureBox4;
        private Button btnDelete;
        private PictureBox pictureBox2;
        private Button btnPrint;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnSetStudentAsset;
        private PictureBox pictureBox7;
        private Button btnSetTransfer;
        private Button btnRepairRoomAsset;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvRoomAssets;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Guid;
        private DataGridViewTextBoxColumn OwnerName;
        private DataGridViewTextBoxColumn TransferDate;
        private DataGridViewTextBoxColumn Discription;
        private DataGridViewTextBoxColumn Id2;
        private DataGridViewTextBoxColumn PartNumber;
        private DataGridViewTextBoxColumn AssetNumber;
        private DataGridViewTextBoxColumn CreateOn;
        private DataGridViewTextBoxColumn CreateBy;
        private Stimulsoft.Report.StiReport stiAssetPrint;
    }
}