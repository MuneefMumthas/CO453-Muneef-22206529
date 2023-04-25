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

            if (goUp == true && player.Top > 36)
            {
                player.Top -= speed;
            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }
        }
        
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            /// <summary>
            /// This method is used to give appropriate instructions for movement. 
            /// when Left, Right, Up, Down keys are pressed,
            /// the booleans, facing string, and the player images are changed accordingly.
            /// </summary>
            
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.playerLeft;
            }
            
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.playerRight;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.playerUp;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.playerDown;
            }
            ///<summary>
            /// Player movement using W,A,S,D Keys
            /// when W,A,S,D keys are pressed,
            /// the booleans, facing string, and the player images are changed accordingly.
            /// </summary>
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.playerLeft;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.playerRight;
            }

            if (e.KeyCode == Keys.W)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.playerUp;
            }

            if (e.KeyCode == Keys.S)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.playerDown;
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
            // instruction for when the space is released (Shoots Bullets)
            if (e.KeyCode == Keys.Space)
            {
                ShootBullet(facing);

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

        }

        private void RestartGame()
        {

        }
    }
}
