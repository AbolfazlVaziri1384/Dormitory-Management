namespace Final
{
    partial class frmRoomAssignment
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
            dgvStudents = new DataGridView();
            lblRoomInfo = new Label();
            pictureBox6 = new PictureBox();
            btnPrint = new Button();
            pictureBox2 = new PictureBox();
            btnDelete = new Button();
            pictureBox5 = new PictureBox();
            btnSetRoomAssignment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(156, 56);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(483, 106);
            dgvStudents.TabIndex = 0;
            // 
            // lblRoomInfo
            // 
            lblRoomInfo.AutoSize = true;
            lblRoomInfo.Font = new Font("B Koodak", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblRoomInfo.ForeColor = Color.RoyalBlue;
            lblRoomInfo.Location = new Point(645, 99);
            lblRoomInfo.Name = "lblRoomInfo";
            lblRoomInfo.Size = new Size(95, 31);
            lblRoomInfo.TabIndex = 1;
            lblRoomInfo.Text = ":اطلاعات اتاق";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.pl;
            pictureBox6.Location = new Point(611, 327);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 30;
            pictureBox6.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.DarkOrchid;
            btnPrint.Location = new Point(322, 327);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(104, 38);
            btnPrint.TabIndex = 32;
            btnPrint.Text = "چاپ";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(433, 327);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(156, 327);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 38);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.trash;
            pictureBox5.Location = new Point(260, 327);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            // 
            // btnSetRoomAssignment
            // 
            btnSetRoomAssignment.BackColor = Color.AliceBlue;
            btnSetRoomAssignment.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetRoomAssignment.ForeColor = Color.ForestGreen;
            btnSetRoomAssignment.Location = new Point(488, 327);
            btnSetRoomAssignment.Name = "btnSetRoomAssignment";
            btnSetRoomAssignment.Size = new Size(117, 38);
            btnSetRoomAssignment.TabIndex = 35;
            btnSetRoomAssignment.Text = "تخصیص جدید";
            btnSetRoomAssignment.UseVisualStyleBackColor = false;
            // 
            // frmRoomAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSetRoomAssignment);
            Controls.Add(btnDelete);
            Controls.Add(pictureBox5);
            Controls.Add(btnPrint);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox6);
            Controls.Add(lblRoomInfo);
            Controls.Add(dgvStudents);
            Name = "frmRoomAssignment";
            Text = "frmRoomAssignment";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private Label lblRoomInfo;
        private PictureBox pictureBox6;
        private Button btnPrint;
        private PictureBox pictureBox2;
        private Button btnDelete;
        private PictureBox pictureBox5;
        private Button btnSetRoomAssignment;
    }
}