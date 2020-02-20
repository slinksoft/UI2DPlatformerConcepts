using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMBSim
{
    public partial class Form1 : Form
    {
        bool left, right;
        bool isjumping, jumpingnow;
        int veolicty, maxveolicty;
        int coins;
        int[] qblock = new int[10];

        bool isfalling;
        bool isinvincible;

        // animation variables

        int form; //mario's current form 0 = tiny 1= big 2 = flower
        int animationswitch; //more info on anitimer
        bool goingleft, goingright; //for walking animations
        bool wasleft, wasright, wasjumping; //for jumping animations

        // mushroom variables

        bool mushroomfalling;
        bool mushroomgoingright, mushroomgoingleft;

        // goomba variables
        bool[] goombafalling = new bool[2];
        int[] goombastompped = new int[2];
        bool[] goombagoingright = new bool[2];
        bool[] goombagoingleft = new bool[2];

        // fireball variables
        bool[] firegoingleft = new bool[2];
        bool[] firegoingright = new bool[2];
        bool[] fireballfalling = new bool[2];
        int fireballout;
        bool disablefireball;

        // sfx initilizations

        System.Media.SoundPlayer powerup = new System.Media.SoundPlayer(Properties.Resources.smb_powerup);
        System.Media.SoundPlayer smalljump = new System.Media.SoundPlayer(Properties.Resources.smb_jump_small);
        System.Media.SoundPlayer bigjump = new System.Media.SoundPlayer(Properties.Resources.smb_jump_super);
        System.Media.SoundPlayer coinnoise = new System.Media.SoundPlayer(Properties.Resources.smb_coin);
        System.Media.SoundPlayer powerupappears = new System.Media.SoundPlayer(Properties.Resources.smb_powerup_appears);
        System.Media.SoundPlayer bump = new System.Media.SoundPlayer(Properties.Resources.smb_bump);
        System.Media.SoundPlayer stomped = new System.Media.SoundPlayer(Properties.Resources.smb_stomp);
        System.Media.SoundPlayer firesfx = new System.Media.SoundPlayer(Properties.Resources.smb_fireball);
        System.Media.SoundPlayer powerdown = new System.Media.SoundPlayer(Properties.Resources.smb_pipe);
        System.Media.SoundPlayer die = new System.Media.SoundPlayer(Properties.Resources.smb_mariodie);

        public Form1()
        {
            InitializeComponent();
            maxveolicty = 20;
            form = 0;
            coins = 0;
            goingright = true;
            mushroomgoingright = true;
            goombagoingleft[0] = true;
            wasright = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = true;

                wasleft = true;
                wasright = false;

                if (goingright == true && isjumping == false)
                {
                    goingright = false;
                    goingleft = true;
                    animationswitch = 3;
                }

            }

            if (e.KeyCode == Keys.Right)
            {
                right = true;

                wasright = true;
                wasleft = false;

                if (goingleft == true && isjumping == false)
                {
                    goingright = true;
                    goingleft = false;
                    animationswitch = 4;
                }


            }

            if (e.KeyCode == Keys.Up && isjumping == false)
            {
                isjumping = true;
                jumpingnow = true;
                veolicty = maxveolicty;
                jumpTimer.Enabled = true;

                wasjumping = true;
                if (wasright == true)
                {
                    animationswitch = 5;
                }
                else if (wasleft == true)
                {
                    animationswitch = 6;
                }


                if (form == 0)
                {
                    smalljump.Play();
                }
                else if (form == 1 || form == 2)
                {
                    bigjump.Play();
                }
            }
            if (e.KeyCode == Keys.Space && form == 2 && disablefireball == false)
            {
                fireAI.Start();
                if (wasleft == true)
                {
                    if (fireballout == 0)
                    {
                        fireballout = 1;
                        firegoingleft[0] = true;
                        fireball1.Location = mario.Location;
                        fireball1.Top += 8;
                        fireAI.Start();
                        firesfx.Play();
                    }
                    else if (fireballout == 1)
                    {
                        fireballout = 2;
                        firegoingleft[1] = true;
                        fireball2.Location = mario.Location;
                        fireball2.Top += 8;
                        fireAI.Start();
                        firesfx.Play();
                        disablefireball = true;
                    }
                }
                else if (wasright == true)
                {

                    if (fireballout == 0)
                    {
                        fireballout = 1;
                        firegoingright[0] = true;
                        fireball1.Location = mario.Location;
                        fireball1.Top += 8;
                        fireAI.Start();
                        firesfx.Play();
                    }
                    else if (fireballout == 1)
                    {
                        fireballout = 2;
                        firegoingright[1] = true;
                        fireball2.Location = mario.Location;
                        fireball2.Top += 8;
                        fireAI.Start();
                        firesfx.Play();
                        disablefireball = true;
                    }
                }
                else
                {
                }



            }
        }

        private void marioMovementCollision_Tick(object sender, EventArgs e)
        {
            #region groundcheck

            if (mario.Bounds.IntersectsWith(ground1.Bounds))
            {
                if (mario.Bottom > ground1.Top)
                {

                    isfalling = false;
                    if (jumpingnow == false)
                    {
                        isjumping = false;

                        if (wasjumping == true)
                        {
                            wasjumping = false;
                            if (wasright == true)
                            {
                                animationswitch = 2;
                            }
                            else if (wasleft == true)
                            {
                                animationswitch = 1;
                            }
                        }

                    }

                }
            }

            else if (mario.Bounds.IntersectsWith(ground2.Bounds))
            {
                if (mario.Bottom > ground2.Top)
                {
                    isfalling = false;

                    if (jumpingnow == false)
                    {
                        isjumping = false;

                        if (wasjumping == true)
                        {
                            wasjumping = false;
                            if (wasright == true)
                            {
                                animationswitch = 2;
                            }
                            else if (wasleft == true)
                            {
                                animationswitch = 1;
                            }
                        }
                    }
                }
            }

            else if (mario.Bounds.IntersectsWith(ground3.Bounds))
            {
                if (mario.Bottom > ground3.Top)
                {
                    isfalling = false;

                    if (jumpingnow == false)
                    {
                        isjumping = false;

                        if (wasjumping == true)
                        {
                            wasjumping = false;
                            if (wasright == true)
                            {
                                animationswitch = 2;
                            }
                            else if (wasleft == true)
                            {
                                animationswitch = 1;
                            }
                        }
                    }
                }
            }

            else if (mario.Bounds.IntersectsWith(ground4.Bounds))
            {
                if (mario.Bottom > ground4.Top)
                {
                    isfalling = false;

                    if (jumpingnow == false)
                    {
                        isjumping = false;

                        if (wasjumping == true)
                        {
                            wasjumping = false;
                            if (wasright == true)
                            {
                                animationswitch = 2;
                            }
                            else if (wasleft == true)
                            {
                                animationswitch = 1;
                            }
                        }
                    }
                }
            }

            else if (mario.Bounds.IntersectsWith(mainfloor.Bounds))
            {
                if (mario.Bottom > mainfloor.Top)
                {
                    isfalling = false;

                    if (jumpingnow == false)
                    {
                        isjumping = false;

                        if (wasjumping == true)
                        {
                            wasjumping = false;
                            if (wasright == true)
                            {
                                animationswitch = 2;
                            }
                            else if (wasleft == true)
                            {
                                animationswitch = 1;
                            }
                        }
                    }
                }
            }

            else if (mario.Bounds.IntersectsWith(qblockP1.Bounds))
            {
                if (mario.Bottom > qblockP1.Top)
                {
                    isfalling = false;

                    if (jumpingnow == false)
                    {
                        isjumping = false;

                        if (wasjumping == true)
                        {
                            wasjumping = false;
                            if (wasright == true)
                            {
                                animationswitch = 2;
                            }
                            else if (wasleft == true)
                            {
                                animationswitch = 1;
                            }
                        }
                    }
                }
            }

            else if (mario.Bounds.IntersectsWith(qblockP2.Bounds))
            {
                if (mario.Bottom > qblockP2.Top)
                {
                    isfalling = false;

                    if (jumpingnow == false)
                    {
                        isjumping = false;

                        if (wasjumping == true)
                        {
                            wasjumping = false;
                            if (wasright == true)
                            {
                                animationswitch = 2;
                            }
                            else if (wasleft == true)
                            {
                                animationswitch = 1;
                            }
                        }
                    }
                }
            }

            else if (mario.Bounds.IntersectsWith(qblockC1.Bounds))
            {
                if (mario.Bottom > qblockC1.Top)
                {
                    isfalling = false;

                    if (jumpingnow == false)
                    {
                        isjumping = false;

                        if (wasjumping == true)
                        {
                            wasjumping = false;
                            if (wasright == true)
                            {
                                animationswitch = 2;
                            }
                            else if (wasleft == true)
                            {
                                animationswitch = 1;
                            }
                        }
                    }
                }
            }

            else if (mario.Bounds.IntersectsWith(qblockC2.Bounds))
            {
                if (mario.Bottom > qblockC2.Top)
                {
                    isfalling = false;

                    if (jumpingnow == false)
                    {
                        isjumping = false;

                        if (wasjumping == true)
                        {
                            wasjumping = false;
                            if (wasright == true)
                            {
                                animationswitch = 2;
                            }
                            else if (wasleft == true)
                            {
                                animationswitch = 1;
                            }
                        }
                    }
                }
            }
            else
            {
                if (jumpingnow == false)
                {
                    isfalling = true;
                    isjumping = true;

                    wasjumping = true;
                    if (wasright == true)
                    {
                        animationswitch = 5;
                    }
                    else if (wasleft == true)
                    {
                        animationswitch = 6;
                    }
                }
            }

            #endregion



            #region collision

            foreach (Control c in this.Controls)
            {
                if (c.Name == "ground1" || c.Name == "ground2" || c.Name == "ground3" || c.Name == "ground4" || c.Name == "qblockP1" || c.Name == "qblockP2" || c.Name == "qblockC1" || c.Name == "qblockC2" || c.Name == "mainfloor")
                {
                    if (mario.Bounds.IntersectsWith(c.Bounds))
                    {
                        if (mario.Right > c.Left && mario.Left < c.Left)
                        {
                            right = false;
                            mario.Left -= 10;
                        }

                        if (mario.Left < c.Right && mario.Right > c.Right)
                        {
                            left = false;
                            mario.Left += 10;
                        }

                        if (mario.Top < c.Bottom && mario.Bottom > c.Bottom)
                        {
                            jumpTimer.Stop();
                            veolicty = 0;
                            jumpingnow = false;

                            if (c.Name == "qblockP1" || c.Name == "qblockP2" || c.Name == "qblockC1" || c.Name == "qblockC2")
                            {

                            }
                            else
                            {
                                bump.Play();
                                mario.Top += 8;
                            }
                        }
                    }


                }
            }

            #endregion


            #region qblockfunction

            if (mario.Bounds.IntersectsWith(qblockP1.Bounds))
            {
                if (mario.Top < qblockP1.Bottom && mario.Bottom > qblockP1.Bottom)
                {
                    jumpTimer.Stop();
                    veolicty = 0;
                    mario.Top += 35;
                    jumpingnow = false;



                    if (qblock[0] == 0)
                    {
                        if (form == 0)
                        {
                            mushroom1.Location = qblockP1.Location;
                            mushroom1.Left += 5;
                            mushroom1.Top -= 35;
                            mushroomgoingleft = false;
                            mushroomgoingright = true;
                            mushroomAI.Start();
                            qblock[0] = 1;
                            qblockP1.Image = Properties.Resources.hitblock;
                            powerupappears.Play();
                        }
                        else if (form == 1 || form == 2)
                        {
                            flower1.Location = qblockP1.Location;
                            flower1.Left += 5;
                            flower1.Top -= 35;
                            qblock[0] = 1;
                            qblockP1.Image = Properties.Resources.hitblock;
                            powerupappears.Play();
                        }


                    }
                    else if (qblock[0] == 1)
                    {
                        bump.Play();
                    }



                }
            }



            else if (mario.Bounds.IntersectsWith(qblockP2.Bounds))
            {
                if (mario.Top < qblockP2.Bottom && mario.Bottom > qblockP2.Bottom)
                {
                    jumpTimer.Stop();
                    mario.Top += 35;
                    veolicty = 0;

                    jumpingnow = false;



                    if (qblock[1] == 0)
                    {
                        if (form == 0)
                        {
                            mushroom1.Location = qblockP2.Location;
                            mushroom1.Left += 5;
                            mushroom1.Top -= 35;
                            mushroomgoingleft = false;
                            mushroomgoingright = true;
                            mushroomAI.Start();
                            qblock[1] = 1;
                            qblockP2.Image = Properties.Resources.hitblock;
                            powerupappears.Play();
                        }
                        else if (form == 1 || form == 2)
                        {
                            flower1.Location = qblockP2.Location;
                            flower1.Left += 5;
                            flower1.Top -= 35;
                            qblock[1] = 1;
                            qblockP2.Image = Properties.Resources.hitblock;
                            powerupappears.Play();
                        }

                    }
                    else if (qblock[1] == 1)
                    {
                        bump.Play();
                    }

                }
            }

            if (mario.Bounds.IntersectsWith(qblockC1.Bounds))
            {
                if (mario.Top < qblockC1.Bottom && mario.Bottom > qblockC1.Bottom)
                {
                    jumpTimer.Stop();
                    veolicty = 0;
                    mario.Top += 35;
                    jumpingnow = false;



                    if (qblock[2] == 0)
                    {

                        qblock[2] = 1;
                        qblockC1.Image = Properties.Resources.hitblock;
                        coinnoise.Play();
                        coins += 1;
                    }


                    else if (qblock[2] == 1)
                    {
                        bump.Play();
                    }
                }
            }


            if (mario.Bounds.IntersectsWith(qblockC2.Bounds))
            {
                if (mario.Top < qblockC2.Bottom && mario.Bottom > qblockC2.Bottom)
                {
                    jumpTimer.Stop();
                    veolicty = 0;
                    mario.Top += 35;
                    jumpingnow = false;



                    if (qblock[3] == 0)
                    {

                        qblock[3] = 1;
                        qblockC2.Image = Properties.Resources.hitblock;
                        coinnoise.Play();
                        coins += 1;
                    }


                    else if (qblock[3] == 1)
                    {
                        bump.Play();
                    }
                }
            }
            #endregion

            if (left == true)
            {
                mario.Left -= 5;
            }

            if (right == true)
            {
                mario.Left += 5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;

                if (isjumping == false)
                {
                    animationswitch = 1;
                }
                goingright = true; //resets walking animation

            }

            else if (e.KeyCode == Keys.Right)
            {
                right = false;

                if (isjumping == false)
                {
                    animationswitch = 2;
                }
                goingleft = true; //resets walking animation

            }
        }

        private void gravityTimer_Tick(object sender, EventArgs e)
        {
            this.Text = Convert.ToString(isinvincible);
            if (isfalling == true)
            {
                mario.Top += 12;
            }

            if (mushroomfalling == true)
            {
                mushroom1.Top += 8;
            }

            #region goombas

            if (goombafalling[0] == true)
            {
                goomba1.Top += 8;
            }
            #endregion

            #region fireball

            if (fireballfalling[0] == true)
            {
                fireball1.Top += 16;
            }

            if (fireballfalling[1] == true)
            {
                fireball2.Top += 8;
            }
            #endregion
        }

        private void jumpTimer_Tick(object sender, EventArgs e)
        {
            mario.Top -= veolicty;
            veolicty -= 1;

            if (veolicty <= 0)
            {
                jumpTimer.Enabled = false;
                jumpingnow = false;
            }
        }

        private void aniTimer_Tick(object sender, EventArgs e)
        {

            if (form == 0)
            {
                mario.Width = 30;
                mario.Height = 36;
                if (animationswitch == 1)
                {
                    animationswitch = 101;
                    mario.Image = Properties.Resources.littleidleleft;
                }

                else if (animationswitch == 2)
                {
                    animationswitch = 102;
                    mario.Image = Properties.Resources.littleidleright;
                }

                else if (animationswitch == 3)
                {
                    animationswitch = 103;
                    mario.Image = Properties.Resources.littleanileft;
                }

                else if (animationswitch == 4)
                {
                    animationswitch = 104;
                    mario.Image = Properties.Resources.littleaniright;
                }

                else if (animationswitch == 5)
                {
                    animationswitch = 105;
                    mario.Image = Properties.Resources.littlejumpright;
                }

                else if (animationswitch == 6)
                {
                    animationswitch = 106;
                    mario.Image = Properties.Resources.littlejumpleft;
                }
            }

            else if (form == 1)
            {
                mario.Width = 35;
                mario.Height = 60;
                if (animationswitch == 1)
                {
                    animationswitch = 101;
                    mario.Image = Properties.Resources.bigidleleft;
                }

                else if (animationswitch == 2)
                {
                    animationswitch = 102;
                    mario.Image = Properties.Resources.bigidleright;
                }

                else if (animationswitch == 3)
                {
                    animationswitch = 103;
                    mario.Image = Properties.Resources.bigleftani;
                }

                else if (animationswitch == 4)
                {
                    animationswitch = 104;
                    mario.Image = Properties.Resources.bigrightani;
                }

                else if (animationswitch == 5)
                {
                    animationswitch = 105;
                    mario.Image = Properties.Resources.bigjumpright;
                }

                else if (animationswitch == 6)
                {
                    animationswitch = 106;
                    mario.Image = Properties.Resources.bigjumpleft;
                }
            }

            else if (form == 2)
            {
                mario.Width = 35;
                mario.Height = 60;
                if (animationswitch == 1)
                {
                    animationswitch = 101;
                    mario.Image = Properties.Resources.fireidleleft;
                }

                else if (animationswitch == 2)
                {
                    animationswitch = 102;
                    mario.Image = Properties.Resources.fireidleright;
                }

                else if (animationswitch == 3)
                {
                    animationswitch = 103;
                    mario.Image = Properties.Resources.fireleft;
                }

                else if (animationswitch == 4)
                {
                    animationswitch = 104;
                    mario.Image = Properties.Resources.fireright;
                }

                else if (animationswitch == 5)
                {
                    animationswitch = 105;
                    mario.Image = Properties.Resources.firejumpright;
                }

                else if (animationswitch == 6)
                {
                    animationswitch = 106;
                    mario.Image = Properties.Resources.firejumpleft;
                }
            }
        }

        private void itemTimer_Tick(object sender, EventArgs e)
        {
            if (mario.Bounds.IntersectsWith(mushroom1.Bounds))
            {
                mushroom1.Location = new System.Drawing.Point(30000, 30000);
                powerup.Play();
                mushroomAI.Stop();

                if (form != 2)
                {
                    form = 1;
                    mario.Top -= 25;
                }
            }

            if (mario.Bounds.IntersectsWith(flower1.Bounds))
            {
                flower1.Location = new System.Drawing.Point(30000, 30000);
                powerup.Play();

                if (form == 0)
                {
                    mario.Top -= 25;
                }

                form = 2;
            }

            if (mario.Bounds.IntersectsWith(coin1.Bounds))
            {
                coin1.Location = new System.Drawing.Point(30000, 30000);
                coinnoise.Play();
                coins += 1;
            }
        }

        private void mushroomAI_Tick(object sender, EventArgs e)
        {

            #region groundcheck for mushroom

            

            if (mushroom1.Bounds.IntersectsWith(ground1.Bounds))
            {

                mushroomfalling = false;

            }
             else if (mushroom1.Bounds.IntersectsWith(mainfloor.Bounds))
            {

                mushroomfalling = false;

            }
            else if (mushroom1.Bounds.IntersectsWith(ground2.Bounds))
            {
                mushroomfalling = false;
            }
            else if (mushroom1.Bounds.IntersectsWith(ground3.Bounds))
            {
                mushroomfalling = false;
            }
            else if (mushroom1.Bounds.IntersectsWith(ground4.Bounds))
            {
                mushroomfalling = false;
            }

            else if (mushroom1.Bounds.IntersectsWith(qblockP1.Bounds))
            {
                mushroomfalling = false;
            }
            else
            {
                mushroomfalling = true;
            }

            #endregion

            #region collisioncheck
            foreach (Control c in this.Controls)
            {
                if (c.Name == "ground1" || c.Name == "ground2" || c.Name == "ground3" || c.Name == "ground4" || c.Name == "qblockP1" || c.Name == "qblockP2" || c.Name == "qblockC1" || c.Name == "qblockC2" || c.Name == "mainfloor")
                {
                    if (mushroom1.Bounds.IntersectsWith(c.Bounds))
                    {
                        if (mushroom1.Right > c.Left && mushroom1.Left < c.Left)
                        {
                            mushroomgoingright = false;
                            mushroomgoingleft = true;
                            mushroom1.Left -= 10;
                        }

                        if (mushroom1.Left < c.Right && mushroom1.Right > c.Right)
                        {
                            mushroomgoingright = true;
                            mushroomgoingleft = false;
                            mushroom1.Left += 10;
                        }
                    }
                }
            }

            #endregion

            if (mushroomgoingright == true)
            {
                mushroom1.Left += 4;
            }
            else if (mushroomgoingleft == true)
            {
                mushroom1.Left -= 4;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mario.Parent = mainground;
            coin1.Parent = mainground;
            mushroom1.Parent = mainground;
            flower1.Parent = mainground;
            fireball1.Parent = mainground;
            fireball2.Parent = mainground;
        }

        private void goombaAI_Tick(object sender, EventArgs e)
        {

            #region goomba1

            #region groundcheck for goomba

            if (goomba1.Bounds.IntersectsWith(ground1.Bounds))
            {
                goombafalling[0] = false;
            }
            else if (goomba1.Bounds.IntersectsWith(ground2.Bounds))
            {
                goombafalling[0] = false;
            }
            else if (goomba1.Bounds.IntersectsWith(ground3.Bounds))
            {
                goombafalling[0] = false;
            }
            else if (goomba1.Bounds.IntersectsWith(ground4.Bounds))
            {
                goombafalling[0] = false;
            }
            else if (goomba1.Bounds.IntersectsWith(mainfloor.Bounds))
            {
                goombafalling[0] = false;
            }
            else
            {
                goombafalling[0] = true;
            }




            #endregion

            #region collisioncheck

            foreach (Control c in this.Controls)
            {
                if (c.Name == "ground1" || c.Name == "ground2" || c.Name == "ground3" || c.Name == "ground4" || c.Name == "qblockP1" || c.Name == "qblockP2" || c.Name == "qblockC1" || c.Name == "qblockC2" || c.Name == "mainfloor")
                {
                    if (goomba1.Bounds.IntersectsWith(c.Bounds))
                    {
                        if (goomba1.Right > c.Left && goomba1.Left < c.Left)
                        {
                            goombagoingright[0] = false;
                            goombagoingleft[0] = true;
                            goomba1.Left -= 10;
                        }

                        if (goomba1.Left < c.Right && goomba1.Right > c.Right)
                        {
                            goombagoingright[0] = true;
                            goombagoingleft[0] = false;
                            goomba1.Left += 10;
                        }
                    }
                }
            }

            #endregion


            if (goombagoingleft[0] == true)
            {
                goomba1.Left -= 2;
            }
            else if (goombagoingright[0] == true)
            {
                goomba1.Left += 2;
            }
            #endregion


        }

        private void enemykillcheck_Tick(object sender, EventArgs e)
        {
            if (mario.Bounds.IntersectsWith(goomba1.Bounds) && isinvincible == false)
            {
                if (mario.Bottom > goomba1.Top)
                {
                    if (isfalling == true)
                    {
                        goomba1.Location = new System.Drawing.Point(30000, 30000);
                        stomped.Play();
                        goombastompped[0] = 1;
                    }
                }
            }

            if (fireball1.Bounds.IntersectsWith(goomba1.Bounds))
            {
                goomba1.Location = new System.Drawing.Point(30000, 30000);
                stomped.Play();
                goombastompped[0] = 1;
                fireballout -= 1;
                fireball1.Left = 10000;
                firegoingleft[0] = false;
                firegoingright[0] = false;
            }

            if (fireball2.Bounds.IntersectsWith(goomba1.Bounds))
            {
                goomba1.Location = new System.Drawing.Point(30000, 30000);
                stomped.Play();
                goombastompped[0] = 1;
                fireballout -= 1;
                fireball2.Left = 10000;
                firegoingleft[1] = false;
                firegoingright[1] = false;
            }

        }

        private void marioDeath_Tick(object sender, EventArgs e)
        {
            mario.Top += 8;
        }

        private void fireAI_Tick(object sender, EventArgs e)
        {
            #region fireball1 groundcheck
            if (fireball1.Bounds.IntersectsWith(ground1.Bounds))
            {
                fireballfalling[0] = false;
            }
            else if (fireball1.Bounds.IntersectsWith(ground2.Bounds))
            {
                fireballfalling[0] = false;
            }
            else if (fireball1.Bounds.IntersectsWith(ground3.Bounds))
            {
                fireballfalling[0] = false;
            }
            else if (fireball1.Bounds.IntersectsWith(ground4.Bounds))
            {
                fireballfalling[0] = false;
            }

            else if (fireball1.Bounds.IntersectsWith(mainfloor.Bounds))
            {
                fireballfalling[0] = false;
            }
            else
            {
                fireballfalling[0] = true;
            }

            #endregion

            #region fireball2 groundcheck
            if (fireball2.Bounds.IntersectsWith(ground1.Bounds))
            {
                fireballfalling[1] = false;
            }
            else if (fireball2.Bounds.IntersectsWith(ground2.Bounds))
            {
                fireballfalling[1] = false;
            }
            else if (fireball2.Bounds.IntersectsWith(ground3.Bounds))
            {
                fireballfalling[1] = false;
            }
            else if (fireball2.Bounds.IntersectsWith(ground4.Bounds))
            {
                fireballfalling[1] = false;
            }

            else if (fireball2.Bounds.IntersectsWith(mainfloor.Bounds))
            {
                fireballfalling[1] = false;
            }
            else
            {
                fireballfalling[1] = true;
            }

            #endregion


            #region collisioncheck fireball1

            foreach (Control c in this.Controls)
            {
                if (c.Name == "ground1" || c.Name == "ground2" || c.Name == "ground3" || c.Name == "ground4" || c.Name == "qblockP1" || c.Name == "qblockP2" || c.Name == "qblockC1" || c.Name == "qblockC2" || c.Name == "mainfloor")
                {
                    if (fireball1.Bounds.IntersectsWith(c.Bounds))
                    {
                        if (fireball1.Right > c.Left && fireball1.Left < c.Left)
                        {
                            fireballout -= 1;
                            fireball1.Left = 30000;
                            firegoingleft[0] = false;
                            firegoingright[0] = false;
                        }

                        if (fireball1.Left < c.Right && fireball1.Right > c.Right)
                        {
                            fireballout -= 1;
                            fireball1.Left = 30000;
                            firegoingleft[0] = false;
                            firegoingright[0] = false;
                        }
                    }
                }
            }

            #endregion

            #region collisioncheck fireball2

            foreach (Control c in this.Controls)
            {
                if (c.Name == "ground1" || c.Name == "ground2" || c.Name == "ground3" || c.Name == "ground4" || c.Name == "qblockP1" || c.Name == "qblockP2" || c.Name == "qblockC1" || c.Name == "qblockC2" || c.Name == "mainfloor")
                {
                    if (fireball2.Bounds.IntersectsWith(c.Bounds))
                    {
                        if (fireball2.Right > c.Left && fireball2.Left < c.Left)
                        {
                            fireballout -= 1;
                            fireball2.Left = 30000;
                            firegoingleft[1] = false;
                            firegoingright[1] = false;
                        }

                        if (fireball2.Left < c.Right && fireball2.Right > c.Right)
                        {
                            fireballout -= 1;
                            fireball2.Left = 30000;
                            firegoingleft[1] = false;
                            firegoingright[1] = false;
                        }
                    }
                }
            }

            #endregion

            if (firegoingleft[0] == true)
            {
                fireball1.Left -= 4;
                fireball1.Top -= 4;
            }

            if (firegoingleft[1] == true)
            {
                fireball2.Left -= 4;
                fireball2.Top -= 4;
            }

            if (firegoingright[0] == true)
            {
                fireball1.Left += 4;
                fireball1.Top -= 4;
            }

            if (firegoingright[1] == true)
            {
                fireball2.Left += 4;
                fireball2.Top -= 4;
            }


            if (fireball1.Bounds.IntersectsWith(leftBorder.Bounds) || fireball1.Bounds.IntersectsWith(rightBorder.Bounds))
            {
                fireballout -= 1;
                fireball1.Left = 30000;
                firegoingleft[0] = false;
                firegoingright[0] = false;
            }

            if (fireball2.Bounds.IntersectsWith(leftBorder.Bounds) || fireball2.Bounds.IntersectsWith(rightBorder.Bounds))
            {
                fireballout -= 1;
                fireball2.Left = 30000;
                firegoingleft[1] = false;
                firegoingright[1] = false;
            }

            if (fireballout == 0)
            {
                fireAI.Stop();
                disablefireball = false;
            }
        }

        private void marioHit_Tick(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Name == "goomba1")
                {
                    if (mario.Bounds.IntersectsWith(c.Bounds) && isfalling == false && isinvincible == false)
                    {
                        if (form == 2)
                        {
                            form = 1;
                            fireballout = 0;
                            disablefireball = false;
                            isinvincible = true;
                            invicibleDelay.Enabled = true;
                            powerdown.Play();
                        }
                        else if (form == 1)
                        {
                            form = 0;
                            isinvincible = true;
                            invicibleDelay.Enabled = true;
              
                            powerdown.Play();
                        }
                        else if (form == 0)
                        {
                            aniTimer.Stop();
                            gravityTimer.Stop();
                            marioMovementCollision.Stop();
                            marioHit.Stop();
                            mario.Image = Properties.Resources.mariodies;
                            marioDeathdelay.Start();
                            mario.Top -= 60;
                            isjumping = true;
                            die.Play();
                        }
                    }
                }


            }
        }

        private void invicibleDelay_Tick(object sender, EventArgs e)
        {
            isinvincible = false;
        }

        private void marioDeathdelay_Tick(object sender, EventArgs e)
        {
            marioDeath.Start();
            marioDeathdelay.Stop();
        }
    }
}