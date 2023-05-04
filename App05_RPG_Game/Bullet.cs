using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace App05_RPG_Game
{
    /// <author>
    /// Muneef Mumthas - 22206529
    /// </author>
    
    class Bullet
    {
        ///<summary>
        /// Constants & Variables 
        ///</summary>
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        ///<summary>
        /// This method is used to customise and create the bullet and
        /// add it to the form.
        ///</summary>
        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.White;
            bullet.Size = new Size(5,5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft; 
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();

        }

        ///<summary>
        /// Bullet timer event. Defines the direction of the bullet to travel, 
        /// when the player turns up,down,left & right.
        ///</summary>
        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                bullet.Left -= speed;
            }

            if (direction == "right")
            {
                bullet.Left += speed;
            }

            if (direction == "up")
            {
                bullet.Top -= speed;
            }

            if (direction == "down") 
            {
                bullet.Top += speed;
            }

            ///<summary>
            ///Disposing the bullet when it goes past a border without hiting on enemies
            ///</summary>
            if (bullet.Left < 10 || bullet.Left > 930 || bullet.Top < 10 || bullet.Top > 690)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }
    }
}
