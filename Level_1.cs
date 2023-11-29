namespace My_Mario
{
    public partial class Level_1 : Form
    {
        bool isLeft = false, isRight = false, isJumping = false;
        int jumpSpeed = 25;
        int force = 7;
        int score = 0;
        const int playerSpeed = 8;
        const int backgroundSpeed = 10;
        int lifeNum;
        bool hasImmune = false;
        const int ghostSpeed = 6;
        bool returned = false; // false is left, true is right ghost1
        bool returned1 = false; // ghost2
        bool returned2 = true; // ghost3
        bool returned4 = false;
        bool returned5 = false;
        int timerTicks = 0;
        MyPlayerInfo playerInfo;

        public Level_1(ref MyPlayerInfo pi, int heartnum = 3)
        {

            InitializeComponent();
            this.lifeNum = heartnum;
            this.DoubleBuffered = true;
            playerInfo = pi;
           

        }
        private void Flashing_Timer_Real(object sender, EventArgs e)
        {
            player.Visible = !player.Visible;
            timerTicks++;
            if (timerTicks == 10)
            {
                hasImmune = false;
                flashingTimer.Stop();
                player.Visible = true;
                timerTicks = 0;
            }

        }
        private void mainGameTimer(object sender, EventArgs e)
        {
            txtScore.Text = "Souls:" + score;
            player.Top += jumpSpeed;

            if (isLeft && player.Left > bonfire1.Left)
            {
                if (player.Left > 50) player.Left -= playerSpeed;

                if (player.Left > bonfire1.Left + 20)
                {
                    background_move_left();
                    moveGameElems();

                    if (player.Left < 60)
                    {
                        background_move_left();
                        moveGameElems();
                    }
                }
            }
            if (isRight)
            {
                if (player.Left + (player.Width + 150) < this.ClientSize.Width) player.Left += playerSpeed;

                if (player.Right < bonfire_closed.Right + 5)
                {
                    background_move_right();
                    moveGameElems();

                    if ((player.Width + 160) > this.ClientSize.Width)
                    {
                        background_move_right();
                        moveGameElems();
                    }

                }
            }


            // Jumping bools
            if (isJumping)
            {

                jumpSpeed = -25;
                force -= 1;

            }
            else
            {
                jumpSpeed = 25;
            }

            if (isJumping && force < 0)
            {
                isJumping = false;
            }


            //Checking pictureboxes
            foreach (Control x in this.Controls)
            {
                if (player.Bounds.IntersectsWith(x.Bounds))
                {
                    // To save player on platform;
                    if ((string)x.Tag == "platform")
                    {
                        if (player.Top - x.Top < 0 && !isJumping)
                        {
                            force = 7;
                            player.Top = x.Top - player.Height + 1;
                            jumpSpeed = 0;

                        }


                    }

                    if (x.Visible)
                    {
                        //If player touches Coins
                        if ((string)x.Tag == "coin")
                        {
                            x.Visible = false;
                            score++;
                        }

                        // Touching theghost
                        if ((string)x.Tag == "ghost")
                        {

                            if (player.Bottom - x.Bottom < 0 && !hasImmune)
                            {
                                player.Top -= jumpSpeed;
                                x.Visible = false;
                                score += 5;
                            }
                            else
                            {
                                if (!hasImmune)
                                {

                                    hasImmune = true;
                                    flashingTimer.Start();
                                    lifeNum--;
                                }

                            }

                            if (lifeNum == 0)
                            {
                                heart1.Visible = false;
                                flashingTimer.Stop();
                                gameTimer1.Stop();
                                MessageBox.Show("You Died" + "\n" + "Please, klick OK to return to level table menu!");
                                endGame();
                            }


                        }
                    }
                }

            }

            //Door Opening
            if (player.Bounds.IntersectsWith(bonfire_closed.Bounds))
            {
                flashingTimer.Stop();
                gameTimer1.Stop();
                MessageBox.Show("Congratulations! You succesfully end your journey!" + Environment.NewLine + "Click OK to return the level table menu");
                endGame(true);
            }

            //life icons controls
            if (lifeNum == 2)
            {
                heart3.Visible = false;
            }
            if (lifeNum == 1)
            {
                heart3.Visible = false;
                heart2.Visible = false;
            }

            //dieing from falling 
            if (player.Top + player.Height > this.ClientSize.Height)
            {
                lifeNum--;
                if (lifeNum > 0) restartGame(lifeNum);
                else
                {
                    heart1.Visible = false;
                    gameTimer1.Stop();
                    flashingTimer.Stop();
                    MessageBox.Show("You Died" + "\n" + "Please, klick OK to return to level table menu!");
                    endGame();

                }
            }

            //Ghost AI
            // false is left, true is right
            if (!returned)
            {
                ghost1.Left -= ghostSpeed;

                if (ghost1.Right <= pictureBox47.Left)
                {
                    ghost1.Image = Properties.Resources.GhostRight;
                    returned = true;
                }

            }
            else
            {
                ghost1.Left += ghostSpeed;

                if (ghost1.Left >= pictureBox47.Right)
                {
                    ghost1.Image = Properties.Resources.GhostLeft;
                    returned = false;
                }

            }

            if (!returned1)
            {
                ghost2.Left -= ghostSpeed;

                if (ghost2.Right <= pictureBox48.Left)
                {
                    ghost2.Image = Properties.Resources.GhostRight;
                    returned1 = true;
                }

            }
            else
            {
                ghost2.Left += ghostSpeed;

                if (ghost2.Left >= pictureBox48.Right)
                {
                    ghost2.Image = Properties.Resources.GhostLeft;
                    returned1 = false;
                }

            }


            if (!returned2)
            {
                ghost3.Left -= ghostSpeed;

                if (ghost3.Right <= pictureBox1.Left)
                {
                    ghost3.Image = Properties.Resources.GhostRight;
                    returned2 = true;
                }

            }
            else
            {
                ghost3.Left += ghostSpeed;

                if (ghost3.Left >= pictureBox1.Right)
                {
                    ghost3.Image = Properties.Resources.GhostLeft;
                    returned2 = false;
                }

            }


            if (!returned5)
            {
                ghost5.Left -= ghostSpeed;

                if (ghost5.Right <= pictureBox40.Left)
                {
                    ghost5.Image = Properties.Resources.GhostRight;
                    returned5 = true;
                }

            }
            else
            {
                ghost5.Left += ghostSpeed;

                if (ghost5.Left >= pictureBox40.Right)
                {
                    ghost5.Image = Properties.Resources.GhostLeft;
                    returned5 = false;
                }

            }

            if (!returned4)
            {
                ghost4.Left -= ghostSpeed;

                if (ghost4.Right <= pictureBox3.Left)
                {
                    ghost4.Image = Properties.Resources.GhostRight;
                    returned4 = true;
                }

            }
            else
            {
                ghost4.Left += ghostSpeed;

                if (ghost4.Left >= pictureBox3.Right)
                {
                    ghost4.Image = Properties.Resources.GhostLeft;
                    returned4 = false;
                }

            }




        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Left)
            {
                if (isLeft == false)
                {
                    player.Image = Properties.Resources.SolaireRuningLeft;
                    isLeft = true;



                }
            }


            if (e.KeyCode == Keys.Right)
            {
                if (isRight == false)
                {
                    player.Image = Properties.Resources.SolaireRuningRight;
                    isRight = true;

                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if (!isJumping)
                    isJumping = true;

            }

            //if(e.KeyCode == Keys.LButton)
            //{
            //    PictureBox fireball = new PictureBox();
            //    fireball.Left = player.Left;
            //    fireball.Top = player.Top;
               

            //    if(player.Image == Properties.Resources.SolaireStandingLeft || isLeft)
            //    {
            //        fireball.Image = Properties.Resources.coin;
            //        fireball.Visible = true;
            //    }
            
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

                player.Image = Properties.Resources.SolaireStandingLeft;
                isLeft = false;

            }

            if (e.KeyCode == Keys.Right)
            {

                player.Image = Properties.Resources.SolaireStandingRight;
                isRight = false;



            }

            if (isJumping == true)
            {
                isJumping = false;

            }
        }

        private void closeGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        Image Level_1_bg = Properties.Resources.level_1_background;
        int b1 = 0, b2 = 1210, b3 = -1210;
        private void Level_1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Level_1_bg, b1, 0);
            e.Graphics.DrawImage(Level_1_bg, b2, 0);
            e.Graphics.DrawImage(Level_1_bg, b3, 0);
            //player.CreateGraphics();

        }

        private void endGame(bool ispassed = false)
        {

            if (ispassed)
            {
                if (!playerInfo.isLevelPassed(1))
                {
                    playerInfo.setLevelPassed(1);
                    playerInfo.addSouls(score);
                }
            }
            Level_Table new_inst_lvtb = new Level_Table(ref playerInfo);
            new_inst_lvtb.Show();
            this.Hide();
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {

        }

        private void Level_1_Load(object sender, EventArgs e)
        {

            playerInfo.SetSong("level 1.wav");
        }

        private void restartGame(int heartnum)
        {
            gameTimer1.Stop();
            flashingTimer.Stop();
            Level_1 new_game = new Level_1(ref playerInfo, heartnum);
            new_game.Show();
            this.Hide();
        }

        private void moveGameElems() //true = right , false = left 
        {
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "platform" || (string)x.Tag == "bonfire" || (string)x.Tag == "key" || (string)x.Tag == "coin" || (string)x.Tag == "ghost")
                {
                    if (isRight)
                    {
                        x.Left -= backgroundSpeed;

                    }
                    else
                    {
                        x.Left += backgroundSpeed;

                    }
                }
            }
        }

        void background_move_right()
        {
            b1 -= backgroundSpeed;
            b2 -= backgroundSpeed;
            b3 -= backgroundSpeed;
            Invalidate();
            if (b1 < -1210)
            {
                b1 = 1210;

            }
            if (b2 < -1210)
            {
                b2 = 1210;
            }
            if (b3 < -1210)
            {
                b3 = 1210;
            }
            Invalidate();

        }
        void background_move_left()
        {

            b1 += backgroundSpeed;
            b2 += backgroundSpeed;
            b3 += backgroundSpeed;
            Invalidate();
            //if (b3 > 1210)
            //{
            //    b3 = 0;
            //}
            //if (b1 > 1210)
            //{
            //    b1 = 0;
            //}
            //if (b2 > 1210)
            //{
            //    b2 = 0;
            //}
            //Invalidate();
        }
    }
}