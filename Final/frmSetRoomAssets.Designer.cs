namespace Final
{
    partial class frmSetRoomAssets
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
            label1 = new Label();
            txtAssetNumber = new TextBox();
            cmbPartNumber = new ComboBox();
            label2 = new Label();
            cmbStatus = new ComboBox();
            label3 = new Label();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(537, 101);
            label1.Name = "label1";
            label1.Size = new Size(89, 29);
            label1.TabIndex = 3;
            label1.Text = ":شماره سریال";
            // 
            // txtAssetNumber
            // 
            txtAssetNumber.Enabled = false;
            txtAssetNumber.Location = new Point(382, 96);
            txtAssetNumber.Multiline = true;
            txtAssetNumber.Name = "txtAssetNumber";
            txtAssetNumber.Size = new Size(151, 35);
            txtAssetNumber.TabIndex = 2;
            // 
            // cmbPartNumber
            // 
            cmbPartNumber.FormattingEnabled = true;
            cmbPartNumber.Items.AddRange(new object[] { "یخچال", "میز", "صندلی", "تخت", "کمد" });
            cmbPartNumber.Location = new Point(382, 163);
            cmbPartNumber.Name = "cmbPartNumber";
            cmbPartNumber.Size = new Size(151, 28);
            cmbPartNumber.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(537, 163);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(73, 29);
            label2.TabIndex = 5;
            label2.Text = "نوع وسیله:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "سالم", "معیوب", "در حال تعمیر" });
            cmbStatus.Location = new Point(382, 226);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(537, 227);
            label3.Name = "label3";
            label3.Size = new Size(97, 29);
            label3.TabIndex = 7;
            label3.Text = ":وضعیت وسیله";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.DarkGreen;
            btnSave.Location = new Point(326, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 39);
            btnSave.TabIndex = 22;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.devices;
            pictureBox1.Location = new Point(191, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // frmSetRoomAssets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(cmbStatus);
            Controls.Add(label2);
            Controls.Add(cmbPartNumber);
            Controls.Add(label1);
            Controls.Add(txtAssetNumber);
            MaximizeBox = false;
            Name = "frmSetRoomAssets";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ثبت وسیله جدید";
            Load += frmSetRoomAssets_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAssetNumber;
        private ComboBox cmbPartNumber;
        private Label label2;
        private ComboBox cmbStatus;
        private Label label3;
        private Button btnSave;
        private PictureBox pictureBox1;
    }
}