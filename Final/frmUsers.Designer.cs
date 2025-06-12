namespace Final
{
    partial class frmUsers
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
            dgvUsers = new DataGridView();
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
            btnAddNew = new Button();
            btnPrint = new Button();
            btnEdit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnDelete = new Button();
            btnChangeStatus = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnBackToMain = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(307, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.RightToLeft = RightToLeft.Yes;
            txtSearch.Size = new Size(328, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(641, 43);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 1;
            label1.Text = ":جستجوی کاربر";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.AliceBlue;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { Id, FisrtName, LastName, Gender, Birthday, StuPerCode, NationalCode, Phone, Status, Address });
            dgvUsers.Location = new Point(12, 107);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RightToLeft = RightToLeft.Yes;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1031, 170);
            dgvUsers.TabIndex = 2;
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
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.AliceBlue;
            btnAddNew.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnAddNew.ForeColor = Color.MediumSeaGreen;
            btnAddNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNew.Location = new Point(641, 326);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(149, 38);
            btnAddNew.TabIndex = 3;
            btnAddNew.Text = "افزودن کاربر";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.MediumOrchid;
            btnPrint.Location = new Point(641, 380);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(149, 38);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "چاپ لیست";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.AliceBlue;
            btnEdit.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnEdit.ForeColor = Color.Orange;
            btnEdit.Location = new Point(410, 324);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(149, 40);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pl;
            pictureBox1.Location = new Point(796, 326);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(796, 380);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pen;
            pictureBox3.Location = new Point(565, 328);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(410, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 38);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.BackColor = Color.AliceBlue;
            btnChangeStatus.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnChangeStatus.ForeColor = Color.DodgerBlue;
            btnChangeStatus.Location = new Point(176, 324);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(149, 40);
            btnChangeStatus.TabIndex = 12;
            btnChangeStatus.Text = "تغییر وضعیت";
            btnChangeStatus.UseVisualStyleBackColor = false;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.trash;
            pictureBox4.Location = new Point(565, 382);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.status;
            pictureBox5.Location = new Point(331, 328);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.search;
            pictureBox6.Location = new Point(740, 43);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // btnBackToMain
            // 
            btnBackToMain.BackColor = Color.AliceBlue;
            btnBackToMain.Font = new Font("B Koodak", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnBackToMain.ForeColor = Color.MediumBlue;
            btnBackToMain.Location = new Point(12, 398);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(99, 40);
            btnBackToMain.TabIndex = 16;
            btnBackToMain.Text = "بازگشت";
            btnBackToMain.UseVisualStyleBackColor = false;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 450);
            Controls.Add(btnBackToMain);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(btnChangeStatus);
            Controls.Add(btnDelete);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnEdit);
            Controls.Add(btnPrint);
            Controls.Add(btnAddNew);
            Controls.Add(dgvUsers);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Name = "frmUsers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "مدیریت کاربران";
            Load += frmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvUsers;
        private Button btnAddNew;
        private Button btnPrint;
        private Button btnEdit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnDelete;
        private Button btnChangeStatus;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnBackToMain;
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
    }
}