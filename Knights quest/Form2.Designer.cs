namespace Knights_quest
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Player = new System.Windows.Forms.PictureBox();
            this.Wallleft = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Box2 = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Box1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Box3 = new System.Windows.Forms.PictureBox();
            this.Box4 = new System.Windows.Forms.PictureBox();
            this.Box5 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.Pad1 = new System.Windows.Forms.PictureBox();
            this.Pad2 = new System.Windows.Forms.PictureBox();
            this.Pad3 = new System.Windows.Forms.PictureBox();
            this.EndDoor = new System.Windows.Forms.PictureBox();
            this.Spot2 = new System.Windows.Forms.PictureBox();
            this.Spot3 = new System.Windows.Forms.PictureBox();
            this.Spot1 = new System.Windows.Forms.PictureBox();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.LivesBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wallleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player.BackColor = System.Drawing.Color.SteelBlue;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(74, 97);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            this.Player.Tag = "player";
            // 
            // Wallleft
            // 
            this.Wallleft.BackColor = System.Drawing.Color.LightSlateGray;
            this.Wallleft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Wallleft.BackgroundImage")));
            this.Wallleft.Location = new System.Drawing.Point(3, 0);
            this.Wallleft.Name = "Wallleft";
            this.Wallleft.Size = new System.Drawing.Size(877, 40);
            this.Wallleft.TabIndex = 2;
            this.Wallleft.TabStop = false;
            this.Wallleft.Tag = "wall";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Box2
            // 
            this.Box2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box2.Image = ((System.Drawing.Image)(resources.GetObject("Box2.Image")));
            this.Box2.Location = new System.Drawing.Point(189, 404);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(50, 50);
            this.Box2.TabIndex = 3;
            this.Box2.TabStop = false;
            this.Box2.Tag = "box";
            // 
            // Enemy1
            // 
            this.Enemy1.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1.Image")));
            this.Enemy1.Location = new System.Drawing.Point(207, 287);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(50, 51);
            this.Enemy1.TabIndex = 4;
            this.Enemy1.TabStop = false;
            this.Enemy1.Tag = "enemy";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(161, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 328);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 597);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(840, 40);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // Box1
            // 
            this.Box1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box1.Image = ((System.Drawing.Image)(resources.GetObject("Box1.Image")));
            this.Box1.Location = new System.Drawing.Point(109, 470);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(50, 50);
            this.Box1.TabIndex = 3;
            this.Box1.TabStop = false;
            this.Box1.Tag = "box";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(379, 178);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 420);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "wall";
            // 
            // Enemy2
            // 
            this.Enemy2.Image = ((System.Drawing.Image)(resources.GetObject("Enemy2.Image")));
            this.Enemy2.Location = new System.Drawing.Point(425, 243);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(50, 51);
            this.Enemy2.TabIndex = 4;
            this.Enemy2.TabStop = false;
            this.Enemy2.Tag = "enemy";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(605, 39);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 409);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "wall";
            // 
            // Box3
            // 
            this.Box3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Box3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box3.Image = ((System.Drawing.Image)(resources.GetObject("Box3.Image")));
            this.Box3.Location = new System.Drawing.Point(658, 365);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(50, 50);
            this.Box3.TabIndex = 3;
            this.Box3.TabStop = false;
            this.Box3.Tag = "box";
            // 
            // Box4
            // 
            this.Box4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Box4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box4.Image = ((System.Drawing.Image)(resources.GetObject("Box4.Image")));
            this.Box4.Location = new System.Drawing.Point(780, 287);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(50, 50);
            this.Box4.TabIndex = 3;
            this.Box4.TabStop = false;
            this.Box4.Tag = "box";
            // 
            // Box5
            // 
            this.Box5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Box5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box5.Image = ((System.Drawing.Image)(resources.GetObject("Box5.Image")));
            this.Box5.Location = new System.Drawing.Point(719, 209);
            this.Box5.Name = "Box5";
            this.Box5.Size = new System.Drawing.Size(50, 50);
            this.Box5.TabIndex = 3;
            this.Box5.TabStop = false;
            this.Box5.Tag = "box";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.Location = new System.Drawing.Point(840, 39);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(40, 409);
            this.pictureBox10.TabIndex = 5;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "wall";
            // 
            // Pad1
            // 
            this.Pad1.BackColor = System.Drawing.Color.Aqua;
            this.Pad1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pad1.Location = new System.Drawing.Point(651, 46);
            this.Pad1.Name = "Pad1";
            this.Pad1.Size = new System.Drawing.Size(50, 55);
            this.Pad1.TabIndex = 3;
            this.Pad1.TabStop = false;
            this.Pad1.Tag = "";
            // 
            // Pad2
            // 
            this.Pad2.BackColor = System.Drawing.Color.Aqua;
            this.Pad2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pad2.Location = new System.Drawing.Point(719, 46);
            this.Pad2.Name = "Pad2";
            this.Pad2.Size = new System.Drawing.Size(50, 55);
            this.Pad2.TabIndex = 3;
            this.Pad2.TabStop = false;
            this.Pad2.Tag = "";
            // 
            // Pad3
            // 
            this.Pad3.BackColor = System.Drawing.Color.Aqua;
            this.Pad3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pad3.Location = new System.Drawing.Point(784, 46);
            this.Pad3.Name = "Pad3";
            this.Pad3.Size = new System.Drawing.Size(50, 55);
            this.Pad3.TabIndex = 3;
            this.Pad3.TabStop = false;
            this.Pad3.Tag = "";
            // 
            // EndDoor
            // 
            this.EndDoor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EndDoor.Location = new System.Drawing.Point(840, 454);
            this.EndDoor.Name = "EndDoor";
            this.EndDoor.Size = new System.Drawing.Size(40, 137);
            this.EndDoor.TabIndex = 5;
            this.EndDoor.TabStop = false;
            this.EndDoor.Tag = "";
            // 
            // Spot2
            // 
            this.Spot2.BackColor = System.Drawing.Color.Aqua;
            this.Spot2.Location = new System.Drawing.Point(739, 46);
            this.Spot2.Name = "Spot2";
            this.Spot2.Size = new System.Drawing.Size(10, 19);
            this.Spot2.TabIndex = 3;
            this.Spot2.TabStop = false;
            this.Spot2.Tag = "spot";
            this.Spot2.Visible = false;
            // 
            // Spot3
            // 
            this.Spot3.BackColor = System.Drawing.Color.Aqua;
            this.Spot3.Location = new System.Drawing.Point(804, 46);
            this.Spot3.Name = "Spot3";
            this.Spot3.Size = new System.Drawing.Size(10, 19);
            this.Spot3.TabIndex = 3;
            this.Spot3.TabStop = false;
            this.Spot3.Tag = "spot";
            this.Spot3.Visible = false;
            // 
            // Spot1
            // 
            this.Spot1.BackColor = System.Drawing.Color.Aqua;
            this.Spot1.Location = new System.Drawing.Point(671, 46);
            this.Spot1.Name = "Spot1";
            this.Spot1.Size = new System.Drawing.Size(10, 19);
            this.Spot1.TabIndex = 3;
            this.Spot1.TabStop = false;
            this.Spot1.Tag = "spot";
            this.Spot1.Visible = false;
            // 
            // txtGame
            // 
            this.txtGame.Enabled = false;
            this.txtGame.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGame.Location = new System.Drawing.Point(898, 24);
            this.txtGame.Multiline = true;
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(169, 159);
            this.txtGame.TabIndex = 6;
            this.txtGame.Text = "Hello";
            // 
            // LivesBox
            // 
            this.LivesBox.Enabled = false;
            this.LivesBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesBox.Location = new System.Drawing.Point(935, 595);
            this.LivesBox.Name = "LivesBox";
            this.LivesBox.ReadOnly = true;
            this.LivesBox.Size = new System.Drawing.Size(100, 30);
            this.LivesBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 428);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1083, 637);
            this.Controls.Add(this.LivesBox);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.EndDoor);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.Spot3);
            this.Controls.Add(this.Spot2);
            this.Controls.Add(this.Spot1);
            this.Controls.Add(this.Box5);
            this.Controls.Add(this.Box4);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Wallleft);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Pad1);
            this.Controls.Add(this.Pad2);
            this.Controls.Add(this.Pad3);
            this.Name = "Form2";
            this.Text = "Knight\'s Quest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wallleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pad3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Wallleft;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Box2;
        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Box1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox Box3;
        private System.Windows.Forms.PictureBox Box4;
        private System.Windows.Forms.PictureBox Box5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox Pad1;
        private System.Windows.Forms.PictureBox Pad2;
        private System.Windows.Forms.PictureBox Pad3;
        private System.Windows.Forms.PictureBox EndDoor;
        private System.Windows.Forms.PictureBox Spot2;
        private System.Windows.Forms.PictureBox Spot3;
        private System.Windows.Forms.PictureBox Spot1;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.TextBox LivesBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}