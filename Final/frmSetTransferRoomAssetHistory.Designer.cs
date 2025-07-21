namespace Final
{
    partial class frmSetTransferRoomAssetHistory
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
            dgvOwner = new DataGridView();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnSave = new Button();
            grpStudent = new GroupBox();
            grpRoom = new GroupBox();
            dgvRoom = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            StuPerCode = new DataGridViewTextBoxColumn();
            NationalCode = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            Id2 = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            FloorNumber = new DataGridViewTextBoxColumn();
            BlockName = new DataGridViewTextBoxColumn();
            DormitoryName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOwner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpStudent.SuspendLayout();
            grpRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            SuspendLayout();
            // 
            // dgvOwner
            // 
            dgvOwner.AllowUserToAddRows = false;
            dgvOwner.AllowUserToDeleteRows = false;
            dgvOwner.BackgroundColor = Color.AliceBlue;
            dgvOwner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwner.Columns.AddRange(new DataGridViewColumn[] { Id, FirstName, LastName, Gender, StuPerCode, NationalCode, IsActive });
            dgvOwner.Location = new Point(6, 36);
            dgvOwner.Name = "dgvOwner";
            dgvOwner.ReadOnly = true;
            dgvOwner.RightToLeft = RightToLeft.Yes;
            dgvOwner.RowHeadersWidth = 51;
            dgvOwner.Size = new Size(729, 162);
            dgvOwner.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(231, 451);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(253, 34);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(546, 428);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(480, 456);
            label1.Name = "label1";
            label1.Size = new Size(60, 29);
            label1.TabIndex = 5;
            label1.Text = ":جستجو";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.MediumSeaGreen;
            btnSave.Location = new Point(309, 519);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 37);
            btnSave.TabIndex = 17;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // grpStudent
            // 
            grpStudent.Controls.Add(dgvOwner);
            grpStudent.Enabled = false;
            grpStudent.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            grpStudent.Location = new Point(12, 12);
            grpStudent.Name = "grpStudent";
            grpStudent.RightToLeft = RightToLeft.Yes;
            grpStudent.Size = new Size(741, 204);
            grpStudent.TabIndex = 18;
            grpStudent.TabStop = false;
            grpStudent.Text = "دانشجو ها";
            // 
            // grpRoom
            // 
            grpRoom.Controls.Add(dgvRoom);
            grpRoom.Enabled = false;
            grpRoom.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            grpRoom.Location = new Point(123, 222);
            grpRoom.Name = "grpRoom";
            grpRoom.RightToLeft = RightToLeft.Yes;
            grpRoom.Size = new Size(515, 204);
            grpRoom.TabIndex = 19;
            grpRoom.TabStop = false;
            grpRoom.Text = "اتاق ها";
            // 
            // dgvRoom
            // 
            dgvRoom.AllowUserToAddRows = false;
            dgvRoom.AllowUserToDeleteRows = false;
            dgvRoom.BackgroundColor = Color.AliceBlue;
            dgvRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoom.Columns.AddRange(new DataGridViewColumn[] { Id2, Number, FloorNumber, BlockName, DormitoryName });
            dgvRoom.Location = new Point(6, 36);
            dgvRoom.Name = "dgvRoom";
            dgvRoom.ReadOnly = true;
            dgvRoom.RightToLeft = RightToLeft.Yes;
            dgvRoom.RowHeadersWidth = 51;
            dgvRoom.Size = new Size(503, 162);
            dgvRoom.TabIndex = 1;
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
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FirstName.HeaderText = "نام";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 56;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LastName.HeaderText = "نام خانوادگی";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 113;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Gender.HeaderText = "جنسیت";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 86;
            // 
            // StuPerCode
            // 
            StuPerCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StuPerCode.HeaderText = "شماره دانشجویی/پرسنلی";
            StuPerCode.MinimumWidth = 6;
            StuPerCode.Name = "StuPerCode";
            StuPerCode.ReadOnly = true;
            StuPerCode.Width = 184;
            // 
            // NationalCode
            // 
            NationalCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NationalCode.HeaderText = "کد ملی";
            NationalCode.MinimumWidth = 6;
            NationalCode.Name = "NationalCode";
            NationalCode.ReadOnly = true;
            NationalCode.Width = 83;
            // 
            // IsActive
            // 
            IsActive.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IsActive.HeaderText = "وضعیت";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Width = 86;
            // 
            // Id2
            // 
            Id2.HeaderText = "Id2";
            Id2.MinimumWidth = 6;
            Id2.Name = "Id2";
            Id2.ReadOnly = true;
            Id2.Visible = false;
            Id2.Width = 125;
            // 
            // Number
            // 
            Number.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Number.HeaderText = "شماره";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            Number.ReadOnly = true;
            Number.Width = 75;
            // 
            // FloorNumber
            // 
            FloorNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FloorNumber.HeaderText = "شماره طبقه";
            FloorNumber.MinimumWidth = 6;
            FloorNumber.Name = "FloorNumber";
            FloorNumber.ReadOnly = true;
            FloorNumber.Width = 105;
            // 
            // BlockName
            // 
            BlockName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BlockName.HeaderText = "نام بلوک";
            BlockName.MinimumWidth = 6;
            BlockName.Name = "BlockName";
            BlockName.ReadOnly = true;
            BlockName.Width = 90;
            // 
            // DormitoryName
            // 
            DormitoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DormitoryName.HeaderText = "نام خوابگاه";
            DormitoryName.MinimumWidth = 6;
            DormitoryName.Name = "DormitoryName";
            DormitoryName.ReadOnly = true;
            DormitoryName.Width = 102;
            // 
            // frmSetTransferRoomAssetHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 584);
            Controls.Add(grpRoom);
            Controls.Add(grpStudent);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            MaximizeBox = false;
            Name = "frmSetTransferRoomAssetHistory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "تخصیص وسایل";
            Load += frmSetTransferRoomAssetHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOwner).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpStudent.ResumeLayout(false);
            grpRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOwner;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnSave;
        private GroupBox grpStudent;
        private GroupBox grpRoom;
        private DataGridView dgvRoom;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn StuPerCode;
        private DataGridViewTextBoxColumn NationalCode;
        private DataGridViewTextBoxColumn IsActive;
        private DataGridViewTextBoxColumn Id2;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn FloorNumber;
        private DataGridViewTextBoxColumn BlockName;
        private DataGridViewTextBoxColumn DormitoryName;
    }
}