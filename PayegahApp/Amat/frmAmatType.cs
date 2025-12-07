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
using ValidationComponents;
using Accounting.utility.Convertor;

namespace PayegahApp.Amat
{
    public partial class frmAmatType : Form
    {
        public frmAmatType()
        {
            InitializeComponent();
        }

        private void frmAmatType_Load(object sender, EventArgs e)
        {
            dgvAmatType.ForeColor = Color.Black;
            dgvAmatType.AutoGenerateColumns = false;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            BindGrid();

        }
        private void ConvertDatesToShamsi()
        {
            foreach (DataGridViewRow row in dgvAmatType.Rows)
            {
                if (row.Cells["DateRegistration"].Value != null &&
                    DateTime.TryParse(row.Cells["DateRegistration"].Value.ToString(), out DateTime date))
                {
                    row.Cells["DateRegistration"].Value = date.ToShamsi();
                }
                else
                {
                    row.Cells["DateRegistration"].Value = "";
                }
            }
        }
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var Data = db.AmadTypeRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    Data = Data.Where(o => o.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    Data = Data.Where(o => o.IsActive == false).ToList();
                }
                dgvAmatType.DataSource = Data;
                ConvertDatesToShamsi();
            }
        }
        private void ActiveStatuse(bool Active)
        {
            int ID = int.Parse(dgvAmatType.CurrentRow.Cells[0].Value.ToString());
            using (UnitofWork db = new UnitofWork())
            {
                AmadType op = db.AmadTypeRepository.GetAll().Where(o => o.AmadTypeIID == ID).FirstOrDefault();
                if (op == null)
                {
                    RtlMessageBox.Show("این نوع عملیات وارد شده وجود ندارد لطفا جدول را بروزرسانی کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var Get = db.AmadTypeRepository.GetbyID(ID);
                bool IsActive = Get.IsActive ?? false;
                if (Active)
                {
                    if (!IsActive)
                    {
                        Get.IsActive = true;
                        db.AmadTypeRepository.Update(Get);
                        db.Save();
                        RtlMessageBox.Show("فعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        RtlMessageBox.Show("این نوع عملیات از قبل فعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    if (IsActive)
                    {
                        Get.IsActive = false;
                        db.AmadTypeRepository.Update(Get);
                        db.Save();
                        RtlMessageBox.Show("غیرفعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        RtlMessageBox.Show("این نوع عملیات از قبل غیرفعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void btnInsertAmatType_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitofWork db = new UnitofWork())
                {
                    AmadType at = new AmadType()
                    {
                        AmadTypeTitle = txtTitle.Text,
                        DateRegistration = DateTime.Now,
                        IsActive = true
                    };
                    db.AmadTypeRepository.Insert(at);
                    db.Save();
                    txtTitle.Clear();
                    RtlMessageBox.Show("عملیات ذخیره سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid();
                }


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAmatType.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvAmatType.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get = db.AmadTypeRepository.GetbyID(ID);
                    if (Get != null)
                    {
                        Get.AmadTypeTitle = txtTitle.Text;
                    }
                    db.AmadTypeRepository.Update(Get);
                    db.Save();
                    RtlMessageBox.Show("تغییرات با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTitle.Clear();
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا برای عملیات ویرایش روی یک سطر از جدول کلیک کنید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Clear();
            }
        }

        private void dgvAmatType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAmatType.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvAmatType.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get = db.AmadTypeRepository.GetbyID(ID);
                    if (Get != null)
                    {
                        txtTitle.Text = Get.AmadTypeTitle;
                    }
                }
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                if (dgvAmatType.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        RtlMessageBox.Show("برای فعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chkActive.Checked = false;
                        txtTitle.Focus();
                        return;
                    }
                    chkActive.Checked = false;
                    ActiveStatuse(true);
                    chkNotActive.Checked = false;
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
                if (dgvAmatType.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        RtlMessageBox.Show("برای غیرفعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chkNotActive.Checked = false;
                        txtTitle.Focus();
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
                    txtTitle.Clear();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dgvAmatType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAmatType.Columns[e.ColumnIndex].Name == "IsActive" && e.Value != null)
            {
                bool isActive = (bool)e.Value;
                e.Value = isActive ? "فعال" : "غیرفعال";
                e.FormattingApplied = true;
            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
