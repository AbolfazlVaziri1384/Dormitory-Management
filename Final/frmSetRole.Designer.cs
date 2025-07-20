namespace Final
{
    partial class frmSetRole
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
            dgvUsers = new DataGridView();
            pictureBox6 = new PictureBox();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(117, 49);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(552, 112);
            dgvUsers.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.search;
            pictureBox6.Location = new Point(601, 211);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(502, 211);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 17;
            label1.Text = ":جستجوی کاربر";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(168, 213);
            txtSearch.Name = "txtSearch";
            txtSearch.RightToLeft = RightToLeft.Yes;
            txtSearch.Size = new Size(328, 27);
            txtSearch.TabIndex = 16;
            // 
            // btnSet
            // 
            btnSet.BackColor = Color.Honeydew;
            btnSet.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSet.ForeColor = Color.DarkGreen;
            btnSet.Location = new Point(335, 304);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(161, 42);
            btnSet.TabIndex = 19;
            btnSet.Text = "ثبت مسئولیت";
            btnSet.UseVisualStyleBackColor = false;
            // 
            // frmSetRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSet);
            Controls.Add(pictureBox6);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dgvUsers);
            Name = "frmSetRole";
            Text = "ثبت نقش کاربر";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private PictureBox pictureBox6;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSet;
    }
}