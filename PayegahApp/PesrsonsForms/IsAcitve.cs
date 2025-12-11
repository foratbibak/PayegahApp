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

namespace PayegahApp.PesrsonsForms
{
    public partial class IsAcitve : Form
    {
        public int IsAcitveEdit = 0;
        public IsAcitve()
        {
            InitializeComponent();
        }

        private void btnIsActive_Click(object sender, EventArgs e)
        {
            
            using (UnitofWork db = new UnitofWork())
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    if (!Int64.TryParse(txtNationalCode.Text, out Int64 code))
                    {
                        RtlMessageBox.Show("کد ملی باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNationalCode.Focus();
                        txtNationalCode.Clear();
                        return;
                    }
                    Int64 national = Int64.Parse(txtNationalCode.Text);
                    Persons persons = db.PersonsRepository.GetAll().Where(p => p.NationalCode == national).FirstOrDefault();
                    if (persons == null)
                    {
                        RtlMessageBox.Show("کاربری با این کدملی یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNationalCode.Clear();
                        return;
                    }
                    if (persons.IsActive != true)
                    {
                        persons.IsActive = true;
                        db.PersonsRepository.Update(persons);
                        db.Save();

                        var member = db.MemberRepository.GetAll().Where(p => p.Persons.NationalCode == national).FirstOrDefault();
                        if (member != null)
                        {
                            member.IsActive = true;
                            db.MemberRepository.Update(member);
                            db.Save();
                            RtlMessageBox.Show("فعال سازی عضو با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }


                    }
                    else
                    {
                        RtlMessageBox.Show("عضو مورد نظر فعال است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void IsAcitve_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (UnitofWork db = new UnitofWork())
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    if (!string.IsNullOrWhiteSpace(txtNationalCode.Text) && !Int64.TryParse(txtNationalCode.Text, out _))
                    {
                        RtlMessageBox.Show("کد ملی باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNationalCode.Focus();
                        txtNationalCode.Clear();
                        return;
                    }
                    Int64 national = Int64.Parse(txtNationalCode.Text);
                    Persons persons = db.PersonsRepository.GetAll().Where(p => p.NationalCode == national).FirstOrDefault();
                    if (persons == null)
                    {
                        RtlMessageBox.Show("کاربری با این کدملی یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNationalCode.Clear();
                        return;
                    }

                    if (persons.IsActive == true)
                    {
                        persons.IsActive = false;
                        db.PersonsRepository.Update(persons);
                        db.Save();
                        var member = db.MemberRepository.GetAll().Where(p => p.Persons.NationalCode == national).FirstOrDefault();

                        if (member != null)
                        {
                            member.IsActive = false;
                            db.MemberRepository.Update(member);
                            db.Save();
                            RtlMessageBox.Show("غیر فعال سازی عضو با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }


                    }
                    else
                    {
                        RtlMessageBox.Show("عضو مورد نظر غیر فعال است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}


