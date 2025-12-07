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

namespace PayegahApp.PesrsonsForms
{
    public partial class frmAddorEdit : Form
    {
        public Int64 P_NationalCode = 0;
        bool P_IsActive = true;
        public frmAddorEdit()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnSabt_Click(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {
                if (!BaseValidator.IsFormValid(this.components))
                    return;

                if (!string.IsNullOrWhiteSpace(txtNationalCode.Text) && !Int64.TryParse(txtNationalCode.Text, out _))
                {
                    RtlMessageBox.Show("کد ملی باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNationalCode.Focus();
                    return;
                }

                Int64 nationalCast = Int64.Parse(txtNationalCode.Text);
                string defaultText = "نامشخص";

                if (P_NationalCode == 0)
                {
                    var existingPerson = db.PersonsRepository.GetAll()
                                            .FirstOrDefault(p => p.NationalCode == nationalCast);
                    if (existingPerson != null)
                    {
                        RtlMessageBox.Show("عضو وارد شده تکراری است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Persons newPerson = new Persons()
                    {
                        NationalCode = nationalCast,
                        PersonName = string.IsNullOrWhiteSpace(txtName.Text) ? defaultText : txtName.Text,
                        PersonFamily = string.IsNullOrWhiteSpace(txtFamily.Text) ? defaultText : txtFamily.Text,
                        PersonAddress = string.IsNullOrWhiteSpace(txtAddress.Text) ? defaultText : txtAddress.Text,
                        PostalCode = string.IsNullOrWhiteSpace(txtPstalCode.Text) ? defaultText : txtPstalCode.Text,
                        PhoneNumber = string.IsNullOrWhiteSpace(txtPhone.Text) ? defaultText : txtPhone.Text,
                        Birthday = string.IsNullOrWhiteSpace(txtBirthday.Text) ? defaultText : txtBirthday.Text,
                        FotherJob = string.IsNullOrWhiteSpace(txtFotherJob.Text) ? defaultText : txtFotherJob.Text,
                        MotherJob = string.IsNullOrWhiteSpace(txtMotherJob.Text) ? defaultText : txtMotherJob.Text,
                        FotherPhoneNumber = string.IsNullOrWhiteSpace(txtFotherPhone.Text) ? defaultText : txtFotherPhone.Text,
                        MotherPhoneNumber = string.IsNullOrWhiteSpace(txtMotherPhone.Text) ? defaultText : txtMotherPhone.Text,
                        RegistrationDate = DateTime.Now,
                        IsActive = this.P_IsActive
                    };

                    db.PersonsRepository.Insert(newPerson);
                    db.Save();

                    Members mem = new Members()
                    {
                        PersonID = newPerson.NationalCode,
                        IsActive = this.P_IsActive,
                        RecordDate = DateTime.Now
                    };
                    db.MemberRepository.Insert(mem);
                    db.Save();

                    DialogResult = DialogResult.OK;
                    RtlMessageBox.Show("عملیات ذخیره سازی با موفقیت انجام شد");
                }
                else
                {
                    var person = db.PersonsRepository.GetAll().Where(p => p.NationalCode == nationalCast && p.NationalCode != P_NationalCode).FirstOrDefault();

                    if (person != null)
                    {
                        RtlMessageBox.Show("کدملی وارد شده تکراری است");
                        txtNationalCode.Focus();
                        return;
                    }



                    var existingPerson = db.PersonsRepository.GetbyID(P_NationalCode);
                    if (existingPerson != null)
                    {
                        existingPerson.NationalCode = nationalCast;
                        existingPerson.PersonName = string.IsNullOrWhiteSpace(txtName.Text) ? defaultText : txtName.Text;
                        existingPerson.PersonFamily = string.IsNullOrWhiteSpace(txtFamily.Text) ? defaultText : txtFamily.Text;
                        existingPerson.PersonAddress = string.IsNullOrWhiteSpace(txtAddress.Text) ? defaultText : txtAddress.Text;
                        existingPerson.PostalCode = string.IsNullOrWhiteSpace(txtPstalCode.Text) ? defaultText : txtPstalCode.Text;
                        existingPerson.PhoneNumber = string.IsNullOrWhiteSpace(txtPhone.Text) ? defaultText : txtPhone.Text;
                        existingPerson.Birthday = string.IsNullOrWhiteSpace(txtBirthday.Text) ? defaultText : txtBirthday.Text;
                        existingPerson.FotherJob = string.IsNullOrWhiteSpace(txtFotherJob.Text) ? defaultText : txtFotherJob.Text;
                        existingPerson.MotherJob = string.IsNullOrWhiteSpace(txtMotherJob.Text) ? defaultText : txtMotherJob.Text;
                        existingPerson.FotherPhoneNumber = string.IsNullOrWhiteSpace(txtFotherPhone.Text) ? defaultText : txtFotherPhone.Text;
                        existingPerson.MotherPhoneNumber = string.IsNullOrWhiteSpace(txtMotherPhone.Text) ? defaultText : txtMotherPhone.Text;
                        existingPerson.IsActive = this.P_IsActive;

                        db.PersonsRepository.Update(existingPerson);
                        db.Save();

                        DialogResult = DialogResult.OK;
                        RtlMessageBox.Show("عملیات ویرایش با موفقیت انجام شد");
                    }
                }
            }
        }

        private void frmAddorEdit_Load(object sender, EventArgs e)
        {


            if (P_NationalCode != 0)
            {
                if (!string.IsNullOrWhiteSpace(txtNationalCode.Text) && !Int64.TryParse(txtNationalCode.Text, out _))
                {
                    RtlMessageBox.Show("کد ملی باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNationalCode.Focus();
                    txtNationalCode.Clear();
                    return;
                }
                using (UnitofWork db = new UnitofWork())
                {
                    this.Text = "عملیات ویرایش";
                    btnSabt.Text = "ویرایش";
                    var Person = db.PersonsRepository.GetbyID(P_NationalCode);
                    txtName.Text = Person.PersonName;
                    txtFamily.Text = Person.PersonFamily;
                    txtNationalCode.Text = Person.NationalCode.ToString();
                    txtAddress.Text = Person.PersonAddress;
                    txtPstalCode.Text = Person.PostalCode;
                    txtPhone.Text = Person.PhoneNumber;
                    txtBirthday.Text = Person.Birthday;
                    txtFotherJob.Text = Person.FotherJob;
                    txtMotherJob.Text = Person.MotherJob;
                    txtFotherPhone.Text = Person.FotherPhoneNumber;
                    txtMotherPhone.Text = Person.MotherPhoneNumber;
                    if (Person.IsActive != null)
                        P_IsActive = (bool)Person.IsActive;

                }

            }
        }
    }
}
