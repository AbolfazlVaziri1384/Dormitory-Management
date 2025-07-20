namespace Final
{
    partial class frmRepairRoomAssetsRequest
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
            dgvRequsts = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtSearch = new TextBox();
            pictureBox6 = new PictureBox();
            btnRepair = new Button();
            btnPrint = new Button();
            pictureBox2 = new PictureBox();
            btnDelete = new Button();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRequsts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dgvRequsts
            // 
            dgvRequsts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequsts.Location = new Point(258, 28);
            dgvRequsts.Name = "dgvRequsts";
            dgvRequsts.RowHeadersWidth = 51;
            dgvRequsts.Size = new Size(300, 101);
            dgvRequsts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(508, 183);
            label1.Name = "label1";
            label1.Size = new Size(132, 29);
            label1.TabIndex = 1;
            label1.Text = ":جستجوی درخواست";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(633, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(258, 182);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(253, 34);
            txtSearch.TabIndex = 5;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.pl;
            pictureBox6.Location = new Point(462, 264);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // btnRepair
            // 
            btnRepair.BackColor = Color.AliceBlue;
            btnRepair.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnRepair.ForeColor = Color.MediumSeaGreen;
            btnRepair.Location = new Point(321, 264);
            btnRepair.Name = "btnRepair";
            btnRepair.Size = new Size(141, 38);
            btnRepair.TabIndex = 30;
            btnRepair.Text = "ثبت درخواست";
            btnRepair.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.DarkOrchid;
            btnPrint.Location = new Point(321, 374);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(141, 38);
            btnPrint.TabIndex = 33;
            btnPrint.Text = "چاپ";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(462, 374);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(321, 320);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 38);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "حذف درخواست";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.trash;
            pictureBox5.Location = new Point(462, 320);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // frmRepairRoomAssetsRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(pictureBox5);
            Controls.Add(btnPrint);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox6);
            Controls.Add(btnRepair);
            Controls.Add(txtSearch);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dgvRequsts);
            Name = "frmRepairRoomAssetsRequest";
            Text = "درخواست تعمیر";
            ((System.ComponentModel.ISupportInitialize)dgvRequsts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRequsts;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtSearch;
        private PictureBox pictureBox6;
        private Button btnRepair;
        private Button btnPrint;
        private PictureBox pictureBox2;
        private Button btnDelete;
        private PictureBox pictureBox5;
    }
}