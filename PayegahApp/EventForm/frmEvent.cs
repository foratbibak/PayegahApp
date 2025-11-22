using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayegahDataLayer;
using PayegahDataLayer.Context;

namespace PayegahApp.EventForm
{
    public partial class frmEvent : Form
    {
        bool E_IsActive = true;
        public frmEvent()
        {
            InitializeComponent();
        }

        private void btnInsertEvent_Click(object sender, EventArgs e)
        {
            frmAddEvent frm = new frmAddEvent();
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
            EventCombo();
        }

        private void frmEvent_Load(object sender, EventArgs e)
        {
            dgvEvent.AutoGenerateColumns = false;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            BindGrid();
        }
        void EventCombo()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var List = db.EventsRepository.GetAll().ToList();
                cmbEvents.DisplayMember = "EventTitle";
                cmbEvents.ValueMember = "EventID";
                cmbEvents.DataSource = List;
            }
            cmbEvents.SelectedIndex = -1;
            cmbEvents.Text = "لطفا یک مراسم را انتخاب فرمایید";
        }
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var data = db.MemberEventRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    data = data.Where(c => c.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    data = data.Where(c => c.IsActive == false).ToList();
                }
                dgvEvent.DataSource = data;
                EventCombo();
            }
        }
        private void ActiveStatuse(bool Active)
        {
            if (dgvEvent.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvEvent.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    MemberRole mr = db.MemberRoleRepository.GetAll().Where(m => m.ID == ID).FirstOrDefault();
                    if (mr == null)
                    {
                        RtlMessageBox.Show("مقام وارد شده یافت نشد.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var Get = db.MemberEventRepository.GetbyID(ID);
                    bool IsActive = Get.IsActive ?? false;
                    if (Active)
                    {
                        if (!IsActive)
                        {
                            Get.IsActive = true;
                            db.MemberEventRepository.Update(Get);
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
                            db.MemberEventRepository.Update(Get);
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

        private void button5_Click(object sender, EventArgs e)
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
                txtNatoinalCode.Focus();

            }
            Int64 NationalCodeCast = Int64.Parse(txtNatoinalCode.Text);
            using (UnitofWork db = new UnitofWork())
            {
                Members mem = db.MemberRepository.GetAll().Where(n => n.MemID == NationalCodeCast).FirstOrDefault();
                if (mem == null)
                {
                    RtlMessageBox.Show("کدملی وارد شده یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNatoinalCode.Focus();
                    return;
                }
                if (cmbEvents.SelectedIndex < 0)
                {
                    RtlMessageBox.Show("لطفا یک  مراسم را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int EventID = (int)cmbEvents.SelectedValue;

                EventMembers em = new EventMembers()
                {
                    MemID = NationalCodeCast,
                    EventID = EventID,
                    IsActive = this.E_IsActive,
                    DateRegestration = DateTime.Now
                };
                db.MemberEventRepository.Insert(em);
                db.Save();
                txtNatoinalCode.Clear();
                BindGrid();
                RtlMessageBox.Show("عملیات ثبت مقام با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void cmbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                if (dgvEvent.CurrentRow.Selected)
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
            {
                if (chkNotActive.Checked)
                {
                    if (dgvEvent.CurrentRow.Selected)
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
        }
    }
}
