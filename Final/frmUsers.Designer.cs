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
            txtSearch.Location = new Point(207, 42);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(253, 42);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(466, 51);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 1;
            label1.Text = ":جستجوی کاربر";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.AliceBlue;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(207, 107);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(291, 170);
            dgvUsers.TabIndex = 2;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.AliceBlue;
            btnAddNew.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnAddNew.ForeColor = Color.MediumSeaGreen;
            btnAddNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNew.Location = new Point(544, 328);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(108, 38);
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
            btnPrint.Location = new Point(544, 382);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(108, 38);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "چاپ لیست";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.AliceBlue;
            btnEdit.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnEdit.ForeColor = Color.Orange;
            btnEdit.Location = new Point(352, 330);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(108, 40);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pl;
            pictureBox1.Location = new Point(658, 328);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(658, 382);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pen;
            pictureBox3.Location = new Point(466, 330);
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
            btnDelete.Location = new Point(352, 384);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 38);
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
            btnChangeStatus.Location = new Point(149, 328);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(108, 40);
            btnChangeStatus.TabIndex = 12;
            btnChangeStatus.Text = "تغییر وضعیت";
            btnChangeStatus.UseVisualStyleBackColor = false;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.trash;
            pictureBox4.Location = new Point(466, 384);
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
            pictureBox5.Location = new Point(263, 330);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.search;
            pictureBox6.Location = new Point(565, 51);
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
            btnBackToMain.Location = new Point(12, 405);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(67, 33);
            btnBackToMain.TabIndex = 16;
            btnBackToMain.Text = "بازگشت";
            btnBackToMain.UseVisualStyleBackColor = false;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}