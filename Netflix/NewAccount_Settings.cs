using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Netflix.Database;
using System.Net.Mail;// eMail kontrolü için

namespace Netflix
{
    public partial class NewAccount_Settings : Form
    {
        private int page;//page 0: kayıt - page 1: kullanıcı 
        DatabaseOperation databaseOperation = new DatabaseOperation();
        private bool eMailControl(string eMail)
        {
            try
            {
                MailAddress m = new MailAddress(eMail);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void getData()
        {
            Account account = new Account();
            account = databaseOperation.getAccountData(Login.eMail);
            txt_firstName.Text = account.firstName;
            txt_lastName.Text = account.lastName;
            txt_eMail.Text = account.eMail;
            txt_password.Text = account.password;
            txt_password1.Text = account.password;
            date.Text = account.date;
        }

        public NewAccount_Settings(int page)
        {
            this.page = page;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        private void txt_password1_TextChanged(object sender, EventArgs e)
        {
            txt_password1.PasswordChar = '*';
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {
                if (databaseOperation.passwordControl(txt_password.Text, txt_password1.Text))
                {
                    if (eMailControl(txt_eMail.Text))
                    {
                        if (databaseOperation.AddAccount(txt_firstName.Text, txt_lastName.Text, txt_eMail.Text, txt_password.Text, date.Text))
                        {
                            ChooseProgramKind cPk = new ChooseProgramKind();
                            cPk.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                        MessageBox.Show("Geçersiz mail adresi girdiniz. Lütfen tekrar deneyiniz.", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Şifreler birbiri ile uyuşmuyor lütfen tekrar deneyiniz.", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (databaseOperation.passwordControl(txt_password.Text, txt_password1.Text))
                {
                    if (eMailControl(txt_eMail.Text))
                    {
                        databaseOperation.UpdateAccount(txt_firstName.Text, txt_lastName.Text, txt_eMail.Text, txt_password.Text, date.Text, Login.eMail);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Geçersiz mail adresi girdiniz. Lütfen tekrar deneyiniz.", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Şifreler birbiri ile uyuşmuyor lütfen tekrar deneyiniz.", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewAccount_Settings_Load(object sender, EventArgs e)
        {
            if (page == 0)
                btn_save.Text = "Kayıt Ol";
            else
            {
                getData();
                btn_save.Text = "Kaydet";
            }
        }
    }
}
