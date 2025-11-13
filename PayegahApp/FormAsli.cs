using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayegahApp.Attendance_absence;
using PayegahApp.Pesrsons;
using PayegahApp.PesrsonsForms;
using PayegahApp.RollForm;

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
            MemberInsert frm=new MemberInsert();
            frm.ShowDialog();
        }
    }
}
