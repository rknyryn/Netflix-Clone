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
    public partial class Home : Form
    {
        string user;
        int userID;
        int pageNumberT = 1;
        int indexList = 0;
        int index, programCount;
        int choosedProgramIndex;
        int passingSecond, passingMinute;//Programın izlenmesinde geçen süre için kullanılıyor.
        int lastEpisode;
        bool b = false;//izlenme durumu kontrolü için.
        Database.DatabaseOperation database = new Database.DatabaseOperation();

        private void fillTableBanner(int nextPrev)//nextPrev: 1(ileri) - nextPrev: 0(geri) - nextPrev: 2(sabit) - nextPrev: 3(başlangıç)  
        {
            programCount = database.getProgramCount();

            if (nextPrev == 1)
                pageNumberT = pageNumberT + 1;
            else if (nextPrev == 0)
                pageNumberT = pageNumberT - 1;
            else if (nextPrev == 2)
                pageNumberT = (indexList / 12) + 1;
            else if (nextPrev == 3)
                pageNumberT = 1;

            index = (pageNumberT * 12) - 12;

            if (pageNumberT == 0)
            {
                this.pageNumberT = 1;
                return;
            }
            else if(index > programCount)
            {
                pageNumberT = pageNumberT - 1;
                return;
            }

            if (index < programCount)
            {
                picBox1.Image = Image.FromFile(database.programs[index].bannerUrl);
                picBox1.Visible = true;
            }
            else
            {
                picBox1.Image = null;
                picBox1.Visible = false;
            }

            if (index + 1 < programCount)
            {
                picBox2.Image = Image.FromFile(database.programs[index + 1].bannerUrl);
                picBox2.Visible = true;
            }
            else
            {
                picBox2.Image = null;
                picBox2.Visible = false;
            }

            if (index + 2 < programCount)
            {
                picBox3.Image = Image.FromFile(database.programs[index + 2].bannerUrl);
                picBox3.Visible = true;
            }
            else
            {
                picBox3.Image = null;
                picBox3.Visible = false;
            }

            if (index + 3 < programCount)
            {
                picBox4.Image = Image.FromFile(database.programs[index + 3].bannerUrl);
                picBox4.Visible = true;
            }
            else
            {
                picBox4.Image = null;
                picBox4.Visible = false;
            }

            if (index + 4 < programCount)
            {
                picBox5.Image = Image.FromFile(database.programs[index + 4].bannerUrl);
                picBox5.Visible = true;
            }
            else
            {
                picBox5.Image = null;
                picBox5.Visible = false;
            }

            if (index + 5 < programCount)
            {
                picBox6.Image = Image.FromFile(database.programs[index + 5].bannerUrl);
                picBox6.Visible = true;
            }
            else
            {
                picBox6.Image = null;
                picBox6.Visible = false;
            }

            if (index + 6 < programCount)
            {
                picBox7.Image = Image.FromFile(database.programs[index + 6].bannerUrl);
                picBox7.Visible = true;
            }
            else
            {
                picBox7.Image = null;
                picBox7.Visible = false;
            }

            if (index + 7 < programCount)
            {
                picBox8.Image = Image.FromFile(database.programs[index + 7].bannerUrl);
                picBox8.Visible = true;
            }
            else
            {
                picBox8.Image = null;
                picBox8.Visible = false;
            }

            if (index + 8 < programCount)
            {
                picBox9.Image = Image.FromFile(database.programs[index + 8].bannerUrl);
                picBox9.Visible = true;
            }
            else
            {
                picBox9.Image = null;
                picBox9.Visible = false;
            }

            if (index + 9 < programCount)
            {
                picBox10.Image = Image.FromFile(database.programs[index + 9].bannerUrl);
                picBox10.Visible = true;
            }
            else
            {
                picBox10.Image = null;
                picBox10.Visible = false;
            }

            if (index + 10 < programCount)
            {
                picBox11.Image = Image.FromFile(database.programs[index + 10].bannerUrl);
                picBox11.Visible = true;
            }
            else
            {
                picBox11.Image = null;
                picBox11.Visible = false;
            }

            if (index + 11 < programCount)
            {
                picBox12.Image = Image.FromFile(database.programs[index + 11].bannerUrl);
                picBox12.Visible = true;
            }
            else
            {
                picBox12.Image = null;
                picBox12.Visible = false;
            }
        }
        private void fillListBanner(int nextPrev)//nextPrev: 1(ileri) - nextPrev: 0(geri) - nextPrev: 2(sabit) - nextPrev: 3(başlangıç)
        {
            programCount = database.getProgramCount();

            if (nextPrev == 1)
                indexList = indexList + 3;
            else if (nextPrev == 0)
                indexList = indexList - 3;
            else if (nextPrev == 2)
                indexList = (pageNumberT * 12) - 12;
            else if (nextPrev == 3)
                indexList = 0;

            if (indexList < 0)
            {
                indexList = indexList + 3;
                return;
            }
            else if(indexList > programCount)
            {
                indexList = indexList - 3;
                return;
            }

            if (indexList < programCount)
            {
                lbl_title1.Visible = true;
                lbl_type1.Visible = true;
                lbl_time1.Visible = true;
                btn_watch1.Visible = true;
                lbl_kind1.Visible = true;
                lbl_average1.Visible = true;

                picBoxA.Image = Image.FromFile(database.programs[indexList].bannerUrl);
                lbl_title1.Text = database.programs[indexList].name;
                lbl_type1.Text = database.programs[indexList].programType;
                lbl_time1.Text = database.programs[indexList].programLength.ToString() + " dakika";
                lbl_kind1.Text = "";
                foreach (var item in database.programs[indexList].programKind)
                {
                    lbl_kind1.Text += item + ", ";
                }
                if (database.programs[indexList].programType == "Dizi" || database.programs[indexList].programType == "Tv Show")
                {
                    lbl_episodes1.Visible = true;
                    lbl_episodes1.Text = database.programs[indexList].numberOfEpisodes.ToString() + " bölüm";
                }
                else
                    lbl_episodes1.Visible = false;
                lbl_average1.Text = "(" + database.programs[indexList].puan.ToString() +"/10) Puan";
            }
            else
            {
                lbl_title1.Visible = false;
                lbl_type1.Visible = false;
                lbl_time1.Visible = false;
                btn_watch1.Visible = false;
                lbl_episodes1.Visible = false;
                lbl_kind1.Visible = false;
                lbl_average1.Visible = false;
                picBoxA.Image = null;
            }

            if (indexList + 1 < programCount)
            {
                lbl_title2.Visible = true;
                lbl_type2.Visible = true;
                lbl_time2.Visible = true;
                btn_watch2.Visible = true;
                lbl_kind2.Visible = true;
                lbl_average2.Visible = true;

                picBoxB.Image = Image.FromFile(database.programs[indexList + 1].bannerUrl);
                lbl_title2.Text = database.programs[indexList + 1].name;
                lbl_type2.Text = database.programs[indexList + 1].programType;
                lbl_time2.Text = database.programs[indexList + 1].programLength.ToString() + " dakika";
                lbl_kind2.Text = "";
                foreach (var item in database.programs[indexList + 1].programKind)
                {
                    lbl_kind2.Text += item + ", ";
                }
                if (database.programs[indexList].programType == "Dizi" || database.programs[indexList].programType == "Tv Show")
                {
                    lbl_episodes2.Visible = true;
                    lbl_episodes2.Text = database.programs[indexList + 1].numberOfEpisodes.ToString() + " bölüm";
                }
                else
                    lbl_episodes2.Visible = false;
                lbl_average2.Text = "(" + database.programs[indexList + 1].puan.ToString() + "/10) Puan";
            }
            else
            {
                lbl_title2.Visible = false;
                lbl_type2.Visible = false;
                lbl_time2.Visible = false;
                btn_watch2.Visible = false;
                lbl_episodes2.Visible = false;
                lbl_kind2.Visible = false;
                lbl_average2.Visible = false;
                picBoxB.Image = null;
            }

            if (indexList + 2 < programCount)
            {
                lbl_title3.Visible = true;
                lbl_type3.Visible = true;
                lbl_time3.Visible = true;
                btn_watch3.Visible = true;
                lbl_kind3.Visible = true;
                lbl_average3.Visible = true;

                picBoxC.Image = Image.FromFile(database.programs[indexList + 2].bannerUrl);
                lbl_title3.Text = database.programs[indexList + 2].name;
                lbl_type3.Text = database.programs[indexList + 2].programType;
                lbl_time3.Text = database.programs[indexList + 2].programLength.ToString() + " dakika";
                lbl_kind3.Text = "";
                foreach (var item in database.programs[indexList + 2].programKind)
                {
                    lbl_kind3.Text += item + ", ";
                }
                if (database.programs[indexList].programType == "Dizi" || database.programs[indexList].programType == "Tv Show")
                {
                    lbl_episodes3.Visible = true;
                    lbl_episodes3.Text = database.programs[indexList + 2].numberOfEpisodes.ToString() + " bölüm";
                }
                else
                    lbl_episodes3.Visible = false;
                lbl_average3.Text = "(" + database.programs[indexList + 2].puan.ToString() + "/10) Puan";
            }
            else
            {
                lbl_title3.Visible = false;
                lbl_type3.Visible = false;
                lbl_time3.Visible = false;
                btn_watch3.Visible = false;
                lbl_episodes3.Visible = false;
                lbl_kind3.Visible = false;
                lbl_average3.Visible = false;
                picBoxC.Image = null;
            }
        }
        private void Info(Programs program)
        {
            picBox_banner.Image = Image.FromFile(program.bannerUrl);
            lbl_title.Text = program.name;
            lbl_kind.Text = "";
            foreach (var item in program.programKind)
            {
                lbl_kind.Text += item + ", ";
            }
            lbl_type.Text = program.programType;
            lbl_time.Text = program.programLength.ToString() + " dakika";
            //lbl_episodes.Text = database.programs[index].numberOfEpisodes.ToString();
            if (program.programType == "Dizi" || program.programType == "Tv Show")
            {
                lbl_episodes.Visible = true;
                lbl_episodes.Text = program.numberOfEpisodes.ToString() + " bölüm";
            }
            else
                lbl_episodes.Visible = false;
            lbl_average.Text = "(" + program.puan.ToString() + "/10) Puan";
            pnl_info.Visible = true;
        }
        private void picBoxEffect(PictureBox pic, bool b)
        {
            if (b == true)
                pic.BorderStyle = BorderStyle.Fixed3D;
            else
                pic.BorderStyle = BorderStyle.None;
        }
        private void Watch(Programs program)
        {
            int episode;
            listBox_episodes.Items.Clear();
            pnl_watch.BringToFront();
            pnl_episodes.Visible = false;
            pnl_player.Visible = false;
            pnl_watch.Visible = true;
            passingSecond = 0;
            lbl_totalTime.Text = program.programLength.ToString() + " dk";

            if (program.programType == "Film")
            {
                passingMinute = database.getLastEpisodePassingTime(userID, program.id);
                lbl_passingTime.Text = passingMinute.ToString() + " dk";
                pnl_player.Visible = true;
                lastEpisode = 1;
            }
            else
            {
                pnl_episodes.Visible = true;
                episode = database.getLastEpisode(userID, program.id);
                this.lastEpisode = episode;
                for (int i = 1; i <= program.numberOfEpisodes; i++)
                {
                    if(i == episode)
                        listBox_episodes.Items.Add(i + ". Bölüm (En son izlenen)");
                    else
                        listBox_episodes.Items.Add(i + ". Bölüm");
                }
            }
        }
        private void WatchPanelButtonClick(Programs program, int episode)
        {
            if(lastEpisode == episode)
                passingMinute = database.getLastEpisodePassingTime(userID, program.id);
            else
            {
                passingMinute = 0;
                this.lastEpisode = episode;
            }
            lbl_passingTime.Text = passingMinute.ToString() + " dk";
            pnl_episodes.Visible = false;
            pnl_player.Visible = true;
        }
        private void resetTimer()//Eğer çalışıyorsa
        {
            if (timer.Enabled == true)
            {
                timer.Stop();
                database.AddList(userID, database.programs[choosedProgramIndex].id, passingMinute, lastEpisode, 0);
                passingMinute = 0;
                passingSecond = 0;
                btn_play.Enabled = true;
                btn_stop.Enabled = false;
                b = false;
                pnl_watch.Visible = false;
            }
        }

        public Home(string eMail)
        {
            user = eMail;
            userID = FileOperation.FileOperation.userID;
            InitializeComponent();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(timer.Enabled == true)
                database.AddList(userID, database.programs[choosedProgramIndex].id, passingMinute, lastEpisode, 0);
            Application.Exit();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        private void lbl_home_MouseHover(object sender, EventArgs e)
        {
            lbl_home.ForeColor = Color.FromArgb(225, 1, 9);
        }

        private void lbl_home_MouseLeave(object sender, EventArgs e)
        {
            lbl_home.ForeColor = Color.FromArgb(252, 252, 252);
        }

        private void lbl_series_MouseHover(object sender, EventArgs e)
        {
            lbl_series.ForeColor = Color.FromArgb(225, 1, 9);
        }

        private void lbl_series_MouseLeave(object sender, EventArgs e)
        {
            lbl_series.ForeColor = Color.FromArgb(252, 252, 252);
        }

        private void lbl_movies_MouseHover(object sender, EventArgs e)
        {
            lbl_movies.ForeColor = Color.FromArgb(225, 1, 9);
        }

        private void lbl_movies_MouseLeave(object sender, EventArgs e)
        {
            lbl_movies.ForeColor = Color.FromArgb(252, 252, 252);
        }

        private void lbl_myList_MouseHover(object sender, EventArgs e)
        {
            lbl_myList.ForeColor = Color.FromArgb(255, 1, 9);
        }

        private void lbl_myList_MouseLeave(object sender, EventArgs e)
        {
            lbl_myList.ForeColor = Color.FromArgb(252, 252, 252);
        }

        private void lbl_tvShows_MouseHover(object sender, EventArgs e)
        {
            lbl_tvShows.ForeColor = Color.FromArgb(255, 1, 9);
        }

        private void lbl_tvShows_MouseLeave(object sender, EventArgs e)
        {
            lbl_tvShows.ForeColor = Color.FromArgb(252, 252, 252);
        }

        private void btn_tableView_Click(object sender, EventArgs e)
        {
            pnl_listView.Visible = false;
            pnl_tableView.Visible = true;
            pnl_info.Visible = false;
            resetTimer();
            fillTableBanner(2);
        }

        private void btn_listView_Click(object sender, EventArgs e)
        {
            pnl_listView.Visible = true;
            pnl_tableView.Visible = false;
            pnl_info.Visible = false;
            resetTimer();
            fillListBanner(2);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            database.getPrograms("AnaSayfa");
            fillTableBanner(2);
        }

        private void btn_tableNext_Click(object sender, EventArgs e)
        {
            fillTableBanner(1);
        }

        private void btn_tablePrev_Click(object sender, EventArgs e)
        {
            fillTableBanner(0);
        }

        private void btn_listNext_Click(object sender, EventArgs e)
        {
            fillListBanner(1);
        }

        private void btn_listPrev_Click(object sender, EventArgs e)
        {
            fillListBanner(0);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            database.Search(txt_search.Text);
            fillTableBanner(3);
            fillListBanner(3);
            pnl_info.Visible = false;
            resetTimer();
        }

        private void lbl_home_Click(object sender, EventArgs e)
        {
            database.getPrograms("AnaSayfa");
            fillTableBanner(3);
            fillListBanner(3);
            pnl_info.Visible = false;
            resetTimer();
        }

        private void lbl_series_Click(object sender, EventArgs e)
        {
            database.getPrograms("Dizi");
            fillTableBanner(3);
            fillListBanner(3);
            pnl_info.Visible = false;
            resetTimer();
        }

        private void lbl_movies_Click(object sender, EventArgs e)
        {
            database.getPrograms("Film");
            fillTableBanner(3);
            fillListBanner(3);
            pnl_info.Visible = false;
            pnl_watch.Visible = false;
            resetTimer();
        }

        private void lbl_tvShows_Click(object sender, EventArgs e)
        {
            database.getPrograms("Tv Show");
            fillTableBanner(3);
            fillListBanner(3);
            pnl_info.Visible = false;
            resetTimer();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            pnl_info.Visible = false;
        }

        private void picBox2_Click(object sender, EventArgs e)
        {
            Info(database.programs[index + 1]);
            choosedProgramIndex = index + 1;
        }

        private void picBox3_Click(object sender, EventArgs e)
        {
            Info(database.programs[index + 2]);
            choosedProgramIndex = index + 2;
        }

        private void picBox4_Click(object sender, EventArgs e)
        {
            Info(database.programs[index + 3]);
            choosedProgramIndex = index + 3;
        }

        private void picBox5_Click(object sender, EventArgs e)
        {
            Info(database.programs[index + 4]);
            choosedProgramIndex = index + 4;
        }

        private void picBox6_Click(object sender, EventArgs e)
        {
            Info(database.programs[index + 5]);
            choosedProgramIndex = index + 5;
        }

        private void picBox7_Click(object sender, EventArgs e)
        {
            Info(database.programs[index + 6]);
            choosedProgramIndex = index + 6;
        }

        private void picBox8_Click(object sender, EventArgs e)
        {
            Info(database.programs[index + 7]);
            choosedProgramIndex = index + 7;
        }

        private void picBox9_Click(object sender, EventArgs e)
        {
            Info(database.programs[index + 8]);
            choosedProgramIndex = index + 8;
        }

        private void picBox10_Click(object sender, EventArgs e)
        {
            Info(database.programs[index + 9]);
            choosedProgramIndex = index + 9;
        }

        private void picBox11_Click(object sender, EventArgs e)
        {
            Info(database.programs[index + 10]);
            choosedProgramIndex = index + 10;
        }

        private void picBox12_Click(object sender, EventArgs e)
        {
            Info(database.programs[index + 11]);
            choosedProgramIndex = index + 11;
        }

        private void picBox1_MouseHover(object sender, EventArgs e)
        {
            picBoxEffect(picBox1, true);
        }

        private void picBox1_MouseLeave(object sender, EventArgs e)
        {
            picBoxEffect(picBox1, false);
        }

        private void picBox2_MouseHover(object sender, EventArgs e)
        {
            picBoxEffect(picBox2, true);
        }

        private void picBox2_MouseLeave(object sender, EventArgs e)
        {
            picBoxEffect(picBox2, false);
        }

        private void picBox3_MouseHover(object sender, EventArgs e)
        {
            picBoxEffect(picBox3, true);
        }

        private void picBox3_MouseLeave(object sender, EventArgs e)
        {
            picBoxEffect(picBox3, false);
        }

        private void picBox4_MouseHover(object sender, EventArgs e)
        {
            picBoxEffect(picBox4, true);
        }

        private void picBox4_MouseLeave(object sender, EventArgs e)
        {
            picBoxEffect(picBox4, false);
        }

        private void picBox5_MouseHover(object sender, EventArgs e)
        {
            picBoxEffect(picBox5, true);
        }

        private void picBox5_MouseLeave(object sender, EventArgs e)
        {
            picBoxEffect(picBox5, false);
        }

        private void picBox6_MouseHover(object sender, EventArgs e)
        {
            picBoxEffect(picBox6, true);
        }

        private void picBox6_MouseLeave(object sender, EventArgs e)
        {
            picBoxEffect(picBox6, false);
        }

        private void picBox7_MouseHover(object sender, EventArgs e)
        {
            picBoxEffect(picBox7, true);
        }

        private void picBox7_MouseLeave(object sender, EventArgs e)
        {
            picBoxEffect(picBox7, false);
        }

        private void picBox8_MouseHover(object sender, EventArgs e)
        {
            picBoxEffect(picBox8, true);
        }

        private void picBox8_MouseLeave(object sender, EventArgs e)
        {
            picBoxEffect(picBox8, false);
        }

        private void picBox9_MouseHover(object sender, EventArgs e)
        {
            picBoxEffect(picBox9, true);
        }

        private void picBox9_MouseLeave(object sender, EventArgs e)
        {
            picBoxEffect(picBox9, false);
        }

        private void picBox10_MouseHover(object sender, EventArgs e)
        {
            picBoxEffect(picBox10, true);
        }

        private void picBox10_MouseLeave(object sender, EventArgs e)
        {
            picBoxEffect(picBox10, false);
        }

        private void picBox11_MouseHover(object sender, EventArgs e)
        {
            picBoxEffect(picBox11, true);
        }

        private void picBox11_MouseLeave(object sender, EventArgs e)
        {
            picBoxEffect(picBox11, false);
        }

        private void picBox12_MouseHover(object sender, EventArgs e)
        {
            picBoxEffect(picBox12, true);
        }

        private void picBox12_MouseLeave(object sender, EventArgs e)
        {
            picBoxEffect(picBox12, false);
        }

        private void btn_watch1_Click(object sender, EventArgs e)
        {
            choosedProgramIndex = indexList;
            Watch(database.programs[choosedProgramIndex]);
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search_Click(sender,e);
                pnl_watch.Visible = false;
                resetTimer();
            }
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            pnl_watch.Visible = false;
        }

        private void btn_watch_Click(object sender, EventArgs e)
        {
            Watch(database.programs[choosedProgramIndex]);
        }

        private void btn_watch2_Click(object sender, EventArgs e)
        {
            choosedProgramIndex = indexList + 1;
            Watch(database.programs[choosedProgramIndex]);
        }

        private void btn_watch3_Click(object sender, EventArgs e)
        {
            choosedProgramIndex = indexList + 2;
            Watch(database.programs[choosedProgramIndex]);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btn_stop.Enabled = false;
            btn_play.Enabled = true;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            timer.Start();
            btn_stop.Enabled = true;
            btn_play.Enabled = false;
            b = true;
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                timer.Stop();
                Puan puan = new Puan(userID, database.programs[choosedProgramIndex].id, passingMinute, lastEpisode);
                puan.ShowDialog();
                b = false;
                passingSecond = 0;
                lbl_timer.Text = passingSecond.ToString();
                btn_play.Enabled = true;
                btn_stop.Enabled = false;
            }
            pnl_watch.Visible = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                timer.Stop();
                Puan puan = new Puan(userID, database.programs[choosedProgramIndex].id, passingMinute, lastEpisode);
                puan.ShowDialog();
                b = false;
                passingSecond = 0;
                lbl_timer.Text = passingSecond.ToString();
                btn_play.Enabled = true;
                btn_stop.Enabled = false;
            }
            pnl_watch.Visible = false;
        }

        private void btn_watchPanel_Click(object sender, EventArgs e)
        {
            WatchPanelButtonClick(database.programs[choosedProgramIndex],listBox_episodes.SelectedIndex+1);
        }

        private void lbl_myList_Click(object sender, EventArgs e)
        {
            database.getMyList(userID);
            fillTableBanner(3);
            fillListBanner(3);
            pnl_info.Visible = false;
            pnl_watch.Visible = false;
            resetTimer();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            passingMinute = 0;
            passingSecond = 0;
            lbl_passingTime.Text = passingMinute.ToString() + " dk";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            passingSecond = passingSecond + 1;
            lbl_timer.Text = passingSecond.ToString();
            if (passingSecond == 60)
            {
                passingMinute = passingMinute + 1;
                passingSecond = 0;
                lbl_passingTime.Text = passingMinute.ToString() + " dk";
            }
            if (passingMinute == database.programs[choosedProgramIndex].programLength)
            {
                timer.Stop();
                timer.Stop();
                Puan puan = new Puan(userID, database.programs[choosedProgramIndex].id, passingMinute, lastEpisode);
                puan.ShowDialog();
                pnl_watch.Visible = false;
            }
        }

        private void picBox1_Click(object sender, EventArgs e)
        {
            Info(database.programs[index]);
            choosedProgramIndex = index;
        }
    }
}
