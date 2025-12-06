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

namespace PayegahApp.EventForm
{
    public partial class frmAddEvent : Form
    {
        bool E_Active = true;
        public frmAddEvent()
        {
            InitializeComponent();
        }

        private void btnEventType_Click(object sender, EventArgs e)
        {
            frmEventType frm = new frmEventType();
            frm.ShowDialog();
        }

        private void frmAddEvent_Load(object sender, EventArgs e)
        {
            dgvEvent.AutoGenerateColumns = false;
            dgvEvent.ForeColor = Color.Black;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            BindGrid();
            cmbEventType();

        }
        //private void ConvertDatesToShamsi()
        //{
        //    foreach (DataGridViewRow row in dgvEvent.Rows)
        //    {
        //        if (row.Cells["colEventDate"].Value != null &&
        //            DateTime.TryParse(row.Cells["colEventDate"].Value.ToString(), out DateTime date))
        //        {
        //            row.Cells["colEventDate"].Value = date.ToShamsi();
        //        }
        //        else
        //        {
        //            row.Cells["colEventDate"].Value = "";
        //        }
        //    }
        //}
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var data = db.EventsRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    data = data.Where(c => c.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    data = data.Where(c => c.IsActive == false).ToList();
                }
                var Join = data.Select(s => new
                {
                    s.EventID,
                    s.EventTitle,
                    s.EventType.Title,
                    s.Description,
                    Date = s.EventDate != null ? s.EventDate.ToShamsi() : "",
                    s.IsActive

                }).ToList();
                dgvEvent.DataSource = Join;
            }
        }
        void cmbEventType()
        {
            using (UnitofWork db = new UnitofWork())
            {

                var list = db.EventTypeRopsitory.GetAll().Where(e=>e.IsActive==true).ToList();
                cmbEvent.DisplayMember = "Title";
                cmbEvent.ValueMember = "EventTypeId";
                cmbEvent.DataSource = list;
            }
            cmbEvent.SelectedIndex = -1;
            cmbEvent.Text = "لطفا یک آیتم را انتخاب فرمایید";
        }
        private void cmbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void ActiveStatus(bool IsActive)
        {
            if (dgvEvent.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvEvent.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    Events E = db.EventsRepository.GetAll().Where(e => e.EventID == ID).FirstOrDefault();
                    if (E == null)
                    {
                        RtlMessageBox.Show("عنوان وارد شده وجود ندارد.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var Get = db.EventsRepository.GetbyID(ID);
                    bool Active = Get.IsActive ?? false;
                    if (IsActive)
                    {
                        if (!Active)
                        {
                            Get.IsActive = true;
                            db.EventsRepository.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("فعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            RtlMessageBox.Show("این مراسم از قبل فعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (Active)
                        {
                            Get.IsActive = false;
                            db.EventsRepository.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("غیرفعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            RtlMessageBox.Show("این مراسم از قبل غیرفعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
        }
        private void btnInsertEvent_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (cmbEvent.SelectedIndex < 0)
                {
                    RtlMessageBox.Show("لطفا نوع مراسم را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
          
                using (UnitofWork db = new UnitofWork())
                {
                    int EventType = (int)cmbEvent.SelectedValue;
                    Events et = new Events()
                    {
                        EventTitle = txtTitle.Text,
                        EventTypeID = EventType,
                        Description = txtDescription.Text,
                        IsActive = this.E_Active,
                        EventDate = DateTime.Now,

                    };
                    db.EventsRepository.Insert(et);
                    db.Save();

                    txtTitle.Clear();
                    txtDescription.Clear();
                    RtlMessageBox.Show("عملیات ذخیره سازی با موفقیت انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid();
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
            cmbEventType();
        }

        private void dgvEvent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEvent.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvEvent.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get = db.EventsRepository.GetbyID(ID);
                    if (Get != null)
                    {
                        txtTitle.Text = Get.EventTitle;
                        txtDescription.Text = Get.Description;
                    }
                    else
                    {
                        RtlMessageBox.Show("عملیات با شکست مواجه شد برنامه دوباره راه اندازی کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEvent.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvEvent.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    if (cmbEvent.SelectedIndex < 0)
                    {
                        RtlMessageBox.Show("لطفا نوع مراسم را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int EventType = (int)cmbEvent.SelectedValue;
                    var Get = db.EventsRepository.GetbyID(ID);
                    if (Get != null)
                    {
                        Get.EventTitle = txtTitle.Text;
                        Get.Description = txtDescription.Text;
                        Get.EventTypeID = EventType;
                    }
                    db.EventsRepository.Update(Get);
                    db.Save();
                    RtlMessageBox.Show("تغییرات با موفقیت اعمال شد.");
                    txtTitle.Clear();
                    txtDescription.Clear();
                    cmbEvent.SelectedIndex = -1;
                    BindGrid();
                }
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if(chkActive.Checked)
            {
                if (dgvEvent.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        RtlMessageBox.Show("برای فعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkNotActive.Checked = false;
                        txtTitle.Focus();
                        return;
                    }
                    chkNotActive.Checked = false;
                    ActiveStatus(true);
                    chkActive.Checked = false;
                    txtTitle.Clear();
                    txtDescription.Clear();
                    BindGrid();
                }
                else
                {
                    RtlMessageBox.Show("لطفا برای عملیات فعال سازی یک سطر را ازجدول انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkActive.Checked = false;
                }
            }
        }

        private void chkNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotActive.Checked)
            {
                if (dgvEvent.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        RtlMessageBox.Show("برای فعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkNotActive.Checked = false;
                        txtTitle.Focus();
                        return;
                    }
                    chkActive.Checked = false;
                    ActiveStatus(false);
                    chkNotActive.Checked = false;
                    txtTitle.Clear();
                    txtDescription.Clear();
                    BindGrid();
                }
                else
                {
                    RtlMessageBox.Show("لطفا برای عملیات غیرفعال سازی یک سطر را ازجدول انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkNotActive.Checked = false;
                }
            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dgvEvent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEvent.Columns[e.ColumnIndex].Name == "IsActive" && e.Value != null)
            {
                bool isActive = (bool)e.Value;
                e.Value = isActive ? "فعال" : "غیرفعال";
                e.FormattingApplied = true;
            }
        }
    }
}
