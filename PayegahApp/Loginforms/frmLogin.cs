using PayegahDataLayer.Context;
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
            AppUtility.SetFormRounded(this, 30);
            CheckTrialPro();
        }
        private void CheckTrialPro()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = System.IO.Path.Combine(folder, "PayegahApp_pro_trial.dat");

            DateTime startDate;
            DateTime lastRun;

            if (!System.IO.File.Exists(filePath))
            {
                // اولین اجرا
                startDate = DateTime.Now;
                lastRun = DateTime.Now;

                string data = startDate.ToString() + "|" + lastRun.ToString();
                System.IO.File.WriteAllText(filePath, data);
            }
            else
            {
                string[] data = System.IO.File.ReadAllText(filePath).Split('|');
                startDate = DateTime.Parse(data[0]);
                lastRun = DateTime.Parse(data[1]);

                // چک عقب کشیدن تاریخ سیستم
                if (DateTime.Now < lastRun)
                {
                    MessageBox.Show("تاریخ سیستم تغییر کرده است. اجرای برنامه امکان‌پذیر نیست.");
                    Application.Exit();
                    return;
                }
            }

            // چک 30 روزه
            double daysPassed = (DateTime.Now - startDate).TotalDays;

            if (daysPassed > 30)
            {
                MessageBox.Show("مدت استفاده از این برنامه پایان یافته است.", "Trial Ended");
                Application.Exit();
                return;
            }

            // ذخیره آخرین تاریخ اجرا
            string newData = startDate.ToString() + "|" + DateTime.Now.ToString();
            System.IO.File.WriteAllText(filePath, newData);
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
