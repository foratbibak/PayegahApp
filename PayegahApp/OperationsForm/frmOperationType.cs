using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.utility.Convertor;
using PayegahDataLayer;
using PayegahDataLayer.Context;
using ValidationComponents;

namespace PayegahApp.OperationsForm
{
    public partial class frmOperationType : Form
    {
        public frmOperationType()
        {
            InitializeComponent();
        }

        private void frmOperationType_Load(object sender, EventArgs e)
        {
            dgvOpType.AutoGenerateColumns=false;
            dgvOpType.ForeColor=Color.Black;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            BindGrid();

        }
        private void ConvertDatesToShamsi()
        {
            foreach (DataGridViewRow row in dgvOpType.Rows)
            {
                if (row.Cells["DateRegestration"].Value != null &&
                    DateTime.TryParse(row.Cells["DateRegestration"].Value.ToString(), out DateTime date))
                {
                    row.Cells["DateRegestration"].Value = date.ToShamsi();
                }
                else
                {
                    row.Cells["DateRegestration"].Value = "";
                }
            }
        }
        void BindGrid()
        {
            using (UnitofWork db =new UnitofWork())
            {
                var Data = db.OperationTypeRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    Data=Data.Where(o=>o.IsActive==true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    Data=Data.Where(o=>o.IsActive == false).ToList();
                }
                dgvOpType.DataSource=Data;
            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void ActiveStatuse(bool Active)
        {
            int ID = int.Parse(dgvOpType.CurrentRow.Cells[0].Value.ToString());
            using(UnitofWork db =new UnitofWork())
            {
                OperationType op=db.OperationTypeRepository.GetAll().Where(o=>o.OperationTypeID==ID).FirstOrDefault();
                if (op == null)
                {
                    RtlMessageBox.Show("نوع وارد شده وجود ندارد لطفا جدول را بروزرسانی کنید","توجه",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                var Get=db.OperationTypeRepository.GetbyID(ID);
                bool IsActive=Get.IsActive ?? false;
                if (Active)
                {
                    if (!IsActive)
                    {
                        Get.IsActive = true;
                        db.OperationTypeRepository.Update(Get);
                        db.Save();
                        RtlMessageBox.Show("فعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        RtlMessageBox.Show("این نوع از قبل فعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    if (IsActive)
                    {
                        Get.IsActive= false;
                        db.OperationTypeRepository.Update(Get);
                        db.Save();
                        RtlMessageBox.Show("غیرفعال‌سازی با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        RtlMessageBox.Show("این نوع از قبل غیرفعال بوده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnInsertOp_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using(UnitofWork db =new UnitofWork())
                {
                    OperationType op = new OperationType()
                    {
                        OperationTypeTitle = txtTitle.Text,
                        DateRegestration = DateTime.Now,
                        IsActive = true
                    };
                    db.OperationTypeRepository.Insert(op);
                    db.Save();
                    RtlMessageBox.Show("عملیات ذخیره سازی با موفقیت انجام شد.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    BindGrid();
                }


            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if(chkActive.Checked)
            {
                if (dgvOpType.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        RtlMessageBox.Show("برای عملیات فعال سازی روی یک سطر از جدول کلیک کنید","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtTitle.Focus();
                        return;
                    }
                    chkNotActive.Checked = false;
                    ActiveStatuse(true);
                    chkActive.Checked = false;
                    txtTitle.Clear();
                    BindGrid();
                }
                else
                {
                    RtlMessageBox.Show("برای عملیات فعال سازی،ابتدا روی یک سطر از جدول کلیک فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTitle.Clear();
                    chkActive.Checked = false;
                    return;
                }
            }
        }

        private void chkNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotActive.Checked)
            {
                if (dgvOpType.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        RtlMessageBox.Show("برای غیرفعال‌سازی، لطفاً ابتدا روی یک سطر از جدول کلیک کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chkNotActive.Checked = false;
                        txtTitle.Focus();
                        return;
                    }
                    chkActive.Checked = false;
                    ActiveStatuse(false);
                    chkNotActive.Checked = false;
                    txtTitle.Clear();
                    BindGrid();
                }
                else
                {
                    RtlMessageBox.Show("لطفا برای عملیات غیرفعال سازی یک سطر را ازجدول انتخاب فرمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkNotActive.Checked = false;
                    txtTitle.Clear() ;
                }
            }
        }

        private void dgvOpType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOpType.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvOpType.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get=db.OperationTypeRepository.GetbyID(ID);
                    if (Get != null)
                    {
                        txtTitle.Text = Get.OperationTypeTitle;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvOpType.CurrentRow.Selected)
            {
                int ID = int.Parse(dgvOpType.CurrentRow.Cells[0].Value.ToString());
                using(UnitofWork db = new UnitofWork())
                {
                    var Get=db.OperationTypeRepository.GetbyID(ID);
                    if(Get != null)
                    {
                        Get.OperationTypeTitle = txtTitle.Text;
                    }
                    db.OperationTypeRepository.Update(Get);
                    db.Save();
                    RtlMessageBox.Show("تغییرات با موفقیت انجام شد.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtTitle.Clear();
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا برای عملیات ویرایش روی یک سطر از جدول کلیک کنید.","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Clear();
            }
        }
    }
}
