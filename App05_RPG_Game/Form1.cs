using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App05_RPG_Game
{
    /// <author>
    /// Muneef Mumthas - 22206529
    /// </author>
    public partial class Form1 : Form
    {
        // Booleans, Constants & Variables
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int score;
        int zombieSpeed = 3; 
        Random randNum = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Closing the menu
            startMenu.Dispose();
            // calling methtod to start the game
            RestartGame();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }
        private void MainTimerEvent(object sender, EventArgs e)
        {
            ///<summary>
            /// Restricting player health to not go below zero
            /// and ending the game when player health is less than 1
            ///</summary> 
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score;
            
            ///<summary>
            ///Movement mechanic and boundries for player movement, 
            ///when booleans are turned on/ when keys are pressed
            ///</summary>
            if (goLeft == true && player.Left >0)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 45)
            {
                player.Top -= speed;
            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                
                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    /// Collision detection between zombies and player (health reduces).
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 5;
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        zombiesList.Remove((PictureBox)x);
                        MakeZombies();
                    }

                    ///<summary>
                    /// A simple AI is applied for the zombie picture box 
                    /// to chase/follow the player.
                    ///</summary>


                    if (x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zombieLeft;
                    }

                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zombieRight;
                    }

                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zombieUp;
                    }

                    if (x.Left < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zombieDown;
                    }
                }

                ///<summary>
                /// This foreach loop checks if the bullet made contact with a zombie,
                /// if it is, then it removes the zombie and the bullet from the frame,
                /// which increases the score by 1.
                ///</summary>
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        /// Collision detection between bullets and zombies
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove((PictureBox)x);
                            MakeZombies();

                        }
                    }
                }
            }

        }
        
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            /// <summary>
            /// This method is used to give appropriate instructions for movement. 
            /// when Left, Right, Up, Down arrow keys are pressed,
            /// the booleans, facing string, and the player images are changed accordingly.
            /// </summary>

            if (gameOver == true)
            {
                return;
            }
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = true;
                    facing = "left";
                    player.Image = Properties.Resources.playerLeft;
                    goRight = false;
                    goUp = false;
                    goDown = false;
                    break;

                case Keys.Right:
                    goRight = true;
                    facing = "right";
                    player.Image = Properties.Resources.playerRight;
                    goLeft = false;
                    goUp = false;
                    goDown = false;
                    break;

                case Keys.Up:
                    goUp = true;
                    facing = "up";
                    player.Image = Properties.Resources.playerUp;
                    goLeft = false;
                    goRight = false;
                    goDown = false;
                    break;

                case Keys.Down:
                    goDown = true;
                    facing = "down";
                    player.Image = Properties.Resources.playerDown;
                    goLeft = false;
                    goRight = false;
                    goUp = false;
                    break;

                ///<summary>
                /// Player movement using W,A,S,D Keys
                /// when W,A,S,D keys are pressed,
                /// the booleans, facing string, and the player images are changed accordingly.
                /// </summary>
                
                case Keys.A:
                    goLeft = true;
                    facing = "left";
                    player.Image = Properties.Resources.playerLeft;
                    goRight = false;
                    goUp = false;
                    goDown = false;
                    break;

                case Keys.D:
                    goRight = true;
                    facing = "right";
                    player.Image = Properties.Resources.playerRight;
                    goLeft = false;
                    goUp = false;
                    goDown = false;
                    break;

                case Keys.W:
                    goUp = true;
                    facing = "up";
                    player.Image = Properties.Resources.playerUp;
                    goLeft = false;
                    goRight = false;
                    goDown = false;
                    break;

                case Keys.S:
                    goDown = true;
                    facing = "down";
                    player.Image = Properties.Resources.playerDown;
                    goLeft = false;
                    goRight = false;
                    goUp = false;
                    break;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            ///<summary>
            ///This method is used to give appropraite instructions.
            ///when Left, Right, Up, Down keys are released, 
            ///the booleans are set to false, so that player stops moving.
            /// </summary>
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            ///<summary>
            /// When W,A,S,D keys are released,
            /// the booleans are set to false, so that player stops moving.
            ///</summary>
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }
            ///<summary>
            /// when the space bar is released and the ammo count is greater than 0,
            /// ShootBullet method will be called to shoot bullets.
            /// and when the ammo count reaches 0, 
            /// an ammo crate is randomly dropped in the screen.
            ///</summary>
            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }

            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

        }

        private void ShootBullet(string direction)
        {
            ///<summary>
            /// This method is used to define the point in player image,
            /// where the bullet should originate from.
            /// and calls the MakeBullet function from Bullet class to create the bullet. 
            ///</summary>
            
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;

            if (direction == "up" || direction == "right")
            {
                shootBullet.bulletLeft = player.Left + (player.Width - 23);
                shootBullet.bulletTop = player.Top + (player.Height - 23);
            }
            else
            {
                shootBullet.bulletLeft = player.Left + (player.Width - 53);
                shootBullet.bulletTop = player.Top + (player.Height - 53);
            }

            shootBullet.MakeBullet(this);
        }

        private void MakeZombies()
        {
            ///<summary>
            /// This method is used to create a picturebox to 
            /// spawn zombies randomly across the screen
            ///</summary>

            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zombieDown;
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombie.BackColor = Color.Transparent;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();

        }

        private void DropAmmo()
        {
            ///<summary>
            /// This method is used to create a picturebox to 
            /// spawn ammo within the range, 
            /// where player can move to access it
            ///</summary>
            
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.BackColor = Color.Transparent;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();
        }

        private void RestartGame()
        {
            ///<summary>
            /// This method is used to restart the game by setting 
            /// score, player health and ammo count back to default
            /// This method also re-position the plaayer and remove the zombie.
            ///</summary>
            player.Image = Properties.Resources.playerUp;

            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);

            }

            zombiesList.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeZombies();
            }

            goUp = false;
            goDown = false;
            goRight = false;
            goLeft = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            GameTimer.Start();

        }
    }
}
