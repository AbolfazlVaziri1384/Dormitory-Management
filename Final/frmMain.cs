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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public long UserID;

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBoxTool.msgq("آیا از خروج مطمئن هستید ؟");
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            int role = Role.FindRole(UserID);
            if (role == (int)EnumTool.Role.Student || role == (int)EnumTool.Role.BlockOwner)
            {
                HighMenu.Visible = false;
            }
            else if (role != (int)EnumTool.Role.Student)
            {
                mnuSetManager.Enabled = false;
            }
            lblFullName.Text = User.GetFullName(User.FindUserById(UserID));
            lblLogin.Text = User.FindUserById(UserID).PreviousLogin.ToHDateTime();
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToHDateTime();
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void mnuFrmDormitory_Click(object sender, EventArgs e)
        {
            frmDormitory frmDormitory = new frmDormitory();
            frmDormitory.UserID = UserID;
            frmDormitory.ShowDialog();
        }

        private void mnuSetDormitory_Click(object sender, EventArgs e)
        {
            frmSetDormitory frmSetDormitory = new frmSetDormitory();
            frmSetDormitory.UserID = UserID;
            frmSetDormitory.ShowDialog();
        }

        private void mnufrmRepairRoomAssetsRequest_Click(object sender, EventArgs e)
        {
            frmRepairRoomAssetsRequest frmRepairRoomAssetsRequest = new frmRepairRoomAssetsRequest();
            frmRepairRoomAssetsRequest.UserID = UserID;
            frmRepairRoomAssetsRequest.ShowDialog();
        }

        private void mnuFrmRoomAssets_Click(object sender, EventArgs e)
        {
            frmRoomAssets frmRoomAssets = new frmRoomAssets();
            frmRoomAssets.UserID = UserID;
            frmRoomAssets.ShowDialog();
        }

        private void mnuSetManager_Click(object sender, EventArgs e)
        {
            frmSetRole frmSetRole = new frmSetRole();
            frmSetRole.UserID = UserID;
            frmSetRole.ShowDialog();
        }

        private void mnufrmSetRoomAssets_Click(object sender, EventArgs e)
        {
            frmSetRoomAssets frmSetRoomAssets = new frmSetRoomAssets();
            frmSetRoomAssets.UserID = UserID;
            frmSetRoomAssets.ShowDialog();
        }

        private void mnufrmSetStudentAssets_Click(object sender, EventArgs e)
        {
            frmSetStudentAssets frmSetStudentAssets = new frmSetStudentAssets();
            frmSetStudentAssets.UserID = UserID;
            frmSetStudentAssets.ShowDialog();
        }
    }
}
