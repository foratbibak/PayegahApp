using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayegahApp.PesrsonsForms;
using PayegahDataLayer.Context;
using PayegahDataLayer.Services;

namespace PayegahApp.Pesrsons
{
    public partial class frmPersons : Form
    {
        public frmPersons()
        {
            InitializeComponent();
        }


        private void frmPersons_Load(object sender, EventArgs e)
        {
            dgvPerson.AutoGenerateColumns = false;
            cmbFillter.Items.Add("همه");
            cmbFillter.Items.Add("فعال");
            cmbFillter.Items.Add("غیرفعال");
            cmbFillter.SelectedIndex = 1;
            dgvPerson.ForeColor = Color.Black;
            BindGrid();
        }

        void BindGrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                var data=db.PersonsRepository.GetAll();
                if (cmbFillter.SelectedItem.ToString() == "فعال")
                {
                    data = data.Where(x => x.IsActive == true).ToList();
                }
                else if (cmbFillter.SelectedItem.ToString() == "غیرفعال")
                {
                    data = data.Where(x => x.IsActive == false).ToList();
                }
                dgvPerson.DataSource = data;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {
                dgvPerson.DataSource = db.PersonsRepository.Fillter(txtSearch.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            IsAcitve frm=new IsAcitve();
            
            if(frm.ShowDialog() == DialogResult.OK)
            {
                
                BindGrid();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAddorEdit frmAddorEdit = new frmAddorEdit();
            if (frmAddorEdit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPerson != null)
            {
                int NationalCode = int.Parse(dgvPerson.CurrentRow.Cells[1].Value.ToString());
                frmAddorEdit frmAddorEdit = new frmAddorEdit();
                frmAddorEdit.P_NationalCode = NationalCode;
                if (frmAddorEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt.Columns.Add("NationalCode");
            Dt.Columns.Add("PersonName");
            Dt.Columns.Add("PersonFamily");
            Dt.Columns.Add("PersonAddress");
            Dt.Columns.Add("PostalCode");
            Dt.Columns.Add("PhoneNumber");
            Dt.Columns.Add("Birthday");
            Dt.Columns.Add("FotherJob");
            Dt.Columns.Add("MotherJob");
            Dt.Columns.Add("FotherPhoneNumber");
            Dt.Columns.Add("MotherPhoneNumber");
            Dt.Columns.Add("RegistrationDate");
            



            foreach (DataGridViewRow item in dgvPerson.Rows)
            {
                Dt.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[5].Value.ToString(),
                    item.Cells[6].Value.ToString(),
                    item.Cells[7].Value.ToString(),
                    item.Cells[8].Value.ToString(),
                    item.Cells[9].Value.ToString(),
                    item.Cells[10].Value.ToString(),
                    item.Cells[11].Value.ToString(),
                    item.Cells[12].Value.ToString()

                    );
            }
            stiReport.Load(Application.StartupPath + "/Report.mrt");
            stiReport.RegData("Dt", Dt);
            stiReport.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnNotActive_Click(object sender, EventArgs e)
        {
            IsAcitve frm =new IsAcitve();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}

