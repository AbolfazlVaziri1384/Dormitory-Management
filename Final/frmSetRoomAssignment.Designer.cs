namespace Final
{
    partial class frmSetRoomAssignment
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
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            btnSave = new Button();
            Id = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            StuPerCode = new DataGridViewTextBoxColumn();
            NationalCode = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.BackgroundColor = Color.AliceBlue;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { Id, FirstName, LastName, Gender, StuPerCode, NationalCode });
            dgvStudents.Location = new Point(34, 30);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RightToLeft = RightToLeft.Yes;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(732, 202);
            dgvStudents.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(282, 265);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(222, 39);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(510, 265);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.MediumSeaGreen;
            btnSave.Location = new Point(319, 338);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 44);
            btnSave.TabIndex = 17;
            btnSave.Text = "ذخیره اطلاعات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            LastName.Width = 119;
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
            // StuPerCode
            // 
            StuPerCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StuPerCode.HeaderText = " شماره دانشجویی/پرسنلی";
            StuPerCode.MinimumWidth = 6;
            StuPerCode.Name = "StuPerCode";
            StuPerCode.ReadOnly = true;
            StuPerCode.Width = 185;
            // 
            // NationalCode
            // 
            NationalCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NationalCode.HeaderText = "شماره ملی";
            NationalCode.MinimumWidth = 6;
            NationalCode.Name = "NationalCode";
            NationalCode.ReadOnly = true;
            // 
            // frmSetRoomAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(dgvStudents);
            MaximizeBox = false;
            Name = "frmSetRoomAssignment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "تخصیص اتاق";
            Load += frmSetRoomAssignment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private Button btnSave;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn StuPerCode;
        private DataGridViewTextBoxColumn NationalCode;
    }
}