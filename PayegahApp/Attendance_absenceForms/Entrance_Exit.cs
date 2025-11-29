using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.utility.Convertor;
using PayegahDataLayer;
using PayegahDataLayer.Context;
using PayegahViewModel;
using Stimulsoft.Report;
using ValidationComponents;

namespace PayegahApp.Attendance_absence
{
    public partial class Entrance_ExitOperation : Form
    {
        public Entrance_ExitOperation()
        {
            InitializeComponent();
        }

        private void btnEntrance_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (txtNationalCode != null)
                {

                    if (!string.IsNullOrWhiteSpace(txtNationalCode.Text) && !Int64.TryParse(txtNationalCode.Text, out _))
                    {
                        RtlMessageBox.Show("کد ملی باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNationalCode.Focus();
                        return;
                    }
                    Int64 nationalcodecast = Int64.Parse(txtNationalCode.Text);

                    using (UnitofWork db = new UnitofWork())
                    {
                        Persons person = db.PersonsRepository.GetAll().Where(p => p.NationalCode == nationalcodecast).FirstOrDefault();
                        if (person == null)
                        {
                            RtlMessageBox.Show("کاربری با این کدملی یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var person2 = db.PersonsRepository.GetbyID(nationalcodecast);
                        if (person2.IsActive != true)
                        {
                            RtlMessageBox.Show("عضو غیرفعال است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                        PayegahDataLayer.Attendance_absence atb = new PayegahDataLayer.Attendance_absence()
                        {
                            PersonID = person.NationalCode,
                            EntranceDate = DateTime.Now,
                            RegestrationDate = DateTime.Now
                        };
                        db.Attendance_AbsenceRepository.Insert(atb);
                        db.Save();
                        RtlMessageBox.Show("کاربر گرامی ورود شما با موفقیت ثبت شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNationalCode.Clear();
                        Bindgrid();
                    }
                }
            }
        }
        private void Entrance_Exit_Load(object sender, EventArgs e)
        {
            dgvAtb.AutoGenerateColumns = false;
            LockedRecord();
            Bindgrid();

        }
        public void LockedRecord()
        {
            using (UnitofWork db = new UnitofWork())
            {
                DateTime now = DateTime.Now;
                var OldRecord = db.Attendance_AbsenceRepository.GetAll().Where(r => r.RegestrationDate.HasValue && now > r.RegestrationDate.Value.AddHours(24)).ToList();
                foreach (var item in OldRecord)
                {
                    item.Locked = "قفل شده";
                    db.Attendance_AbsenceRepository.Update(item);
                }
                db.Save();
            }
        }
        void Bindgrid()
        {

            using (UnitofWork db = new UnitofWork())
            {
                List<PayegahList> atbList;
                if (chkShowAll.Checked)
                {

                    atbList = db.Attendance_AbsenceRepository.GetAll()
                    .Select(a => new PayegahList
                    {
                        ID = a.ID,
                        PersonID = (Int64)a.PersonID,
                        Name = a.Persons.PersonName,
                        Family = a.Persons.PersonFamily,
                        EntranceDate = a.EntranceDate,
                        ExitDate = a.ExitDate,
                        Locked = a.Locked
                    }).ToList();

                }
                else
                {
                    atbList = db.Attendance_AbsenceRepository.GetAll().Where(w => w.RegestrationDate >= DateTime.Now.Date)
                   .Select(a => new PayegahList
                   {
                       ID = a.ID,
                       PersonID = (Int64)a.PersonID,
                       Name = a.Persons.PersonName,
                       Family = a.Persons.PersonFamily,
                       EntranceDate = a.EntranceDate,
                       ExitDate = a.ExitDate,
                       Locked = a.Locked
                   }).ToList();

                }

                dgvAtb.DataSource = atbList;
                ConvertDatesToShamsi();

            }
        }
        private void ConvertDatesToShamsi()
        {
            foreach (DataGridViewRow row in dgvAtb.Rows)
            {
                if (row.Cells["colEntranceDate"].Value != null &&
                    DateTime.TryParse(row.Cells["colEntranceDate"].Value.ToString(), out DateTime date))
                {
                    row.Cells["colEntranceDate"].Value = date.ToShamsi();
                }
                else
                {
                    row.Cells["colEntranceDate"].Value = "";
                }
                if (row.Cells["colExitDate"].Value != null &&
                    DateTime.TryParse(row.Cells["colExitDate"].Value.ToString(), out DateTime date1))
                {
                    row.Cells["colExitDate"].Value = date1.ToShamsi();
                }
                else
                {
                    row.Cells["colExitDate"].Value = "";
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (txtNationalCode != null)
                {
                    if (!string.IsNullOrWhiteSpace(txtNationalCode.Text) && !Int64.TryParse(txtNationalCode.Text, out _))
                    {
                        RtlMessageBox.Show("کد ملی باید فقط شامل عدد باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNationalCode.Focus();
                        return;
                    }
                    Int64 nationalcode = Int64.Parse(txtNationalCode.Text);
                    using (UnitofWork db = new UnitofWork())
                    {
                        Persons person = db.PersonsRepository.GetAll(p => p.NationalCode == nationalcode).FirstOrDefault();
                        if (person == null)
                        {
                            RtlMessageBox.Show("کاربری با این کدملی یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var person2 = db.PersonsRepository.GetbyID(nationalcode);
                        if (person2.IsActive != true)
                        {
                            RtlMessageBox.Show("عضو غیرفعال است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                        PayegahDataLayer.Attendance_absence atb = new PayegahDataLayer.Attendance_absence()
                        {
                            PersonID = person.NationalCode,
                            ExitDate = DateTime.Now,
                            RegestrationDate = DateTime.Now,
                        };
                        db.Attendance_AbsenceRepository.Insert(atb);
                        db.Save();
                        RtlMessageBox.Show("کاربر گرامی خروج شما با موفقیت ثبت شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNationalCode.Clear();
                        Bindgrid();

                    }
                }
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {
                dgvAtb.DataSource = Fillter(txtSearch.Text);
            }
        }
        public List<PayegahList> Fillter(string parameter)
        {
            using (UnitofWork db = new UnitofWork())
            {
                return db.Attendance_AbsenceRepository.GetAll().Where(a => (a.Persons.PersonName + " " + a.Persons.PersonFamily).Contains(parameter))
                .Select(a => new PayegahList
                {
                    PersonID = (Int64)a.PersonID,
                    Name = a.Persons.PersonName,
                    Family = a.Persons.PersonFamily,
                    EntranceDate = a.EntranceDate,
                    ExitDate = a.ExitDate,
                    Locked = a.Locked
                }).ToList();

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAtb.CurrentRow != null)
            {
                using (UnitofWork db = new UnitofWork())
                {
                    string Name = dgvAtb.CurrentRow.Cells[2].Value.ToString();
                    string Family = dgvAtb.CurrentRow.Cells[3].Value.ToString();
                    string FullName = Name + " " + Family;
                    PayegahDataLayer.Attendance_absence atb = db.Attendance_AbsenceRepository.GetbyID(int.Parse(dgvAtb.CurrentRow.Cells[0].Value.ToString())); if (atb != null);
                    if (atb != null && string.IsNullOrEmpty(atb.Locked))
                    {
                        if (RtlMessageBox.Show($"آیا از حذف کاربر  {FullName} مطمئن  هستید.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            int ID = int.Parse(dgvAtb.CurrentRow.Cells[0].Value.ToString());
                            db.Attendance_AbsenceRepository.DeletebyId(ID);
                            db.Save();
                            Bindgrid();
                        }
                    }
                    else
                    {
                        RtlMessageBox.Show("فقط در تاریخ جاری میتوان عضو مورد نظر را حذف کنید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک عضو را از جدول برای عملیات حذف انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt.Columns.Add("PersonID");
            Dt.Columns.Add("Name");
            Dt.Columns.Add("Family");
            Dt.Columns.Add("EntranceDate");
            Dt.Columns.Add("ExitDate");
            foreach (DataGridViewRow item in dgvAtb.Rows)
            {
                Dt.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString()
                    //item.Cells[5].Value.ToString()
                    );
            }
            stiReport1.Load(Application.StartupPath + "/ReportAttsensAbsens.mrt");
            stiReport1.RegData("Dt", Dt);
            stiReport1.Show();
        }


        private void chkShowAll_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkShowAll.Checked == true)
            {
                MessageBox.Show("نمایش همه فعال شد");
            }
            else
            {
                MessageBox.Show("نمایش همه غیر فعال شد");
            }
            Bindgrid();

        }
    }
}
