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
    public partial class frmSubstituteStudentAssets : Form
    {
        public frmSubstituteStudentAssets()
        {
            InitializeComponent();
        }
        DormitoryDbContext db;
        private void frmSubstituteStudentAssets_Load(object sender, EventArgs e)
        {
            db = new DormitoryDbContext();
            RefreshSSAList(db.SubstituteStudentAssets.ToList());
            db.Dispose();
        }
        private void RefreshSSAList(List<Models.SubstituteStudentAsset> SSAlist)
        {
            dgvSubstitute.Rows.Clear();

            foreach (var item in SSAlist)
            {
                string Thing;
                switch ((EnumTool.PartNumber)item.PartNumber)
                {
                    case EnumTool.PartNumber.Refrigerator:
                        Thing = "یخچال";
                        break;
                    case EnumTool.PartNumber.Desk:
                        Thing = "میز";
                        break;
                    case EnumTool.PartNumber.Chair:
                        Thing = "صندلی";
                        break;
                    case EnumTool.PartNumber.Bed:
                        Thing = "تخت";
                        break;
                    case EnumTool.PartNumber.Dresser:
                        Thing = "کمد";
                        break;
                    default:
                        Thing = "";
                        break;
                }
                dgvSubstitute.Rows.Add(item.Id.ToString(),
                                        User.GetFullName(User.FindUserById(item.StudentId)),
                                        Thing,
                                        (item.NewRoomAssetId == 0 || item.NewRoomAssetId == null) ? "" : RoomAsset.FindRoomAssetById(item.NewRoomAssetId).AssetNumber,
                                        (item.LastRoomAssetId == 0 || item.LastRoomAssetId == null) ? "" : RoomAsset.FindRoomAssetById(item.LastRoomAssetId).AssetNumber);
            }

            if (dgvSubstitute.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvSubstitute.Rows)
                {
                    if (row.Cells[4].Value == "")
                    {
                        row.DefaultCellStyle.BackColor = Color.Aqua;
                    }
                }
            }



        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtSSA = new DataTable();
            dtSSA.Columns.Add("Name");
            dtSSA.Columns.Add("PartNumber");
            dtSSA.Columns.Add("NewRoomAsset");
            dtSSA.Columns.Add("LastRoomAsset");

            foreach (DataGridViewRow row in dgvSubstitute.Rows)
            {
                dtSSA.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString()
                    );
            }
            stiSSAPrint.Load(Application.StartupPath + "/SSAReport.mrt");
            stiSSAPrint.RegData("DTSSA", dtSSA);
            stiSSAPrint.Show();
        }
    }
}
