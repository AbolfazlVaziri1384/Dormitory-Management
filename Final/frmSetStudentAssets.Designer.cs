namespace Final
{
    partial class frmSetStudentAssets
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
            txtName = new TextBox();
            txtDiscription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblGuid = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(463, 99);
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.Yes;
            txtName.Size = new Size(166, 27);
            txtName.TabIndex = 0;
            // 
            // txtDiscription
            // 
            txtDiscription.Location = new Point(396, 165);
            txtDiscription.Multiline = true;
            txtDiscription.Name = "txtDiscription";
            txtDiscription.RightToLeft = RightToLeft.Yes;
            txtDiscription.Size = new Size(233, 81);
            txtDiscription.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(635, 99);
            label1.Name = "label1";
            label1.Size = new Size(74, 31);
            label1.TabIndex = 5;
            label1.Text = ":نام وسیله";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Koodak", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(635, 166);
            label2.Name = "label2";
            label2.Size = new Size(78, 31);
            label2.TabIndex = 6;
            label2.Text = ":توضیحات";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.devices;
            pictureBox1.Location = new Point(125, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblGuid
            // 
            lblGuid.AutoSize = true;
            lblGuid.Location = new Point(504, 274);
            lblGuid.Name = "lblGuid";
            lblGuid.Size = new Size(51, 20);
            lblGuid.TabIndex = 8;
            lblGuid.Text = "-------";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.DarkGreen;
            btnSave.Location = new Point(463, 325);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 36);
            btnSave.TabIndex = 20;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmSetStudentAssets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(lblGuid);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDiscription);
            Controls.Add(txtName);
            MaximizeBox = false;
            Name = "frmSetStudentAssets";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ثبت لوازم دانشجو";
            Load += frmSetStudentAssets_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDiscription;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblGuid;
        private Button btnSave;
    }
}