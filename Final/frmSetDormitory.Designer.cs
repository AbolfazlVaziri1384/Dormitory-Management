namespace Final
{
    partial class frmSetDormitory
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
            label2 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            label3 = new Label();
            numCapacity = new NumericUpDown();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            radMan = new RadioButton();
            radWoman = new RadioButton();
            label11 = new Label();
            radFamily = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(633, 105);
            label1.Name = "label1";
            label1.Size = new Size(77, 29);
            label1.TabIndex = 0;
            label1.Text = ":نام خوابگاه";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Koodak", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(633, 148);
            label2.Name = "label2";
            label2.Size = new Size(55, 29);
            label2.TabIndex = 1;
            label2.Text = ":آدرس";
            // 
            // txtName
            // 
            txtName.Location = new Point(399, 105);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(206, 33);
            txtName.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(399, 157);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(205, 65);
            txtAddress.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Koodak", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(633, 245);
            label3.Name = "label3";
            label3.Size = new Size(58, 29);
            label3.TabIndex = 4;
            label3.Text = ":ظرفیت";
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(399, 245);
            numCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(206, 27);
            numCapacity.TabIndex = 5;
            numCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.MediumSeaGreen;
            btnSave.Location = new Point(420, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(157, 37);
            btnSave.TabIndex = 6;
            btnSave.Text = "ذخیره اطلاعات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.newBlock;
            pictureBox1.Location = new Point(150, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // radMan
            // 
            radMan.AutoSize = true;
            radMan.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            radMan.ForeColor = Color.MediumBlue;
            radMan.Location = new Point(483, 288);
            radMan.Name = "radMan";
            radMan.Size = new Size(71, 30);
            radMan.TabIndex = 28;
            radMan.TabStop = true;
            radMan.Text = "برادران";
            radMan.UseVisualStyleBackColor = true;
            // 
            // radWoman
            // 
            radWoman.AutoSize = true;
            radWoman.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            radWoman.ForeColor = Color.MediumBlue;
            radWoman.Location = new Point(399, 288);
            radWoman.Name = "radWoman";
            radWoman.Size = new Size(78, 30);
            radWoman.TabIndex = 27;
            radWoman.TabStop = true;
            radWoman.Text = "خواهران";
            radWoman.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label11.ForeColor = Color.MediumBlue;
            label11.Location = new Point(633, 289);
            label11.Name = "label11";
            label11.Size = new Size(61, 29);
            label11.TabIndex = 26;
            label11.Text = ":جنسیت";
            // 
            // radFamily
            // 
            radFamily.AutoSize = true;
            radFamily.Font = new Font("B Koodak", 9F, FontStyle.Bold);
            radFamily.ForeColor = Color.MediumBlue;
            radFamily.Location = new Point(560, 288);
            radFamily.Name = "radFamily";
            radFamily.Size = new Size(66, 30);
            radFamily.TabIndex = 29;
            radFamily.TabStop = true;
            radFamily.Text = "متاهلی";
            radFamily.UseVisualStyleBackColor = true;
            // 
            // frmSetDormitory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(radFamily);
            Controls.Add(radMan);
            Controls.Add(radWoman);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(numCapacity);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSetDormitory";
            Text = "ثبت خوابگاه جدید";
            Load += frmSetDormitory_Load;
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtAddress;
        private Label label3;
        private NumericUpDown numCapacity;
        private Button btnSave;
        private PictureBox pictureBox1;
        private RadioButton radMan;
        private RadioButton radWoman;
        private Label label11;
        private RadioButton radFamily;
    }
}