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
            FisrtName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            StuPerCode = new DataGridViewTextBoxColumn();
            NationalCode = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
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
            pictureBox1.Location = new Point(586, 249);
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
            label1.Location = new Point(486, 249);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(100, 29);
            label1.TabIndex = 7;
            label1.Text = "جستجوی اتاق :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(264, 240);
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
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { Id, FisrtName, LastName, Gender, Birthday, StuPerCode, NationalCode, Phone, Status, Address });
            dgvRooms.Location = new Point(81, 12);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RightToLeft = RightToLeft.Yes;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(662, 170);
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
            // FisrtName
            // 
            FisrtName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FisrtName.HeaderText = "نام";
            FisrtName.MinimumWidth = 6;
            FisrtName.Name = "FisrtName";
            FisrtName.ReadOnly = true;
            FisrtName.Width = 56;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LastName.HeaderText = "نام خانوادگی";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 110;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Gender.HeaderText = "جنسیت";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 84;
            // 
            // Birthday
            // 
            Birthday.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Birthday.HeaderText = "تاریخ تولد";
            Birthday.MinimumWidth = 6;
            Birthday.Name = "Birthday";
            Birthday.ReadOnly = true;
            Birthday.Width = 91;
            // 
            // StuPerCode
            // 
            StuPerCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StuPerCode.HeaderText = "کد دانشجویی/پرسنلی";
            StuPerCode.MinimumWidth = 6;
            StuPerCode.Name = "StuPerCode";
            StuPerCode.ReadOnly = true;
            StuPerCode.Width = 161;
            // 
            // NationalCode
            // 
            NationalCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NationalCode.HeaderText = "کد ملی";
            NationalCode.MinimumWidth = 6;
            NationalCode.Name = "NationalCode";
            NationalCode.ReadOnly = true;
            NationalCode.Width = 79;
            // 
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Phone.HeaderText = "تلفن";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 66;
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
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Address.HeaderText = "آدرس";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 73;
            // 
            // btnSetRoomAssegment
            // 
            btnSetRoomAssegment.BackColor = Color.AliceBlue;
            btnSetRoomAssegment.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetRoomAssegment.ForeColor = Color.CadetBlue;
            btnSetRoomAssegment.Location = new Point(198, 389);
            btnSetRoomAssegment.Name = "btnSetRoomAssegment";
            btnSetRoomAssegment.Size = new Size(166, 40);
            btnSetRoomAssegment.TabIndex = 53;
            btnSetRoomAssegment.Text = "تخصیص اتاق";
            btnSetRoomAssegment.UseVisualStyleBackColor = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.personal;
            pictureBox9.Location = new Point(365, 389);
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
            btnSetRoom.Location = new Point(433, 329);
            btnSetRoom.Name = "btnSetRoom";
            btnSetRoom.Size = new Size(165, 40);
            btnSetRoom.TabIndex = 49;
            btnSetRoom.Text = "افزودن اتاق جدید";
            btnSetRoom.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.pl;
            pictureBox7.Location = new Point(604, 327);
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
            btnShowRoomAssegment.Location = new Point(199, 452);
            btnShowRoomAssegment.Name = "btnShowRoomAssegment";
            btnShowRoomAssegment.Size = new Size(165, 40);
            btnShowRoomAssegment.TabIndex = 47;
            btnShowRoomAssegment.Text = "مشاهده افراد داخل اتاق";
            btnShowRoomAssegment.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.eye;
            pictureBox6.Location = new Point(367, 450);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 46;
            pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(369, 331);
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
            btnPrint.Location = new Point(198, 331);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(166, 40);
            btnPrint.TabIndex = 42;
            btnPrint.Text = "چاپ لیست اتاق ها";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.trash;
            pictureBox4.Location = new Point(604, 448);
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
            btnDelete.Location = new Point(432, 452);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(166, 40);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "حذف اتاق انتخاب شده";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pen;
            pictureBox3.Location = new Point(604, 389);
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
            btnEdit.Location = new Point(432, 391);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(166, 40);
            btnEdit.TabIndex = 38;
            btnEdit.Text = "ویرایش اطلاعات اتاق";
            btnEdit.UseVisualStyleBackColor = false;
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
            Name = "frmRoom";
            Text = "frmRoom";
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FisrtName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn StuPerCode;
        private DataGridViewTextBoxColumn NationalCode;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Address;
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
    }
}