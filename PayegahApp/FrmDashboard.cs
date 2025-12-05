using Accounting.utility.Convertor;
using PayegahApp.Amat;
using PayegahApp.EventForm;
using PayegahApp.frmEntrance_Exit;
using PayegahApp.Loginforms;
using PayegahApp.OperationsForm;
using PayegahApp.Pesrsons;
using PayegahApp.Reports;
using PayegahApp.RollForm;
using PayegahUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayegahApp
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateConvertor.ToShamsi(DateTime.Now);

        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            AppUtility.SetFormRounded(this, 30);
            timerr = new Timer();
            timerr.Interval = 1000;
            timerr.Tick += Timer_Tick;
            timerr.Start();

            Timer_Tick(null, null);

            //ApplyPermissions();
            //private void ApplyPermissions()
            //{
            //    btnPerson.Enabled = currentUser.Permissions.CanPerson;
            //    btnEntrance_Exit.Enabled = currentUser.Permissions.CanEntranceExit;
            //    btnRoll.Enabled = currentUser.Permissions.CanRoll;
            //    btnMemberInsert.Enabled = currentUser.Permissions.CanMemberInsert;
            //    btnEvent.Enabled = currentUser.Permissions.CanEvent;
            //    button1.Enabled = currentUser.Permissions.CanOperationMember;
            //    btnAmat.Enabled = currentUser.Permissions.CanAmat;
            //    button3.Enabled = currentUser.Permissions.CanReport;
            //}
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateConvertor.ToShamsi(DateTime.Now);
            //lblTime.Text = DateTime.Now.ToString("HH:mm:ss");         

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginManageMent frm = new LoginManageMent();
            frm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmPersons frm = new frmPersons();
            frm.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Entrance_Exit frm = new Entrance_Exit();
            frm.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmRole frm = new frmRole();
            frm.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmEvent frm = new frmEvent();
            frm.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OperationMember frm = new OperationMember();
            frm.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frmAmatMember frm = new frmAmatMember();
            frm.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Reportfrm reportfrm = new Reportfrm();
            reportfrm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            aboutus aboutus = new aboutus();
            aboutus.ShowDialog();
        }
    }
}
