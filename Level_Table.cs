using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace My_Mario
{

    public partial class Level_Table : Form
    {
        private MyPlayerInfo playerInfo;
        public Level_Table(ref MyPlayerInfo pi)
        {
           
            InitializeComponent();
            playerInfo = pi;
            Coins.Text = "Souls:" + playerInfo.getSouls();
            playerInfo.SetSong("Main Menu.wav");

         
            
        }

        //backward buttun
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main_Menu inst_mm = new Main_Menu(ref playerInfo);
            inst_mm.Show();
            this.Hide();
        }

        //clos bottom
        private void closeLevelTable(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            playerInfo.StopSong();
        }

        //Music bottom
        private void MusicOnOFF_Click(object sender, EventArgs e)
        {
            playerInfo.MusicOnOff();
            if (playerInfo.CheckMusicStatus())
            {
                MusicOnOFF.Image = Properties.Resources.MusicOn;
                playerInfo.SetSong("Main Menu.wav");
            }
            else
            {
                MusicOnOFF.Image = Properties.Resources.MusicOff;
                playerInfo.StopSong();
            }
        }

   
        private void ThunderIcon_Click(object sender, EventArgs e)
        {
            Camp LUPT = new Camp(true,ref playerInfo);
            LUPT.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThunderIcon_Click(sender, e);
        }

        private void ThunderIcon_MouseLeave(object sender, EventArgs e)
        {
            ThunderIcon.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void ThunderIcon_MouseMove(object sender, MouseEventArgs e)
        {
            ThunderIcon.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }
        private void level_1_but_Click(object sender, EventArgs e)
        {
            playerInfo.StopSong();
            Level_1 inst_lv1 = new Level_1(ref playerInfo);
            inst_lv1.Show();
            this.Hide();
        }

        private void level_2_but_Click(object sender, EventArgs e)
        {
            if (playerInfo.isLevelPassed(1))
            {
                playerInfo.StopSong();
                Level_2 inst_lv2 = new Level_2(ref playerInfo);
                inst_lv2.Show();
                this.Hide();
            }
            else MessageBox.Show("You haven't pass previous level!" + "\n" + " It's early to travel in this one!");
        }

        private void level_3_but_Click(object sender, EventArgs e)
        {
            if (playerInfo.isLevelPassed(2))
            {
               
                MessageBox.Show("Level isn't ready yet!");
            }
            else MessageBox.Show("You haven't pass previous level!" + "\n" + " It's early to travel in this one!");
        }
        private void level_4_but_Click(object sender, EventArgs e)
        {
            if (playerInfo.isLevelPassed(3))
            {

            }
            else MessageBox.Show("You haven't pass previous level!" + "\n" + " It's early to travel in this one!");
        }

        private void level_5_but_Click(object sender, EventArgs e)
        {
            if (playerInfo.isLevelPassed(4))
            {
                
            }
            else MessageBox.Show("You haven't pass previous level!" + "\n" + " It's early to travel in this one!");
        }

        private void level_6_but_Click(object sender, EventArgs e)
        {
            if (playerInfo.isLevelPassed(5))
            {
               
            }
            else MessageBox.Show("You haven't pass previous level!" + "\n" + " It's early to travel in this one!");
        }

        private void level_7_but_Click(object sender, EventArgs e)
        {
            if (playerInfo.isLevelPassed(6))
            {
                
            }
            else MessageBox.Show("You haven't pass previous level!" + "\n" + " It's early to travel in this one!");
        }

        private void level_8_but_Click(object sender, EventArgs e)
        {
            if (playerInfo.isLevelPassed(7))
            {
                
            }
            else MessageBox.Show("You haven't pass previous level!" + "\n" + " It's early to travel in this one!");
        }


    }
}
