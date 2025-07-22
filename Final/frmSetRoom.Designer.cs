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
            // numFloorNumber
            // 
            numFloorNumber.Location = new Point(407, 110);
            numFloorNumber.Name = "numFloorNumber";
            numFloorNumber.Size = new Size(125, 27);
            numFloorNumber.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(538, 110);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 10;
            label2.Text = ":شماره طبقه";
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(407, 222);
            numCapacity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(125, 27);
            numCapacity.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(538, 220);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 12;
            label4.Text = ":ظرفیت";
            // 
            // numNumber
            // 
            numNumber.Location = new Point(407, 166);
            numNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numNumber.Name = "numNumber";
            numNumber.Size = new Size(125, 27);
            numNumber.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(538, 166);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 15;
            label3.Text = ":شماره اتاق";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.MediumSeaGreen;
            btnSave.Location = new Point(407, 276);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 39);
            btnSave.TabIndex = 16;
            btnSave.Text = "ذخیره اطلاعات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.newroom;
            pictureBox1.Location = new Point(139, 84);
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
            ClientSize = new Size(800, 451);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(numNumber);
            Controls.Add(numCapacity);
            Controls.Add(label4);
            Controls.Add(numFloorNumber);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "frmSetRoom";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ثبت اتاق جدید";
            Load += frmSetRoom_Load;
            ((System.ComponentModel.ISupportInitialize)numFloorNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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