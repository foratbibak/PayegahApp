using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayegahApp.RoleForm;
using PayegahDataLayer;
using PayegahDataLayer.Context;

namespace PayegahApp.RollForm
{
    public partial class frmRole : Form
    {
        bool R_IsActive = true;
        public frmRole()
        {
            InitializeComponent();
        }

        private void btnInsertRoll_Click(object sender, EventArgs e)
        {
            RoleType frm = new RoleType();
            frm.ShowDialog();
        }

        private void frmRoll_Load(object sender, EventArgs e)
        {
            dgvRole.AutoGenerateColumns=false;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            BindGrid();
            CmbRoleType();
            CmbRole();


        }
        void CmbRoleType()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var list = db.RoleTypeRepository.GetAll().ToList();
                cmbRoles.DisplayMember = "TypeTitle";
                cmbRoles.ValueMember = "RoleType_ID";
                cmbRoles.DataSource = list;
            }
        }
        void CmbRole()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var list = db.RoleRepository.GetAll().ToList();
                cmbRoleName.DisplayMember = "RoleTitle";
                cmbRoleName.ValueMember = "Role_ID";
                cmbRoleName.DataSource = list;
            }
        }
        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                dgvRole.DataSource=db.MemberRoleRepository.GetAll();
                //var data = db.MemberRoleRepository.GetAll();
                //if (cmbFillter.SelectedItem.ToString() == "فعال")
                //{
                //    data=data.Where(c=>c.IActive==true).ToList();
                //}
                //else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                //{
                //    data=data.Where(c=>c.IActive==false).ToList();
                //}
                //dgvRole.DataSource = data;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            BindGrid();
            CmbRole();
            CmbRoleType();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShora_Click(object sender, EventArgs e)
        {
            RoleNames frm = new RoleNames();
            frm.ShowDialog();
        }

        private void cmbRoleName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnInsertMemberRole_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNatoinalCode.Text))
            {
                RtlMessageBox.Show("لطفا برای ثبت مقام کدملی را وارد فرمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNatoinalCode.Focus();
                return;
            }
            if (!Int64.TryParse(txtNatoinalCode.Text, out Int64 code))
            {
                RtlMessageBox.Show("کدملی فقط باید شامل عدد باشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cmbRoleName.SelectedValue == null && cmbRoles.SelectedValue == null)
            {
                RtlMessageBox.Show("لطفا مقام و شورای مورد نظر را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Int64 NationalCodeCast = Int64.Parse(txtNatoinalCode.Text);
            using (UnitofWork db = new UnitofWork())
            {
                Members mem = db.MemberRepository.GetAll().Where(n => n.MemID == NationalCodeCast).FirstOrDefault();
                if (mem == null)
                {
                    RtlMessageBox.Show("کدملی وارد شده یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbRoleName.SelectedIndex < 0 || cmbRoles.SelectedIndex < 0)
                {
                    RtlMessageBox.Show("لطفا مقام و شورای مورد نظر را انتخاب فرمایید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int roleTypeId = (int)cmbRoles.SelectedValue;
                int roleId =(int)cmbRoleName.SelectedValue;
                MemberRole mr = new MemberRole()
                {
                    MemID = NationalCodeCast,
                    RoleTypeID = roleTypeId,
                    Role_ID = roleId,
                    IActive = this.R_IsActive,
                    DateRegestration = DateTime.Now
                };
                db.MemberRoleRepository.Insert(mr);
                db.Save();
                BindGrid();
                RtlMessageBox.Show("عملیات ثبت مقام با موفقیت انجام شد.","",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
