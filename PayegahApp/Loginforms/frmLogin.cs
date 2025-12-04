using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayegahDataLayer.Context;

namespace PayegahApp.Loginforms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("نام کاربری را وارد فرمایید.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("کلمه عبور را وارد فرمایید.");
                return;
            }

            using (UnitofWork db = new UnitofWork())
            {
                if(db.UserRepository.GetAll(u => u.UserName == txtUser.Text && u.Password == txtPass.Text).Any())
                {
                    DialogResult=DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز اشتباه است");
                }
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
