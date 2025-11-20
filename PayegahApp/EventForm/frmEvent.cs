using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayegahApp.EventForm
{
    public partial class frmEvent : Form
    {
        public frmEvent()
        {
            InitializeComponent();
        }

        private void btnInsertEvent_Click(object sender, EventArgs e)
        {
            frmAddEvent frm=new frmAddEvent();
            frm.ShowDialog();
        }
    }
}
