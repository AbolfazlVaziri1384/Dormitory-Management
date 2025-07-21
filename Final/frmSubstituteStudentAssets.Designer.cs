namespace Final
{
    partial class frmSubstituteStudentAssets
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
            pictureBox2 = new PictureBox();
            btnPrint = new Button();
            dgvSubstitute = new DataGridView();
            stiSSAPrint = new Stimulsoft.Report.StiReport();
            Id = new DataGridViewTextBoxColumn();
            FisrtName = new DataGridViewTextBoxColumn();
            PartNumber = new DataGridViewTextBoxColumn();
            NewAssetNumber = new DataGridViewTextBoxColumn();
            LastAssetNumber = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubstitute).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(394, 316);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 63;
            pictureBox2.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.MediumOrchid;
            btnPrint.Location = new Point(222, 322);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(166, 40);
            btnPrint.TabIndex = 62;
            btnPrint.Text = "چاپ لیست";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // dgvSubstitute
            // 
            dgvSubstitute.AllowUserToAddRows = false;
            dgvSubstitute.AllowUserToDeleteRows = false;
            dgvSubstitute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubstitute.BackgroundColor = Color.AliceBlue;
            dgvSubstitute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubstitute.Columns.AddRange(new DataGridViewColumn[] { Id, FisrtName, PartNumber, NewAssetNumber, LastAssetNumber });
            dgvSubstitute.Location = new Point(31, 29);
            dgvSubstitute.Name = "dgvSubstitute";
            dgvSubstitute.ReadOnly = true;
            dgvSubstitute.RightToLeft = RightToLeft.Yes;
            dgvSubstitute.RowHeadersWidth = 51;
            dgvSubstitute.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubstitute.Size = new Size(549, 252);
            dgvSubstitute.TabIndex = 57;
            // 
            // stiSSAPrint
            // 
            stiSSAPrint.CookieContainer = null;
            stiSSAPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            stiSSAPrint.HttpHeadersContainer = null;
            stiSSAPrint.Key = "dc69760d94df4c41b0663699e1f15c9c";
            stiSSAPrint.ReferencedAssemblies = new string[]
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
            stiSSAPrint.ReportAlias = "Report";
            stiSSAPrint.ReportGuid = "3e9f8e6eebe645e4909f328f47a618cd";
            stiSSAPrint.ReportName = "Report";
            stiSSAPrint.ReportSource = null;
            stiSSAPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            stiSSAPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            stiSSAPrint.UseProgressInThread = false;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 51;
            // 
            // FisrtName
            // 
            FisrtName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FisrtName.HeaderText = "نام";
            FisrtName.MinimumWidth = 6;
            FisrtName.Name = "FisrtName";
            FisrtName.ReadOnly = true;
            FisrtName.Width = 56;
            // 
            // PartNumber
            // 
            PartNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartNumber.HeaderText = "پارت نامبر";
            PartNumber.MinimumWidth = 6;
            PartNumber.Name = "PartNumber";
            PartNumber.ReadOnly = true;
            PartNumber.Width = 99;
            // 
            // NewAssetNumber
            // 
            NewAssetNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NewAssetNumber.HeaderText = "شماره سریال جدید";
            NewAssetNumber.MinimumWidth = 6;
            NewAssetNumber.Name = "NewAssetNumber";
            NewAssetNumber.ReadOnly = true;
            NewAssetNumber.Width = 112;
            // 
            // LastAssetNumber
            // 
            LastAssetNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LastAssetNumber.HeaderText = "شماره سربال قدیمی";
            LastAssetNumber.MinimumWidth = 6;
            LastAssetNumber.Name = "LastAssetNumber";
            LastAssetNumber.ReadOnly = true;
            LastAssetNumber.Width = 150;
            // 
            // frmSubstituteStudentAssets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 378);
            Controls.Add(pictureBox2);
            Controls.Add(btnPrint);
            Controls.Add(dgvSubstitute);
            MaximizeBox = false;
            Name = "frmSubstituteStudentAssets";
            StartPosition = FormStartPosition.CenterParent;
            Text = "تاریخچه تعویض وسایل دانشجویان";
            Load += frmSubstituteStudentAssets_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubstitute).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Button btnPrint;
        private DataGridView dgvSubstitute;
        private Stimulsoft.Report.StiReport stiSSAPrint;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FisrtName;
        private DataGridViewTextBoxColumn PartNumber;
        private DataGridViewTextBoxColumn NewAssetNumber;
        private DataGridViewTextBoxColumn LastAssetNumber;
    }
}