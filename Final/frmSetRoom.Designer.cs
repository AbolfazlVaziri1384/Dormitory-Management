namespace Final
{
    partial class frmSetRoom
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
            label1 = new Label();
            numFloorNumber = new NumericUpDown();
            label2 = new Label();
            numCapacity = new NumericUpDown();
            label4 = new Label();
            numNumber = new NumericUpDown();
            label3 = new Label();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numFloorNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(357, 70);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 26);
            txtName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(472, 74);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 5;
            label1.Text = ":نام اتاق";
            // 
            // numFloorNumber
            // 
            numFloorNumber.Location = new Point(357, 122);
            numFloorNumber.Margin = new Padding(3, 2, 3, 2);
            numFloorNumber.Name = "numFloorNumber";
            numFloorNumber.Size = new Size(109, 23);
            numFloorNumber.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(472, 122);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 10;
            label2.Text = ":شماره طبقه";
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(357, 206);
            numCapacity.Margin = new Padding(3, 2, 3, 2);
            numCapacity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(109, 23);
            numCapacity.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(472, 205);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 12;
            label4.Text = ":ظرفیت";
            // 
            // numNumber
            // 
            numNumber.Location = new Point(357, 164);
            numNumber.Margin = new Padding(3, 2, 3, 2);
            numNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numNumber.Name = "numNumber";
            numNumber.Size = new Size(109, 23);
            numNumber.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(472, 164);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 15;
            label3.Text = ":شماره اتاق";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.MediumSeaGreen;
            btnSave.Location = new Point(290, 250);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "ذخیره اطلاعات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.newroom;
            pictureBox1.Location = new Point(122, 63);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // frmSetRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(numNumber);
            Controls.Add(numCapacity);
            Controls.Add(label4);
            Controls.Add(numFloorNumber);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmSetRoom";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ثبت اتاق جدید";
            ((System.ComponentModel.ISupportInitialize)numFloorNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private NumericUpDown numFloorNumber;
        private Label label2;
        private NumericUpDown numCapacity;
        private Label label4;
        private NumericUpDown numNumber;
        private Label label3;
        private Button btnSave;
        private PictureBox pictureBox1;
    }
}