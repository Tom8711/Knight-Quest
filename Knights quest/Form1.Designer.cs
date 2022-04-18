namespace Knights_quest
{
    partial class KnightsQuest
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnightsQuest));
            this.Player = new System.Windows.Forms.PictureBox();
            this.Wallleft = new System.Windows.Forms.PictureBox();
            this.Wallright = new System.Windows.Forms.PictureBox();
            this.Walldown = new System.Windows.Forms.PictureBox();
            this.wallup = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Key1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy3 = new System.Windows.Forms.PictureBox();
            this.EnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.Enemy4 = new System.Windows.Forms.PictureBox();
            this.Enemy5 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.Enemy6 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.LivesBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wallleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wallright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Walldown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.SteelBlue;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(40, 542);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(47, 51);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Tag = "player";
            // 
            // Wallleft
            // 
            this.Wallleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Wallleft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Wallleft.BackgroundImage")));
            this.Wallleft.Location = new System.Drawing.Point(0, 0);
            this.Wallleft.Name = "Wallleft";
            this.Wallleft.Size = new System.Drawing.Size(40, 637);
            this.Wallleft.TabIndex = 1;
            this.Wallleft.TabStop = false;
            this.Wallleft.Tag = "wall";
            // 
            // Wallright
            // 
            this.Wallright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Wallright.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Wallright.BackgroundImage")));
            this.Wallright.Location = new System.Drawing.Point(838, 429);
            this.Wallright.Name = "Wallright";
            this.Wallright.Size = new System.Drawing.Size(48, 208);
            this.Wallright.TabIndex = 1;
            this.Wallright.TabStop = false;
            this.Wallright.Tag = "wall";
            // 
            // Walldown
            // 
            this.Walldown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Walldown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Walldown.BackgroundImage")));
            this.Walldown.Location = new System.Drawing.Point(39, 597);
            this.Walldown.Name = "Walldown";
            this.Walldown.Size = new System.Drawing.Size(800, 40);
            this.Walldown.TabIndex = 1;
            this.Walldown.TabStop = false;
            this.Walldown.Tag = "wall";
            // 
            // wallup
            // 
            this.wallup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wallup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wallup.BackgroundImage")));
            this.wallup.Location = new System.Drawing.Point(39, 0);
            this.wallup.Name = "wallup";
            this.wallup.Size = new System.Drawing.Size(800, 40);
            this.wallup.TabIndex = 1;
            this.wallup.TabStop = false;
            this.wallup.Tag = "wall";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 429);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 28);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(308, 139);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 458);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "wall";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(108, 270);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 28);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "wall";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(555, 294);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(73, 65);
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "wall";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.Location = new System.Drawing.Point(398, 294);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(76, 65);
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "wall";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(719, 429);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 28);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // Key1
            // 
            this.Key1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Key1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Key1.BackgroundImage")));
            this.Key1.Location = new System.Drawing.Point(398, 139);
            this.Key1.Name = "Key1";
            this.Key1.Size = new System.Drawing.Size(76, 65);
            this.Key1.TabIndex = 1;
            this.Key1.TabStop = false;
            this.Key1.Tag = "wall";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(555, 139);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(73, 65);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "wall";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.Location = new System.Drawing.Point(39, 462);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(200, 28);
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "wall";
            // 
            // Enemy1
            // 
            this.Enemy1.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1.Image")));
            this.Enemy1.Location = new System.Drawing.Point(46, 402);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(50, 51);
            this.Enemy1.TabIndex = 2;
            this.Enemy1.TabStop = false;
            this.Enemy1.Tag = "enemy";
            // 
            // Enemy2
            // 
            this.Enemy2.Image = ((System.Drawing.Image)(resources.GetObject("Enemy2.Image")));
            this.Enemy2.Location = new System.Drawing.Point(342, 74);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(50, 51);
            this.Enemy2.TabIndex = 2;
            this.Enemy2.TabStop = false;
            this.Enemy2.Tag = "enemy";
            // 
            // Enemy3
            // 
            this.Enemy3.Image = ((System.Drawing.Image)(resources.GetObject("Enemy3.Image")));
            this.Enemy3.Location = new System.Drawing.Point(634, 368);
            this.Enemy3.Name = "Enemy3";
            this.Enemy3.Size = new System.Drawing.Size(50, 51);
            this.Enemy3.TabIndex = 2;
            this.Enemy3.TabStop = false;
            this.Enemy3.Tag = "enemy";
            // 
            // EnemyTimer
            // 
            this.EnemyTimer.Enabled = true;
            this.EnemyTimer.Interval = 1;
            this.EnemyTimer.Tick += new System.EventHandler(this.EnemyTimer_Tick);
            // 
            // Enemy4
            // 
            this.Enemy4.Image = ((System.Drawing.Image)(resources.GetObject("Enemy4.Image")));
            this.Enemy4.Location = new System.Drawing.Point(398, 463);
            this.Enemy4.Name = "Enemy4";
            this.Enemy4.Size = new System.Drawing.Size(50, 51);
            this.Enemy4.TabIndex = 2;
            this.Enemy4.TabStop = false;
            this.Enemy4.Tag = "enemy";
            // 
            // Enemy5
            // 
            this.Enemy5.Image = ((System.Drawing.Image)(resources.GetObject("Enemy5.Image")));
            this.Enemy5.Location = new System.Drawing.Point(782, 536);
            this.Enemy5.Name = "Enemy5";
            this.Enemy5.Size = new System.Drawing.Size(50, 51);
            this.Enemy5.TabIndex = 2;
            this.Enemy5.TabStop = false;
            this.Enemy5.Tag = "enemy";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(489, 226);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(53, 48);
            this.pictureBox10.TabIndex = 3;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "key";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(46, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 48);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "key";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(342, 503);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(53, 48);
            this.pictureBox11.TabIndex = 3;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "key";
            // 
            // Enemy6
            // 
            this.Enemy6.Image = ((System.Drawing.Image)(resources.GetObject("Enemy6.Image")));
            this.Enemy6.Location = new System.Drawing.Point(252, 47);
            this.Enemy6.Name = "Enemy6";
            this.Enemy6.Size = new System.Drawing.Size(50, 51);
            this.Enemy6.TabIndex = 2;
            this.Enemy6.TabStop = false;
            this.Enemy6.Tag = "enemy";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.Location = new System.Drawing.Point(719, 139);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(28, 290);
            this.pictureBox12.TabIndex = 1;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "wall";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox13.BackgroundImage")));
            this.pictureBox13.Location = new System.Drawing.Point(838, 0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(48, 373);
            this.pictureBox13.TabIndex = 1;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "wall";
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.door.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("door.BackgroundImage")));
            this.door.Image = ((System.Drawing.Image)(resources.GetObject("door.Image")));
            this.door.Location = new System.Drawing.Point(838, 368);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(48, 61);
            this.door.TabIndex = 4;
            this.door.TabStop = false;
            // 
            // txtGame
            // 
            this.txtGame.Enabled = false;
            this.txtGame.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGame.Location = new System.Drawing.Point(902, 20);
            this.txtGame.Multiline = true;
            this.txtGame.Name = "txtGame";
            this.txtGame.ReadOnly = true;
            this.txtGame.Size = new System.Drawing.Size(169, 120);
            this.txtGame.TabIndex = 5;
            this.txtGame.Text = "Hello";
            // 
            // LivesBox
            // 
            this.LivesBox.Enabled = false;
            this.LivesBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesBox.Location = new System.Drawing.Point(932, 577);
            this.LivesBox.Name = "LivesBox";
            this.LivesBox.ReadOnly = true;
            this.LivesBox.Size = new System.Drawing.Size(100, 30);
            this.LivesBox.TabIndex = 6;
            // 
            // KnightsQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1083, 637);
            this.Controls.Add(this.LivesBox);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.door);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.Enemy5);
            this.Controls.Add(this.Enemy4);
            this.Controls.Add(this.Enemy3);
            this.Controls.Add(this.Enemy6);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.wallup);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Walldown);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Key1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.Wallright);
            this.Controls.Add(this.Wallleft);
            this.Controls.Add(this.Player);
            this.Name = "KnightsQuest";
            this.Tag = "key";
            this.Text = "Knight\'s Quest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KnightsQuest_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wallleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wallright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Walldown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Wallleft;
        private System.Windows.Forms.PictureBox Wallright;
        private System.Windows.Forms.PictureBox Walldown;
        private System.Windows.Forms.PictureBox wallup;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Key1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox Enemy3;
        private System.Windows.Forms.Timer EnemyTimer;
        private System.Windows.Forms.PictureBox Enemy4;
        private System.Windows.Forms.PictureBox Enemy5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox Enemy6;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.TextBox LivesBox;
    }
}

