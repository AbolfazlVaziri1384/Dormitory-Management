namespace Final
{
    partial class frmRoom
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtSearch = new TextBox();
            dgvRooms = new DataGridView();
            btnSetRoomAssegment = new Button();
            pictureBox9 = new PictureBox();
            btnSetRoom = new Button();
            pictureBox7 = new PictureBox();
            btnShowRoomAssegment = new Button();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnPrint = new Button();
            pictureBox4 = new PictureBox();
            btnDelete = new Button();
            pictureBox3 = new PictureBox();
            btnEdit = new Button();
            stiRoomPrint = new Stimulsoft.Report.StiReport();
            Id = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            FloorNumber = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            StudentCount = new DataGridViewTextBoxColumn();
            CountOn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(577, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(477, 249);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(100, 29);
            label1.TabIndex = 7;
            label1.Text = "جستجوی اتاق :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(255, 240);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(222, 39);
            txtSearch.TabIndex = 6;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.AliceBlue;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { Id, Number, FloorNumber, Capacity, StudentCount, CountOn });
            dgvRooms.Location = new Point(79, 12);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RightToLeft = RightToLeft.Yes;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(628, 205);
            dgvRooms.TabIndex = 9;
            dgvRooms.CellContentClick += dgvRooms_CellContentClick;
            // 
            // btnSetRoomAssegment
            // 
            btnSetRoomAssegment.BackColor = Color.AliceBlue;
            btnSetRoomAssegment.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetRoomAssegment.ForeColor = Color.CadetBlue;
            btnSetRoomAssegment.Location = new Point(189, 389);
            btnSetRoomAssegment.Name = "btnSetRoomAssegment";
            btnSetRoomAssegment.Size = new Size(166, 40);
            btnSetRoomAssegment.TabIndex = 53;
            btnSetRoomAssegment.Text = "تخصیص اتاق";
            btnSetRoomAssegment.UseVisualStyleBackColor = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.personal;
            pictureBox9.Location = new Point(356, 389);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(50, 44);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 52;
            pictureBox9.TabStop = false;
            // 
            // btnSetRoom
            // 
            btnSetRoom.BackColor = Color.AliceBlue;
            btnSetRoom.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetRoom.ForeColor = Color.SeaGreen;
            btnSetRoom.Location = new Point(424, 329);
            btnSetRoom.Name = "btnSetRoom";
            btnSetRoom.Size = new Size(165, 40);
            btnSetRoom.TabIndex = 49;
            btnSetRoom.Text = "افزودن اتاق جدید";
            btnSetRoom.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.pl;
            pictureBox7.Location = new Point(595, 327);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(45, 44);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 48;
            pictureBox7.TabStop = false;
            // 
            // btnShowRoomAssegment
            // 
            btnShowRoomAssegment.BackColor = Color.AliceBlue;
            btnShowRoomAssegment.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnShowRoomAssegment.ForeColor = Color.Chocolate;
            btnShowRoomAssegment.Location = new Point(190, 452);
            btnShowRoomAssegment.Name = "btnShowRoomAssegment";
            btnShowRoomAssegment.Size = new Size(165, 40);
            btnShowRoomAssegment.TabIndex = 47;
            btnShowRoomAssegment.Text = "مشاهده افراد داخل اتاق";
            btnShowRoomAssegment.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.eye;
            pictureBox6.Location = new Point(358, 450);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 46;
            pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(360, 331);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.MediumOrchid;
            btnPrint.Location = new Point(189, 331);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(166, 40);
            btnPrint.TabIndex = 42;
            btnPrint.Text = "چاپ لیست اتاق ها";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.trash;
            pictureBox4.Location = new Point(595, 448);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(423, 452);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(166, 40);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "حذف اتاق انتخاب شده";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pen;
            pictureBox3.Location = new Point(595, 389);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.AliceBlue;
            btnEdit.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnEdit.ForeColor = Color.Fuchsia;
            btnEdit.Location = new Point(423, 391);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(166, 40);
            btnEdit.TabIndex = 38;
            btnEdit.Text = "ویرایش اطلاعات اتاق";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // stiRoomPrint
            // 
            stiRoomPrint.CookieContainer = null;
            stiRoomPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            stiRoomPrint.HttpHeadersContainer = null;
            stiRoomPrint.Key = "8af69fd458c5454b8c8c890c9a9cb753";
            stiRoomPrint.ReferencedAssemblies = new string[]
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
            stiRoomPrint.ReportAlias = "Report";
            stiRoomPrint.ReportGuid = "00e5d77dcc0a4933843cb80e75e60fef";
            stiRoomPrint.ReportName = "Report";
            stiRoomPrint.ReportSource = null;
            stiRoomPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            stiRoomPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            stiRoomPrint.UseProgressInThread = false;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Number
            // 
            Number.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Number.HeaderText = "شماره";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            Number.ReadOnly = true;
            Number.Width = 77;
            // 
            // FloorNumber
            // 
            FloorNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FloorNumber.HeaderText = "شماره طبقه";
            FloorNumber.MinimumWidth = 6;
            FloorNumber.Name = "FloorNumber";
            FloorNumber.ReadOnly = true;
            FloorNumber.Width = 115;
            // 
            // Capacity
            // 
            Capacity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Capacity.HeaderText = "ظرفیت";
            Capacity.MinimumWidth = 6;
            Capacity.Name = "Capacity";
            Capacity.ReadOnly = true;
            Capacity.Width = 83;
            // 
            // StudentCount
            // 
            StudentCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentCount.HeaderText = "تعداد ساکنین";
            StudentCount.MinimumWidth = 6;
            StudentCount.Name = "StudentCount";
            StudentCount.ReadOnly = true;
            StudentCount.Width = 121;
            // 
            // CountOn
            // 
            CountOn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CountOn.HeaderText = "تاریخ ثبت";
            CountOn.MinimumWidth = 6;
            CountOn.Name = "CountOn";
            CountOn.ReadOnly = true;
            CountOn.Width = 96;
            // 
            // frmRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(btnSetRoomAssegment);
            Controls.Add(pictureBox9);
            Controls.Add(btnSetRoom);
            Controls.Add(pictureBox7);
            Controls.Add(btnShowRoomAssegment);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox2);
            Controls.Add(btnPrint);
            Controls.Add(pictureBox4);
            Controls.Add(btnDelete);
            Controls.Add(pictureBox3);
            Controls.Add(btnEdit);
            Controls.Add(dgvRooms);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            MaximizeBox = false;
            Name = "frmRoom";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Room";
            Load += frmRoom_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtSearch;
        private DataGridView dgvRooms;
        private Button btnSetRoomAssegment;
        private PictureBox pictureBox9;
        private Button btnTransferRoomAssetHistory;
        private PictureBox pictureBox8;
        private Button btnSetRoom;
        private PictureBox pictureBox7;
        private Button btnShowRoomAssegment;
        private PictureBox pictureBox6;
        private Button btnRepairRoomAsset;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private Button btnPrint;
        private PictureBox pictureBox4;
        private Button btnDelete;
        private PictureBox pictureBox3;
        private Button btnEdit;
        private Stimulsoft.Report.StiReport stiRoomPrint;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn FloorNumber;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn StudentCount;
        private DataGridViewTextBoxColumn CountOn;
    }
}