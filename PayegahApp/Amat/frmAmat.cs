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
    public partial class frmAmat : Form
    {
        public frmAmat()
        {
            InitializeComponent();
        }



        private void frmAmat_Load(object sender, EventArgs e)
        {
            dgvAmad.AutoGenerateColumns = false;
            dgvAmad.ForeColor = Color.Black;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            BindGrid();
            cmbAmad();

        }
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var data = db.AmadRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    data = data.Where(c => c.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    data = data.Where(c => c.IsActive == false).ToList();
                }
                dgvAmad.DataSource = data;
            }
        }
        void cmbAmad()
        {
            using (UnitofWork db = new UnitofWork())
            {

                var list = db.AmadTypeRepository.GetAll().Where(e => e.IsActive == true).ToList();
                cmbAmadType.DisplayMember = "AmadTitle";
                cmbAmadType.ValueMember = "AmadTypeIID";
                cmbAmadType.DataSource = list;
            }
            cmbAmadType.SelectedIndex = -1;
            cmbAmadType.Text = "لطفا یک آیتم را انتخاب فرمایید";
        }
        private void ActiveStatus(bool IsActive)
        {
            if (dgvAmad.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvAmad.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    Amad E = db.AmadRepository.GetAll().Where(e => e.AmadID == ID).FirstOrDefault();
                    if (E == null)
                    {
                        RtlMessageBox.Show("عنوان وارد شده وجود ندارد.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var Get = db.AmadRepository.GetbyID(ID);
                    bool Active = Get.IsActive ?? false;
                    if (IsActive)
                    {
                        if (!Active)
                        {
                            Get.IsActive = true;
                            db.AmadRepository.Update(Get);
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
                            db.AmadRepository.Update(Get);
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
        private void btnInsertAmad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                RtlMessageBox.Show("عنوان تجهیزات را وارد فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                RtlMessageBox.Show("کد تجهیزات را وارد فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Int64 CodeCast = Int64.Parse(txtCode.Text);
            if (cmbAmadType.SelectedIndex < 0)
            {
                RtlMessageBox.Show("لطفا نوع مراسم را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            using (UnitofWork db = new UnitofWork())
            {
                int EventType = (int)cmbAmadType.SelectedValue;
                Amad et = new Amad()
                {
                    AmadTitle = txtTitle.Text,
                    AmadTypeId = EventType,
                    AmadCode = CodeCast,
                    IsActive = true,
                    AmadDate = DateTime.Now
                };
                db.AmadRepository.Insert(et);
                txtTitle.Clear();
                txtCode.Clear();
                db.Save();
                RtlMessageBox.Show("عملیات ذخیره سازی با موفقیت انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGrid();
            }

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAmad.CurrentRow.Selected)
            {
                Int64 CodeCast = Int64.Parse(txtCode.Text);
                if (string.IsNullOrWhiteSpace(txtCode.Text))
                {
                    RtlMessageBox.Show("کد تجهیزات را وارد فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    RtlMessageBox.Show("عنوان تجهیزات را وارد فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!Int64.TryParse(txtCode.Text, out Int64 code))
                {
                    RtlMessageBox.Show("کدملی فقط باید شامل عدد باشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCode.Focus();
                    return;

                }
                int ID = int.Parse(dgvAmad.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    if (cmbAmadType.SelectedIndex < 0)
                    {
                        RtlMessageBox.Show("لطفا نوع مراسم را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int AmadType = (int)cmbAmadType.SelectedValue;
                    var Get = db.AmadRepository.GetbyID(ID);
                    if (Get != null)
                    {
                        Get.AmadTitle = txtTitle.Text;
                        Get.AmadCode = CodeCast;
                        Get.AmadTypeId = AmadType;
                    }
                    db.AmadRepository.Update(Get);
                    db.Save();
                    RtlMessageBox.Show("تغییرات با موفقیت اعمال شد.");
                    txtTitle.Clear();
                    txtCode.Clear();
                    cmbAmadType.SelectedIndex = -1;
                    BindGrid();
                }
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
                if (dgvAmad.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        RtlMessageBox.Show("برای فعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chkActive.Checked = false;
                        txtTitle.Focus();
                        return;
                    }
                    chkActive.Checked = false;
                    ActiveStatus(true);
                    chkNotActive.Checked = false;
                    txtTitle.Clear();
                    txtCode.Clear();
                    BindGrid();
                }
                else
                {
                    RtlMessageBox.Show("لطفا برای عملیات فعال سازی یک سطر را ازجدول انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkActive.Checked = false;
                    txtTitle.Clear();
                    txtCode.Clear();
                }
            }
        }

        private void chkNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotActive.Checked)
            {
                if (dgvAmad.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        RtlMessageBox.Show("برای غیرفعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chkNotActive.Checked = false;
                        txtTitle.Focus();
                        return;
                    }
                    chkActive.Checked = false;
                    ActiveStatus(false);
                    chkNotActive.Checked = false;
                    txtTitle.Clear();
                    txtCode.Clear();
                    BindGrid();
                }
                else
                {
                    RtlMessageBox.Show("لطفا برای عملیات غیرفعال سازی یک سطر را ازجدول انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkNotActive.Checked = false;
                    txtTitle.Clear();
                    txtCode.Clear();
                }
            }
        }

        private void btnAmadType_Click(object sender, EventArgs e)
        {
            frmAmatType frm = new frmAmatType();
            frm.ShowDialog();
        }

        private void dgvAmad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAmad.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvAmad.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get = db.AmadRepository.GetbyID(ID);
                    if (Get != null)
                    {
                        txtTitle.Text = Get.AmadTitle;
                        txtCode.Text = Get.AmadCode.ToString();
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
            cmbAmad();
        }
    }
}
