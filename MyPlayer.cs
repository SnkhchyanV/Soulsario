using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Media;
using System.Runtime.InteropServices;

namespace My_Mario
    
{
    
    public class MyPlayerInfo
    {

        
        static int Level = 0;
        static int Souls = 0;
        static bool[] passes = new bool[10];
        static bool isMusicOn = true;
        SoundPlayer MyPlayer = new SoundPlayer();

        static int faith = 10;
        static int fluke = 3;
        static int speed = 10;
        static int defence = 10;

        static bool havefireball = true;
        public MyPlayerInfo()
        {
            passes[1] = true;
        }
        
        public bool HaveFireBAll()
        {
            return havefireball;
        }
        

        public int GetFaith()
        {
            return faith;
        }

        public int GetFluke()
        {
            return fluke;
        }

       public int GetSpeed()
        {
            return speed;
        }


        public int GetDefence()
        {
            return defence;
        }

        
        public void SetSong(string a)
        {
            MyPlayer.SoundLocation = a;
            MyPlayer.PlayLooping();
        }

        public void StopSong()
        {
            MyPlayer.Stop();
        }
        
        public int getSouls()
        {
            return Souls;
        }
        public void addSouls(int value)
        {
            Souls += value;
        }
        public void setLevelPassed(int i)
        {
            passes[i] = true;

        }
        public bool isLevelPassed(int i)
        {
            return passes[i];
        }

        public bool CheckMusicStatus()
        {
            return isMusicOn;
        }

        public void MusicOnOff()
        {
            isMusicOn = !isMusicOn;
        }
        
    }
}
