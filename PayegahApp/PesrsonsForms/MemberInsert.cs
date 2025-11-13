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

                    Members mem = new Members()
                    {
                        PersonID = personCode.NationalCode,
                        //IsActive = this.M_IsActive,
                        RecordDate = DateTime.Now
                    };
                    db.MemberRepository.Insert(mem);
                    db.Save();
                    RtlMessageBox.Show("عضویت با موفقیت ثبت شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNationalCode.Clear();
                }
            }
        }
        private void valid(bool activet)
        {
            if (!Int64.TryParse(txtNationalCode.Text, out Int64 code))
            {
                RtlMessageBox.Show("کد باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNationalCode.Focus();
                return;
            }
            using (UnitofWork db = new UnitofWork())
            {
                Persons personCode = db.PersonsRepository.GetAll().Where(p => p.NationalCode == code).FirstOrDefault();
                if (personCode != null)
                {
                    RtlMessageBox.Show("کد ملی وارد شده یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var person = db.MemberRepository.GetbyID(code);
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
                        RtlMessageBox.Show("این مقام از قبل غیرفعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        private void MemberInsert_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                dgvMember.DataSource = db.MemberRepository.GetAll();
            }
        }
    }
}
