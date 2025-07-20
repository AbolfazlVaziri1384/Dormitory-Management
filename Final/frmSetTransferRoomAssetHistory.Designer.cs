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
            ((System.ComponentModel.ISupportInitialize)dgvOwner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvOwner
            // 
            dgvOwner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwner.Location = new Point(248, 31);
            dgvOwner.Name = "dgvOwner";
            dgvOwner.RowHeadersWidth = 51;
            dgvOwner.Size = new Size(300, 121);
            dgvOwner.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(258, 202);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(253, 34);
            txtSearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(607, 183);
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
            label1.Location = new Point(507, 207);
            label1.Name = "label1";
            label1.Size = new Size(107, 29);
            label1.TabIndex = 5;
            label1.Text = ":جستجوی وسیله";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.MediumSeaGreen;
            btnSave.Location = new Point(334, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 37);
            btnSave.TabIndex = 17;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // frmTransferRoomAssetHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dgvOwner);
            Name = "frmTransferRoomAssetHistory";
            Text = "تخصیص وسایل";
            ((System.ComponentModel.ISupportInitialize)dgvOwner).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOwner;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnSave;
    }
}