using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Mario
{
    
    public partial class Camp : Form
    {
        static bool returnto = false; // 0 to mainmenu, 1 to leveltable 
        MyPlayerInfo playerinfo;
        public Camp(bool FromWhereReturned, ref MyPlayerInfo pi)
        {
            InitializeComponent();
            returnto = FromWhereReturned;
            playerinfo = pi;

            if(playerinfo.HaveFireBAll())
            {
                FireBallSkill.ForeColor = Color.Green;
            }
          
        }

        private void Level_UP_Table_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Camp_Load(object sender, EventArgs e)
        {
            playerinfo.SetSong("bonfire.wav");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(!returnto)
            {
                Main_Menu camp_mm_go = new Main_Menu(ref playerinfo);
                camp_mm_go.Show();
                this.Hide();
            }
            else {
                Level_Table camp_mm_go = new Level_Table(ref playerinfo);
                camp_mm_go.Show();
                this.Hide();
            }
            
        }
    }
}
