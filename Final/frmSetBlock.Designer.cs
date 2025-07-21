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
            label1.Location = new Point(480, 65);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = ":نام بلوک";
            // 
            // txtName
            // 
            txtName.Location = new Point(365, 62);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 26);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(480, 110);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 5;
            label2.Text = ":تعداد طبقه";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(480, 156);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 6;
            label3.Text = ":تعداد اتاق";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(486, 201);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 7;
            label4.Text = ":ظرفیت";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.MediumSeaGreen;
            btnSave.Location = new Point(298, 257);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 28);
            btnSave.TabIndex = 8;
            btnSave.Text = "ذخیره اطلاعات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // numFloorNumber
            // 
            numFloorNumber.Location = new Point(365, 110);
            numFloorNumber.Margin = new Padding(3, 2, 3, 2);
            numFloorNumber.Name = "numFloorNumber";
            numFloorNumber.Size = new Size(109, 23);
            numFloorNumber.TabIndex = 9;
            // 
            // numeRoomNumber
            // 
            numeRoomNumber.Location = new Point(365, 156);
            numeRoomNumber.Margin = new Padding(3, 2, 3, 2);
            numeRoomNumber.Name = "numeRoomNumber";
            numeRoomNumber.Size = new Size(106, 23);
            numeRoomNumber.TabIndex = 10;
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(365, 202);
            numCapacity.Margin = new Padding(3, 2, 3, 2);
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(106, 23);
            numCapacity.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.new_blocks;
            pictureBox1.Location = new Point(128, 62);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // frmSetBlock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmSetBlock";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ثبت بلوک جدید";
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