namespace Final
{
    partial class frmRoomAssets
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
            dgvRoomAssets = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtSearch = new TextBox();
            pictureBox2 = new PictureBox();
            btnPrint = new Button();
            pictureBox4 = new PictureBox();
            btnDelete = new Button();
            pictureBox3 = new PictureBox();
            btnEdit = new Button();
            btnRepairRoomAsset = new Button();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnRepairRoomAssetsRequest = new Button();
            pictureBox7 = new PictureBox();
            btnSetRoomAssets = new Button();
            btnTransferRoomAssetHistory = new Button();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            btnSetOwner = new Button();
            btnDeleteOwner = new Button();
            btnEditOwner = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRoomAssets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // dgvRoomAssets
            // 
            dgvRoomAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomAssets.Location = new Point(60, 74);
            dgvRoomAssets.Name = "dgvRoomAssets";
            dgvRoomAssets.RowHeadersWidth = 51;
            dgvRoomAssets.Size = new Size(675, 109);
            dgvRoomAssets.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(554, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(454, 21);
            label1.Name = "label1";
            label1.Size = new Size(107, 29);
            label1.TabIndex = 4;
            label1.Text = ":جستجوی وسیله";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(232, 12);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(222, 39);
            txtSearch.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(403, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.MediumOrchid;
            btnPrint.Location = new Point(232, 217);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(166, 40);
            btnPrint.TabIndex = 24;
            btnPrint.Text = "چاپ لیست وسایل";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.trash;
            pictureBox4.Location = new Point(404, 384);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(232, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(166, 40);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "حذف وسیله انتخاب شده";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pen;
            pictureBox3.Location = new Point(404, 273);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.AliceBlue;
            btnEdit.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnEdit.ForeColor = Color.Fuchsia;
            btnEdit.Location = new Point(232, 275);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(166, 40);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "ویرایش اطلاعات وسیله";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnRepairRoomAsset
            // 
            btnRepairRoomAsset.BackColor = Color.AliceBlue;
            btnRepairRoomAsset.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnRepairRoomAsset.ForeColor = Color.Orange;
            btnRepairRoomAsset.Location = new Point(515, 275);
            btnRepairRoomAsset.Name = "btnRepairRoomAsset";
            btnRepairRoomAsset.Size = new Size(165, 40);
            btnRepairRoomAsset.TabIndex = 27;
            btnRepairRoomAsset.Text = "درخواست تعمیر وسیله";
            btnRepairRoomAsset.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.wrench;
            pictureBox5.Location = new Point(677, 275);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.eye;
            pictureBox6.Location = new Point(683, 330);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 28;
            pictureBox6.TabStop = false;
            // 
            // btnRepairRoomAssetsRequest
            // 
            btnRepairRoomAssetsRequest.BackColor = Color.AliceBlue;
            btnRepairRoomAssetsRequest.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnRepairRoomAssetsRequest.ForeColor = Color.Chocolate;
            btnRepairRoomAssetsRequest.Location = new Point(515, 332);
            btnRepairRoomAssetsRequest.Name = "btnRepairRoomAssetsRequest";
            btnRepairRoomAssetsRequest.Size = new Size(165, 40);
            btnRepairRoomAssetsRequest.TabIndex = 29;
            btnRepairRoomAssetsRequest.Text = "مشاهده همه درخواست ها";
            btnRepairRoomAssetsRequest.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.pl;
            pictureBox7.Location = new Point(686, 386);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(45, 44);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;
            // 
            // btnSetRoomAssets
            // 
            btnSetRoomAssets.BackColor = Color.AliceBlue;
            btnSetRoomAssets.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetRoomAssets.ForeColor = Color.SeaGreen;
            btnSetRoomAssets.Location = new Point(515, 388);
            btnSetRoomAssets.Name = "btnSetRoomAssets";
            btnSetRoomAssets.Size = new Size(165, 40);
            btnSetRoomAssets.TabIndex = 31;
            btnSetRoomAssets.Text = "افزودن وسیله جدید";
            btnSetRoomAssets.UseVisualStyleBackColor = false;
            // 
            // btnTransferRoomAssetHistory
            // 
            btnTransferRoomAssetHistory.BackColor = Color.AliceBlue;
            btnTransferRoomAssetHistory.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnTransferRoomAssetHistory.ForeColor = Color.Olive;
            btnTransferRoomAssetHistory.Location = new Point(515, 217);
            btnTransferRoomAssetHistory.Name = "btnTransferRoomAssetHistory";
            btnTransferRoomAssetHistory.Size = new Size(165, 40);
            btnTransferRoomAssetHistory.TabIndex = 33;
            btnTransferRoomAssetHistory.Text = "مشاهده تاریخچه تغییرات";
            btnTransferRoomAssetHistory.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.eye;
            pictureBox8.Location = new Point(683, 215);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(52, 50);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 32;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.personal;
            pictureBox9.Location = new Point(399, 332);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(50, 44);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 34;
            pictureBox9.TabStop = false;
            // 
            // btnSetOwner
            // 
            btnSetOwner.BackColor = Color.AliceBlue;
            btnSetOwner.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetOwner.ForeColor = Color.CadetBlue;
            btnSetOwner.Location = new Point(232, 332);
            btnSetOwner.Name = "btnSetOwner";
            btnSetOwner.Size = new Size(166, 40);
            btnSetOwner.TabIndex = 35;
            btnSetOwner.Text = "تغییر مالک وسیله";
            btnSetOwner.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOwner
            // 
            btnDeleteOwner.BackColor = Color.AliceBlue;
            btnDeleteOwner.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDeleteOwner.ForeColor = Color.Crimson;
            btnDeleteOwner.Location = new Point(60, 388);
            btnDeleteOwner.Name = "btnDeleteOwner";
            btnDeleteOwner.Size = new Size(166, 40);
            btnDeleteOwner.TabIndex = 36;
            btnDeleteOwner.Text = "حذف مالک فعلی وسیله";
            btnDeleteOwner.UseVisualStyleBackColor = false;
            // 
            // btnEditOwner
            // 
            btnEditOwner.BackColor = Color.AliceBlue;
            btnEditOwner.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnEditOwner.ForeColor = Color.CadetBlue;
            btnEditOwner.Location = new Point(60, 332);
            btnEditOwner.Name = "btnEditOwner";
            btnEditOwner.Size = new Size(166, 40);
            btnEditOwner.TabIndex = 37;
            btnEditOwner.Text = "ویرایش اطلاعات مالک";
            btnEditOwner.UseVisualStyleBackColor = false;
            // 
            // frmRoomAssets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditOwner);
            Controls.Add(btnDeleteOwner);
            Controls.Add(btnSetOwner);
            Controls.Add(pictureBox9);
            Controls.Add(btnTransferRoomAssetHistory);
            Controls.Add(pictureBox8);
            Controls.Add(btnSetRoomAssets);
            Controls.Add(pictureBox7);
            Controls.Add(btnRepairRoomAssetsRequest);
            Controls.Add(pictureBox6);
            Controls.Add(btnRepairRoomAsset);
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
            Controls.Add(dgvRoomAssets);
            Name = "frmRoomAssets";
            Text = "لوازم خوابگاه";
            Load += frmRoomAssets_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoomAssets).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRoomAssets;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtSearch;
        private PictureBox pictureBox2;
        private Button btnPrint;
        private PictureBox pictureBox4;
        private Button btnDelete;
        private PictureBox pictureBox3;
        private Button btnEdit;
        private Button btnRepairRoomAsset;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnRepairRoomAssetsRequest;
        private PictureBox pictureBox7;
        private Button btnSetRoomAssets;
        private Button btnTransferRoomAssetHistory;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Button btnSetOwner;
        private Button btnDeleteOwner;
        private Button btnEditOwner;
    }
}