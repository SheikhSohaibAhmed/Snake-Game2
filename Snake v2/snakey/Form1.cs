using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace snakey
{
    public partial class Form1 : Form
    {
        List<Circle> snake = new List<Circle>();
        Circle food = new Circle();
        public Form1()
        {
            InitializeComponent();
            new Settings();
            gametimer.Interval = 1000 / Settings.speed;
            gametimer.Tick += updatescreen;
            gametimer.Start();
            startgame();
        }
        private void startgame()
        {
            lblgaeover.Visible = false;
            new Settings();
            snake.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            snake.Add(head);
            lblscore.Text = Settings.score.ToString();
            generatefood();
        }
        private void generatefood()
        {
            int maxXpos = pbcanvas.Size.Width / Settings.width;
            int maxYpos = pbcanvas.Size.Height / Settings.height;
            Random randon = new Random();
            food = new Circle();
            food.X = randon.Next(0, maxXpos);
            food.Y = randon.Next(0, maxYpos);
        }
        private void updatescreen(object sender, EventArgs e)
        {
            if (Settings.gameover == true)
            {
                if (Input.keypressed(Keys.Enter))
                {
                    startgame();
                }
            }
            else
            {
                if (Input.keypressed(Keys.Right) && Settings.direction != directions.left)
                    Settings.direction = directions.right;
                else if (Input.keypressed(Keys.Left) && Settings.direction != directions.right)
                    Settings.direction = directions.left;
                else if (Input.keypressed(Keys.Down) && Settings.direction != directions.up)
                    Settings.direction = directions.down;
                else if (Input.keypressed(Keys.Up) && Settings.direction != directions.down)
                    Settings.direction = directions.up;
                moveplayer();
            }
            pbcanvas.Invalidate();
        }
        private void pbcanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!Settings.gameover)
            {
                Brush snakecolor;
                for (int i = 0; i < snake.Count; i++)
                {
                    if (i == 0)
                        snakecolor = Brushes.Black;
                    else
                        snakecolor = Brushes.Green;
                    canvas.FillEllipse(snakecolor, new Rectangle(snake[i].X * Settings.width, snake[i].Y * Settings.height, Settings.width, Settings.height));
                    canvas.FillEllipse(Brushes.Red, new Rectangle(food.X * Settings.width, food.Y * Settings.height, Settings.width, Settings.height));
                }

            }
            else
            {
                string gameoover = "Game Over \n your score is " + Settings.score + "\n press enter to try again";
                lblgaeover.Text = gameoover;
                lblgaeover.Visible = true;
            }
        }

        private void moveplayer()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case directions.right:
                            {
                                snake[i].X++;
                                break;
                            }
                        case directions.left:
                            {
                                snake[i].X--;
                                break;
                            }
                        case directions.up:
                            {
                                snake[i].Y--;
                                break;
                            }
                        case directions.down:
                            {
                                snake[i].Y++;
                                break;
                            }
                    }
                    int maxXpos = pbcanvas.Size.Width / Settings.width;
                    int maxYpos = pbcanvas.Size.Height / Settings.height;
                    if (snake[i].X < 0 || snake[i].X > maxXpos || snake[i].Y < 0 || snake[i].Y > maxYpos)
                        Die();
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].X == snake[j].X &&
                           snake[i].Y == snake[j].Y)
                        {
                            Die();
                        }
                    }
                    if (snake[0].X == food.X && snake[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.changestate(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.changestate(e.KeyCode, false);
        }
        private void Eat()
        {
            //Add circle to body
            Circle circle = new Circle
            {
                X = snake[snake.Count - 1].X,
                Y = snake[snake.Count - 1].Y
            };
            snake.Add(circle);

            //Update Score
            Settings.score += Settings.points;
            lblscore.Text = Settings.score.ToString();

            generatefood();
        }

        private void Die()
        {
            Settings.gameover = true;
        }
    }
}
