using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App05_RPG_Game
{
    /// <author>
    /// Muneef Mumthas - 22206529
    /// Game Name: Chill & Survive
    /// </author>


    public partial class Form1 : Form
    {
        ///<summary>
        /// Booleans, Constants & Variables 
        ///</summary>
        bool goLeft, goRight, goUp, goDown, gameOver, gamePaused, startMenuBool, newStartMenuBool, pauseMenuBool, restartBool;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int score;
        int zombieSpeed = 3;
        Random randNum = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>();

        /// <summary>
        /// Method to initialise options when the application loads.
        /// It hides pausemenu, newstartmenu and confirmation panels.
        /// Also hides wasted & continue texts, and stops background music at the start 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            PauseMenu.Hide();
            newStartMenu.Hide();
            confirmationPanel.Hide();
            txtWasted.Hide();
            txtContinue.Hide();

            songPlayer.URL = @"BackgroundSong.mp3";
            songPlayer.settings.playCount = 9999;
            songPlayer.Ctlcontrols.stop();
            gameOver = true;
            gamePaused = true;

        }

        /// <summary>
        /// Click event handler for Start Game button in startmenu (panel)
        /// Once clicked, it plays option selected sound,
        /// Disposes the startmenu (panel) and runs the game.
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            startMenuBool = false;
            startMenu.Dispose();

            RestartGame();
            songPlayer.Ctlcontrols.play();

            SoundPlayer menuclick = new SoundPlayer(Properties.Resources.MenuEnterEdited);
            menuclick.Play();
        }

        /// <summary>
        /// Click event handler for Quit Game button in startmenu (panel) 
        /// Once clicked, it plays option selected sound and
        /// Shows the confirmationmenu (panel).
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            startMenuBool = true;
            confirmationPanel.Show();
            confirmationPanel.BackgroundImage = Properties.Resources.UpdatedStartMenu3;
            confirmationPanel.BringToFront();
            
            SoundPlayer menuclick = new SoundPlayer(Properties.Resources.MenuEnterEdited);
            menuclick.Play();
        }

        /// <summary>
        /// Click event handler for Resume Game button in pausemenu (panel) 
        /// Once clicked, it plays option selected sound,
        /// hides pausemenu (panel) and resumes the game.
        /// </summary>
        private void resumeGame_Click(object sender, EventArgs e)
        {
            goUp = false;
            goDown = false;
            goRight = false;
            goLeft = false;
            gameOver = false;
            gamePaused = false;
            PauseMenu.Hide();
            pauseMenuBool = false;
            GameTimer.Start();
            songPlayer.Ctlcontrols.play();
            this.Focus();
            
            SoundPlayer menuclick = new SoundPlayer(Properties.Resources.MenuEnterEdited);
            menuclick.Play();
        }

        /// <summary>
        /// Click event handler for Restart Game button in pausemenu (panel) 
        /// Once clicked, it plays option selected sound and
        /// shows confirmationmenu (panel).
        /// </summary>
        private void restartButton_Click(object sender, EventArgs e)
        {
            restartBool = true;
            pauseMenuBool = true;
            confirmationPanel.Show();
            confirmationPanel.BackgroundImage = Properties.Resources.UpdatedMenu3;
            confirmationPanel.BringToFront();
            
            SoundPlayer menuclick = new SoundPlayer(Properties.Resources.MenuEnterEdited);
            menuclick.Play();
        }

        /// <summary>
        /// Click event handler for Quit Game button in pausemenu (panel) 
        /// Once clicked, it plays option selected sound and
        /// Shows the confirmationmenu (panel).
        /// </summary>
        private void QuitGame_Click(object sender, EventArgs e)
        {
            pauseMenuBool = true;
            confirmationPanel.Show();
            confirmationPanel.BackgroundImage = Properties.Resources.UpdatedMenu3;
            confirmationPanel.BringToFront();
            
            SoundPlayer menuclick = new SoundPlayer(Properties.Resources.MenuEnterEdited);
            menuclick.Play();
        }

        /// <summary>
        /// Click event handler for Start New Game button in newstartmenu (panel) 
        /// Once clicked, it plays option selected sound, 
        /// hides wasted and continue texts,
        /// hides the newstartmenu (panel) and restarts the game.
        /// </summary>
        private void NewGame_Click(object sender, EventArgs e)
        {
            newStartMenu.Hide();
            newStartMenuBool = false;
            
            txtWasted.Hide();
            txtContinue.Hide();
            
            RestartGame();
            songPlayer.Ctlcontrols.play();
            this.Focus();
            
            SoundPlayer menuclick = new SoundPlayer(Properties.Resources.MenuEnterEdited);
            menuclick.Play();
        }

        /// <summary>
        /// Click event handler for Quit Game button in newstartmenu (panel) 
        /// Once clicked, it plays option selected sound and
        /// Shows the confirmationmenu (panel).
        /// </summary>
        private void Quit_Click(object sender, EventArgs e)
        {
            newStartMenuBool = true;
            confirmationPanel.Show();
            confirmationPanel.BackgroundImage = Properties.Resources.UpdatedStartMenu3;
            confirmationPanel.BringToFront();
            
            SoundPlayer menuclick = new SoundPlayer(Properties.Resources.MenuEnterEdited);
            menuclick.Play();
        }

        /// <summary>
        /// Enter event handler to play scroll sound
        /// whenever user moves the mouse over the options (buttons)
        /// </summary>
        private void startButton_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer menuscroll = new SoundPlayer(Properties.Resources.MenuScrollEdited);
            menuscroll.Play();
        }

        /// <summary>
        /// Click event handler for No button in confirmation (panel) 
        /// Once clicked, it plays option selected sound,
        /// Hides the confirmation (panel) and displays the menu
        /// from where the confirmation (panel) was called.
        /// </summary
        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer menuclick = new SoundPlayer(Properties.Resources.MenuEnterEdited);
            menuclick.Play();

            if (startMenuBool == true)
            {
                confirmationPanel.Hide();
                startMenu.Show();
                startMenu.BringToFront();
            }

            if (pauseMenuBool == true)
            {
                confirmationPanel.Hide();
                PauseMenu.Show();
                PauseMenu.BringToFront();
                gamePaused = true;
                restartBool = false;
                this.Focus();
            }

            if (newStartMenuBool == true)
            {
                confirmationPanel.Hide();
                newStartMenu.Show();
                newStartMenu.BringToFront();
            }
        }

        /// <summary>
        /// Click event handler for Yes button in confirmation (panel) 
        /// Once clicked, it plays option selected sound,
        /// If it was called from a restart button,
        /// it hides the pausemenu & confirmation (panels) and restarts the game.
        /// otherwise (called from quit game options), it exits the application.
        /// </summary
        private void button1_Click(object sender, EventArgs e)
        {
            if (pauseMenuBool == true && restartBool == true)
            {
                PauseMenu.Hide();
                confirmationPanel.Hide();
                pauseMenuBool = false;
                restartBool = false;
                
                RestartGame();
                songPlayer.Ctlcontrols.stop();
                songPlayer.Ctlcontrols.play();
                this.Focus();
                
                SoundPlayer menuclick = new SoundPlayer(Properties.Resources.MenuEnterEdited);
                menuclick.Play();
            }
            else
            {
                Application.Exit();
            }

        }

        /// <summary>
        /// Tick event handler for the Game timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                songPlayer.Ctlcontrols.stop();
                
                SoundPlayer death = new SoundPlayer(Properties.Resources.deathsoundedited);
                death.Play();
                
                txtContinue.Show();
                txtContinue.BringToFront();
                txtWasted.Show();
                txtWasted.BringToFront();
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score;

            ///<summary>
            /// Movement mechanic and boundries for player movement, 
            /// when booleans are turned on/ when keys are pressed
            ///</summary>
            if (goLeft == true && player.Left > 0)
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
                    /// <summary>
                    /// Collision detection between zombies and player (health reduces).
                    /// </summary>
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
                /// and increases the score by 1.
                ///</summary>
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        /// <summary>
                        /// Collision detection between bullets and zombies
                        /// </summary>
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();

                            
                            SoundPlayer kill = new SoundPlayer(Properties.Resources.KillSound);
                            kill.Play();

                            zombiesList.Remove((PictureBox)x);
                            MakeZombies();
                        }
                    }
                }
            }

        }

        ///<summary>
        /// KeyDown event handler, used to give appropraite instructions
        /// when Left, Right, Up, Down arrow keys, W,A,S,D keys are pressed.
        /// the booleans, facing string, and the player images are then changed accordingly
        ///</summary>
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true || gamePaused == true)
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

        ///<summary>
        /// KeyUp event handler, used to give appropraite instructions
        /// when Left, Right, Up, Down arrow keys, W,A,S,D keys are released.
        /// the booleans are set to false, so that player stops moving.
        ///</summary>
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
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
            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false && gamePaused == false)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }

            }

            ///<summary>
            /// when the game is not paused and escape key is pressed
            /// it opens up pausemenu (panel) and pauses the game
            ///</summary>
            if (e.KeyCode == Keys.Escape && gamePaused == false && gameOver == false)
            {
                gamePaused = true;
                GameTimer.Stop();
                PauseMenu.Show();
                PauseMenu.BringToFront();
                songPlayer.Ctlcontrols.pause();
            }

            ///<summary>
            /// when the game is paused and escape key is pressed
            /// it closes pausemenu (panel) and resumes the game
            ///</summary>
            else if (e.KeyCode == Keys.Escape && gamePaused == true && gameOver == false)
            {
                goUp = false;
                goDown = false;
                goRight = false;
                goLeft = false;
                gameOver = false;
                gamePaused = false;
                PauseMenu.Hide();
                pauseMenuBool = false;
                GameTimer.Start();
                songPlayer.Ctlcontrols.play();
                this.Focus();
                
                SoundPlayer menuclick = new SoundPlayer(Properties.Resources.MenuEnterEdited);
                menuclick.Play();
            }

            ///<summary>
            /// when the game is over and enter key is pressed 
            /// it opens up newstartmenu (panel)
            ///</summary> 
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                newStartMenu.Show();
                newStartMenu.BringToFront();
                 
                SoundPlayer pause = new SoundPlayer(Properties.Resources.MenuScrollEdited);
                pause.Play();
            }

        }

        ///<summary>
        /// This method is used to define the point in player image,
        /// where the bullet should originate from.
        /// and calls the MakeBullet function from Bullet class to create the bullet. 
        ///</summary>
        private void ShootBullet(string direction)
        {
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

        ///<summary>
        /// This method is used to create a picturebox to 
        /// spawn zombies randomly across the screen.
        ///</summary>
        private void MakeZombies()
        {
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

        ///<summary>
        /// This method is used to create a picturebox to 
        /// spawn ammo crate within the range, 
        /// where player can move to access it
        ///</summary>
        private void DropAmmo()
        {
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

        ///<summary>
        /// This method is used to restart the game by setting 
        /// score, player health and ammo count back to default
        /// This method also re-position the player and removes the zombie.
        ///</summary>
        private void RestartGame()
        {
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
            gamePaused = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            player.Left = 426;
            player.Top = 534;

            GameTimer.Start();

        }
    }
}
