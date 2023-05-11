namespace App05_RPG_Game
{
    partial class Form1
    {
        /// <author>
        /// Muneef Mumthas - 22206529
        /// </author>
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAmmo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.startMenu = new System.Windows.Forms.Panel();
            this.quitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.PauseMenu = new System.Windows.Forms.Panel();
            this.restartButton = new System.Windows.Forms.Button();
            this.QuitGame = new System.Windows.Forms.Button();
            this.resumeGame = new System.Windows.Forms.Button();
            this.txtWasted = new System.Windows.Forms.Label();
            this.newStartMenu = new System.Windows.Forms.Panel();
            this.Quit = new System.Windows.Forms.Button();
            this.StartNewGame = new System.Windows.Forms.Button();
            this.txtContinue = new System.Windows.Forms.Label();
            this.confirmationPanel = new System.Windows.Forms.Panel();
            this.No = new System.Windows.Forms.Button();
            this.Yes = new System.Windows.Forms.Button();
            this.confirmation = new System.Windows.Forms.Button();
            this.songPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.startMenu.SuspendLayout();
            this.PauseMenu.SuspendLayout();
            this.newStartMenu.SuspendLayout();
            this.confirmationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.BackColor = System.Drawing.Color.Transparent;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(8, 9);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(93, 24);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(605, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(678, 10);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(234, 23);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::App05_RPG_Game.Properties.Resources.playerUp;
            this.player.Location = new System.Drawing.Point(426, 534);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(327, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(71, 24);
            this.txtScore.TabIndex = 5;
            this.txtScore.Text = "Kills: 0";
            // 
            // startMenu
            // 
            this.startMenu.BackgroundImage = global::App05_RPG_Game.Properties.Resources.UpdatedStartMenu3;
            this.startMenu.Controls.Add(this.quitButton);
            this.startMenu.Controls.Add(this.startButton);
            this.startMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startMenu.Location = new System.Drawing.Point(0, 0);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(924, 661);
            this.startMenu.TabIndex = 6;
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Pricedown Bl", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.quitButton.Location = new System.Drawing.Point(365, 305);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(195, 50);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit Game";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            this.quitButton.Enter += new System.EventHandler(this.startButton_MouseEnter);
            this.quitButton.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Pricedown Bl", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startButton.Location = new System.Drawing.Point(365, 220);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(195, 50);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            this.startButton.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            // 
            // PauseMenu
            // 
            this.PauseMenu.BackgroundImage = global::App05_RPG_Game.Properties.Resources.UpdatedMenu3;
            this.PauseMenu.Controls.Add(this.restartButton);
            this.PauseMenu.Controls.Add(this.QuitGame);
            this.PauseMenu.Controls.Add(this.resumeGame);
            this.PauseMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseMenu.Location = new System.Drawing.Point(0, 0);
            this.PauseMenu.Name = "PauseMenu";
            this.PauseMenu.Size = new System.Drawing.Size(924, 661);
            this.PauseMenu.TabIndex = 7;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.restartButton.FlatAppearance.BorderSize = 0;
            this.restartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.restartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Pricedown Bl", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.restartButton.Location = new System.Drawing.Point(336, 292);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(250, 50);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Start New Game";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            this.restartButton.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            // 
            // QuitGame
            // 
            this.QuitGame.BackColor = System.Drawing.Color.Transparent;
            this.QuitGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.QuitGame.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.QuitGame.FlatAppearance.BorderSize = 0;
            this.QuitGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.QuitGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.QuitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitGame.Font = new System.Drawing.Font("Pricedown Bl", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.QuitGame.Location = new System.Drawing.Point(365, 364);
            this.QuitGame.Name = "QuitGame";
            this.QuitGame.Size = new System.Drawing.Size(195, 50);
            this.QuitGame.TabIndex = 2;
            this.QuitGame.Text = "Quit Game";
            this.QuitGame.UseVisualStyleBackColor = false;
            this.QuitGame.Click += new System.EventHandler(this.QuitGame_Click);
            this.QuitGame.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            // 
            // resumeGame
            // 
            this.resumeGame.BackColor = System.Drawing.Color.Transparent;
            this.resumeGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.resumeGame.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.resumeGame.FlatAppearance.BorderSize = 0;
            this.resumeGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.resumeGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.resumeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resumeGame.Font = new System.Drawing.Font("Pricedown Bl", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.resumeGame.Location = new System.Drawing.Point(365, 220);
            this.resumeGame.Name = "resumeGame";
            this.resumeGame.Size = new System.Drawing.Size(195, 50);
            this.resumeGame.TabIndex = 1;
            this.resumeGame.Text = "Resume Game";
            this.resumeGame.UseVisualStyleBackColor = false;
            this.resumeGame.Click += new System.EventHandler(this.resumeGame_Click);
            this.resumeGame.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            // 
            // txtWasted
            // 
            this.txtWasted.AutoSize = true;
            this.txtWasted.BackColor = System.Drawing.Color.Transparent;
            this.txtWasted.Font = new System.Drawing.Font("Pricedown Bl", 99.74998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWasted.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtWasted.Location = new System.Drawing.Point(189, 160);
            this.txtWasted.Name = "txtWasted";
            this.txtWasted.Size = new System.Drawing.Size(561, 160);
            this.txtWasted.TabIndex = 8;
            this.txtWasted.Text = "Wasted!";
            this.txtWasted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newStartMenu
            // 
            this.newStartMenu.BackgroundImage = global::App05_RPG_Game.Properties.Resources.UpdatedStartMenu3;
            this.newStartMenu.Controls.Add(this.Quit);
            this.newStartMenu.Controls.Add(this.StartNewGame);
            this.newStartMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newStartMenu.Location = new System.Drawing.Point(0, 0);
            this.newStartMenu.Name = "newStartMenu";
            this.newStartMenu.Size = new System.Drawing.Size(924, 661);
            this.newStartMenu.TabIndex = 9;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Transparent;
            this.Quit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Quit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Quit.FlatAppearance.BorderSize = 0;
            this.Quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.Quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Pricedown Bl", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Quit.Location = new System.Drawing.Point(365, 305);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(195, 50);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit Game";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            this.Quit.Enter += new System.EventHandler(this.startButton_MouseEnter);
            this.Quit.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            // 
            // StartNewGame
            // 
            this.StartNewGame.BackColor = System.Drawing.Color.Transparent;
            this.StartNewGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartNewGame.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.StartNewGame.FlatAppearance.BorderSize = 0;
            this.StartNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.StartNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.StartNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartNewGame.Font = new System.Drawing.Font("Pricedown Bl", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StartNewGame.Location = new System.Drawing.Point(358, 220);
            this.StartNewGame.Name = "StartNewGame";
            this.StartNewGame.Size = new System.Drawing.Size(221, 50);
            this.StartNewGame.TabIndex = 0;
            this.StartNewGame.Text = "Start New Game";
            this.StartNewGame.UseVisualStyleBackColor = false;
            this.StartNewGame.Click += new System.EventHandler(this.NewGame_Click);
            this.StartNewGame.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            // 
            // txtContinue
            // 
            this.txtContinue.AutoSize = true;
            this.txtContinue.BackColor = System.Drawing.Color.Transparent;
            this.txtContinue.Font = new System.Drawing.Font("Pricedown Bl", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtContinue.Location = new System.Drawing.Point(690, 630);
            this.txtContinue.Name = "txtContinue";
            this.txtContinue.Size = new System.Drawing.Size(228, 23);
            this.txtContinue.TabIndex = 10;
            this.txtContinue.Text = "Press ENTER to continue...";
            this.txtContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmationPanel
            // 
            this.confirmationPanel.BackgroundImage = global::App05_RPG_Game.Properties.Resources.UpdatedMenu3;
            this.confirmationPanel.Controls.Add(this.No);
            this.confirmationPanel.Controls.Add(this.Yes);
            this.confirmationPanel.Controls.Add(this.confirmation);
            this.confirmationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmationPanel.Location = new System.Drawing.Point(0, 0);
            this.confirmationPanel.Name = "confirmationPanel";
            this.confirmationPanel.Size = new System.Drawing.Size(924, 661);
            this.confirmationPanel.TabIndex = 11;
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.Color.Transparent;
            this.No.Cursor = System.Windows.Forms.Cursors.Default;
            this.No.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.No.FlatAppearance.BorderSize = 0;
            this.No.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.No.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No.Font = new System.Drawing.Font("Pricedown Bl", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.No.Location = new System.Drawing.Point(560, 317);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(113, 50);
            this.No.TabIndex = 3;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = false;
            this.No.Click += new System.EventHandler(this.button4_Click);
            this.No.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.Color.Transparent;
            this.Yes.Cursor = System.Windows.Forms.Cursors.Default;
            this.Yes.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Yes.FlatAppearance.BorderSize = 0;
            this.Yes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.Yes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yes.Font = new System.Drawing.Font("Pricedown Bl", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Yes.Location = new System.Drawing.Point(263, 317);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(113, 50);
            this.Yes.TabIndex = 1;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = false;
            this.Yes.Click += new System.EventHandler(this.button1_Click);
            this.Yes.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            // 
            // confirmation
            // 
            this.confirmation.BackColor = System.Drawing.Color.Transparent;
            this.confirmation.Cursor = System.Windows.Forms.Cursors.Default;
            this.confirmation.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.confirmation.FlatAppearance.BorderSize = 0;
            this.confirmation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.confirmation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.confirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmation.Font = new System.Drawing.Font("Pricedown Bl", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.confirmation.Location = new System.Drawing.Point(263, 224);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(410, 50);
            this.confirmation.TabIndex = 0;
            this.confirmation.Text = "Are you sure?";
            this.confirmation.UseVisualStyleBackColor = false;
            // 
            // songPlayer
            // 
            this.songPlayer.Enabled = true;
            this.songPlayer.Location = new System.Drawing.Point(129, 9);
            this.songPlayer.Name = "songPlayer";
            this.songPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("songPlayer.OcxState")));
            this.songPlayer.Size = new System.Drawing.Size(75, 23);
            this.songPlayer.TabIndex = 12;
            this.songPlayer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App05_RPG_Game.Properties.Resources.FinaleditedBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.songPlayer);
            this.Controls.Add(this.startMenu);
            this.Controls.Add(this.PauseMenu);
            this.Controls.Add(this.newStartMenu);
            this.Controls.Add(this.txtContinue);
            this.Controls.Add(this.txtWasted);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.confirmationPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 700);
            this.MinimumSize = new System.Drawing.Size(940, 700);
            this.Name = "Form1";
            this.Text = "Chill & Survive";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.startMenu.ResumeLayout(false);
            this.PauseMenu.ResumeLayout(false);
            this.newStartMenu.ResumeLayout(false);
            this.confirmationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Panel startMenu;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel PauseMenu;
        private System.Windows.Forms.Button resumeGame;
        private System.Windows.Forms.Button QuitGame;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label txtWasted;
        private System.Windows.Forms.Panel newStartMenu;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button StartNewGame;
        private System.Windows.Forms.Label txtContinue;
        private System.Windows.Forms.Panel confirmationPanel;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button confirmation;
        private AxWMPLib.AxWindowsMediaPlayer songPlayer;
    }
}

