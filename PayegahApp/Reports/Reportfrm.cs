using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Accounting.utility.Convertor;
using PayegahDataLayer;

namespace PayegahApp.Reports
{
    public partial class Reportfrm : Form
    {
        public Reportfrm()
        {
            InitializeComponent();
        }

        private void Reportfrm_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void LoadTables()
        {
            txtFromDate.Text = DateTime.Now.ToShamsi();
            txtToDate.Text = DateTime.Now.ToShamsi();
            dgvResults.ForeColor = Color.Black;
            dgvResults.AutoGenerateColumns = true;
            var tables = new List<string>
            {
                "حضور و غیاب",
                "تجهیزات",
                "مراسمات",
                "عملیات",
                "اعضای شورا"
            };

            cmbfrm.DataSource = tables;
            cmbfrm.SelectedIndex = -1;
            cmbfrm.Text = "لطفا یک عملیات را انتخاب فرمایید";
        }

        public static DateTime ConvertShamsiToGregorian(string shamsiDate)
        {
            if (string.IsNullOrWhiteSpace(shamsiDate))
                throw new ArgumentException("تاریخ وارد نشده است.");

            var persianCalendar = new PersianCalendar();
            var parts = shamsiDate.Split('/');

            if (parts.Length != 3)
                throw new FormatException("فرمت تاریخ صحیح نیست. مثال: 1404/08/10");

            int year = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int day = int.Parse(parts[2]);

            return persianCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

        private string ToShamsi(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0:0000}/{1:00}/{2:00}",
                                 pc.GetYear(dt),
                                 pc.GetMonth(dt),
                                 pc.GetDayOfMonth(dt));
        }

        private object GetData(string tableName, DateTime fromDate, DateTime toDate)
        {
            using (var db = new PayegahDbEntities())
            {
                switch (tableName)
                {
                    case "حضور و غیاب":
                        return db.Attendance_absence
                                 .Where(a => a.RegestrationDate >= fromDate && a.RegestrationDate <= toDate)
                                 .ToList()
                                 .Select(a => new
                                 {
                                     a.PersonID,
                                     EntranceDate = string.IsNullOrEmpty(a.EntranceDate)? "": DateTime.Parse(a.EntranceDate).ToShamsi(),

                                     ExitDate = string.IsNullOrEmpty(a.ExitDate)? "": DateTime.Parse(a.ExitDate).ToShamsi(),
                                     RegestrationDate = ToShamsi((DateTime)a.RegestrationDate)
                                 })
                                 .ToList();

                    case "تجهیزات":
                        return db.AmadMembers
                                 .Where(a => a.AmadDateRegestration >= fromDate && a.AmadDateRegestration <= toDate)
                                 .ToList()
                                 .Select(a => new
                                 {
                                     a.MemID,
                                     a.AmadID,
                                     AmadDateRegestration = ToShamsi((DateTime)a.AmadDateRegestration)
                                 })
                                 .ToList();

                    case "مراسمات":
                        return db.EventMembers
                                 .Where(e => e.DateRegestration >= fromDate && e.DateRegestration <= toDate)
                                 .ToList()
                                 .Select(e => new
                                 {
                                     e.MemID,
                                     e.EventID,
                                     DateRegestration = ToShamsi((DateTime)e.DateRegestration)
                                 })
                                 .ToList();

                    case "عملیات":
                        return db.OperationMembers
                                 .Where(o => o.DateRegstration >= fromDate && o.DateRegstration <= toDate)
                                 .ToList()
                                 .Select(o => new
                                 {
                                     o.MemID,
                                     o.OperationID,
                                     DateRegstration = ToShamsi(o.DateRegstration)
                                 })
                                 .ToList();

                    case "اعضای شورا":
                        return db.MemberRole
                                 .Where(r => r.DateRegestration >= fromDate && r.DateRegestration <= toDate)
                                 .ToList()
                                 .Select(r => new
                                 {
                                     r.MemID,
                                     r.Role_ID,
                                     r.RoleTypeID,
                                     DateRegestration = ToShamsi((DateTime)r.DateRegestration)
                                 })
                                 .ToList();

                    default:
                        return null;
                }
            }

        }


        private void btnReport_Click(object sender, EventArgs e)
        {
            if (cmbfrm.SelectedIndex < 0)
            {
                RtlMessageBox.Show("لطفا یک بخش را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFromDate.Text) || string.IsNullOrWhiteSpace(txtToDate.Text))
            {
                RtlMessageBox.Show("لطفا هر دو تاریخ را وارد کنید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fromDate, toDate;
            try
            {
                fromDate = ConvertShamsiToGregorian(txtFromDate.Text.Trim());
                toDate = ConvertShamsiToGregorian(txtToDate.Text.Trim());
            }
            catch (Exception)
            {
                RtlMessageBox.Show("فرمت تاریخ صحیح نیست. مثال: 1404/08/10", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedTable = cmbfrm.SelectedItem.ToString();
            var data = GetData(selectedTable, fromDate, toDate);

            if (data != null && ((System.Collections.ICollection)data).Count > 0)
            {
                dgvResults.DataSource = data;
                SetDataGridViewHeaders(selectedTable);
            }
            else
            {
                dgvResults.DataSource = null;
                RtlMessageBox.Show("در این بازه تاریخی هیچ داده‌ای ثبت نشده است.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetDataGridViewHeaders(string tableName)
        {
            switch (tableName)
            {
                case "حضور و غیاب":
                    dgvResults.Columns["PersonID"].HeaderText = "کد عضو";
                    dgvResults.Columns["EntranceDate"].HeaderText = "تاریخ ورود";
                    dgvResults.Columns["ExitDate"].HeaderText = "تاریخ خروج";
                    dgvResults.Columns["RegestrationDate"].HeaderText = "تاریخ ثبت";
                    break;

                case "تجهیزات":
                    dgvResults.Columns["MemID"].HeaderText = "کدملی";
                    dgvResults.Columns["AmadID"].HeaderText = "تجهیزات";
                    dgvResults.Columns["AmadDateRegestration"].HeaderText = "تاریخ ثبت";
                    break;

                case "مراسمات":
                    dgvResults.Columns["MemID"].HeaderText = "کدملی";
                    dgvResults.Columns["EventID"].HeaderText = "مراسم";
                    dgvResults.Columns["DateRegestration"].HeaderText = "تاریخ ثبت";
                    break;

                case "عملیات":
                    dgvResults.Columns["MemID"].HeaderText = "کدملی";
                    dgvResults.Columns["OperationID"].HeaderText = "عملیات";
                    dgvResults.Columns["DateRegstration"].HeaderText = "تاریخ ثبت";
                    break;

                case "اعضای شورا":
                    dgvResults.Columns["MemID"].HeaderText = "کدملی";
                    dgvResults.Columns["Role_ID"].HeaderText = "مقام";
                    dgvResults.Columns["RoleTypeID"].HeaderText = "نوع مقام";
                    dgvResults.Columns["DateRegestration"].HeaderText = "تاریخ ثبت";
                    break;
            }

            dgvResults.AutoResizeColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvResults.DataSource = null;
        }
    }

    public static class DateTimeExtensions
    {
        public static string ToShamsi(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0:0000}/{1:00}/{2:00}",
                                 pc.GetYear(dt),
                                 pc.GetMonth(dt),
                                 pc.GetDayOfMonth(dt));
        }
    }
}



