using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using Accounting.utility.Convertor;
using PayegahApp.Amat;
using PayegahApp.EventForm;
using PayegahApp.frmEntrance_Exit;
using PayegahApp.OperationsForm;
using PayegahApp.Pesrsons;
using PayegahApp.PesrsonsForms;
using PayegahApp.Reports;
using PayegahApp.RollForm;
using PayegahDataLayer;
using PayegahUtility;

namespace PayegahApp
{
    public partial class FormAsli : Form
    {
        private Timer timer;

        public FormAsli()
        {
            InitializeComponent();
        }

        private void FormAsli_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000;   
            timer.Tick += Timer_Tick;
            timer.Start();

            Timer_Tick(null, null);  
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateConvertor.ToShamsi(DateTime.Now);      
            //lblTime.Text = DateTime.Now.ToString("HH:mm:ss");         

        }
        private void btnPerson_Click(object sender, EventArgs e)
        {
            frmPersons frmPersons = new frmPersons();
            frmPersons.ShowDialog();
        }

        private void btnEntrance_Exit_Click(object sender, EventArgs e)
        {
            Entrance_Exit frm = new Entrance_Exit();
            frm.ShowDialog();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            frmRole frm = new frmRole();
            frm.ShowDialog();
        }

        private void btnMemberInsert_Click(object sender, EventArgs e)
        {
            MemberInsertOLD frm = new MemberInsertOLD();
            frm.ShowDialog();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            frmEvent frm = new frmEvent();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperationMember frm = new OperationMember();
            frm.ShowDialog();
        }

        private void btnAmat_Click(object sender, EventArgs e)
        {
            frmAmatMember frm = new frmAmatMember();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportfrm reportfrm = new Reportfrm();
            reportfrm.ShowDialog();
        }
    }
}
