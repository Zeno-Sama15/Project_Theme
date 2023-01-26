using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Project_theme
{
    public partial class Form2 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Tem certeza de que deseja sair?", "Atenção", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (DialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("The Legend of Zelda Ocarina of Time");
                listBox1.Items.Add("The Legend of Zelda Majora's Mask");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                pictureBox1.Image = null;
                label6.Text = "";
                label4.Text = "";
                label10.Text = "";
                label5.Text = "";
                label7.Text = "";
                label8.Text = "";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("The Legend of Zelda The Wind Waker");
                listBox1.Items.Add("The Legend of Zelda Twilight Princess");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                pictureBox1.Image = null;
                label6.Text = "";
                label4.Text = "";
                label10.Text = "";
                label5.Text = "";
                label7.Text = "";
                label8.Text = "";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("The Legend of Zelda Breath of The Wild");
                listBox1.Items.Add("The Legend of Zelda Link's Awakening");
                listBox1.Items.Add("The Legend of Zelda Skyward Sword");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                pictureBox1.Image = null;
                label6.Text = "";
                label4.Text = "";
                label10.Text = "";
                label5.Text = "";
                label7.Text = "";
                label8.Text = "";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "The Legend of Zelda Ocarina of Time")
            {
                pictureBox1.Image = Properties.Resources.Wallpaper_OOT;
                label6.Text = "Link";
                label4.Text = "Navi";
                label10.Text = "Zelda";
                label5.Text = "Marlon";
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                label7.Text = "Zelda's Lullaby";
                label8.Text = "Lost Woods";
            }
            else if (listBox1.Text == "The Legend of Zelda Majora's Mask")
            {
                pictureBox1.Image = Properties.Resources.Wallpaper_MMS;
                label6.Text = "Deku Link";
                label4.Text = "Lua";
                label10.Text = "Skullkid";
                label5.Text = "Vendedor";
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                label7.Text = "Song of Healing";
                label8.Text = "Astral Observatory";
            }
            else if (listBox1.Text == "The Legend of Zelda The Wind Waker")
            {
                pictureBox1.Image = Properties.Resources.Wallpaper_TWW;
                label6.Text = "King Lions";
                label4.Text = "Medli";
                label10.Text = "Tetra";
                label5.Text = "Avó";
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                label7.Text = "The Legendary Hero";
                label8.Text = "Title Theme";
            }
            else if (listBox1.Text == "The Legend of Zelda Twilight Princess")
            {
                pictureBox1.Image = Properties.Resources.Wallpaper_TWP;
                label6.Text = "Midna";
                label4.Text = "Zant";
                label10.Text = "Zelda";
                label5.Text = "Ganondorf";
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                label7.Text = "Hidden Village";
                label8.Text = "Orchestra Piece #1";
            }
            else if (listBox1.Text == "The Legend of Zelda Breath of The Wild")
            {
                pictureBox1.Image = Properties.Resources.Wallpaper_BOTW;
                label6.Text = "Link";
                label4.Text = "Zelda";
                label10.Text = "Daruk";
                label5.Text = "Urbosa";
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                label7.Text = "Trailer Music";
                label8.Text = "Divine Beast Vah Medoh";
            }
            else if (listBox1.Text == "The Legend of Zelda Link's Awakening")
            {
                pictureBox1.Image = Properties.Resources.Wallpaper_LinksAwakening;
                label6.Text = "Link";
                label4.Text = "Owl";
                label10.Text = "Tarim";
                label5.Text = "Marim";
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                label7.Text = "Staff Credits";
                label8.Text = "Marin's Ballad of the Windfish";
            }
            else if (listBox1.Text == "The Legend of Zelda Skyward Sword")
            {
                pictureBox1.Image = Properties.Resources.Wallpaper_SWS;              
                label6.Text = "Ghiraim";
                label4.Text = "Fi";
                label10.Text = "Groose";
                label5.Text = "Zelda";
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                label7.Text = "Staff Roll";
                label8.Text = "Fi's Farewell Theme";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "The Legend of Zelda Ocarina of Time")
            {
                pictureBox4.Image = Properties.Resources.Link_OOT;
            }
            else if (listBox1.Text == "The Legend of Zelda Majora's Mask")
            {
                pictureBox4.Image = Properties.Resources.DekuLink_MMS;
            }
            else if (listBox1.Text == "The Legend of Zelda The Wind Waker")
            {
                pictureBox4.Image = Properties.Resources.KingofRedLions_TWW;
            }
            else if (listBox1.Text == "The Legend of Zelda Twilight Princess")
            {
                pictureBox4.Image = Properties.Resources.Midna_TWP;
            }
            else if (listBox1.Text == "The Legend of Zelda Breath of The Wild")
            {
                pictureBox4.Image = Properties.Resources.Link_BOTW;
            }
            else if (listBox1.Text == "The Legend of Zelda Link's Awakening")
            {
                pictureBox4.Image = Properties.Resources.Link_LinksAwakening;
            }
            else if (listBox1.Text == "The Legend of Zelda Skyward Sword")
            {
                pictureBox4.Image = Properties.Resources.Ghiraim_SWS;
            }
            if (checkBox4.Checked == false)
            {
                this.pictureBox4.Image = null;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "The Legend of Zelda Ocarina of Time")
            {
                pictureBox2.Image = Properties.Resources.Navi_OOT;
            }
            else if (listBox1.Text == "The Legend of Zelda Majora's Mask")
            {
                pictureBox2.Image = Properties.Resources.Lua_MMS;
            }
            else if (listBox1.Text == "The Legend of Zelda The Wind Waker")
            {
                pictureBox2.Image = Properties.Resources.Medli_TWW;
            }
            else if (listBox1.Text == "The Legend of Zelda Twilight Princess")
            {
                pictureBox2.Image = Properties.Resources.Zant_TWP;
            }
            else if (listBox1.Text == "The Legend of Zelda Breath of The Wild")
            {
                pictureBox2.Image = Properties.Resources.Zelda_BOTW;
            }
            else if (listBox1.Text == "The Legend of Zelda Link's Awakening")
            {
                pictureBox2.Image = Properties.Resources.Owl_LinksAwakening;
            }
            else if (listBox1.Text == "The Legend of Zelda Skyward Sword")
            {
                pictureBox2.Image = Properties.Resources.Fi_SWS;
            }
            if (checkBox1.Checked == false)
            {
                this.pictureBox2.Image = null;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "The Legend of Zelda Ocarina of Time")
            {
                pictureBox3.Image = Properties.Resources.Zelda_OOT;
            }
            else if (listBox1.Text == "The Legend of Zelda Majora's Mask")
            {
                pictureBox3.Image = Properties.Resources.SkullKid_MMS;
            }
            else if (listBox1.Text == "The Legend of Zelda The Wind Waker")
            {
                pictureBox3.Image = Properties.Resources.Tetra_TWW;
            }
            else if (listBox1.Text == "The Legend of Zelda Twilight Princess")
            {
                pictureBox3.Image = Properties.Resources.Zelda_TWP;
            }
            else if (listBox1.Text == "The Legend of Zelda Breath of The Wild")
            {
                pictureBox3.Image = Properties.Resources.Daruk_BOTW1;
            }
            else if (listBox1.Text == "The Legend of Zelda Link's Awakening")
            {
                pictureBox3.Image = Properties.Resources.Tarin_LinksAwakening;
            }
            else if (listBox1.Text == "The Legend of Zelda Skyward Sword")
            {
                pictureBox3.Image = Properties.Resources.Groose_SWS;
            }
            if (checkBox2.Checked == false)
            {
                this.pictureBox3.Image = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "The Legend of Zelda Ocarina of Time")
            {
                pictureBox5.Image = Properties.Resources.Marlon_OOT;
            }
            else if (listBox1.Text == "The Legend of Zelda Majora's Mask")
            {
                pictureBox5.Image = Properties.Resources.Vendedor_MMS;
            }
            else if (listBox1.Text == "The Legend of Zelda The Wind Waker")
            {
                pictureBox5.Image = Properties.Resources.Grandma_TWW;
            }
            else if (listBox1.Text == "The Legend of Zelda Twilight Princess")
            {
                pictureBox5.Image = Properties.Resources.Ganondorf_TWP;
            }
            else if (listBox1.Text == "The Legend of Zelda Breath of The Wild")
            {
                pictureBox5.Image = Properties.Resources.Urbosa_BOTW;
            }
            else if (listBox1.Text == "The Legend of Zelda Link's Awakening")
            {
                pictureBox5.Image = Properties.Resources.Marin_LinksAwakening;
            }
            else if (listBox1.Text == "The Legend of Zelda Skyward Sword")
            {
                pictureBox5.Image = Properties.Resources.Zelda_SWS1;
            }
            if (checkBox3.Checked == false)
            {
                this.pictureBox5.Image = null;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                player.controls.stop();
            }
            else
            {
                if (listBox1.Text == "The Legend of Zelda Ocarina of Time")
                {
                    player.URL = "Music1_OOT.mp3";
                }
                else if (listBox1.Text == "The Legend of Zelda Majora's Mask")
                {
                    player.URL = "Music1_MMS.mp3";
                }
                else if (listBox1.Text == "The Legend of Zelda The Wind Waker")
                {
                    player.URL = "Music1_TWW.mp3";
                }
                else if (listBox1.Text == "The Legend of Zelda Twilight Princess")
                {
                    player.URL = "Music1_TWP.mp3";
                }
                else if (listBox1.Text == "The Legend of Zelda Breath of The Wild")
                {
                    player.URL = "Music1_BOTW.mp3";
                }
                else if (listBox1.Text == "The Legend of Zelda Link's Awakening")
                {
                    player.URL = "Music1_LAK.mp3";
                }
                else if (listBox1.Text == "The Legend of Zelda Skyward Sword")
                {
                    player.URL = "Music1_SWS.mp3";
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == false)
            {
                player.controls.stop();
            }
            else
            {
                if (listBox1.Text == "The Legend of Zelda Ocarina of Time")
                {
                    player.URL = "Music2_OOT.mp3";
                }
                else if (listBox1.Text == "The Legend of Zelda Majora's Mask")
                {
                    player.URL = "Music2_MMS.mp3";
                }
                else if (listBox1.Text == "The Legend of Zelda The Wind Waker")
                {
                    player.URL = "Music2_TWW.mp3";
                }
                else if (listBox1.Text == "The Legend of Zelda Twilight Princess")
                {
                    player.URL = "Music2_TWP.mp3";
                }
                else if (listBox1.Text == "The Legend of Zelda Breath of The Wild")
                {
                    player.URL = "Music2_BOTW.mp3";
                }
                else if (listBox1.Text == "The Legend of Zelda Link's Awakening")
                {
                    player.URL = "Music2_LAK.mp3";
                }
                else if (listBox1.Text == "The Legend of Zelda Skyward Sword")
                {
                    player.URL = "Music2_SWS.mp3";
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
