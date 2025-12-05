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
    public partial class aboutus : Form
    {
        public aboutus()
        {
            InitializeComponent();
        }

        private void aboutus_Load(object sender, EventArgs e)
        {
            AppUtility.SetFormRounded(this, 30);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
