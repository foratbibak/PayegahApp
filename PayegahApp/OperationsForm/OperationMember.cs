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
using PayegahDataLayer;
using PayegahDataLayer.Context;
using Stimulsoft.Report;

namespace PayegahApp.OperationsForm
{
    public partial class OperationMember : Form
    {
        public OperationMember()
        {
            InitializeComponent();
        }

        private void btnInsertOp_Click(object sender, EventArgs e)
        {
            frmAddOperation frm = new frmAddOperation();
            frm.ShowDialog();
        }

        private void btnDgree_Click(object sender, EventArgs e)
        {
            frmDgreeOperation frm = new frmDgreeOperation();
            frm.ShowDialog();
        }

        private void OperationMember_Load(object sender, EventArgs e)
        {
            dgvOpM.ForeColor = Color.Black;
            dgvOpM.AutoGenerateColumns = false;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            BindGrid();
        }
        private void ConvertDatesToShamsi()
        {
            foreach (DataGridViewRow row in dgvOpM.Rows)
            {
                if (row.Cells["colDateRegestration"].Value != null &&
                    DateTime.TryParse(row.Cells["colDateRegestration"].Value.ToString(), out DateTime date))
                {
                    row.Cells["colDateRegestration"].Value = date.ToShamsi();
                }
                else
                {
                    row.Cells["colDateRegestration"].Value = "";
                }
            }
        }
        void OPCombo()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var List = db.OperationsRepository.GetAll().Where(e => e.IsActive == true).ToList();
                cmbOperations.DisplayMember = "OPFullName";
                cmbOperations.ValueMember = "OperationID";
                cmbOperations.DataSource = List;
            }
            cmbOperations.SelectedIndex = -1;
            cmbOperations.Text = "لطفا یک مراسم را انتخاب فرمایید";
        }
        void DgreeCombo()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var List = db.OperationDgreeRepository.GetAll().Where(e => e.IsActive == true).ToList();
                cmbDgree.DisplayMember = "DgTitle";
                cmbDgree.ValueMember = "DgreeID";
                cmbDgree.DataSource = List;
            }
            cmbDgree.SelectedIndex = -1;
            cmbDgree.Text = "لطفا یک مراسم را انتخاب فرمایید";
        }
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var data = db.OperationMembersRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    data = data.Where(c => c.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    data = data.Where(c => c.IsActive == false).ToList();
                }
                dgvOpM.DataSource = data;
                ConvertDatesToShamsi();
                OPCombo();
                DgreeCombo();
            }
        }
        private void ActiveStatuse(bool Active)
        {
            if (dgvOpM.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvOpM.CurrentRow.Cells[0].Value.ToString());
                Int64 NationalCodeCast = Int64.Parse(txtNatoinalCode.Text);
                using (UnitofWork db = new UnitofWork())
                {
                    Members m = db.MemberRepository.GetAll().Where(e => e.MemID == NationalCodeCast).FirstOrDefault();
                    var Get = db.OperationMembersRepository.GetbyID(ID);
                    bool IsActive = Get.IsActive ?? false;
                    if (Active)
                    {
                        if (!IsActive)
                        {
                            Get.IsActive = true;
                            db.OperationMembersRepository.Update(Get);
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
                            Get.IsActive = false;
                            db.OperationMembersRepository.Update(Get);
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
            OPCombo();
            DgreeCombo();
        }

        private void btnInsertMem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNatoinalCode.Text))
            {
                RtlMessageBox.Show("لطفا برای ثبت عملیات کدملی را وارد فرمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNatoinalCode.Focus();
                return;
            }
            if (!Int64.TryParse(txtNatoinalCode.Text, out Int64 code))
            {
                RtlMessageBox.Show("کدملی فقط باید شامل عدد باشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNatoinalCode.Focus();
                return;

            }
            Int64 NationalCodeCast = Int64.Parse(txtNatoinalCode.Text);
            using (UnitofWork db = new UnitofWork())
            {
                Members mem = db.MemberRepository.GetAll().Where(n => n.PersonID == NationalCodeCast).FirstOrDefault();
                if (mem == null)
                {
                    RtlMessageBox.Show("کدملی وارد شده یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNatoinalCode.Focus();
                    return;
                }
                if (cmbOperations.SelectedIndex < 0 || cmbDgree.SelectedIndex < 0)
                {
                    RtlMessageBox.Show("لطفا عملیات و مسئولیت را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int OPIDCast = (int)cmbOperations.SelectedValue;
                int DGIDCast = (int)cmbDgree.SelectedValue;

                OperationMembers om = new OperationMembers()
                {
                    MemID = mem.MemID,
                    OperationID = OPIDCast,
                    DgreeID = DGIDCast,
                    IsActive = true,
                    DateRegstration = DateTime.Now
                };
                db.OperationMembersRepository.Insert(om);
                db.Save();
                txtNatoinalCode.Clear();
                BindGrid();
                RtlMessageBox.Show(" ثبت عملیات با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void btnEditMem_Click(object sender, EventArgs e)
        {
            if (dgvOpM.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvOpM.CurrentRow.Cells[0].Value.ToString());
                Int64 NationalCodeCast = Int64.Parse(txtNatoinalCode.Text);
                using (UnitofWork db = new UnitofWork())
                {
                    Members em = db.MemberRepository.GetAll().Where(m => m.MemID == NationalCodeCast).FirstOrDefault();
                    var Get = db.OperationMembersRepository.GetbyID(ID);
                    if (cmbOperations.SelectedIndex < 0 || cmbDgree.SelectedIndex < 0)
                    {
                        RtlMessageBox.Show("لطفا عملیات و مسئولیت را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int OPIDCast = (int)cmbOperations.SelectedValue;
                    int DGIDCast = (int)cmbDgree.SelectedValue;
                    if (Get != null)
                    {
                        Get.MemID = NationalCodeCast;
                        Get.OperationID = OPIDCast;
                        Get.DgreeID = DGIDCast;
                    }
                    db.OperationMembersRepository.Update(Get);
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

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                if (dgvOpM.CurrentRow.Selected)
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
                if (dgvOpM.CurrentRow.Selected)
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
                    BindGrid();
                }
                else
                {
                    RtlMessageBox.Show("لطفا برای عملیات غیرفعال سازی یک سطر را ازجدول انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkNotActive.Checked = false;
                }
            }
        }

        private void dgvOpM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOpM.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvOpM.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get = db.OperationMembersRepository.GetbyID(ID);
                    if (Get != null)
                    {
                        txtNatoinalCode.Text=Get.MemID.ToString();
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt.Columns.Add("colMemID");
            Dt.Columns.Add("colOperationID");
            Dt.Columns.Add("colDgreeID");
            Dt.Columns.Add("colDateRegestration");
            foreach (DataGridViewRow item in dgvOpM.Rows)
            {
                Dt.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString()

                    );
            }
            stiReport.Load(Application.StartupPath + "/ReportOperation.mrt");
            stiReport.RegData("Dt", Dt);
            stiReport.Show();
        }
    }
}