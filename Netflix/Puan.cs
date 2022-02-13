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
    public partial class Puan : Form
    {
        int puan;
        int userID, programID, passingMinute, lastEpisode;
        DatabaseOperation database = new DatabaseOperation();
        public Puan(int userID, int programID, int passingMinute, int lastEpisode)
        {
            this.userID = userID;
            this.programID = programID;
            this.passingMinute = passingMinute;
            this.lastEpisode = lastEpisode;
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.puan = 2;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.puan = 5;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.puan = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.puan = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.puan = 4;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.puan = 7;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            this.puan = 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.AddList(userID, programID, passingMinute,lastEpisode,puan);
            this.Close();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.puan = 6;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.puan = 8;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            this.puan = 10;
        }
    }
}
