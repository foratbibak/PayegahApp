using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayegahDataLayer.Context;
using PayegahDataLayer;
using Accounting.utility.Convertor;
using Stimulsoft.Report;

namespace PayegahApp.Amat
{
    public partial class frmAmatMember : Form
    {
        public frmAmatMember()
        {
            InitializeComponent();
        }

        private void btnInsertEvent_Click(object sender, EventArgs e)
        {
            frmAmat frm = new frmAmat();
            frm.ShowDialog();
        }
        private void frmAmatMember_Load(object sender, EventArgs e)
        {

            dgvAmadM.AutoGenerateColumns = false;
            dgvAmadM.ForeColor = Color.Black;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("تخصیص");
            cmbFillter.Items.Add("عدم تخصیص");
            cmbFillter.SelectedIndex = 1;
            BindGrid();
        }
        //private void ConvertDatesToShamsi()
        //{
        //    foreach (DataGridViewRow row in dgvAmadM.Rows)
        //    {
        //        if (row.Cells["AmadDateRegestration"].Value != null &&
        //            DateTime.TryParse(row.Cells["AmadDateRegestration"].Value.ToString(), out DateTime date))
        //        {
        //            row.Cells["AmadDateRegestration"].Value = date.ToShamsi();
        //        }
        //        else
        //        {
        //            row.Cells["AmadDateRegestration"].Value = "";
        //        }
        //    }
        //}
        void AmCombo()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var List = db.AmadRepository.GetAll().Where(e => e.IsActive == true).ToList();
                cmbAmad.DisplayMember = "AmadFullName";
                cmbAmad.ValueMember = "AmadID";
                cmbAmad.DataSource = List;
            }
            cmbAmad.SelectedIndex = -1;
            cmbAmad.Text = "لطفا یک نوع از تجهیزات را انتخاب فرمایید";
        }

        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var data = db.AmadMemberRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "تخصیص")
                {
                    data = data.Where(c => c.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "تعمیم")
                {
                    data = data.Where(c => c.IsActive == false).ToList();
                }
                //dgvAmadM.DataSource = data.Select(s => new
                //{
                //    PersonFullName = s.Members.Persons.PersonFullName,
                //    PersonID = s.Members.PersonID,
                //    AmadFullName = s.Amad.AmadFullName,
                //    AmadDateRegestration = s.AmadDateRegestration
                //}).ToList();
                var Join = data.Select(s => new
                {
                    s.ID,
                    s.Members.Persons.PersonFullName,
                    s.Members.PersonID,
                    s.Amad.AmadTitle,
                    s.Amad.AmadType.AmadTypeTitle,
                    Date = s.AmadDateRegestration != null ? s.AmadDateRegestration.Value.ToShamsi(): ""

                }).ToList();
                dgvAmadM.DataSource = Join;
                //ConvertDatesToShamsi();
                AmCombo();
            }
        }


        private void ActiveStatuse(bool Active)
        {
            if (dgvAmadM.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvAmadM.CurrentRow.Cells[0].Value.ToString());
                Int64 NationalCodeCast = Int64.Parse(txtNatoinalCode.Text);
                using (UnitofWork db = new UnitofWork())
                {
                    Members m = db.MemberRepository.GetAll().Where(e => e.MemID == NationalCodeCast).FirstOrDefault();
                    var Get = db.AmadMemberRepository.GetbyID(ID);
                    bool IsActive = Get.IsActive ?? false;
                    if (Active)
                    {
                        if (!IsActive)
                        {
                            Get.IsActive = true;
                            db.AmadMemberRepository.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("فعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            RtlMessageBox.Show("این آماد از قبل فعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        if (IsActive)
                        {
                            Get.IsActive = false;
                            db.AmadMemberRepository.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("غیرفعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            RtlMessageBox.Show("این نوع آماد از قبل غیرفعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
        }
        private void btnInsertMem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNatoinalCode.Text))
            {
                RtlMessageBox.Show("لطفا برای ثبت تجهیزات کدملی را وارد فرمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNatoinalCode.Focus();
                return;
            }

            if (!Int64.TryParse(txtNatoinalCode.Text, out Int64 NationalCodeCast))
            {
                RtlMessageBox.Show("کدملی فقط باید شامل عدد باشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNatoinalCode.Focus();
                return;
            }

            using (UnitofWork db = new UnitofWork())
            {
                Members mem = db.MemberRepository.GetAll().FirstOrDefault(n => n.PersonID == NationalCodeCast);
                if (mem == null)
                {
                    RtlMessageBox.Show("کدملی وارد شده یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNatoinalCode.Focus();
                    return;
                }

                if (cmbAmad.SelectedIndex < 0 || cmbAmad.SelectedValue == null)
                {
                    RtlMessageBox.Show("لطفا تجهیزات را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(cmbAmad.SelectedValue.ToString(), out int AmadIDCast))
                {
                    RtlMessageBox.Show("مقدار انتخاب‌شده معتبر نیست.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AmadMembers amm = new AmadMembers()
                {
                    MemID = mem.MemID,
                    AmadID = AmadIDCast,
                    IsActive = true,
                    AmadDateRegestration = DateTime.Now
                };

                db.AmadMemberRepository.Insert(amm);
                db.Save();

                txtNatoinalCode.Clear();
                BindGrid();

                RtlMessageBox.Show("ثبت عملیات با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnEditMem_Click(object sender, EventArgs e)
        {
            if (dgvAmadM.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvAmadM.CurrentRow.Cells[0].Value.ToString());
                Int64 NationalCodeCast = Int64.Parse(txtNatoinalCode.Text);
                using (UnitofWork db = new UnitofWork())
                {
                    Members em = db.MemberRepository.GetAll().Where(m => m.PersonID == NationalCodeCast).FirstOrDefault();
                    if (em == null)
                    {
                        RtlMessageBox.Show("کدملی وارد شده یافت نشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var Get = db.AmadMemberRepository.GetbyID(ID);
                    if (cmbAmad.SelectedIndex < 0)
                    {
                        RtlMessageBox.Show("لطفا یک  آماد را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int AmadIDCast = (int)cmbAmad.SelectedValue;
                    if (Get != null)
                    {
                        Get.MemID = em.MemID;
                        Get.AmadID = AmadIDCast;
                    }
                    db.AmadMemberRepository.Update(Get);
                    db.Save();
                    RtlMessageBox.Show("تغییرات با موفقیت اعمال شد.");
                    txtNatoinalCode.Clear();
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا برای عملیات ویراش روی یک سطر از جدول کلیک کنید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
            AmCombo();
        }

        private void dgvAmadM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAmadM.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvAmadM.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get = db.AmadMemberRepository.GetbyID(ID);
                    if (Get != null)
                    {
                        txtNatoinalCode.Text = Get.Members.PersonID.ToString();
                    }
                }
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                if (dgvAmadM.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtNatoinalCode.Text))
                    {
                        RtlMessageBox.Show("برای تخصیص، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    RtlMessageBox.Show("لطفا برای عملیات تخصیص یک سطر را ازجدول انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkActive.Checked = false;
                    txtNatoinalCode.Clear();
                }

            }
        }

        private void chkNotActive_CheckedChanged(object sender, EventArgs e)
        {

            if (chkNotActive.Checked)
            {
                if (dgvAmadM.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtNatoinalCode.Text))
                    {
                        RtlMessageBox.Show("برای ‌،عدم تخصیص لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    BindGrid();
                }
                else
                {
                    RtlMessageBox.Show("لطفا برای عملیات عدم تخصیص یک سطر را ازجدول انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkNotActive.Checked = false;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt.Columns.Add("PersonFullName");
            Dt.Columns.Add("PersonID");
            Dt.Columns.Add("AmadTitle");
            Dt.Columns.Add("AmadTypeTitle");
            Dt.Columns.Add("Date");

            foreach (DataGridViewRow item in dgvAmadM.Rows)
            {
                Dt.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[5].Value.ToString()



                    );
            }
            stiReport.Load(Application.StartupPath + "/ReportAmad.mrt");
            stiReport.RegData("Dt", Dt);
            stiReport.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {
                dgvAmadM.DataSource = db.MemberEventRepository.FillterByCodeAmad(txtSearch.Text);

            }
        }
    }
}
