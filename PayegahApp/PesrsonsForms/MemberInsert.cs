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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static Stimulsoft.Report.Export.StiBidirectionalConvert;

namespace PayegahApp.PesrsonsForms
{
    public partial class MemberInsert : Form
    {
        bool M_IsActive = true;
        public MemberInsert()
        {
            InitializeComponent();
        }

        private void btnInsertMember_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (!Int64.TryParse(txtNationalCode.Text, out Int64 code))
                {
                    RtlMessageBox.Show("کد باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNationalCode.Focus();
                    return;
                }
                Int64 NationalCodeCast = Int64.Parse(txtNationalCode.Text);
                using (UnitofWork db = new UnitofWork())
                {
                    Persons personCode = db.PersonsRepository.GetAll(p => p.NationalCode == NationalCodeCast).FirstOrDefault();
                    if (personCode == null)
                    {
                        RtlMessageBox.Show("کاربری با این کدملی یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Members member = db.MemberRepository.GetAll().Where(m => m.PersonID == NationalCodeCast).FirstOrDefault();
                    if (member != null)
                    {
                        RtlMessageBox.Show("عضویت تکراری است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNationalCode.Focus();
                        return;
                    }
                    var personActive = db.PersonsRepository.GetbyID(NationalCodeCast);
                    if (personActive.IsActive != true)
                    {
                        RtlMessageBox.Show("عضو غیرفعال شده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNationalCode.Focus();
                        return;
                    }
                    Members mem = new Members()
                    {
                        PersonID = personCode.NationalCode,
                        IsActive = this.M_IsActive,
                        RecordDate = DateTime.Now
                    };
                    db.MemberRepository.Insert(mem);
                    db.Save();
                    RtlMessageBox.Show("عضویت با موفقیت ثبت شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNationalCode.Clear();
                    BindGrid();
                }
            }
        }
        private void IsActiveorNot(bool activet)
        {
            using (UnitofWork db = new UnitofWork())
            {
                {
                    if (!Int64.TryParse(txtNationalCode.Text, out Int64 code))
                    {
                        RtlMessageBox.Show("کد باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNationalCode.Focus();
                        return;
                    }

                    Int64 NationalCodeCast = Int64.Parse(txtNationalCode.Text);
                    Persons personCode = db.PersonsRepository.GetAll().Where(p => p.NationalCode == NationalCodeCast).FirstOrDefault();
                    if (personCode == null)
                    {
                        RtlMessageBox.Show("کد ملی وارد شده یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var person = db.MemberRepository.GetAll().FirstOrDefault(m => m.PersonID == NationalCodeCast);
                    bool isActive = person.IsActive ?? false;
                    if (activet)
                    {
                        if (!isActive)
                        {
                            person.IsActive = true;
                            db.MemberRepository.Update(person);
                            db.Save();
                            RtlMessageBox.Show("فعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            RtlMessageBox.Show("این عضو از قبل فعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (isActive)
                        {
                            person.IsActive = false;
                            db.MemberRepository.Update(person);
                            db.Save();
                            RtlMessageBox.Show("غیرفعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            RtlMessageBox.Show("این عضو از قبل غیرفعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
        }

        private void MemberInsert_Load(object sender, EventArgs e)
        {
            dgvMember.AutoGenerateColumns = false;
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
                var data = db.MemberRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    data = data.Where(x => x.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    data = data.Where(x => x.IsActive == false).ToList();
                }
                dgvMember.DataSource = data;
            }
        }
        

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtNationalCode.Text))
                {
                    RtlMessageBox.Show("برای فعال‌سازی، لطفاً ابتدا کد مقام را وارد کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkActive.Checked = false;
                    txtNationalCode.Focus();
                    return;
                }
                chkNotActive.Checked = false;
                IsActiveorNot(true);
                chkActive.Checked = false;
                txtNationalCode.Clear();
                BindGrid();
            }
        }

        private void chkNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotActive.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtNationalCode.Text))
                {
                    RtlMessageBox.Show("برای غیرفعال‌سازی، لطفاً ابتدا کد مقام را وارد کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkNotActive.Checked = false;
                    txtNationalCode.Focus();
                    return;
                }
                chkNotActive.Checked = false;
                IsActiveorNot(false);
                chkNotActive.Checked = false;
                txtNationalCode.Clear();
            }

        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();

        }
    }
}

