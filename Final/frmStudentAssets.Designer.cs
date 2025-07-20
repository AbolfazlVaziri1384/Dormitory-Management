namespace Final
{
    partial class frmStudentAssets
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
            dgvStudentAssets = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtSearch = new TextBox();
            pictureBox4 = new PictureBox();
            btnDelete = new Button();
            pictureBox3 = new PictureBox();
            btnEdit = new Button();
            pictureBox2 = new PictureBox();
            btnPrint = new Button();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnSetStudentAsset = new Button();
            pictureBox7 = new PictureBox();
            btnSetTransfer = new Button();
            btnRepairRoomAsset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudentAssets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // dgvStudentAssets
            // 
            dgvStudentAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentAssets.Location = new Point(93, 36);
            dgvStudentAssets.Name = "dgvStudentAssets";
            dgvStudentAssets.RowHeadersWidth = 51;
            dgvStudentAssets.Size = new Size(607, 125);
            dgvStudentAssets.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(547, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(448, 199);
            label1.Name = "label1";
            label1.Size = new Size(107, 29);
            label1.TabIndex = 4;
            label1.Text = ":جستجوی وسیله";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(226, 190);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(222, 39);
            txtSearch.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.trash;
            pictureBox4.Location = new Point(335, 379);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(180, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 40);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pen;
            pictureBox3.Location = new Point(335, 262);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.AliceBlue;
            btnEdit.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnEdit.ForeColor = Color.Fuchsia;
            btnEdit.Location = new Point(180, 264);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(149, 40);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(334, 323);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.MediumOrchid;
            btnPrint.Location = new Point(180, 323);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(149, 40);
            btnPrint.TabIndex = 18;
            btnPrint.Text = "چاپ لیست";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.wrench;
            pictureBox5.Location = new Point(603, 383);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.devices;
            pictureBox6.Location = new Point(603, 262);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(59, 42);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // btnSetStudentAsset
            // 
            btnSetStudentAsset.BackColor = Color.AliceBlue;
            btnSetStudentAsset.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetStudentAsset.ForeColor = Color.ForestGreen;
            btnSetStudentAsset.Location = new Point(448, 264);
            btnSetStudentAsset.Name = "btnSetStudentAsset";
            btnSetStudentAsset.Size = new Size(149, 40);
            btnSetStudentAsset.TabIndex = 22;
            btnSetStudentAsset.Text = "ثبت لوازم جدید";
            btnSetStudentAsset.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.room;
            pictureBox7.Location = new Point(603, 317);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(59, 46);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // btnSetTransfer
            // 
            btnSetTransfer.BackColor = Color.AliceBlue;
            btnSetTransfer.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetTransfer.ForeColor = Color.SaddleBrown;
            btnSetTransfer.Location = new Point(448, 323);
            btnSetTransfer.Name = "btnSetTransfer";
            btnSetTransfer.Size = new Size(149, 40);
            btnSetTransfer.TabIndex = 24;
            btnSetTransfer.Text = "انتقال مالکیت";
            btnSetTransfer.UseVisualStyleBackColor = false;
            // 
            // btnRepairRoomAsset
            // 
            btnRepairRoomAsset.BackColor = Color.AliceBlue;
            btnRepairRoomAsset.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnRepairRoomAsset.ForeColor = Color.Orange;
            btnRepairRoomAsset.Location = new Point(448, 383);
            btnRepairRoomAsset.Name = "btnRepairRoomAsset";
            btnRepairRoomAsset.Size = new Size(149, 40);
            btnRepairRoomAsset.TabIndex = 25;
            btnRepairRoomAsset.Text = "درخواست تعمیر";
            btnRepairRoomAsset.UseVisualStyleBackColor = false;
            // 
            // frmStudentAssets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRepairRoomAsset);
            Controls.Add(btnSetTransfer);
            Controls.Add(pictureBox7);
            Controls.Add(btnSetStudentAsset);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(btnPrint);
            Controls.Add(pictureBox4);
            Controls.Add(btnDelete);
            Controls.Add(pictureBox3);
            Controls.Add(btnEdit);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dgvStudentAssets);
            Name = "frmStudentAssets";
            Text = "لوازم دانشجو";
            Load += frmStudentAssets_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentAssets).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentAssets;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtSearch;
        private PictureBox pictureBox4;
        private Button btnDelete;
        private PictureBox pictureBox3;
        private Button btnEdit;
        private PictureBox pictureBox2;
        private Button btnPrint;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnSetStudentAsset;
        private PictureBox pictureBox7;
        private Button btnSetTransfer;
        private Button btnRepairRoomAsset;
    }
}