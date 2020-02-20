using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace platformerconcept
{
    public partial class Form1 : Form
    {
        bool left, right; // mario movement 
        bool goLeft, goRight; // gooma movement
        bool leftani, rightani; // mario directional animation
        bool isJumping, onFloor; // checks for collision on floor
        bool goomL, goomR, goomOnFloor; // gooma movement
        int gravity = 5;
        int moveSpeed = 3;
        int velocity = 25;
        int cVelocity = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // put primary controls in the background
            mario.Parent = background;
            goomba.Parent = background;
            
                    DoubleBuffered = true; // helps drawing
            goomL = true; // set initial movement for goomba
        }

        private void EnemyMovement_Tick(object sender, EventArgs e)
        {
            goomOnFloor = false; // initial onfloor set
            foreach (Control c in this.Controls)
            {
                // if intersects with any of these controls
                if (c.Name == "pf1" || c.Name == "floor" || c.Name == "pf2" || c.Name == "pf3" || c.Name == "pf4" || c.Name == "pf5")
                {
                    if (goomba.Bounds.IntersectsWith(c.Bounds))
                    {
                        if (goomba.Right >= (c.Left) && goomba.Right <= (c.Left + 5) && goomba.Left <= c.Left) // touches right wall, turns left
                        {
                            goomR = false;
                            goomL = true;
                        }
                        if (goomba.Left <= (c.Right) && goomba.Left >= (c.Right - 5) && goomba.Right >= c.Right) // touches left wall, turns right
                        {
                            goomL = false;
                            goomR = true;
                        }
                        if (goomba.Bottom >= (c.Top) && goomba.Bottom <= (c.Top + 5)) // touches top surface, is on floor and don't fall down
                        {
                            goomOnFloor = true;
                        }
                        else // if not, fall down
                        {
                            goomOnFloor = false;
                        }
                    }
                }
            }

            // actually pushes goomba down
            if (goomOnFloor == false)
            {
                goomba.Top += gravity;
            }

            // moves gooma left or right
            if (goomR == true)
                goomba.Left += 2;
            if (goomL == true)
                goomba.Left -= 2;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // if pressing left arrow key, move left. movement happens in timer1
            if (e.KeyCode == Keys.Left)
            {
                left = true;
                goLeft = true;
                goRight = false;
                // set left animation
                if (leftani == false && rightani == true && isJumping == false && onFloor == true)
                {
                    rightani = false;
                    leftani = true;
                    mario.Image = Properties.Resources.littleanileft;
                }
                else if (leftani == false && rightani == false && isJumping == false && onFloor == true)
                {
                    rightani = false;
                    leftani = true;
                    mario.Image = Properties.Resources.littleanileft;
                }

            }
            // if pressing right arrow key, move right. movement happens in timer1
            else if (e.KeyCode == Keys.Right)
            {
                right = true;
                goLeft = false;
                goRight = true;
                // set right animation
                if (leftani == true && rightani == false && isJumping == false && onFloor == true)
                {
                    rightani = true;
                    leftani = false;
                    mario.Image = Properties.Resources.littleaniright;
                }
                else if (leftani == false && rightani == false && isJumping == false && onFloor == true)
                {
                    rightani = true;
                    leftani = false;
                    mario.Image = Properties.Resources.littleaniright;
                }
            }
            // if pressing up arrow key, jump. movement happens in timer1
            if (e.KeyCode == Keys.Up)
            {
                if (isJumping == false && onFloor == true)
                {
                    isJumping = true;
 
                    cVelocity = velocity; // set jump velocity
                    // set jump animation
                    if (goLeft == true)
                    {
                        leftani = false;
                        rightani = false;
                        mario.Image = Properties.Resources.littlejumpleft;
                    }
                    else if (goRight == true)
                    {
                        leftani = false;
                        rightani = false;
                        mario.Image = Properties.Resources.littlejumpright;
                    }
                    jump.Start();
                }
            }

            if (e.KeyCode == Keys.R)
                Application.Restart();
        }

        private void Jump_Tick(object sender, EventArgs e)
        {
            // move mario up (jumping)
            if (isJumping == true && cVelocity > 0)
            {
                mario.Top -= cVelocity;
                cVelocity -= 1;
            }
            else
            {
                isJumping = false;
                jump.Stop();
            }
        }

        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // stops moving left and sets idle animation
            if (e.KeyCode == Keys.Left)
            {
                left = false;
                if (leftani == true && isJumping == false && onFloor == true)
                {
                    mario.Image = Properties.Resources.littleidleleft;
                    leftani = false;
                    rightani = false;
                }
            }
            //stops moving right and sets idle animation
            else if (e.KeyCode == Keys.Right)
            {
                right = false;
                if (rightani == true && isJumping == false && onFloor == true)
                {
                    mario.Image = Properties.Resources.littleidleright;
                    leftani = false;
                    rightani = false;
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            onFloor = false; // initial onfloor set
           

            // if collides with any of these
            foreach (Control c in this.Controls)
            {
                if (c.Name == "pf1" || c.Name == "floor" || c.Name == "pf2" || c.Name == "pf3" || c.Name == "pf4" || c.Name == "pf5")
                {
                    if (mario.Bounds.IntersectsWith(c.Bounds))
                    {
                        if (mario.Right >= (c.Left) && mario.Right <= (c.Left + 5) && mario.Left <= c.Left) // cant move  right if hit left wall
                            right = false;
                         if (mario.Left <= (c.Right) && mario.Left >= (c.Right - 5) && mario.Right >= c.Right) // cant move left if it right wall
                            left = false;

                         if (mario.Top <= c.Bottom && mario.Bottom >= c.Bottom) // don't go through a bottom part of an object 
                        {
                            jump.Stop();
                            isJumping = false;
                         
                        }
                         if (mario.Bottom >= (c.Top) && mario.Bottom <= (c.Top + 5)) // if on top of platform, prevent gravity from pushing mario down
                        {
                            onFloor = true;
                                if (goLeft == true && left == false)
                                    mario.Image = Properties.Resources.littleidleleft;
                                else if (goRight == true && right == false)
                                    mario.Image = Properties.Resources.littleidleright;
                        }
                        else
                        {
                            onFloor = false;
                        }
                    }
                }
            }
            // pushes mario down if not jumping or not on top of platform
            if (onFloor == false && isJumping == false)
            {
                mario.Top += gravity;
            }

            // moves mario left or right
            if (right == true)
                mario.Left += moveSpeed;
            if (left == true)
                mario.Left -= moveSpeed;

            // if collide with any coins, collect it
            foreach (Control c in this.Controls)
            {
                if (c.Name.Contains("coin"))
                {
                    if (mario.Bounds.IntersectsWith(c.Bounds))
                    {
                        c.Dispose();
                    }
                }
            }

            // if collides with goomba on top, kill it
            if (mario.Bounds.IntersectsWith(goomba.Bounds))
            {
                if (mario.Bottom >= (goomba.Top) && mario.Top <= (goomba.Top))
                {
                    goomba.Dispose();
                }
            }
        }
    }

}
