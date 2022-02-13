using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Netflix.Database;

namespace Netflix
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DatabaseOperation databaseOperation = new DatabaseOperation();
        FileOperation.FileOperation file = new FileOperation.FileOperation();
        Home home;
        public static string eMail;

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_exit_MouseHover(object sender, EventArgs e)
        {
            lbl_exit.ForeColor = Color.FromArgb(225, 1, 9);
        }

        private void lbl_exit_MouseLeave(object sender, EventArgs e)
        {
            lbl_exit.ForeColor = Color.FromArgb(252, 252, 252);
        }

        private void lbl_newAccount_MouseHover(object sender, EventArgs e)
        {
            lbl_newAccount.ForeColor = Color.FromArgb(225, 1, 9);
        }

        private void lbl_newAccount_MouseLeave(object sender, EventArgs e)
        {
            lbl_newAccount.ForeColor = Color.FromArgb(252, 252, 252);
        }

        private void lbl_newAccount_Click(object sender, EventArgs e)
        {
            NewAccount_Settings nAccount = new NewAccount_Settings(0);
            nAccount.ShowDialog();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(databaseOperation.LoginControl(txt_eMail.Text, txt_password.Text))
            {
                if (eMail == null)
                {
                    databaseOperation.getUserID(txt_eMail.Text);
                    file.openingSave(txt_eMail.Text);
                }
                eMail = txt_eMail.Text;
                home = new Home(txt_eMail.Text);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.\nLütfen tekrar deneyiniz...", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            btn1.ForeColor = Color.FromArgb(225, 1, 9);
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.ForeColor = Color.FromArgb(177, 177, 177);
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            eMail = file.openingControl();
            if (eMail != null)
            {
                home = new Home(eMail);
                home.Show();
                this.Hide();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (databaseOperation.LoginControl(txt_eMail.Text, txt_password.Text))
                {
                    if (eMail == null)
                    {
                        databaseOperation.getUserID(txt_eMail.Text);
                        file.openingSave(txt_eMail.Text);
                    }
                    eMail = txt_eMail.Text;
                    home = new Home(txt_eMail.Text);
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.\nLütfen tekrar deneyiniz...", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
