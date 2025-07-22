using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final.Models;
using Final.Tools;

namespace Final
{
    public partial class frmSetStudentAssets : Form
    {
        public frmSetStudentAssets()
        {
            InitializeComponent();
        }
        public long UserID;
        private void frmSetStudentAssets_Load(object sender, EventArgs e)
        {
            lblGuid.Text = Serial();
        }
        private string Serial()
        {
            DateTime now = DateTime.Now;
            return $"{now:yyyyMMddHHmmss}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool Istrue = CheckTool.StudentAssetField(txtName.Text, txtDiscription.Text);
                if (Istrue == true)
                {
                    StudentAsset.SetStudentAsset(txtName.Text, lblGuid.Text, UserID, txtDiscription.Text);
                    MessageBoxTool.msgr("وسیله جدید با موفقیت ثبت شد");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.Message);
            }
        }
    }
}
