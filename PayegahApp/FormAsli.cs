using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.utility.Convertor;
using PayegahApp.Amat;
using PayegahApp.Attendance_absence;
using PayegahApp.EventForm;
using PayegahApp.OperationsForm;
using PayegahApp.Pesrsons;
using PayegahApp.PesrsonsForms;
using PayegahApp.RollForm;
using PayegahDataLayer;
using PayegahUtility;
namespace PayegahApp
{
    public partial class FormAsli : Form
    {
        public FormAsli()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            frmPersons frmPersons = new frmPersons();
            frmPersons.ShowDialog();

        }

        private void FormAsli_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //FrmLogin frmLogin = new FrmLogin();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //{
            //    this.Show();
            //    lblDate.Text = DateConvertor.ToSahmsi(DateTime.Now);
            //    lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            //}
            //else
            //{
            //    Application.Exit();
            //}



            this.Region = new Region(AppUtility.SetFormRonded(this,50));






        }

        private void btnEntrance_Exit_Click(object sender, EventArgs e)
        {
            Entrance_Exit frm=new Entrance_Exit();
            frm.ShowDialog();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            frmRole frm=new frmRole();
            frm.ShowDialog();
        }

        private void btnMemberInsert_Click(object sender, EventArgs e)
        {
            MemberInsertOLD frm=new MemberInsertOLD();
            frm.ShowDialog();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            frmEvent frm=new frmEvent();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperationMember frm=new OperationMember();
            frm.ShowDialog();
        }

        private void btnAmat_Click(object sender, EventArgs e)
        {
            frmAmatMember frm=new frmAmatMember();
            frm.ShowDialog();
        }
    }
}
