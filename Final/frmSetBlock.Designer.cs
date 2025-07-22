namespace Final
{
    partial class frmSetBlock
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
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            numFloorNumber = new NumericUpDown();
            numeRoomNumber = new NumericUpDown();
            numCapacity = new NumericUpDown();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numFloorNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeRoomNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(549, 87);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = ":نام بلوک";
            // 
            // txtName
            // 
            txtName.Location = new Point(417, 83);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 33);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(549, 147);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 5;
            label2.Text = ":تعداد طبقه";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(549, 208);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 6;
            label3.Text = ":تعداد اتاق";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(555, 268);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 7;
            label4.Text = ":ظرفیت";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.MediumSeaGreen;
            btnSave.Location = new Point(341, 343);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 37);
            btnSave.TabIndex = 8;
            btnSave.Text = "ذخیره اطلاعات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // numFloorNumber
            // 
            numFloorNumber.Location = new Point(417, 147);
            numFloorNumber.Name = "numFloorNumber";
            numFloorNumber.Size = new Size(125, 27);
            numFloorNumber.TabIndex = 9;
            // 
            // numeRoomNumber
            // 
            numeRoomNumber.Location = new Point(417, 208);
            numeRoomNumber.Name = "numeRoomNumber";
            numeRoomNumber.Size = new Size(121, 27);
            numeRoomNumber.TabIndex = 10;
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(417, 269);
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(121, 27);
            numCapacity.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.new_blocks;
            pictureBox1.Location = new Point(146, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // frmSetBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(pictureBox1);
            Controls.Add(numCapacity);
            Controls.Add(numeRoomNumber);
            Controls.Add(numFloorNumber);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmSetBlock";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ثبت بلوک جدید";
            Load += frmSetBlock_Load;
            ((System.ComponentModel.ISupportInitialize)numFloorNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeRoomNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private NumericUpDown numFloorNumber;
        private NumericUpDown numeRoomNumber;
        private NumericUpDown numCapacity;
        private PictureBox pictureBox1;
    }
}