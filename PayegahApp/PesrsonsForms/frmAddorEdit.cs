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
                if (BaseValidator.IsFormValid(this.components))
                {
                    if (!string.IsNullOrWhiteSpace(txtNationalCode.Text) && !Int64.TryParse(txtNationalCode.Text, out _))
                    {
                        RtlMessageBox.Show("کد ملی باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNationalCode.Focus();
                        return;
                    }
                    Int64 nationalcast = Int64.Parse(txtNationalCode.Text);
                    if (P_NationalCode == 0)
                    {
                        Persons person = db.PersonsRepository.GetAll().Where(p => p.NationalCode == nationalcast).FirstOrDefault();
                        if (person != null)
                        {
                            RtlMessageBox.Show("عضو وارد شده تکراری است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }


                    string defaultText = "نامشخص";
                    Persons persons = new Persons()
                    {
                        NationalCode = nationalcast,
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

                    if (P_NationalCode == 0)
                    {
                        db.PersonsRepository.Insert(persons);
                        DialogResult = DialogResult.OK;
                    }

                    else
                    {
                        db.PersonsRepository.Update(persons);
                        DialogResult = DialogResult.OK;
                    }
                    db.Save();
                    if (P_NationalCode == 0)
                    {
                        using (UnitofWork dbb = new UnitofWork())
                        {
                            Int64 nationalCast = Int64.Parse(txtNationalCode.Text);
                            Members mem = new Members()
                            {


                                PersonID = persons.NationalCode,
                                IsActive = this.P_IsActive,
                                RecordDate = DateTime.Now
                            };
                            dbb.MemberRepository.Insert(mem);
                            dbb.Save();
                        }
                       
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
