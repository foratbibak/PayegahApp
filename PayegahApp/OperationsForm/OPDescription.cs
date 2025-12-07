using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.utility.Convertor;
using PayegahDataLayer.Context;
using Stimulsoft.Report;
using static Stimulsoft.Report.Export.StiBidirectionalConvert;

namespace PayegahApp.OperationsForm
{
    public partial class OPDescription : Form
    {
        public OPDescription()
        {
            InitializeComponent();
        }

        private void OPDescription_Load(object sender, EventArgs e)
        {
            dgvOPReports.ForeColor = Color.Black;
            dgvOPReports.AutoGenerateColumns = false;
            BindGrid();

        }
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                 var data= db.OPDescriptionRepository.GetAll();
                var Join = data.Select(s => new
                {
                    s.ID,
                    s.Operations.OperationTitle,
                    s.Descreption,
                    Date = s.RegestrationDate != null ? s.RegestrationDate.Value.ToShamsi() : "",
                }).ToList();
                dgvOPReports.DataSource = Join;
                cmbOP();
            }
        }
        //private void ConvertDatesToShamsi()
        //{
        //    foreach (DataGridViewRow row in dgvOPReports.Rows)
        //    {
        //        if (row.Cells["RegestrationDate"].Value != null &&
        //            DateTime.TryParse(row.Cells["RegestrationDate"].Value.ToString(), out DateTime date))
        //        {
        //            row.Cells["RegestrationDate"].Value = date.ToShamsi();
        //        }
        //        else
        //        {
        //            row.Cells["RegestrationDate"].Value = "";
        //        }
        //    }
        //}
        void cmbOP()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var List = db.OperationsRepository.GetAll().Where(e => e.IsActive == true).ToList();
                cmbOPeration.DisplayMember = "OPFullName";
                cmbOPeration.ValueMember = "OperationID";
                cmbOPeration.DataSource = List;
            }
            cmbOPeration.SelectedIndex = -1;
            cmbOPeration.Text = "لطفا یک عملیات را انتخاب فرمایید";
        }

        private void btnInsertDe_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                RtlMessageBox.Show("گزارش خود را وارد فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }
            if (cmbOPeration.SelectedIndex < 0)
            {
                RtlMessageBox.Show("لطفا یک عملیات را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (UnitofWork db = new UnitofWork())
            {
                int cmbOP = (int)cmbOPeration.SelectedValue;
            PayegahDataLayer.DecriptionOperation d = new PayegahDataLayer.DecriptionOperation()
            {
                OperationID = cmbOP,
                Descreption = txtDescription.Text,
                RegestrationDate = DateTime.Now,
            };
            
                db.OPDescriptionRepository.Insert(d);
                db.Save();
                RtlMessageBox.Show("عملیات ذخیره سازی با موفقیت انجام شد.");
                txtDescription.Clear();
                BindGrid();
            }
        }

        private void dgvOPReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvOPReports.CurrentRow.Selected)
                {
                    int ID = int.Parse(dgvOPReports.CurrentRow.Cells[0].Value.ToString());
                    using (UnitofWork db = new UnitofWork())
                    {
                        var Get = db.OPDescriptionRepository.GetbyID(ID);
                        if (Get != null)
                        {
                            txtDescription.Text = Get.Descreption;
                        }
                    }
                }
            }
            catch (Exception)
            {

                RtlMessageBox.Show("عملیات ویرایش با شکست مواجه لطفا با پشتیبانی تماس بگیرید");
            }
        
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgvOPReports != null)
            {
                if (dgvOPReports.CurrentRow.Selected)
                {
                    int ID = int.Parse(dgvOPReports.CurrentRow.Cells[0].Value.ToString());
                    using (UnitofWork db = new UnitofWork())
                    {
                        if (string.IsNullOrWhiteSpace(txtDescription.Text))
                        {
                            RtlMessageBox.Show("لطفا برای ثبت توضیحات یک عملیات را وارد فرمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDescription.Focus();
                            return;
                        }
                        if (cmbOPeration.SelectedIndex < 0)
                        {
                            RtlMessageBox.Show("لطفا یک عملیات را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var Get = db.OPDescriptionRepository.GetbyID(ID);
                        int cmbopCast = (int)cmbOPeration.SelectedValue;
                        if (Get != null)
                        {
                            Get.Descreption = txtDescription.Text;
                            Get.OperationID = cmbopCast;
                        }
                        db.OPDescriptionRepository.Update(Get);
                        db.Save();
                        BindGrid();
                        txtDescription.Clear();
                        RtlMessageBox.Show("تغییرات اعمال شد");
                    }
                }
              
            }
            else
            {
                RtlMessageBox.Show("لطفا یک سطر از جدول را برای عملیات ویرایش انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt.Columns.Add("OperationID");
            Dt.Columns.Add("Descreption");
            Dt.Columns.Add("RegestrationDate");
            foreach (DataGridViewRow item in dgvOPReports.Rows)
            {
                Dt.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString()
                    );
            }
            stiReport.Load(Application.StartupPath + "/ReportOPDescription.mrt");
            stiReport.RegData("Dt", Dt);
            stiReport.Show();
        }

        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
            cmbOP();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvOPReports != null)
            {
                if (RtlMessageBox.Show("آیا از حذف گزارش انتخاب شده مطمئن هستید.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using(UnitofWork db=new UnitofWork())
                    {
                        int ID = int.Parse(dgvOPReports.CurrentRow.Cells[0].Value.ToString());
                        db.OPDescriptionRepository.DeletebyId(ID);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("برای حذف گزارش مورد نظر یک رکود را در جدول زیر انتخاب فرمایید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


