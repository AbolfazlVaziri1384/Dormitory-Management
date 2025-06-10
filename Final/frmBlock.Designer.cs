namespace Final
{
    partial class frmBlock
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
            dgvBlocks = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            btnDelete = new Button();
            btnEdit = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnPrint = new Button();
            btnSetBlock = new Button();
            btnSetRoom = new Button();
            btnDeleteOwner = new Button();
            btnAddOwner = new Button();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnShowRooms = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBlocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgvBlocks
            // 
            dgvBlocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBlocks.Location = new Point(242, 29);
            dgvBlocks.Name = "dgvBlocks";
            dgvBlocks.RowHeadersWidth = 51;
            dgvBlocks.Size = new Size(300, 109);
            dgvBlocks.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(461, 159);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 1;
            label1.Text = ":جستجوی بلوک";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(242, 154);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(223, 34);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(559, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(154, 335);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 38);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.AliceBlue;
            btnEdit.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnEdit.ForeColor = Color.Orange;
            btnEdit.Location = new Point(328, 335);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(104, 38);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.trash;
            pictureBox5.Location = new Point(258, 335);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pen;
            pictureBox4.Location = new Point(438, 335);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.printer;
            pictureBox2.Location = new Point(614, 335);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.AliceBlue;
            btnPrint.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnPrint.ForeColor = Color.DarkOrchid;
            btnPrint.Location = new Point(503, 335);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(104, 38);
            btnPrint.TabIndex = 23;
            btnPrint.Text = "چاپ";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnSetBlock
            // 
            btnSetBlock.BackColor = Color.AliceBlue;
            btnSetBlock.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetBlock.ForeColor = Color.MediumSeaGreen;
            btnSetBlock.Location = new Point(503, 228);
            btnSetBlock.Name = "btnSetBlock";
            btnSetBlock.Size = new Size(104, 38);
            btnSetBlock.TabIndex = 24;
            btnSetBlock.Text = "ثبت بلوک";
            btnSetBlock.UseVisualStyleBackColor = false;
            // 
            // btnSetRoom
            // 
            btnSetRoom.BackColor = Color.AliceBlue;
            btnSetRoom.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSetRoom.ForeColor = Color.MediumSeaGreen;
            btnSetRoom.Location = new Point(328, 225);
            btnSetRoom.Name = "btnSetRoom";
            btnSetRoom.Size = new Size(104, 38);
            btnSetRoom.TabIndex = 25;
            btnSetRoom.Text = "ثبت اتاق";
            btnSetRoom.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOwner
            // 
            btnDeleteOwner.BackColor = Color.AliceBlue;
            btnDeleteOwner.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnDeleteOwner.ForeColor = Color.Crimson;
            btnDeleteOwner.Location = new Point(311, 281);
            btnDeleteOwner.Name = "btnDeleteOwner";
            btnDeleteOwner.Size = new Size(145, 38);
            btnDeleteOwner.TabIndex = 28;
            btnDeleteOwner.Text = "حذف مسئول بلوک";
            btnDeleteOwner.UseVisualStyleBackColor = false;
            // 
            // btnAddOwner
            // 
            btnAddOwner.BackColor = Color.AliceBlue;
            btnAddOwner.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnAddOwner.ForeColor = Color.MediumSeaGreen;
            btnAddOwner.Location = new Point(462, 281);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(145, 38);
            btnAddOwner.TabIndex = 27;
            btnAddOwner.Text = "افزودن مسئول بلوک";
            btnAddOwner.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.personal;
            pictureBox8.Location = new Point(613, 284);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 35);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 26;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.pl;
            pictureBox7.Location = new Point(432, 225);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(43, 38);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.pl;
            pictureBox6.Location = new Point(607, 228);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.room;
            pictureBox3.Location = new Point(258, 225);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // btnShowRooms
            // 
            btnShowRooms.BackColor = Color.AliceBlue;
            btnShowRooms.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnShowRooms.ForeColor = Color.DeepPink;
            btnShowRooms.Location = new Point(154, 225);
            btnShowRooms.Name = "btnShowRooms";
            btnShowRooms.Size = new Size(104, 38);
            btnShowRooms.TabIndex = 32;
            btnShowRooms.Text = "نمایش اتاق ها";
            btnShowRooms.UseVisualStyleBackColor = false;
            // 
            // frmBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowRooms);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(btnDeleteOwner);
            Controls.Add(btnAddOwner);
            Controls.Add(pictureBox8);
            Controls.Add(btnSetRoom);
            Controls.Add(btnSetBlock);
            Controls.Add(btnPrint);
            Controls.Add(pictureBox2);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgvBlocks);
            Name = "frmBlock";
            Text = "frmBlock";
            Load += frmBlock_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBlocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBlocks;
        private Label label1;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private Button btnDelete;
        private Button btnEdit;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Button btnPrint;
        private Button btnSetBlock;
        private Button btnSetRoom;
        private Button btnDeleteOwner;
        private Button btnAddOwner;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private Button btnShowRooms;
    }
}