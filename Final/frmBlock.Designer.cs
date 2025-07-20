namespace Final
{
    partial class frmBlock
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
            btnDelete = new Button();
            btnEdit = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnPrint = new Button();
            btnSetBlock = new Button();
            btnSetRoom = new Button();
            btnDeleteOwner = new Button();
            btnAddOwner = new Button();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnShowRooms = new Button();
            stiBlockPrint = new Stimulsoft.Report.StiReport();
            dgvBlocks = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            FloorNumber = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            CreateOn = new DataGridViewTextBoxColumn();
            OwnerName = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            txtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBlocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(115, 447);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 38);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.AliceBlue;
            btnEdit.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnEdit.ForeColor = Color.Orange;
            btnEdit.Location = new Point(289, 447);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(104, 38);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.trash;
            pictureBox5.Location = new Point(219, 447);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pen;
            pictureBox4.Location = new Point(399, 447);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(575, 447);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.DarkOrchid;
            btnPrint.Location = new Point(464, 447);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(104, 38);
            btnPrint.TabIndex = 23;
            btnPrint.Text = "چاپ";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnSetBlock
            // 
            btnSetBlock.BackColor = Color.AliceBlue;
            btnSetBlock.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetBlock.ForeColor = Color.MediumSeaGreen;
            btnSetBlock.Location = new Point(464, 320);
            btnSetBlock.Name = "btnSetBlock";
            btnSetBlock.Size = new Size(104, 38);
            btnSetBlock.TabIndex = 24;
            btnSetBlock.Text = "ثبت بلوک";
            btnSetBlock.UseVisualStyleBackColor = false;
            // 
            // btnSetRoom
            // 
            btnSetRoom.BackColor = Color.AliceBlue;
            btnSetRoom.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetRoom.ForeColor = Color.MediumSeaGreen;
            btnSetRoom.Location = new Point(289, 317);
            btnSetRoom.Name = "btnSetRoom";
            btnSetRoom.Size = new Size(104, 38);
            btnSetRoom.TabIndex = 25;
            btnSetRoom.Text = "ثبت اتاق";
            btnSetRoom.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOwner
            // 
            btnDeleteOwner.BackColor = Color.AliceBlue;
            btnDeleteOwner.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDeleteOwner.ForeColor = Color.Crimson;
            btnDeleteOwner.Location = new Point(272, 383);
            btnDeleteOwner.Name = "btnDeleteOwner";
            btnDeleteOwner.Size = new Size(145, 38);
            btnDeleteOwner.TabIndex = 28;
            btnDeleteOwner.Text = "حذف مسئول بلوک";
            btnDeleteOwner.UseVisualStyleBackColor = false;
            // 
            // btnAddOwner
            // 
            btnAddOwner.BackColor = Color.AliceBlue;
            btnAddOwner.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnAddOwner.ForeColor = Color.MediumSeaGreen;
            btnAddOwner.Location = new Point(423, 383);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(145, 38);
            btnAddOwner.TabIndex = 27;
            btnAddOwner.Text = "افزودن مسئول بلوک";
            btnAddOwner.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.personal;
            pictureBox8.Location = new Point(574, 386);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 35);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 26;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.pl;
            pictureBox7.Location = new Point(393, 317);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(43, 38);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.pl;
            pictureBox6.Location = new Point(568, 320);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.room;
            pictureBox3.Location = new Point(219, 317);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // btnShowRooms
            // 
            btnShowRooms.BackColor = Color.AliceBlue;
            btnShowRooms.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnShowRooms.ForeColor = Color.DeepPink;
            btnShowRooms.Location = new Point(115, 317);
            btnShowRooms.Name = "btnShowRooms";
            btnShowRooms.Size = new Size(104, 38);
            btnShowRooms.TabIndex = 32;
            btnShowRooms.Text = "نمایش اتاق ها";
            btnShowRooms.UseVisualStyleBackColor = false;
            // 
            // stiBlockPrint
            // 
            stiBlockPrint.CookieContainer = null;
            stiBlockPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            stiBlockPrint.HttpHeadersContainer = null;
            stiBlockPrint.Key = "47557b8934334926953d943555af1a3e";
            stiBlockPrint.ReferencedAssemblies = new string[]
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
            stiBlockPrint.ReportAlias = "Report";
            stiBlockPrint.ReportGuid = "65a32e83ee534b44896118cdabec54d2";
            stiBlockPrint.ReportName = "Report";
            stiBlockPrint.ReportSource = null;
            stiBlockPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            stiBlockPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            stiBlockPrint.UseProgressInThread = false;
            // 
            // dgvBlocks
            // 
            dgvBlocks.AllowUserToAddRows = false;
            dgvBlocks.AllowUserToDeleteRows = false;
            dgvBlocks.BackgroundColor = Color.AliceBlue;
            dgvBlocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBlocks.Columns.AddRange(new DataGridViewColumn[] { Id, Name, FloorNumber, RoomNumber, Capacity, CreateOn, OwnerName });
            dgvBlocks.Location = new Point(12, 71);
            dgvBlocks.Name = "dgvBlocks";
            dgvBlocks.ReadOnly = true;
            dgvBlocks.RightToLeft = RightToLeft.Yes;
            dgvBlocks.RowHeadersWidth = 51;
            dgvBlocks.Size = new Size(726, 217);
            dgvBlocks.TabIndex = 33;
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
            // FloorNumber
            // 
            FloorNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FloorNumber.HeaderText = "شماره طبقه";
            FloorNumber.MinimumWidth = 6;
            FloorNumber.Name = "FloorNumber";
            FloorNumber.ReadOnly = true;
            FloorNumber.Width = 115;
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RoomNumber.HeaderText = "تعداد اتاق ها";
            RoomNumber.MinimumWidth = 6;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            RoomNumber.Width = 118;
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
            // CreateOn
            // 
            CreateOn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CreateOn.HeaderText = "تاریخ ثبت";
            CreateOn.MinimumWidth = 6;
            CreateOn.Name = "CreateOn";
            CreateOn.ReadOnly = true;
            CreateOn.Width = 96;
            // 
            // OwnerName
            // 
            OwnerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OwnerName.HeaderText = "نام مسئول";
            OwnerName.MinimumWidth = 6;
            OwnerName.Name = "OwnerName";
            OwnerName.ReadOnly = true;
            OwnerName.Width = 105;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(595, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(129, 21);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(367, 34);
            txtSearch.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(497, 26);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 34;
            label1.Text = ":جستجوی بلوک";
            // 
            // frmBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 524);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgvBlocks);
            Controls.Add(btnShowRooms);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(btnDeleteOwner);
            Controls.Add(btnAddOwner);
            Controls.Add(pictureBox8);
            Controls.Add(btnSetRoom);
            Controls.Add(btnSetBlock);
            Controls.Add(btnPrint);
            Controls.Add(pictureBox2);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmBlock";
            Load += frmBlock_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBlocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDelete;
        private Button btnEdit;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Button btnPrint;
        private Button btnSetBlock;
        private Button btnSetRoom;
        private Button btnDeleteOwner;
        private Button btnAddOwner;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private Button btnShowRooms;
        private Stimulsoft.Report.StiReport stiBlockPrint;
        private DataGridView dgvBlocks;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn FloorNumber;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn CreateOn;
        private DataGridViewTextBoxColumn OwnerName;
        private PictureBox pictureBox1;
        private TextBox txtSearch;
        private Label label1;
    }
}