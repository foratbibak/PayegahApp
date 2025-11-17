using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayegahDataLayer;
using PayegahDataLayer.Context;
using ValidationComponents;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace PayegahApp.RoleForm
{
    public partial class RoleNames : Form
    {
        bool R_Active = true;
        public RoleNames()
        {
            InitializeComponent();
        }

        private void btnInsertRoll_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitofWork db = new UnitofWork())
                {
                    string defaultText = "نامشخص";

                    Role r = new Role()
                    {
                        RoleTitle = txtInsert.Text,
                        Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? defaultText : txtDescription.Text,
                        IsActive = this.R_Active,
                        RegstretionDate = DateTime.Now
                    };
                    db.RoleRepository.Insert(r);
                    db.Save();
                    RtlMessageBox.Show("عملیات موفقیت آمیز بود", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid();

                }
            }

        }
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var data = db.RoleRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    data = data.Where(r => r.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    data = data.Where(r => r.IsActive == false).ToList();
                }
                dgvRole.DataSource = data;

            }
        }

        private void RoleNames_Load(object sender, EventArgs e)
        {
            dgvRole.AutoGenerateColumns = false;

            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            BindGrid();
        }
        private void ActiveStatus(bool Active)
        {
            if (dgvRole.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvRole.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get=db.RoleRepository.GetbyID(ID);
                    bool IsActive = Get.IsActive ?? false;
                    if(Active)
                    {
                        if (!IsActive)
                        {
                            Get.IsActive = true;
                            db.RoleRepository.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("فعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            RtlMessageBox.Show("این شورا از قبل فعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        
                    }
                    else
                    {
                        if (IsActive)
                        {
                            Get.IsActive = false;
                            db.RoleRepository.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("غیرفعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            RtlMessageBox.Show("این شورا از قبل غیرفعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک سطر را در جدول برای عملیات انتخاب فرمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dgvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void btnEdt_Click(object sender, EventArgs e)
        {
            if (dgvRole.CurrentRow.Selected)
            {
                using (UnitofWork db = new UnitofWork())
                {
                    int ID = int.Parse(dgvRole.CurrentRow.Cells[0].Value.ToString());
                    var RoleGet = db.RoleRepository.GetbyID(ID);
                    if (RoleGet != null)
                    {
                        RoleGet.RoleTitle = txtInsert.Text;
                        RoleGet.Description = txtDescription.Text;
                    }
                    db.RoleRepository.Update(RoleGet);
                    db.Save();
                    RtlMessageBox.Show("تغییرات با موفقیت اعمال شد.");
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک سطر را در جدول برای عملیات انتخاب فرمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int ID = int.Parse(dgvRole.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var roll = db.RoleRepository.GetbyID(ID);
                    if (roll != null)
                    {
                        txtInsert.Text = roll.RoleTitle;
                        txtDescription.Text = roll.Description;
                    }
                }
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if(chkActive.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtInsert.Text))
                {
                    RtlMessageBox.Show("برای فعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkActive.Checked = false;
                    return;
                }
                if (dgvRole.CurrentRow.Selected)
                {
                    ActiveStatus(true);
                    chkActive.Checked = false;
                    txtInsert.Clear();
                    txtDescription.Clear();
                    BindGrid();
                }
            }
        }

        private void chkNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotActive.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtInsert.Text))
                {
                    RtlMessageBox.Show("برای غیرفعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkNotActive.Checked = false;
                    return;
                }
                if (dgvRole.CurrentRow.Selected)
                {
                    chkActive.Checked = false;
                    ActiveStatus(false);
                    chkNotActive.Checked = false;
                    txtInsert.Clear();
                    txtDescription.Clear();
                    BindGrid();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
