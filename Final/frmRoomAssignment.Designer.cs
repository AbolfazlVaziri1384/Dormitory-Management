namespace Final
{
    partial class frmRoomAssignment
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
            dgvStudents = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            StuPerCode = new DataGridViewTextBoxColumn();
            NationalCode = new DataGridViewTextBoxColumn();
            CreateOn = new DataGridViewTextBoxColumn();
            pictureBox6 = new PictureBox();
            btnPrint = new Button();
            pictureBox2 = new PictureBox();
            btnDelete = new Button();
            pictureBox5 = new PictureBox();
            btnSetRoomAssignment = new Button();
            groupBox1 = new GroupBox();
            lblDormitoryOwner = new Label();
            lblBlockOwner = new Label();
            label3 = new Label();
            label4 = new Label();
            lblBlock = new Label();
            label1 = new Label();
            lblDormitory = new Label();
            label6 = new Label();
            stiRoomAssigmentPrint = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.BackgroundColor = Color.AliceBlue;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { Id, Name, StuPerCode, NationalCode, CreateOn });
            dgvStudents.Location = new Point(42, 146);
            dgvStudents.Margin = new Padding(3, 2, 3, 2);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RightToLeft = RightToLeft.Yes;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(536, 121);
            dgvStudents.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
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
            // StuPerCode
            // 
            StuPerCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StuPerCode.HeaderText = "شماره دانشجویی";
            StuPerCode.MinimumWidth = 6;
            StuPerCode.Name = "StuPerCode";
            StuPerCode.ReadOnly = true;
            StuPerCode.Width = 106;
            // 
            // NationalCode
            // 
            NationalCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NationalCode.HeaderText = "کد ملی";
            NationalCode.MinimumWidth = 6;
            NationalCode.Name = "NationalCode";
            NationalCode.ReadOnly = true;
            NationalCode.Width = 63;
            // 
            // CreateOn
            // 
            CreateOn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CreateOn.HeaderText = "تاریخ ثبت";
            CreateOn.MinimumWidth = 6;
            CreateOn.Name = "CreateOn";
            CreateOn.ReadOnly = true;
            CreateOn.Width = 72;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.pl;
            pictureBox6.Location = new Point(500, 284);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 28);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 30;
            pictureBox6.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.DarkOrchid;
            btnPrint.Location = new Point(247, 284);
            btnPrint.Margin = new Padding(3, 2, 3, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(91, 28);
            btnPrint.TabIndex = 32;
            btnPrint.Text = "چاپ";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(344, 284);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(102, 284);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 28);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.trash;
            pictureBox5.Location = new Point(192, 284);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            // 
            // btnSetRoomAssignment
            // 
            btnSetRoomAssignment.BackColor = Color.AliceBlue;
            btnSetRoomAssignment.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetRoomAssignment.ForeColor = Color.ForestGreen;
            btnSetRoomAssignment.Location = new Point(392, 284);
            btnSetRoomAssignment.Margin = new Padding(3, 2, 3, 2);
            btnSetRoomAssignment.Name = "btnSetRoomAssignment";
            btnSetRoomAssignment.Size = new Size(102, 28);
            btnSetRoomAssignment.TabIndex = 35;
            btnSetRoomAssignment.Text = "تخصیص جدید";
            btnSetRoomAssignment.UseVisualStyleBackColor = false;
            btnSetRoomAssignment.Click += btnSetRoomAssignment_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDormitoryOwner);
            groupBox1.Controls.Add(lblBlockOwner);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblBlock);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblDormitory);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(42, 16);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(536, 125);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات اتاق :";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblDormitoryOwner
            // 
            lblDormitoryOwner.AutoSize = true;
            lblDormitoryOwner.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblDormitoryOwner.ForeColor = Color.OliveDrab;
            lblDormitoryOwner.Location = new Point(274, 76);
            lblDormitoryOwner.Name = "lblDormitoryOwner";
            lblDormitoryOwner.Size = new Size(132, 18);
            lblDormitoryOwner.TabIndex = 44;
            lblDormitoryOwner.Text = "DormitoryOwner";
            // 
            // lblBlockOwner
            // 
            lblBlockOwner.AutoSize = true;
            lblBlockOwner.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblBlockOwner.ForeColor = Color.SaddleBrown;
            lblBlockOwner.Location = new Point(39, 77);
            lblBlockOwner.Name = "lblBlockOwner";
            lblBlockOwner.Size = new Size(100, 18);
            lblBlockOwner.TabIndex = 40;
            lblBlockOwner.Text = "BlockOwner";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(158, 76);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 39;
            label3.Text = "مسئول بلوک :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.OliveDrab;
            label4.Location = new Point(429, 76);
            label4.Name = "label4";
            label4.Size = new Size(105, 18);
            label4.TabIndex = 43;
            label4.Text = "مسئول خوابگاه :";
            // 
            // lblBlock
            // 
            lblBlock.AutoSize = true;
            lblBlock.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblBlock.ForeColor = Color.SaddleBrown;
            lblBlock.Location = new Point(40, 39);
            lblBlock.Name = "lblBlock";
            lblBlock.Size = new Size(95, 18);
            lblBlock.TabIndex = 38;
            lblBlock.Text = "BlockName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(178, 38);
            label1.Name = "label1";
            label1.Size = new Size(65, 18);
            label1.TabIndex = 37;
            label1.Text = "نام بلوک :";
            // 
            // lblDormitory
            // 
            lblDormitory.AutoSize = true;
            lblDormitory.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblDormitory.ForeColor = Color.OliveDrab;
            lblDormitory.Location = new Point(276, 36);
            lblDormitory.Name = "lblDormitory";
            lblDormitory.Size = new Size(127, 18);
            lblDormitory.TabIndex = 42;
            lblDormitory.Text = "DormitoryName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.ForeColor = Color.OliveDrab;
            label6.Location = new Point(452, 36);
            label6.Name = "label6";
            label6.Size = new Size(78, 18);
            label6.TabIndex = 41;
            label6.Text = "نام خوبگاه :";
            // 
            // stiRoomAssigmentPrint
            // 
            stiRoomAssigmentPrint.CookieContainer = null;
            stiRoomAssigmentPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            stiRoomAssigmentPrint.HttpHeadersContainer = null;
            stiRoomAssigmentPrint.Key = "08ea257179d44bf7ba1eb99220408389";
            stiRoomAssigmentPrint.ReferencedAssemblies = new string[]
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
            stiRoomAssigmentPrint.ReportAlias = "Report";
            stiRoomAssigmentPrint.ReportGuid = "69f560883654496496bcfd77328c8026";
            stiRoomAssigmentPrint.ReportName = "Report";
            stiRoomAssigmentPrint.ReportSource = null;
            stiRoomAssigmentPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            stiRoomAssigmentPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            stiRoomAssigmentPrint.UseProgressInThread = false;
            // 
            // frmRoomAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 338);
            Controls.Add(groupBox1);
            Controls.Add(btnSetRoomAssignment);
            Controls.Add(btnDelete);
            Controls.Add(pictureBox5);
            Controls.Add(btnPrint);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox6);
            Controls.Add(dgvStudents);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "RoomAssignment";
            Load += frmRoomAssignment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudents;
        private PictureBox pictureBox6;
        private Button btnPrint;
        private PictureBox pictureBox2;
        private Button btnDelete;
        private PictureBox pictureBox5;
        private Button btnSetRoomAssignment;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblBlock;
        private Label lblBlockOwner;
        private Label label3;
        private Label lblDormitoryOwner;
        private Label label4;
        private Label lblDormitory;
        private Label label6;
        private Stimulsoft.Report.StiReport stiRoomAssigmentPrint;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn StuPerCode;
        private DataGridViewTextBoxColumn NationalCode;
        private DataGridViewTextBoxColumn CreateOn;
    }
}