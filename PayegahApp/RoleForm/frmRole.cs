using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.utility.Convertor;
using PayegahApp.RoleForm;
using PayegahDataLayer;
using PayegahDataLayer.Context;
using Stimulsoft.Report;

namespace PayegahApp.RollForm
{
    public partial class frmRole : Form
    {
        bool R_IsActive = true;
        public frmRole()
        {
            InitializeComponent();
        }

        private void btnInsertRoll_Click(object sender, EventArgs e)
        {
            RoleType frm = new RoleType();
            frm.ShowDialog();
        }

        private void frmRoll_Load(object sender, EventArgs e)
        {
            dgvRole.AutoGenerateColumns = false;
            dgvRole.ForeColor = Color.Black;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            BindGrid();
            CmbRoleType();
            CmbRole();
        }
        //private void ConvertDatesToShamsi()
        //{
        //    foreach (DataGridViewRow row in dgvRole.Rows)
        //    {
        //        if (row.Cells["DateRegestration"].Value != null &&
        //            DateTime.TryParse(row.Cells["DateRegestration"].Value.ToString(), out DateTime date))
        //        {
        //            row.Cells["DateRegestration"].Value = date.ToShamsi();
        //        }
        //        else
        //        {
        //            row.Cells["DateRegestration"].Value = "";
        //        }
        //    }
        //}
        void CmbRoleType()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var list = db.RoleTypeRepository.GetAll().Where(x => x.IsActive == true).ToList();
                cmbRoles.DisplayMember = "TypeTitle";
                cmbRoles.ValueMember = "RoleType_ID";
                cmbRoles.DataSource = list;
            }
            cmbRoles.SelectedIndex = -1;
            cmbRoles.Text = "لطفا یک آیتم را انتخاب فرمایید.";
        }
        void CmbRole()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var list = db.RoleRepository.GetAll().Where(x => x.IsActive == true).ToList();
                cmbRoleName.DisplayMember = "RoleTitle";
                cmbRoleName.ValueMember = "Role_ID";
                cmbRoleName.DataSource = list;
            }
            cmbRoleName.SelectedIndex = -1;
            cmbRoleName.Text = "لطفا یک آیتم را انتخاب فرمایید.";
        }
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var data = db.MemberRoleRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    data = data.Where(c => c.IActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    data = data.Where(c => c.IActive == false).ToList();
                }
                var Join = data.Select(s => new
                {
                    s.ID,
                    s.Role.Role_ID,
                    s.Members.Persons.PersonFullName,
                    s.Members.PersonID,
                    s.Role.RoleTitle,
                    s.RoleType.TypeTitle,
                    Date = s.DateRegestration != null ? s.DateRegestration.Value.ToShamsi() : ""

                }).ToList();
                dgvRole.DataSource = Join;
            }
            CmbRole();
            CmbRoleType();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            BindGrid();
            CmbRole();
            CmbRoleType();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShora_Click(object sender, EventArgs e)
        {
            RoleNames frm = new RoleNames();
            frm.ShowDialog();
        }

        private void cmbRoleName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnInsertMemberRole_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNatoinalCode.Text))
            {
                RtlMessageBox.Show("لطفا برای ثبت مقام کدملی را وارد فرمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNatoinalCode.Focus();
                return;
            }
            if (!Int64.TryParse(txtNatoinalCode.Text, out Int64 code))
            {
                RtlMessageBox.Show("کدملی فقط باید شامل عدد باشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Int64 NationalCodeCast = Int64.Parse(txtNatoinalCode.Text);
            using (UnitofWork db = new UnitofWork())
            {
                Members mem = db.MemberRepository.GetAll().Where(n => n.PersonID == NationalCodeCast).FirstOrDefault();
                if (mem == null)
                {
                    RtlMessageBox.Show("کدملی وارد شده یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbRoleName.SelectedIndex < 0 || cmbRoles.SelectedIndex < 0)
                {
                    RtlMessageBox.Show("لطفا مقام و وظیفه مورد نظر را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int roleTypeId = (int)cmbRoles.SelectedValue;
                int roleId = (int)cmbRoleName.SelectedValue;
                MemberRole mr = new MemberRole()
                {
                    MemID = mem.MemID,
                    RoleTypeID = roleTypeId,
                    Role_ID = roleId,
                    IActive = this.R_IsActive,
                    DateRegestration = DateTime.Now
                };
                db.MemberRoleRepository.Insert(mr);
                txtNatoinalCode.Clear();
                db.Save();
                BindGrid();
                RtlMessageBox.Show("عملیات ثبت مقام با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void ActiveStatuse(bool Active)
        {
            if (dgvRole.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvRole.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    MemberRole mr = db.MemberRoleRepository.GetAll().Where(m => m.ID == ID).FirstOrDefault();
                    if (mr == null)
                    {
                        RtlMessageBox.Show("مقام وارد شده یافت نشد.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var Get = db.MemberRoleRepository.GetbyID(ID);
                    bool IsActive = Get.IActive ?? false;
                    if (Active)
                    {
                        if (!IsActive)
                        {
                            Get.IActive = true;
                            db.MemberRoleRepository.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("فعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            RtlMessageBox.Show("این مقام از قبل فعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        if (IsActive)
                        {
                            Get.IActive = false;
                            db.MemberRoleRepository.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("غیرفعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            RtlMessageBox.Show("این نوع از قبل غیرفعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtNatoinalCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                if (dgvRole.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtNatoinalCode.Text))
                    {
                        RtlMessageBox.Show("برای فعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkActive.Checked = false;
                        txtNatoinalCode.Focus();
                        txtNatoinalCode.Clear();
                        return;
                    }
                    chkNotActive.Checked = false;
                    ActiveStatuse(true);
                    chkActive.Checked = false;
                    txtNatoinalCode.Clear();
                    BindGrid();
                }
                else
                {
                    RtlMessageBox.Show("لطفا برای عملیات فعال سازی یک سطر را ازجدول انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkActive.Checked = false;
                    txtNatoinalCode.Clear();
                }

            }
        }

        private void chkNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotActive.Checked)
            {
                if (dgvRole.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtNatoinalCode.Text))
                    {
                        RtlMessageBox.Show("برای غیرفعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkNotActive.Checked = false;
                        txtNatoinalCode.Focus();
                        txtNatoinalCode.Clear();
                        return;
                    }
                    chkActive.Checked = false;
                    ActiveStatuse(false);
                    chkNotActive.Checked = false;
                    txtNatoinalCode.Clear();
                    BindGrid();
                }
                else
                {
                    RtlMessageBox.Show("لطفا برای عملیات غیرفعال سازی یک سطر را ازجدول انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkNotActive.Checked = false;
                }
            }
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRole.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvRole.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get = db.MemberRoleRepository.GetbyID(ID);
                    if (Get != null)
                    {
                        txtNatoinalCode.Text = Get.Members.PersonID.ToString();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRole.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvRole.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get = db.MemberRoleRepository.GetbyID(ID);
                    Int64 NationalCodeCast = Int64.Parse(txtNatoinalCode.Text);

                    var member = db.MemberRepository.GetAll()
                                    .FirstOrDefault(m => m.PersonID == NationalCodeCast);

                    if (member == null)
                    {
                        RtlMessageBox.Show("کدملی وارد شده یافت نشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (cmbRoleName.SelectedIndex < 0 || cmbRoles.SelectedIndex < 0)
                    {
                        RtlMessageBox.Show("لطفا برای عملیات ویرایش مقام و وظیفه مورد نظر را از لیست انتخاب فرمایید. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int roleTypeId = (int)cmbRoles.SelectedValue;
                    int roleId = (int)cmbRoleName.SelectedValue;

                    if (Get != null)
                    {
                        Get.MemID = member.MemID;
                        Get.RoleTypeID = roleTypeId;
                        Get.Role_ID = roleId;
                    }
                    db.MemberRoleRepository.Update(Get);
                    db.Save();
                    RtlMessageBox.Show("تغییرات با موفقیت اعمال شد.");
                    txtNatoinalCode.Clear();
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا برای انجام عملیات ویرایش یک سطر از جدول را انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNatoinalCode.Clear();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt.Columns.Add("PersonFullName");
            Dt.Columns.Add("PersonID");
            Dt.Columns.Add("TypeTitle");
            Dt.Columns.Add("RoleTitle");
            Dt.Columns.Add("Date");
            foreach (DataGridViewRow item in dgvRole.Rows)
            {
                Dt.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[5].Value.ToString()

                    );
            }
            stiReport.Load(Application.StartupPath + "/ReportRole.mrt");
            stiReport.RegData("Dt", Dt);
            stiReport.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {
                dgvRole.DataSource = db.MemberEventRepository.FilterByCodeRole(txtSearch.Text);

            }
        }
    }
}
