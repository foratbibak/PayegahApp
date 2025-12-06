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
using ValidationComponents;

namespace PayegahApp.OperationsForm
{
    public partial class frmDgreeOperation : Form
    {
        public frmDgreeOperation()
        {
            InitializeComponent();
        }

        private void frmDgreeOperation_Load(object sender, EventArgs e)
        {
            dgvDgree.AutoGenerateColumns = false;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            dgvDgree.ForeColor = Color.Black;
            BindGrid();
        }
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var data = db.OperationDgreeRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    data = data.Where(x => x.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    data = data.Where(x => x.IsActive == false).ToList();
                }
                dgvDgree.DataSource = data;
                ConvertDatesToShamsi();
            }
        }
        private void ConvertDatesToShamsi()
        {
            foreach (DataGridViewRow row in dgvDgree.Rows)
            {
                if (row.Cells["colRegestrationDate"].Value != null &&
                    DateTime.TryParse(row.Cells["colRegestrationDate"].Value.ToString(), out DateTime date))
                {
                    row.Cells["colRegestrationDate"].Value = date.ToShamsi();
                }
                else
                {
                    row.Cells["colRegestrationDate"].Value = "";
                }
            }
        }
        private void ActiveStatuse(bool Activate)
        {
            if (dgvDgree.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvDgree.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    OperationDgree E = db.OperationDgreeRepository.GetAll().Where(e => e.DgreeID == ID).FirstOrDefault();
                    if (E == null)
                    {
                        RtlMessageBox.Show("عنوان وارد شده وجود ندارد.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var Get = db.OperationDgreeRepository.GetbyID(ID);
                    bool IsActive = Get.IsActive ?? false;
                    if (Activate)
                    {
                        if (!IsActive)
                        {
                            Get.IsActive = true;
                            db.OperationDgreeRepository.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("فعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            RtlMessageBox.Show("این نوع از قبل فعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        if (IsActive)
                        {
                            Get.IsActive = false;
                            db.OperationDgreeRepository.Update(Get);
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
        private void btnInsertDg_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitofWork db = new UnitofWork())
                {
                    OperationDgree op = new OperationDgree()
                    {
                        DgTitle = txtTitle.Text,
                        IsActive = true,
                        RegestrationDate = DateTime.Now,

                    };
                    db.OperationDgreeRepository.Insert(op);
                    db.Save();
                    txtTitle.Clear();
                    RtlMessageBox.Show("عملیات ذخیره سازی با موفقیت انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid();
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDgree.CurrentRow.Selected)
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        RtlMessageBox.Show("برای‌ ویرایش، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkActive.Checked = false;
                        txtTitle.Focus();
                        txtTitle.Clear();
                        return;
                    }
                    int ID = int.Parse(dgvDgree.CurrentRow.Cells[0].Value.ToString());
                    using (UnitofWork db = new UnitofWork())
                    {
                        var Get = db.OperationDgreeRepository.GetbyID(ID);
                        if (Get != null)
                        {
                            Get.DgTitle = txtTitle.Text;
                        }
                        db.OperationDgreeRepository.Update(Get);
                        db.Save();
                        txtTitle.Clear();
                        RtlMessageBox.Show("تغییرات با موفقیت انجام شد.", "", MessageBoxButtons.OK);
                        BindGrid();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("برای عملیات ویرایش روی عضو مورد نظر در جدول کلیک فرمایید.");
                txtTitle.Clear();
            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDgree_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDgree_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDgree.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvDgree.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get = db.OperationDgreeRepository.GetbyID(ID);
                    if (Get != null)
                    {
                        txtTitle.Text = Get.DgTitle;
                    }
                }
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                if (dgvDgree.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        RtlMessageBox.Show("برای فعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkActive.Checked = false;
                        txtTitle.Focus();
                        txtTitle.Clear();
                        return;
                    }

                    chkNotActive.Checked = false;
                    ActiveStatuse(true);
                    chkActive.Checked = false;
                    txtTitle.Clear();
                    BindGrid();

                }
                else
                {
                    RtlMessageBox.Show("لطفا برای عملیات فعال سازی یک سطر را ازجدول انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkActive.Checked = false;
                    txtTitle.Clear();
                }

            }
        }

        private void chkNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotActive.Checked)
            {
                if (dgvDgree.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        RtlMessageBox.Show("برای غیرفعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkNotActive.Checked = false;
                        txtTitle.Focus();
                        txtTitle.Clear();
                        return;
                    }
                    chkActive.Checked = false;
                    ActiveStatuse(false);
                    chkNotActive.Checked = false;
                    txtTitle.Clear();
                    BindGrid();
                }
                else
                {
                    RtlMessageBox.Show("لطفا برای عملیات غیرفعال سازی یک سطر را ازجدول انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkNotActive.Checked = false;
                }
            }
        }

        private void dgvDgree_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDgree.Columns[e.ColumnIndex].Name == "IsActive" && e.Value != null)
            {
                bool isActive = (bool)e.Value;
                e.Value = isActive ? "فعال" : "غیرفعال";
                e.FormattingApplied = true;
            }
        }
    }
}
