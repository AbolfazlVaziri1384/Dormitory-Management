namespace Final
{
    partial class frmRepairRoomAsset
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
            cmbStatus = new ComboBox();
            txtDiscription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(318, 75);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(158, 28);
            cmbStatus.TabIndex = 0;
            // 
            // txtDiscription
            // 
            txtDiscription.Location = new Point(214, 133);
            txtDiscription.Multiline = true;
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(262, 77);
            txtDiscription.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(475, 75);
            label1.Name = "label1";
            label1.Size = new Size(97, 29);
            label1.TabIndex = 2;
            label1.Text = ":وضعیت وسیله";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(475, 134);
            label2.Name = "label2";
            label2.Size = new Size(221, 29);
            label2.TabIndex = 3;
            label2.Text = ":توضیحات مربوط به خرابی/تعمیرات";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSave.ForeColor = Color.DarkGreen;
            btnSave.Location = new Point(338, 279);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 39);
            btnSave.TabIndex = 21;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // frmRepairRoomAsset
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDiscription);
            Controls.Add(cmbStatus);
            Name = "frmRepairRoomAsset";
            Text = "درخواست تعمیر وسیله";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStatus;
        private TextBox txtDiscription;
        private Label label1;
        private Label label2;
        private Button btnSave;
    }
}