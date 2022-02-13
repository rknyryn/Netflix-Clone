using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Netflix
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void btn_exitAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Netflix", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                FileOperation.FileOperation.closeAccount();
            else
                this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            NewAccount_Settings settings = new NewAccount_Settings(1);
            settings.ShowDialog();
            this.Close();
        }
    }
}
