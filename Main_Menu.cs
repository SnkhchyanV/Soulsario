using System.Media;


namespace My_Mario
{
    public partial class Main_Menu : Form
    {
        

        MyPlayerInfo playerInfo;
        public Main_Menu(ref MyPlayerInfo pi)
        {
            InitializeComponent();
            playerInfo = pi;
            playerInfo.SetSong("Main Menu.wav");
        }

        private void play_button_Click(object sender, EventArgs e)        
        { 
            Level_Table inst_lt = new Level_Table(ref playerInfo);
            inst_lt.Show();
            this.Hide();
        }

        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            Camp my_camp = new Camp(false,ref playerInfo);
            my_camp.Show();
            this.Hide();
        }
    }
}
