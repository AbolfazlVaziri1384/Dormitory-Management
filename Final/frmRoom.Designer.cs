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
            Id = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            FloorNumber = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            StudentCount = new DataGridViewTextBoxColumn();
            CountOn = new DataGridViewTextBoxColumn();
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
            pictureBox1.Location = new Point(505, 187);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(417, 187);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(92, 17);
            label1.TabIndex = 7;
            label1.Text = "جستجوی اتاق :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(223, 180);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(195, 30);
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
            dgvRooms.Location = new Point(69, 9);
            dgvRooms.Margin = new Padding(3, 2, 3, 2);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RightToLeft = RightToLeft.Yes;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(550, 154);
            dgvRooms.TabIndex = 9;
            dgvRooms.CellContentClick += dgvRooms_CellContentClick;
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
            Number.Width = 62;
            // 
            // FloorNumber
            // 
            FloorNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FloorNumber.HeaderText = "شماره طبقه";
            FloorNumber.MinimumWidth = 6;
            FloorNumber.Name = "FloorNumber";
            FloorNumber.ReadOnly = true;
            FloorNumber.Width = 91;
            // 
            // Capacity
            // 
            Capacity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Capacity.HeaderText = "ظرفیت";
            Capacity.MinimumWidth = 6;
            Capacity.Name = "Capacity";
            Capacity.ReadOnly = true;
            Capacity.Width = 67;
            // 
            // StudentCount
            // 
            StudentCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentCount.HeaderText = "تعداد ساکنین";
            StudentCount.MinimumWidth = 6;
            StudentCount.Name = "StudentCount";
            StudentCount.ReadOnly = true;
            StudentCount.Width = 96;
            // 
            // CountOn
            // 
            CountOn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CountOn.HeaderText = "تاریخ ثبت";
            CountOn.MinimumWidth = 6;
            CountOn.Name = "CountOn";
            CountOn.ReadOnly = true;
            CountOn.Width = 78;
            // 
            // btnSetRoomAssegment
            // 
            btnSetRoomAssegment.BackColor = Color.AliceBlue;
            btnSetRoomAssegment.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetRoomAssegment.ForeColor = Color.CadetBlue;
            btnSetRoomAssegment.Location = new Point(165, 292);
            btnSetRoomAssegment.Margin = new Padding(3, 2, 3, 2);
            btnSetRoomAssegment.Name = "btnSetRoomAssegment";
            btnSetRoomAssegment.Size = new Size(145, 30);
            btnSetRoomAssegment.TabIndex = 53;
            btnSetRoomAssegment.Text = "تخصیص اتاق";
            btnSetRoomAssegment.UseVisualStyleBackColor = false;
            btnSetRoomAssegment.Click += btnSetRoomAssegment_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.personal;
            pictureBox9.Location = new Point(312, 292);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(44, 33);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 52;
            pictureBox9.TabStop = false;
            // 
            // btnSetRoom
            // 
            btnSetRoom.BackColor = Color.AliceBlue;
            btnSetRoom.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetRoom.ForeColor = Color.SeaGreen;
            btnSetRoom.Location = new Point(371, 247);
            btnSetRoom.Margin = new Padding(3, 2, 3, 2);
            btnSetRoom.Name = "btnSetRoom";
            btnSetRoom.Size = new Size(144, 30);
            btnSetRoom.TabIndex = 49;
            btnSetRoom.Text = "افزودن اتاق جدید";
            btnSetRoom.UseVisualStyleBackColor = false;
            btnSetRoom.Click += btnSetRoom_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.pl;
            pictureBox7.Location = new Point(521, 245);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(39, 33);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 48;
            pictureBox7.TabStop = false;
            // 
            // btnShowRoomAssegment
            // 
            btnShowRoomAssegment.BackColor = Color.AliceBlue;
            btnShowRoomAssegment.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnShowRoomAssegment.ForeColor = Color.Chocolate;
            btnShowRoomAssegment.Location = new Point(166, 339);
            btnShowRoomAssegment.Margin = new Padding(3, 2, 3, 2);
            btnShowRoomAssegment.Name = "btnShowRoomAssegment";
            btnShowRoomAssegment.Size = new Size(144, 30);
            btnShowRoomAssegment.TabIndex = 47;
            btnShowRoomAssegment.Text = "مشاهده افراد داخل اتاق";
            btnShowRoomAssegment.UseVisualStyleBackColor = false;
            btnShowRoomAssegment.Click += btnShowRoomAssegment_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.eye;
            pictureBox6.Location = new Point(313, 338);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(46, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 46;
            pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(315, 248);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.MediumOrchid;
            btnPrint.Location = new Point(165, 248);
            btnPrint.Margin = new Padding(3, 2, 3, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(145, 30);
            btnPrint.TabIndex = 42;
            btnPrint.Text = "چاپ لیست اتاق ها";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.trash;
            pictureBox4.Location = new Point(521, 336);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(370, 339);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 30);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "حذف اتاق انتخاب شده";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pen;
            pictureBox3.Location = new Point(521, 292);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.AliceBlue;
            btnEdit.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnEdit.ForeColor = Color.Fuchsia;
            btnEdit.Location = new Point(370, 293);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(145, 30);
            btnEdit.TabIndex = 38;
            btnEdit.Text = "ویرایش اطلاعات اتاق";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
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
            // frmRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 411);
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
            Margin = new Padding(3, 2, 3, 2);
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