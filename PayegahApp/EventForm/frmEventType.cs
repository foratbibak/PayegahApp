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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace PayegahApp.EventForm
{
    public partial class frmEventType : Form
    {
        bool IsActive = true;
        public frmEventType()
        {
            InitializeComponent();
        }

        private void frmEventType_Load(object sender, EventArgs e)
        {
            dgvEventType.AutoGenerateColumns = false;
            dgvEventType.ForeColor=Color.Black;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            BindGrid();

        }
        private void ConvertDatesToShamsi()
        {
            foreach (DataGridViewRow row in dgvEventType.Rows)
            {
                if (row.Cells["colDate"].Value != null &&
                    DateTime.TryParse(row.Cells["colDate"].Value.ToString(), out DateTime date))
                {
                    row.Cells["colDate"].Value = date.ToShamsi();
                }
                else
                {
                    row.Cells["colDate"].Value = "";
                }
            }
        }
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var data = db.EventTypeRopsitory.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    data = data.Where(x => x.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    data = data.Where(x => x.IsActive == false).ToList();
                }
                dgvEventType.DataSource = data;
            }
            ConvertDatesToShamsi();
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnInsertEventType_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitofWork db = new UnitofWork())
                {
                    PayegahDataLayer.EventType et = new PayegahDataLayer.EventType()
                    {
                        Title = txtTitle.Text,
                        DateRegstretion = DateTime.Now,
                        IsActive = this.IsActive
                    };
                    db.EventTypeRopsitory.Insert(et);
                    db.Save();
                    RtlMessageBox.Show("عملیات ذخیره سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid();
                }
            }
        }
        private void ActiveStatuse(bool Activate)
        {
            if (dgvEventType.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvEventType.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    EventType E = db.EventTypeRopsitory.GetAll().Where(e => e.EventTypeId == ID).FirstOrDefault();
                    if (E == null)
                    {
                        RtlMessageBox.Show("عنوان وارد شده وجود ندارد.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var Get = db.EventTypeRopsitory.GetbyID(ID);
                    bool IsActive = Get.IsActive ?? false;
                    if (Activate)
                    {
                        if (!IsActive)
                        {
                            Get.IsActive = true;
                            db.EventTypeRopsitory.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("فعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            RtlMessageBox.Show("این نوع مراسم از قبل فعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        if (IsActive)
                        {
                            Get.IsActive = false;
                            db.EventTypeRopsitory.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("غیرفعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            RtlMessageBox.Show("این نوع مراسم از قبل غیرفعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                if (dgvEventType.CurrentRow.Selected)
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
                    chkActive.Checked=false;
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
                if (dgvEventType.CurrentRow.Selected)
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

        private void dgvEventType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEventType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int ID = int.Parse(dgvEventType.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var et = db.EventTypeRopsitory.GetbyID(ID);
                    if (et != null)
                    {
                        txtTitle.Text = et.Title;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEventType.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvEventType.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get = db.EventTypeRopsitory.GetbyID(ID);
                    if (Get != null)
                    {
                        Get.Title = txtTitle.Text;
                    }
                    db.EventTypeRopsitory.Update(Get);
                    db.Save();
                    RtlMessageBox.Show("تغییرات با موفقیت اعمال شد.");
                    txtTitle.Clear();
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا برای انجام عملیات ویرایش یک سطر از جدول را انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid(); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
