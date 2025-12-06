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
using PayegahDataLayer;
using PayegahDataLayer.Context;
using ValidationComponents;

namespace PayegahApp.OperationsForm
{
    public partial class frmAddOperation : Form
    {
        public frmAddOperation()
        {
            InitializeComponent();
        }

        private void btnOpType_Click(object sender, EventArgs e)
        {
            frmOperationType frm = new frmOperationType();
            frm.ShowDialog();
        }
        void cmbOpType()
        {
            using (UnitofWork db = new UnitofWork())
            {

                var list = db.OperationTypeRepository.GetAll().Where(e => e.IsActive == true).ToList();
                cmbOperation.DisplayMember = "OperationTypeTitle";
                cmbOperation.ValueMember = "OperationTypeID";
                cmbOperation.DataSource = list;
            }
            cmbOperation.SelectedIndex = -1;
            cmbOperation.Text = "لطفا یک آیتم را انتخاب فرمایید";
        }
        private void btnInsertOp_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (cmbOperation.SelectedIndex < 0)
                {
                    RtlMessageBox.Show("لطفا نوع مراسم را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (UnitofWork db = new UnitofWork())
                {
                    int OpTypeID = (int)cmbOperation.SelectedValue;
                    Operations op = new Operations()
                    {
                        OperationTitle = txtTitle.Text,
                        OperationTypeID = OpTypeID,
                        IsActive = true,
                        OperationDate = DateTime.Now,
                    };
                    db.OperationsRepository.Insert(op);
                    db.Save();
                    RtlMessageBox.Show("عملیات ذخیره سازی با موفقیت انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTitle.Clear();
                    BindGrid();
                }
            }
        }
        private void frmAddOperation_Load(object sender, EventArgs e)
        {
            dgvOperation.AutoGenerateColumns = false;
            dgvOperation.ForeColor=Color.Black;
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
                var data = db.OperationsRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    data = data.Where(x => x.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    data = data.Where(x => x.IsActive == false).ToList();
                }
                var Join = data.Select(s => new
                {
                    s.OperationID,
                    s.OperationTitle,
                    s.OperationType.OperationTypeTitle,
                    Date = s.OperationDate != null ? s.OperationDate.ToShamsi() : "",
                    s.IsActive

                }).ToList();
                dgvOperation.DataSource = Join;
                cmbOpType();
            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void dgvOperation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOperation.CurrentRow.Selected)
            {

                int ID = int.Parse(dgvOperation.CurrentRow.Cells[0].Value.ToString());
                using (UnitofWork db = new UnitofWork())
                {
                    var Get = db.OperationsRepository.GetbyID(ID);
                    if (Get != null)
                    {
                        txtTitle.Text = Get.OperationTitle;
                    }
                    else
                    {
                        RtlMessageBox.Show("عملیات با شکست مواجه شد برنامه دوباره راه اندازی کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvOperation.CurrentRow.Selected)
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    if (cmbOperation.SelectedIndex < 0)
                    {
                        RtlMessageBox.Show("لطفا نوع مراسم را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int ID = int.Parse(dgvOperation.CurrentRow.Cells[0].Value.ToString());
                    using (UnitofWork db = new UnitofWork())
                    {
                        int OpTypeID = (int)cmbOperation.SelectedValue;
                        var Get = db.OperationsRepository.GetbyID(ID);
                        if (Get != null)
                        {
                            Get.OperationTitle = txtTitle.Text;
                            Get.OperationTypeID = OpTypeID;
                        }
                        db.OperationsRepository.Update(Get);
                        db.Save();
                        txtTitle.Clear();
                        RtlMessageBox.Show("تغییرات با موفقیت انجام شد.", "", MessageBoxButtons.OK);
                        BindGrid();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("برای انجام عملیات ویرایش رو یک سطر از جدول انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
            cmbOpType();
        }
        private void ActiveStatuse(bool Active)
        {
            int ID = int.Parse(dgvOperation.CurrentRow.Cells[0].Value.ToString());
            using (UnitofWork db = new UnitofWork())
            {
                Operations op = db.OperationsRepository.GetAll().Where(o => o.OperationID == ID).FirstOrDefault();
                if (op == null)
                {
                    RtlMessageBox.Show("نوع وارد شده وجود ندارد لطفا جدول را بروزرسانی کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var Get = db.OperationsRepository.GetbyID(ID);
                bool IsActive = Get.IsActive ?? false;
                if (Active)
                {
                    if (!IsActive)
                    {
                        Get.IsActive = true;
                        db.OperationsRepository.Update(Get);
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
                        Get.IsActive = false;
                        db.OperationsRepository.Update(Get);
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
        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                if (dgvOperation.CurrentRow.Selected)
                {
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        RtlMessageBox.Show("برای عملیات فعال سازی روی یک سطر از جدول کلیک کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (dgvOperation.CurrentRow.Selected)
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
                    txtTitle.Clear();
                }
            }
        }

        private void dgvOperation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOperation.Columns[e.ColumnIndex].Name == "IsActive" && e.Value != null)
            {
                bool isActive = (bool)e.Value;
                e.Value = isActive ? "فعال" : "غیرفعال";
                e.FormattingApplied = true;
            }
        }
    }
}
