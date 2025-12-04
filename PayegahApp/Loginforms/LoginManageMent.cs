using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Accounting.utility.Convertor;
using PayegahDataLayer;
using PayegahDataLayer.Context;
using static System.Net.Mime.MediaTypeNames;

namespace PayegahApp.Loginforms
{
    public partial class LoginManageMent : Form
    {
        public LoginManageMent()
        {
            InitializeComponent();
        }

        private void LoginManageMent_Load(object sender, EventArgs e)
        {
            dgvUsers.ForeColor = Color.Black;
            dgvUsers.AutoGenerateColumns = false;
            BindGrid();
        }
        //private void ConvertDatesToShamsi()
        //{
        //    foreach (DataGridViewRow row in dgvUsers.Rows)
        //    {
        //        if (row.Cells["colDate"].Value != null &&
        //            DateTime.TryParse(row.Cells["colDate"].Value.ToString(), out DateTime date))
        //        {
        //            row.Cells["colDate"].Value = date.ToShamsi();
        //        }
        //    }
        //}
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                dgvUsers.DataSource = db.UserRepository.GetAll().Select(s => new
                {
                    s.UserID,
                    s.Persons.NationalCode,
                    s.UserName,
                    s.Password,
                    Date = s.LoginDate != null ? s.LoginDate.ToShamsi() : ""

                }).ToList();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                if (dgvUsers.CurrentRow.Selected)
                {
                    int ID = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                    using (UnitofWork db = new UnitofWork())
                    {
                        var Get = db.UserRepository.GetbyID(ID);
                        if (Get != null)
                        {
                            txtUserName.Text = Get.UserName;
                            txtNatnioalCode.Text = Get.PersonID.ToString();
                            txtPassUser.Text = Get.Password;
                        }
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا برای عملیات روی یک سطر از جدول کلیک کنید.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                
                using (UnitofWork db = new UnitofWork())
                {
                    if (RtlMessageBox.Show($"آیا از حذف کاربر مطمئن هستید.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int ID = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                        db.UserRepository.DeletebyId(ID);
                        db.Save();
                        RtlMessageBox.Show("عملیات حذف با موفقیت انجام شد");
                        txtPassUser.Clear();
                        txtNatnioalCode.Clear();
                        txtPassUser.Clear();
                        BindGrid();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک کاربر را از جدول برای عملیات حذف انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditMem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                if (dgvUsers.CurrentRow.Selected)
                {
                    int ID = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                    using (UnitofWork db = new UnitofWork())
                    {
                        if (!string.IsNullOrWhiteSpace(txtNatnioalCode.Text))
                        {
                            Int64 nationalcodecast = Int64.Parse(txtNatnioalCode.Text);
                            if (!Int64.TryParse(txtNatnioalCode.Text, out long code))
                            {
                                RtlMessageBox.Show("کدملی فقط شامل عدد است.");
                                return;
                            }
                            Persons person = db.PersonsRepository.GetAll().Where(p => p.NationalCode == nationalcodecast).FirstOrDefault();
                            if (person == null)
                            {
                                RtlMessageBox.Show("کاربری با این کدملی یافت نشد.");
                                return;
                            }
                            var Get = db.UserRepository.GetbyID(ID);
                            if (Get != null)
                            {
                                Get.PersonID = nationalcodecast;
                                Get.UserName=txtUserName.Text;
                                Get.Password = txtPassUser.Text;
                            }
                            db.UserRepository.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("تغییرات با موفقیت انجام شد.");
                            txtNatnioalCode.Clear();
                            txtPassUser.Clear();
                            txtPassUser.Clear();
                            BindGrid();
                            return;
                        }
                        if (!string.IsNullOrWhiteSpace(txtUserName.Text))
                        {
                            var Get = db.UserRepository.GetbyID(ID);
                            if (Get != null)
                            {
                                Get.UserName = txtUserName.Text;
                                Get.Password = txtPassUser.Text;
                            }
                            db.UserRepository.Update(Get);
                            db.Save();
                            RtlMessageBox.Show("تغییرات با موفقیت انجام شد.");
                            txtUserName.Clear();
                            txtPassUser.Clear();
                            BindGrid();
                        }
                    
                    }
                }
                else
                {
                    RtlMessageBox.Show("لطفا برای عملیات ویرایش روی یک سطر از جدول کلیک کنید.");
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا برای عملیات ویرایش روی یک سطر از جدول کلیک کنید.");
            }
        }

        private void btnInsertP_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) && string.IsNullOrWhiteSpace(txtNatnioalCode.Text))
            {
                RtlMessageBox.Show("لطفا نام کاربری یا کدملی یکی را وارد کنید.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassUser.Text))
            {
                RtlMessageBox.Show("لطفا کلمه عبور خود را وارد فرمایید.");
                return;
            }

            using (UnitofWork db = new UnitofWork())
            {
                if (!string.IsNullOrWhiteSpace(txtNatnioalCode.Text))
                {
                    if (string.IsNullOrWhiteSpace(txtUserName.Text))
                    {
                        RtlMessageBox.Show("لطفا یک نام کاربری برای عضو تعریف کنید.");
                        return;
                    }
                    if (!Int64.TryParse(txtNatnioalCode.Text, out long code))
                    {
                        RtlMessageBox.Show("کدملی فقط شامل عدد است.");
                        return;
                    }
                    Int64 nationalcodecast = Int64.Parse(txtNatnioalCode.Text);
                    Persons person = db.PersonsRepository.GetAll().Where(p => p.NationalCode == nationalcodecast).FirstOrDefault();
                    if (person == null)
                    {
                        RtlMessageBox.Show("کاربری با این کدملی یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Users us = new Users()
                    {
                        PersonID = person.NationalCode,
                        UserName = txtUserName.Text,
                        Password = txtPassUser.Text,
                        LoginDate = DateTime.Now
                    };
                    db.UserRepository.Insert(us);
                    db.Save();
                    RtlMessageBox.Show("عملیات ذخیره سازی با موفقیت انجام شد.");
                    txtNatnioalCode.Clear();
                    txtPassUser.Clear();
                    txtUserName.Clear();
                    BindGrid();
                }
                if (!string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    Users ur = new Users()
                    {
                        UserName = txtUserName.Text,
                        Password = txtPassUser.Text,
                        LoginDate = DateTime.Now
                    };

                    db.UserRepository.Insert(ur);
                    db.Save();
                    txtUserName.Clear();
                    txtPassUser.Clear();
                    RtlMessageBox.Show("عملیات ذخیره سازی با موفقیت انجام شد.");
                    BindGrid();
                    return;

                }

            }
        }
    }
}
