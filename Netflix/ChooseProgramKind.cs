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
    public partial class ChooseProgramKind : Form
    {
        int chooseCount = 0;
        List<string> kinds = new List<string>();

        public ChooseProgramKind()
        {
            InitializeComponent();
        }

        private void chcBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBox1.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Aksiyon ve Macera");
                    chooseCount = chooseCount + 1;
                }
                else
                    chcBox1.Checked = false;
            }
            else if (chcBox1.Checked == false)
            {
                kinds.Remove("Aksiyon ve Macera");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Romantizm");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox2.Checked = false;
            }
            else if (checkBox2.Checked == false)
            {
                kinds.Remove("Romantizm");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Dramalar");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox5.Checked = false;
            }
            else if (checkBox5.Checked == false)
            {
                kinds.Remove("Dramalar");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Çocuk ve Aile");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox4.Checked = false;
            }
            else if (checkBox4.Checked == false)
            {
                kinds.Remove("Çocuk ve Aile");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Belgesel");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox3.Checked = false;
            }
            else if (checkBox3.Checked == false)
            {
                kinds.Remove("Belgesel");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Komedi");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox8.Checked = false;
            }
            else if (checkBox8.Checked == false)
            {
                kinds.Remove("Komedi");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Reality Program");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox12.Checked = false;
            }
            else if (checkBox12.Checked == false)
            {
                kinds.Remove("Reality Program");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Anime");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox13.Checked = false;
            }
            else if (checkBox13.Checked == false)
            {
                kinds.Remove("Anime");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Bilim Kurgu ve Fantastik Yapımlar");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox1.Checked = false;
            }
            else if (checkBox1.Checked == false)
            {
                kinds.Remove("Bilim Kurgu ve Fantastik Yapımlar");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Aksiyon");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox7.Checked = false;
            }
            else if (checkBox7.Checked == false)
            {
                kinds.Remove("Aksiyon");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Korku");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox6.Checked = false;
            }
            else if (checkBox6.Checked == false)
            {
                kinds.Remove("Korku");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Bilim ve Doğa");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox9.Checked = false;
            }
            else if (checkBox9.Checked == false)
            {
                kinds.Remove("Bilim ve Doğa");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Bilim Kurgu");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox10.Checked = false;
            }
            else if (checkBox10.Checked == false)
            {
                kinds.Remove("Bilim Kurgu");
                chooseCount = chooseCount - 1;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                if (chooseCount != 3)
                {
                    kinds.Add("Gerilim");
                    chooseCount = chooseCount + 1;
                }
                else
                    checkBox11.Checked = false;
            }
            else if (checkBox11.Checked == false)
            {
                kinds.Remove("Gerilim");
                chooseCount = chooseCount - 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chooseCount == 3)
            {
                ShowKinds showKinds = new ShowKinds(kinds);
                showKinds.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Lütfen 3 adet tür seçiniz.", "Netflix", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
