using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Knights_quest
{
    public partial class KnightsQuest : Form
    {
        public KnightsQuest()
        {
            InitializeComponent();
            instance = this;
        }

        //Variabelen
        public bool goUp, goDown, goLeft, goRight, gameOver;
        public int speed = 4;
        public int enemySpeed1 = 2;
        public int enemySpeed2 = 2;
        public int enemySpeed3 = 2;
        public int enemySpeed4 = 3;
        public int keys = 0;
        int keysToCollect = 3;
        public int lives = 3;
        public static KnightsQuest instance;

        //Het sluiten van de het fenster als het kruisje wordt ingedrukt
        private void KnightsQuest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Loop timer 20ms
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //De begintekst in het tekstvak
            txtGame.Text = "You need to gather all " + (keysToCollect - keys) + " key(s) and escape!";
            LivesBox.Text = "Lives: " + lives;
            
            //Beweging van de speler bij het indrukken van de pijltoetsen
            if (goUp == true)
            {
                Player.Top -= speed;
            }
            if (goDown == true)
            {
                Player.Top += speed;
            }
            if (goLeft == true)
            {
                Player.Left -= speed;
            }
            if (goRight == true)
            {
                Player.Left += speed;
            }

            
            //De speler wordt tegengehouden als deze tegen de deur aanloopt en de sleutels niet zijn verzameld
            if (goRight == true && door.Visible == true && Player.Bounds.IntersectsWith(door.Bounds))
            {
                Player.Left = door.Left - 50;
            }

            //definering van de picturebox met de tag: x (muur)
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "wall")
                    {
                        //De speler wordt tegengehouden als deze tegen een muur loopt
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (goUp == true)
                            {
                                Player.Top = x.Bottom;
                            }
                            if (goDown == true)
                            {
                                Player.Top = x.Top - 55;
                            }
                            if (goLeft == true)
                            {
                                Player.Left = x.Right;
                            }
                            if (goRight == true)
                            {
                                Player.Left = x.Left - 50;
                            }
                        }
                    }

                    //Als de speler sleutels aanraakt verdwijnen deze en wordt er 1 bij de variabele keys opgeteld
                    if ((string)x.Tag == "key")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            keys++;
                        }
                    }

                    //Als de speler een vijand aanraakt wordt het level gereset. Als er geen levens meer zijn stopt het spel
                    if ((string)x.Tag == "enemy")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (lives == 1)
                            {
                                lives -= 1;
                                gameOver = true;
                                GameTimer.Stop();
                                EnemyTimer.Stop();
                                txtGame.Text = "You've been caught by the guard. Game over! Press SPACE to try again.";
                            }
                            else
                            {
                                RestartGame();
                                lives -= 1;
                            }  
                        }
                    }
                }

                //De speler wint als deze voorbij de deur loopt. Form1 wordt gesloten en Form2 opent. Het aantal levens wordt overgedragen naar Form2 (het volgende level)
                if (Player.Left > 838)
                {
                    GameTimer.Stop();
                    EnemyTimer.Stop();
                    this.Hide();
                    Form2 f2 = new Form2(lives);
                    f2.ShowDialog();
                    this.Close();
                }
            }

            //Als de speler alle sleutels heeft aangeraakt verdwijnt de deur
            if (keys == 3 && gameOver == false)
            {
                door.Visible = false;
                txtGame.Text = "You're almost there! Try reaching the door!";
            }
        }

        //Loop timer voor de beweging van de vijanden 1ms
        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            //Beweegpatroon vijand 1
            if (Enemy1.Left == 46)
            {
                Enemy1.Top -= enemySpeed1;
            }
            if (Enemy1.Top == 304)
            {
                Enemy1.Left += enemySpeed1;
            }
            if (Enemy1.Left == 252)
            {
                Enemy1.Top += enemySpeed1;
            }
            if (Enemy1.Top == 402)
            {
                Enemy1.Left -= enemySpeed1;
            }

            //Beweegpatroon vijand 2
            if (Enemy2.Left == 342)
            {
                Enemy2.Top += enemySpeed1;
            }
            if (Enemy2.Top == 368)
            {
                Enemy2.Left += enemySpeed1;
            }
            if (Enemy2.Left == 634)
            {
                Enemy2.Top -= enemySpeed1;
            }
            if (Enemy2.Top == 74)
            {
                Enemy2.Left -= enemySpeed1;
            }

            //Beweegpatroon vijand 3
            if (Enemy3.Left == 634)
            {
                Enemy3.Top -= enemySpeed1;
            }
            if (Enemy3.Top == 74)
            {
                Enemy3.Left -= enemySpeed1;
            }
            if (Enemy3.Left == 342)
            {
                Enemy3.Top += enemySpeed1;
            }
            if (Enemy3.Top == 368)
            {
                Enemy3.Left += enemySpeed1;
            }

            //Beweegpatroon vijand 4
            Enemy4.Left += enemySpeed2;
            if (Enemy4.Left < 398 || Enemy4.Left > 782)
            {
                enemySpeed2 = -enemySpeed2;
            }

            //Beweegpatroon vijand 5
            Enemy5.Left -= enemySpeed3;
            if (Enemy4.Left < 398 || Enemy4.Left > 782)
            {
                enemySpeed3 = -enemySpeed3;
            }

            //Beweegpatroon vijand 6
            if (Enemy6.Left < 46)
            {
                enemySpeed4 = -enemySpeed4;
            }        
            if (Enemy6.Top < 46)
            {
                enemySpeed4 = -enemySpeed4;
            }
            if (Enemy6.Left == 252)
            {
                Enemy6.Top += enemySpeed4;
            }
            if (Enemy6.Top == 209)
            {
                Enemy6.Left -= enemySpeed4;
            }
        }

        //Interacties bij het indrukken van de toetsen
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && goDown == false && goLeft == false && goRight == false)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && goUp == false && goLeft == false && goRight == false)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Left && goDown == false && goUp == false && goRight == false)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && goDown == false && goLeft == false && goUp == false)
            {
                goRight = true;
            }
        }

        //Interacties bij het loslaten van de toetsen
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && gameOver == true)
            {
                RestartGame();
            }

        }

        //Functie voor het herstarten van het level
        private void RestartGame()
        {
            //Reset van de variabelen.
            gameOver = false;
            keys = 0;
            keysToCollect = 3;

            //Reset van de variabele lives indien er geen levens meer zijn
            if (lives == 0)
            {
                lives = 3;
            }

            //Het zichtbaar maken van de sleutels en de deur
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Visible = true;  
                }
            }

            //Het resetten van de locaties van de speler en de vijanden
            Player.Left = 40;
            Player.Top = 542;

            Enemy1.Left = 46;
            Enemy1.Top = 402;

            Enemy2.Left = 342;
            Enemy2.Top = 74;

            Enemy3.Left = 634;
            Enemy3.Top = 368;

            Enemy4.Left = 398;
            Enemy4.Top = 463;

            Enemy5.Left = 782;
            Enemy5.Top = 536;

            Enemy6.Left = 252;
            Enemy6.Top = 47;

            //Het starten van beide timers
            GameTimer.Start();
            EnemyTimer.Start();
        }
    }
}
