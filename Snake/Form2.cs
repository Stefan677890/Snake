using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form2 : Form
    {
        public static int difficulty = 1;
        public static int HighScore = 0;

        int PlayerScore = 0;
        int applesEaten = 0;

        bool isGoldenAppleActive = false;

        double PlayerX = 377;
        double PlayerY = 304;

        double PlayerSpeed = 0;

        int SnakeSize = 20;

        string direction = "right";

        List<Point> SnakeTail = new List<Point>();

        int AppleX, AppleY;
        int GoldenAppleX, GoldenAppleY;

        Random rand = new Random();

        public Form2()
        {
            InitializeComponent();

            this.KeyPreview = true;

            if (difficulty == 0)
            {
                PlayerSpeed = 2.0;
            }

            else if (difficulty == 1)
            {
                PlayerSpeed = 3.0;
            }

            else if (difficulty == 2)
            {
                PlayerSpeed = 4.0;
            }

            else if (difficulty == 3)
            {
                PlayerSpeed = 5.0;
            }

            this.DoubleBuffered = true;

        }


        private void Tick(object sender, EventArgs e)
        {
            if (direction == "up")
            {
                PlayerY -= (int)PlayerSpeed;
            }

            else if (direction == "down")
            {
                PlayerY += (int)PlayerSpeed;
            }

            else if (direction == "left")

            {
                PlayerX -= (int)PlayerSpeed;
            }

            else if (direction == "right")

            {
                PlayerX += (int)PlayerSpeed;
            }

            SnakeTail.Insert(0, new Point((int)PlayerX, (int)PlayerY));

            int fps = (int)Math.Max(1, 20.0 / PlayerSpeed);
            int maxTailFrames = (PlayerScore + 1) * fps; 

            while (SnakeTail.Count > maxTailFrames)
            {
                SnakeTail.RemoveAt(SnakeTail.Count - 1);
            }

            this.Invalidate(); 

            Rectangle snakeRect = new Rectangle((int)PlayerX, (int)PlayerY, SnakeSize, SnakeSize);
            Rectangle appleRect = new Rectangle(AppleX, AppleY, SnakeSize, SnakeSize);

            if (snakeRect.IntersectsWith(appleRect))
            {
                PlayerScore += 1;
                PlayerSpeed *= 1.02; 

                SpawnApple();

                applesEaten += 1;

                if (applesEaten % 10 == 0) SpawnGoldenApple();
            }

            if (isGoldenAppleActive)
            {
                Rectangle goldenAppleRect = new Rectangle(GoldenAppleX, GoldenAppleY, SnakeSize, SnakeSize);
                if (snakeRect.IntersectsWith(goldenAppleRect))
                {
                    PlayerScore += 5;
                    isGoldenAppleActive = false;
                }
            }

            int safeFrames = (int)(fps * 2.5);

            Rectangle headHitbox = new Rectangle((int)PlayerX + 3, (int)PlayerY + 3, SnakeSize - 6, SnakeSize - 6);

            for (int i = safeFrames; i < SnakeTail.Count; i++)
            {
                Rectangle tailPart = new Rectangle(SnakeTail[i].X + 3, SnakeTail[i].Y + 3, SnakeSize - 6, SnakeSize - 6);
                if (headHitbox.IntersectsWith(tailPart))
                {
                    GameOver();
                    return;
                }
            }

            if (PlayerX > this.ClientSize.Width - 140 || PlayerX < 117 || PlayerY > this.ClientSize.Height - 50 || PlayerY < 108)
            {
                if (PlayerScore > HighScore)
                {
                    HighScore = PlayerScore;
                }

            }

            if (PlayerX > this.ClientSize.Width - 140)
            {
                GameOver();
            }

            if (PlayerX < 117)
            {
                GameOver();
            }

            if (PlayerY > this.ClientSize.Height - 50)
            {
                GameOver();
            }

            if (PlayerY < 108)
            {
                GameOver();
            }
        }
        private void GameOver()
        {
            Timer.Stop();
            if (PlayerScore > HighScore) HighScore = PlayerScore;

            try_again.Show();
            Main_menu.Show();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            foreach (Point part in SnakeTail)
            {
                e.Graphics.FillRectangle(Brushes.Lime, part.X, part.Y, SnakeSize, SnakeSize);
            }

            e.Graphics.FillRectangle(Brushes.Green, new Rectangle((int)PlayerX, (int)PlayerY, SnakeSize, SnakeSize));
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(AppleX, AppleY, SnakeSize, SnakeSize));

            if (isGoldenAppleActive)
            {
                e.Graphics.FillRectangle(Brushes.Gold, new Rectangle(GoldenAppleX, GoldenAppleY, SnakeSize, SnakeSize));
            }

            Font scoreFont = new Font("Arial", 16, FontStyle.Bold);
            e.Graphics.DrawString("Score: " + PlayerScore, scoreFont, Brushes.White, new Point(120, 70));
            e.Graphics.DrawString("             " + HighScore, scoreFont, Brushes.Gold, new Point(300, 70));
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && direction != "down") direction = "up";
            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && direction != "up") direction = "down";
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && direction != "right") direction = "left";
            if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && direction != "left") direction = "right";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Timer.Start();
            try_again.Hide();
            Main_menu.Hide();
            SpawnApple();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            Board menu = new Board();
            menu.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            PlayerX = 377;
            PlayerY = 304;

            direction = "right";

            PlayerScore = 0;

            applesEaten = 0;
            isGoldenAppleActive = false;

            SnakeTail.Clear();
            try_again.Hide();
            Main_menu.Hide();

            this.Focus();

            SpawnApple();

            Timer.Start();
        }
        private void SpawnApple()
        {
            int minX = 117;
            int maxX = this.ClientSize.Width - 160;

            int minY = 108;
            int maxY = this.ClientSize.Height - 70;

            AppleX = rand.Next(minX, maxX);
            AppleY = rand.Next(minY, maxY);
        }

        private void SpawnGoldenApple()
        {
            int minX = 117;
            int maxX = this.ClientSize.Width - 160;

            int minY = 108;
            int maxY = this.ClientSize.Height - 70;

            GoldenAppleX = rand.Next(minX, maxX);
            GoldenAppleY = rand.Next(minY, maxY);

            isGoldenAppleActive = true;
        }
    }
}