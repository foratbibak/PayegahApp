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
using ValidationComponents;

namespace PayegahApp.RollForm
{
    public partial class RoleType : Form

    {
        bool R_IsActive = true;
        public RoleType()
        {
            InitializeComponent();
        }

        private void btnInsertRoll_Click(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {

                if (BaseValidator.IsFormValid(this.components))
                {
                    if (!string.IsNullOrWhiteSpace(txtCode.Text) && !Int64.TryParse(txtCode.Text, out _))
                    {
                        RtlMessageBox.Show("کد باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCode.Focus();
                        txtCode.Clear();
                        return;
                    }
                    Int64 code = Int64.Parse(txtCode.Text);
                    string title = txtRoll.Text;
                    PayegahDataLayer.RoleType Pr = db.RoleTypeRepository.GetAll().Where(pr => pr.Code == code).FirstOrDefault();
                    if (Pr != null)
                    {
                        RtlMessageBox.Show("کد مقام وارد شده تکراری است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRoll.Clear();
                        txtCode.Clear();
                        return;
                    }

                    PayegahDataLayer.RoleType Rl = new PayegahDataLayer.RoleType()
                    {
                        TypeTitle = txtRoll.Text,
                        Code = code,
                        IsActive=this.R_IsActive,
                        DateRegstretion = DateTime.Now

                    };


                    db.RoleTypeRepository.Insert(Rl);
                    RtlMessageBox.Show("مقام با موفقیت ثبت شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.Save();
                    txtRoll.Clear();
                    txtCode.Clear();
                    BindGrid();


                }
            }
        }

        private void RollType_Load(object sender, EventArgs e)
        {
            dgvRollType.AutoGenerateColumns = false;
            dgvRollType.ForeColor = Color.Black;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            BindGrid();

        }
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var data = db.RoleTypeRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    data = data.Where(x => x.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    data = data.Where(x => x.IsActive == false).ToList();
                }
                dgvRollType.DataSource = data;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvRollType.CurrentRow.Selected)
            {
                using (UnitofWork db = new UnitofWork())
                {
                    if (BaseValidator.IsFormValid(this.components))
                    {
                        if (!string.IsNullOrWhiteSpace(txtCode.Text) && !Int64.TryParse(txtCode.Text, out _))
                        {
                            RtlMessageBox.Show("کد باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCode.Focus();
                            txtCode.Clear();
                            return;
                        }
                        Int64 Code = Int64.Parse(txtCode.Text);
                        //PayegahDataLayer.RoleType pr =db.RoleTypeRepository.GetAll().Where(p=>p.Code== Code).FirstOrDefault();
                        //if (pr != null)
                        //{
                        //    RtlMessageBox.Show("کد مقام وارد شده تکراری است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}
                        int ID = int.Parse(dgvRollType.CurrentRow.Cells[0].Value.ToString());
                        var rl = db.RoleTypeRepository.GetbyID(ID);
                        if (rl != null)
                        {
                            rl.TypeTitle = txtRoll.Text;
                            rl.Code = Code;
                        }
                        db.RoleTypeRepository.Update(rl);
                        db.Save();
                        txtCode.Clear();
                        txtRoll.Clear();
                        RtlMessageBox.Show("تغییرات با موفقیت اعمال شد.");
                        BindGrid();
                    }

                }
            }
            else
            {
                RtlMessageBox.Show("برای عملیات ویرایش لطفا عضو مورد نظر را از جدول انتخاب فرمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void dgvRollType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvRollType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!string.IsNullOrWhiteSpace(txtCode.Text) && !Int64.TryParse(txtCode.Text, out _))
                {
                    RtlMessageBox.Show("کد باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCode.Focus();
                    txtCode.Clear();
                    return;
                }
                int ID = int.Parse(dgvRollType.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var roll = db.RoleTypeRepository.GetbyID(ID);
                    if (roll != null)
                    {
                        txtRoll.Text = roll.TypeTitle;
                        txtCode.Text = roll.Code.ToString();
                    }
                }
            }
        }
        private void PersonStatus(bool activate)
        {
            if (!Int64.TryParse(txtCode.Text, out Int64 code))
            {
                RtlMessageBox.Show("کد باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Clear();
                txtCode.Focus();
                return;
            }
            using (UnitofWork db = new UnitofWork())
            {
                Int64 CodeCast2 = Int64.Parse(txtCode.Text);
                PayegahDataLayer.RoleType rt = db.RoleTypeRepository.GetAll().Where(r => r.Code == CodeCast2).FirstOrDefault();
                if (rt == null)
                {
                    RtlMessageBox.Show(" کد یافت نشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Focus();
                    return;

                }
                int CodeCast = int.Parse(txtCode.Text);
                var pr = db.RoleTypeRepository.GetAll().FirstOrDefault(p=>p.Code == CodeCast);
                bool isActive = pr.IsActive ?? false;
                if (activate)
                {
                    if (!isActive)
                    {
                        pr.IsActive = true;
                        db.RoleTypeRepository.Update(pr);
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
                    if (isActive)
                    {
                        pr.IsActive = false;
                        db.RoleTypeRepository.Update(pr);
                        db.Save();
                        RtlMessageBox.Show("غیرفعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        RtlMessageBox.Show("این مقام از قبل غیرفعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCode.Text))
                {
                    RtlMessageBox.Show("برای فعال‌سازی، لطفاً ابتدا کد مقام را وارد کنید.","توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkActive.Checked = false;
                    txtCode.Focus();
                    return;
                }
                chkNotActive.Checked = false;
                PersonStatus(true);
                chkActive.Checked = false;
                txtCode.Clear();
                BindGrid();
            }
        }

        private void chkNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotActive.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCode.Text))
                {
                    RtlMessageBox.Show("برای غیرفعال‌سازی، لطفاً ابتدا کد مقام را وارد کنید.","توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkNotActive.Checked = false;
                    txtCode.Focus();
                    return;
                }
                chkActive.Checked = false;
                PersonStatus(false);
                chkNotActive.Checked= false;
                txtCode.Clear();
                BindGrid();
                
            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFillter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
