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
    public partial class ShowKinds : Form
    {
        List<string> kinds;
        Database.DatabaseOperation database = new Database.DatabaseOperation();
        public ShowKinds(List<string> kinds)
        {
            this.kinds = kinds;
            InitializeComponent();
        }

        private void fillForm()
        {
            group1.Text = kinds[0].ToString();
            group2.Text = kinds[1].ToString();
            group3.Text = kinds[2].ToString();

            database.getHighScore(kinds[0].ToString());
            if(database.programs.Count > 1 || database.programs.Count == 1)
            {
                pictureBox1.Image = Image.FromFile(database.programs[0].bannerUrl);
                label1.Text = database.programs[0].name;
            }
            if (database.programs.Count == 2)
            {
                pictureBox2.Image = Image.FromFile(database.programs[1].bannerUrl);
                label2.Text = database.programs[1].name;
            }

            database.getHighScore(kinds[1].ToString());
            if (database.programs.Count > 1 || database.programs.Count == 1)
            {
                pictureBox3.Image = Image.FromFile(database.programs[0].bannerUrl);
                label3.Text = database.programs[0].name;
            }
            if (database.programs.Count == 2)
            {
                pictureBox4.Image = Image.FromFile(database.programs[1].bannerUrl);
                label4.Text = database.programs[1].name;
            }

            database.getHighScore(kinds[2].ToString());
            if (database.programs.Count > 1 || database.programs.Count == 1)
            {
                pictureBox5.Image = Image.FromFile(database.programs[0].bannerUrl);
                label5.Text = database.programs[0].name;
            }
            if (database.programs.Count == 2)
            {
                pictureBox6.Image = Image.FromFile(database.programs[1].bannerUrl);
                label6.Text = database.programs[1].name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowKinds_Load(object sender, EventArgs e)
        {
            fillForm();
        }
    }
}
