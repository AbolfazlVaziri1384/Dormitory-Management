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
    public partial class frmRoomAssets : Form
    {
        public frmRoomAssets()
        {
            InitializeComponent();
        }
        DormitoryDbContext db;
        public long UserID;
        private void frmRoomAssets_Load(object sender, EventArgs e)
        {
            db = new DormitoryDbContext();
            RefreshRoomAssetsList(db.RoomAssets.ToList());
            db.Dispose();
        }
        private void RefreshRoomAssetsList(List<Models.RoomAsset> RoomAssetlist)
        {
            dgvRoomAssets.Rows.Clear();
            foreach (var item in RoomAssetlist)
            {
                if ((item.CreatBy == UserID) && (item.IsDeleted == false))
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
                    dgvRoomAssets.Rows.Add(item.Id.ToString(),
                                          Thing,
                                            item.AssetNumber,
                                            (item.IsUsed == true) ? "در حال استفاده" : "آزاد",
                                            (item.Status == (int)EnumTool.Status.Intact) ? "سالم" : (item.Status == (int)EnumTool.Status.Defective) ? "معیوب" : "درحال تعمیر",
                                            HDateTimeTool.ToHDateTime(item.CreatOn));
                }

            }
            if (dgvRoomAssets.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvRoomAssets.Rows)
                {
                    // اگر وسیله در حال استفاده باشد
                    if (row.Cells[3].Value.ToString() != "در حال استفاده")
                    {
                        row.DefaultCellStyle.BackColor = Color.Aqua;
                    }
                }
            }
        }

        private void btnTransferRoomAssetHistory_Click(object sender, EventArgs e)
        {
            frmSubstituteStudentAssets frmSubstituteStudentAssets = new frmSubstituteStudentAssets();
            frmSubstituteStudentAssets.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == null) return;

                db = new DormitoryDbContext();
                RefreshRoomAssetsList((List<Models.RoomAsset>)db.RoomAssets.Where(i => i.PartNumber.ToString().Contains(txtSearch.Text.Trim()) ||
                                                                                  i.AssetNumber.ToString().Contains(txtSearch.Text.Trim())).ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtRoomAssets = new DataTable();
            dtRoomAssets.Columns.Add("PartNumber");
            dtRoomAssets.Columns.Add("AssetNumber");
            dtRoomAssets.Columns.Add("IsUsed");
            dtRoomAssets.Columns.Add("Status");
            dtRoomAssets.Columns.Add("CreatOn");

            foreach (DataGridViewRow row in dgvRoomAssets.Rows)
            {
                dtRoomAssets.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString()
                    );
            }
            stiRoomAssetsPrint.Load(Application.StartupPath + "/RoomAssetsReport.mrt");
            stiRoomAssetsPrint.RegData("DTRoomAssets", dtRoomAssets);
            stiRoomAssetsPrint.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoomAssets.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = long.Parse(dgvRoomAssets.CurrentRow.Cells[0].Value.ToString());
                frmSetRoomAssets frm = new frmSetRoomAssets();
                frm.RoomAssetID = id;
                frm.UserID = UserID;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshRoomAssetsList(db.RoomAssets.ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoomAssets.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = long.Parse(dgvRoomAssets.CurrentRow.Cells[0].Value.ToString());
                if (id != 0)
                {
                    DialogResult result;
                    result = MessageBoxTool.msgq("آیا از حذف مطمئن هستید ؟");
                    if (result == DialogResult.Yes)
                    {
                        RoomAsset.DeleteRoomAsset(id, UserID);
                        MessageBoxTool.msg();
                        db = new DormitoryDbContext();
                        RefreshRoomAssetsList(db.RoomAssets.ToList());
                        db.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnRepairRoomAsset_Click(object sender, EventArgs e)
        {
            if (dgvRoomAssets.Rows.Count == 0)
            {
                return;
            }
            long id;
            id = long.Parse(dgvRoomAssets.CurrentRow.Cells[0].Value.ToString());
            frmRepairRoomAsset frm = new frmRepairRoomAsset();
            frm.UserID = UserID;
            frm.RoomAssetID = id;
            frm.ShowDialog();
            // برای اینکه اگر زمانی ما درخواست تعمیر را ثبت کردیم
            db = new DormitoryDbContext();
            RefreshRoomAssetsList(db.RoomAssets.ToList());
            db.Dispose();
        }

        private void btnSetRoomAssets_Click(object sender, EventArgs e)
        {
            frmSetRoomAssets frm = new frmSetRoomAssets();
            frm.UserID = UserID;
            frm.ShowDialog();
            db = new DormitoryDbContext();
            RefreshRoomAssetsList(db.RoomAssets.ToList());
            db.Dispose();
        }

        private void btnRepairRoomAssetsRequest_Click(object sender, EventArgs e)
        {
            frmRepairRoomAssetsRequest frm = new frmRepairRoomAssetsRequest();
            frm.UserID = UserID;
            frm.ShowDialog();
            // برای اینکه اگر زمانی ما درخواست تعمیر را حذف کردیم
            db = new DormitoryDbContext();
            RefreshRoomAssetsList(db.RoomAssets.ToList());
            db.Dispose();
        }

        private void btnSetOwner_Click(object sender, EventArgs e)
        {
            if (dgvRoomAssets.Rows.Count == 0)
            {
                return;
            }
            if (dgvRoomAssets.CurrentRow.Cells[3].Value.ToString() == "در حال استفاده")
            {
                MessageBoxTool.msger("این وسیله در حال استفاده است");
                return;
            }
            long id;
            id = long.Parse(dgvRoomAssets.CurrentRow.Cells[0].Value.ToString());
            frmSetTransferRoomAssetHistory frm = new frmSetTransferRoomAssetHistory();
            frm.UserID = UserID;
            frm.RoomAssetID = id;
            frm.ShowDialog();
            db = new DormitoryDbContext();
            RefreshRoomAssetsList(db.RoomAssets.ToList());
            db.Dispose();
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            if (dgvRoomAssets.Rows.Count == 0)
            {
                return;
            }
            long id;
            id = long.Parse(dgvRoomAssets.CurrentRow.Cells[0].Value.ToString());
            DialogResult result;
            result = MessageBoxTool.msgq("آیا از حذف مطمئن هستید ؟");
            if (result == DialogResult.Yes)
            {
                TransferRoomAssetHistory.DeleteOwner(id);
                db = new DormitoryDbContext();
                RefreshRoomAssetsList(db.RoomAssets.ToList());
                db.Dispose();
            }
        }

        private void btnEditOwner_Click(object sender, EventArgs e)
        {
            if (dgvRoomAssets.Rows.Count == 0)
            {
                return;
            }
            if (dgvRoomAssets.CurrentRow.Cells[3].Value.ToString() != "در حال استفاده")
            {
                MessageBoxTool.msger("این وسیله در حال استفاده نیست");
                return;
            }
            long id;
            id = long.Parse(dgvRoomAssets.CurrentRow.Cells[0].Value.ToString());
            frmSetTransferRoomAssetHistory frm = new frmSetTransferRoomAssetHistory();
            frm.UserID = UserID;
            frm.EditTransferRoomAssetID = id;
            frm.ShowDialog();
        }

        private void btnShowOwner_Click(object sender, EventArgs e)
        {
            if (dgvRoomAssets.Rows.Count == 0)
            {
                return;
            }
            long id;
            id = long.Parse(dgvRoomAssets.CurrentRow.Cells[0].Value.ToString());
            string masseg = "";
            TransferRoomAssetHistory tra = TransferRoomAssetHistory.FindByAssetId(id);
            string room;
            if (tra == null) masseg = "این وسیله هنوز به کسی داده نشده است";
            else
                switch (RoomAsset.FindRoomAssetById(tra.RoomAssetId).PartNumber)
                {
                    case 1:
                        room = "اتاق" + $" {Room.FindRoomById(RoomAssigment.GetByRoomId(tra.RoomId ?? -1).RoomId).Number} \n" + "در طبقه" + $" {Room.FindRoomById(RoomAssigment.GetByRoomId(tra.RoomId ?? -1).RoomId).FloorNumber} \n" + "در بلوک" + $" {Block.FindBlockById(Room.FindRoomById(RoomAssigment.GetByRoomId(tra.RoomId ?? -1).RoomId).BlockId).Name} \n" + "در خوابگاه" + $" {Dormitory.FindDormitoryById(Block.FindBlockById(Room.FindRoomById(RoomAssigment.GetByRoomId(tra.RoomId ?? -1).RoomId).BlockId).DermitoryId).Name} \n";
                        masseg = $"این یخچال برای {room} است";
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        room = "اتاق" + $" {Room.FindRoomById(RoomAssigment.FindByUserId(tra.StudentId ?? -1).RoomId).Number} " + "در بلوک" + $" {Block.FindBlockById(Room.FindRoomById(RoomAssigment.FindByUserId(tra.StudentId ?? -1).RoomId).BlockId).Name} " + "در خوابگاه" + $" {Dormitory.FindDormitoryById(Block.FindBlockById(Room.FindRoomById(RoomAssigment.FindByUserId(tra.StudentId ?? -1).RoomId).BlockId).DermitoryId).Name} ";
                        var user = User.FindUserById(tra.StudentId ?? -1);
                        masseg = "این وسیله برای" + $" {User.GetFullName(user)} " + "با کد دانشجویی" + $" {user.StuPerCode} " + "در" + $" {room} " + "است";
                        break;
                }
            MessageBoxTool.msgr(masseg);
        }
    }
}
