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
            txtName.Location = new Point(408, 94);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 34);
            txtName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(539, 99);
            label1.Name = "label1";
            label1.Size = new Size(56, 29);
            label1.TabIndex = 5;
            label1.Text = ":نام اتاق";
            // 
            // numFloorNumber
            // 
            numFloorNumber.Location = new Point(408, 162);
            numFloorNumber.Name = "numFloorNumber";
            numFloorNumber.Size = new Size(125, 27);
            numFloorNumber.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(539, 162);
            label2.Name = "label2";
            label2.Size = new Size(80, 29);
            label2.TabIndex = 10;
            label2.Text = ":شماره طبقه";
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(408, 275);
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(125, 27);
            numCapacity.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(539, 273);
            label4.Name = "label4";
            label4.Size = new Size(58, 29);
            label4.TabIndex = 12;
            label4.Text = ":ظرفیت";
            // 
            // numNumber
            // 
            numNumber.Location = new Point(408, 218);
            numNumber.Name = "numNumber";
            numNumber.Size = new Size(125, 27);
            numNumber.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(539, 218);
            label3.Name = "label3";
            label3.Size = new Size(75, 29);
            label3.TabIndex = 15;
            label3.Text = ":شماره اتاق";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.MediumSeaGreen;
            btnSave.Location = new Point(332, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 43);
            btnSave.TabIndex = 16;
            btnSave.Text = "ذخیره اطلاعات";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.newroom;
            pictureBox1.Location = new Point(140, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // frmSetRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "frmSetRoom";
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