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
    

    public partial class Form2 : Form
    {
        //Variabelen
        bool goUp, goDown, goLeft, goRight, enemy1Right = true, enemy1Left, enemy2Right, enemy2Left = true, spot1Press, spot2Press, spot3Press, gameOver;

        //Het sluiten van de het fenster als het kruisje wordt ingedrukt
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Variabelen
        int speed = 4;
        int enemySpeed = 5;
        public int lives;
        public static Form2 instance;

        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        //Functie voor het meenemen van levens uit Form1
        public Form2(int pastLives)
        {
            InitializeComponent();
            instance = this;
            lives = pastLives;
        }


        //Loop timer 20ms
        private void GameTimer_Tick(object sender, EventArgs e)
        {

            //tekst veld met tekst. Deze veranderd als de speler bij de 3 dozen komt
            LivesBox.Text = "Lives: " + lives;

            if (Player.Left > 555)
            {
                txtGame.Text = "The gate is closed. Try opening it.";
            }
            else
            {
                txtGame.Text = "You need to sneak past the guards.";
            }

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

            //Beweegpatroon vijand 1
            if (enemy1Right == true)
            {
                Enemy1.Left += enemySpeed;
            }
            if (enemy1Left == true)
            {
                Enemy1.Left -= enemySpeed;
            }

            //Beweegpatroon vijand 2
            if (enemy2Right == true)
            {
                Enemy2.Left += enemySpeed;
            }
            if (enemy2Left == true)
            {
                Enemy2.Left -= enemySpeed;
            }

            //De speler wordt tegengehouden als deze tegen de gesloten (visible) deur aanloopt
            if (EndDoor.Visible == true && Player.Bounds.IntersectsWith(EndDoor.Bounds))
            {
                Player.Left -= 5;
            }

            //De deur wordt geopend als alle panelen zijn ingedrukt met een doos
            if (spot1Press == true && spot2Press == true && spot3Press == true)
            {
                EndDoor.Visible = false;
            }

            //De speler wint als deze voorbij de deur loopt. De timer stopt en het spel kan worden herstart door op de spatiebalk te drukken
            if (Player.Left > 880)
            {
                GameTimer.Stop();
                gameOver = true;
                txtGame.Text = "Congratulations! You've excaped the dungeon!!! Press SPACE if you want to try again.";
            }

            //Doos 1 wordt tegengehouden door doos 2
            if (Box1.Bounds.IntersectsWith(Box2.Bounds) && Player.Bounds.IntersectsWith(Box1.Bounds))
            {
                if (goUp == true)
                {
                    Box1.Top = Box2.Bottom + 5;
                }
                if (goDown == true)
                {
                    Box1.Top = Box2.Top - 55;
                }
                if (goLeft == true)
                {
                    Box1.Left = Box2.Right + 5;
                }
                if (goRight == true)
                {
                    Box1.Left = Box2.Left - 55;
                }
            }

            //Doos 2 wordt tegengehouden door doos 1
            if (Box2.Bounds.IntersectsWith(Box1.Bounds) && Player.Bounds.IntersectsWith(Box2.Bounds))
            {
                if (goUp == true)
                {
                    Box2.Top = Box1.Bottom + 5;
                }
                if (goDown == true)
                {
                    Box2.Top = Box1.Top - 55;
                }
                if (goLeft == true)
                {
                    Box2.Left = Box1.Right + 5;
                }
                if (goRight == true)
                {
                    Box2.Left = Box1.Left - 55;
                }
            }

            //Doos 3 wordt tegengehouden door doos 4
            if (Box3.Bounds.IntersectsWith(Box4.Bounds) && Player.Bounds.IntersectsWith(Box3.Bounds))
            {
                if (goUp == true)
                {
                    Box3.Top = Box4.Bottom + 5;
                }
                if (goDown == true)
                {
                    Box3.Top = Box4.Top - 55;
                }
                if (goLeft == true)
                {
                    Box3.Left = Box4.Right + 5;
                }
                if (goRight == true)
                {
                    Box3.Left = Box4.Left - 55;
                }
            }

            //Doos 3 wordt tegengehouden door doos 5
            if (Box3.Bounds.IntersectsWith(Box5.Bounds) && Player.Bounds.IntersectsWith(Box3.Bounds))
            {
                if (goUp == true)
                {
                    Box3.Top = Box5.Bottom + 5;
                }
                if (goDown == true)
                {
                    Box3.Top = Box5.Top - 55;
                }
                if (goLeft == true)
                {
                    Box3.Left = Box5.Right + 5;
                }
                if (goRight == true)
                {
                    Box3.Left = Box5.Left - 55;
                }
            }

            //Doos 4 wordt tegengehouden door doos 3
            if (Box4.Bounds.IntersectsWith(Box3.Bounds) && Player.Bounds.IntersectsWith(Box4.Bounds))
            {
                if (goUp == true)
                {
                    Box4.Top = Box3.Bottom + 5;
                }
                if (goDown == true)
                {
                    Box4.Top = Box3.Top - 55;
                }
                if (goLeft == true)
                {
                    Box4.Left = Box3.Right + 5;
                }
                if (goRight == true)
                {
                    Box4.Left = Box3.Left - 55;
                }
            }

            //Doos 4 wordt tegengehouden door doos 5
            if (Box4.Bounds.IntersectsWith(Box5.Bounds) && Player.Bounds.IntersectsWith(Box4.Bounds))
            {
                if (goUp == true)
                {
                    Box4.Top = Box5.Bottom + 5;
                }
                if (goDown == true)
                {
                    Box4.Top = Box5.Top - 55;
                }
                if (goLeft == true)
                {
                    Box4.Left = Box5.Right + 5;
                }
                if (goRight == true)
                {
                    Box4.Left = Box5.Left - 55;
                }
            }

            //Doos 5 wordt tegengehouden door doos 3
            if (Box5.Bounds.IntersectsWith(Box3.Bounds) && Player.Bounds.IntersectsWith(Box5.Bounds))
            {
                if (goUp == true)
                {
                    Box5.Top = Box3.Bottom + 5;
                }
                if (goDown == true)
                {
                    Box5.Top = Box3.Top - 55;
                }
                if (goLeft == true)
                {
                    Box5.Left = Box3.Right + 5;
                }
                if (goRight == true)
                {
                    Box5.Left = Box3.Left - 55;
                }
            }

            //Doos 5 wordt tegengehouden door doos 4
            if (Box5.Bounds.IntersectsWith(Box4.Bounds) && Player.Bounds.IntersectsWith(Box5.Bounds))
            {
                if (goUp == true)
                {
                    Box5.Top = Box4.Bottom + 5;
                }
                if (goDown == true)
                {
                    Box5.Top = Box4.Top - 55;
                }
                if (goLeft == true)
                {
                    Box5.Left = Box4.Right + 5;
                }
                if (goRight == true)
                {
                    Box5.Left = Box4.Left - 55;
                }
            }

            //definering van de pictureboxes met de tags: x (muur), y (doos), z (vijand)
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox)
                        {
                            foreach (Control z in this.Controls)
                            {
                                if (z is PictureBox)
                                {
                                    if ((string)x.Tag == "wall")
                                    {
                                        if ((string)y.Tag == "box")
                                        {
                                            if ((string)z.Tag == "enemy")
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
                                                        Player.Top = x.Top - 53;
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

                                                //De speler duwt de doos in de richting waarin bewogen wordt
                                                if (Player.Bounds.IntersectsWith(y.Bounds))
                                                {                                                   
                                                    if (goUp == true)
                                                    {
                                                        y.Top -= speed;
                                                        Player.Top = y.Bottom + 3;
                                                    }
                                                    if (goDown == true)
                                                    {
                                                        y.Top += speed;
                                                        Player.Top = y.Top - 53;
                                                    }
                                                    if (goLeft == true)
                                                    {
                                                        y.Left -= speed;
                                                        Player.Left = y.Right + 3;
                                                    }
                                                    if (goRight == true)
                                                    {
                                                        y.Left += speed;
                                                        Player.Left = y.Left - 53;
                                                    }
                                                }

                                                //Als de speler een vijand aanraakt wordt het level gereset. Als er geen levens meer zijn stopt het spel
                                                if (Player.Bounds.IntersectsWith(z.Bounds))
                                                {
                                                    if (lives == 1)
                                                    {
                                                        lives -= 1;
                                                        gameOver = true;
                                                        GameTimer.Stop();
                                                        txtGame.Text = "You've been caught by the guard. Game over! Press SPACE to try again.";
                                                    }
                                                    else
                                                    {
                                                        RestardLevel();
                                                        lives -= 1;
                                                    }
                                                }

                                                //Interactie tussen de doos en de muur
                                                if (y.Bounds.IntersectsWith(x.Bounds))
                                                {                                                  
                                                    if (goUp == true)
                                                    {
                                                        y.Top = x.Bottom +5;
                                                    }
                                                    if (goDown == true)
                                                    {
                                                        y.Top = x.Top - 55;
                                                    }
                                                    if (goLeft == true)
                                                    {
                                                        y.Left = x.Right + 5;
                                                    }
                                                    if (goRight == true)
                                                    {
                                                        y.Left = x.Left - 55;
                                                    }
                                                }

                                                //Het omkeren van de vijand beweging bij het aanraken van een muur

                                                //Als vijand 1 naar rechts beweegt en de muur raakt
                                                if (z.Bounds.IntersectsWith(x.Bounds) && enemy1Right == true)
                                                {
                                                    if ((string)z.Name == "Enemy1")
                                                    {
                                                        z.Left -= 5;
                                                        enemy1Right = false;
                                                        enemy1Left = true;
                                                    }

                                                }
                                                //Als vijand 1 naar links beweegt en de muur raakt
                                                if (z.Bounds.IntersectsWith(x.Bounds) && enemy1Left == true)
                                                {
                                                    if ((string)z.Name == "Enemy1")
                                                    {
                                                        z.Left += 5;
                                                        enemy1Left = false;
                                                        enemy1Right = true;
                                                    }

                                                }

                                                //Als vijand 2 naar rechts beweegt en de muur raakt
                                                if (z.Bounds.IntersectsWith(x.Bounds) && enemy2Right == true)
                                                {
                                                    if ((string)z.Name == "Enemy2")
                                                    {
                                                        z.Left -= 5;
                                                        enemy2Right = false;
                                                        enemy2Left = true;
                                                    }
                                                }
                                                //Als vijand 2 naar links beweegt en de muur raakt
                                                if (z.Bounds.IntersectsWith(x.Bounds) && enemy2Left == true)
                                                {
                                                    if ((string)z.Name == "Enemy2")
                                                    {
                                                        z.Left += 5;
                                                        enemy2Left = false;
                                                        enemy2Right = true;
                                                    }

                                                }

                                                //Interactie tussen vijand en doos

                                                //Interactie tussen vijand 1 en 2 en de rechterkant van de doos
                                                if (y.Bounds.IntersectsWith(z.Bounds) && y.Right < z.Left +5)
                                                {
                                                    if ((string)z.Name == "Enemy1")
                                                    {
                                                        z.Left += 5;
                                                        enemy1Left = false;
                                                        enemy1Right = true;
                                                    }
                                                    if ((string)z.Name == "Enemy2")
                                                    {
                                                        z.Left += 5;
                                                        enemy2Left = false;
                                                        enemy2Right = true;
                                                    }
                                                }

                                                //Interactie tussen vijand 1 en 2 en de linkerkant van de doos
                                                if (y.Bounds.IntersectsWith(z.Bounds) && y.Left > z.Right - 5)
                                                {
                                                    if ((string)z.Name == "Enemy1")
                                                    {
                                                        z.Left -= 5;
                                                        enemy1Right = false;
                                                        enemy1Left = true;
                                                    }
                                                    if ((string)z.Name == "Enemy2")
                                                    {
                                                        z.Left -= 5;
                                                        enemy2Right = false;
                                                        enemy2Left = true;
                                                    }
                                                }

                                                //Interactie tussen de boven en onderkant van de doos en vijand
                                                if (y.Bounds.IntersectsWith(z.Bounds) && y.Left < z.Right && y.Right > z.Left && y.Top < z.Top)
                                                {
                                                    y.Top = z.Top - 56;
                                                }
                                                if (y.Bounds.IntersectsWith(z.Bounds) && y.Left < z.Right && y.Right > z.Left && y.Bottom > z.Bottom)
                                                {
                                                    y.Top = z.Bottom + 4;
                                                }

                                                //Interactie tussen doos en drukplaten 1, 2 en 3
                                                if (y.Bounds.IntersectsWith(Spot1.Bounds))
                                                {
                                                    spot1Press = true;
                                                    Pad1.BackColor = Color.Black;
                                                }
                                                if (y.Bounds.IntersectsWith(Spot2.Bounds))
                                                {
                                                    spot2Press = true;
                                                    Pad2.BackColor = Color.Black;
                                                }
                                                if (y.Bounds.IntersectsWith(Spot3.Bounds))
                                                {
                                                    spot3Press = true;
                                                    Pad3.BackColor = Color.Black;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
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

            //Form1 wordt geopend als het spel afgelopen is en de spatiebalk wordt ingedrukt
            if (e.KeyCode == Keys.Space && gameOver == true)
            {
                this.Hide();
                KnightsQuest f1 = new KnightsQuest();
                f1.ShowDialog();
                this.Close();
            }

            
        }

        //Functie voor het herstarten van het level. Alle objecten worden op de beginlocatie gezet
        private void RestardLevel()
        {
            Player.Top = 59;
            Player.Left = 74;

            Box1.Top = 470;
            Box1.Left = 109;

            Box2.Top = 404;
            Box2.Left = 189;

            Box3.Top = 365;
            Box3.Left = 658;

            Box4.Top = 287;
            Box4.Left = 780;

            Box5.Top = 209;
            Box5.Left = 719;

            Enemy1.Top = 287;
            Enemy1.Left = 207;

            Enemy2.Top = 243;
            Enemy2.Left = 425;

            spot1Press = false;
            Pad1.BackColor = Color.Aqua;

            spot2Press = false;
            Pad2.BackColor = Color.Aqua;

            spot3Press = false;
            Pad3.BackColor = Color.Aqua;

            EndDoor.Visible = true;
        }
    }
}
