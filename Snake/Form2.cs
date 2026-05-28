using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form2 : Form
    {
        public static int difficulty = 1;
        int PlayerScore = 0;

        int PlayerX = 377;
        int PlayerY = 304;

        int SnakeSize = 20;
        
        double PlayerSpeed = 0;

        int AppleX;
        int AppleY;

        List<Point> SnakeTail = new List<Point>();


        Random rand = new Random();

        string direction = "right";

        public Form2()
        {
            InitializeComponent();

            this.KeyPreview = true;

            if (difficulty == 0)
            {
                PlayerSpeed = 4.0;
            }
            else if (difficulty == 1)
            {
                PlayerSpeed = 5.0;
            }
            else if (difficulty == 2)
            {
                PlayerSpeed = 6.0;
            }
            else if (difficulty == 3)
            {
                PlayerSpeed = 7.0;
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

            this.Invalidate();

            Rectangle snakeRect = new Rectangle(PlayerX, PlayerY, 20, 20);
            Rectangle appleRect = new Rectangle(AppleX, AppleY, 20, 20);

            if (snakeRect.IntersectsWith(appleRect))
            {
                PlayerScore += 1;
                PlayerSpeed *= 1.005;      
                SpawnApple();
            }


            if (PlayerX > this.ClientSize.Width - 140)
            {
                Timer.Stop();
                try_again.Show();
                Main_menu.Show();
            }
            if (PlayerX < 117)
            {
                Timer.Stop();
                try_again.Show();
                Main_menu.Show();
            }
            if (PlayerY > this.ClientSize.Height - 50)
            {
                Timer.Stop();
                try_again.Show();
                Main_menu.Show();
            }
            if (PlayerY < 108)
            {
                Timer.Stop();
                try_again.Show();
                Main_menu.Show();
            }
            foreach(Point part in SnakeTail)
            {
                Rectangle SnakeTails = new Rectangle(part.X, part.Y , 20, 20);
            }
            if (appleRect.IntersectsWith (snakeRect))
            {
                PlayerScore += 1;
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            foreach (Point part in SnakeTail)
            {
                e.Graphics.FillRectangle(Brushes.Lime, part.X, part.Y, SnakeSize, SnakeSize);
            }

            e.Graphics.FillRectangle(Brushes.Green, new Rectangle(PlayerX, PlayerY, 20, 20));
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(AppleX, AppleY, 20, 20));
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

            try_again.Hide();
            Main_menu.Hide();
            Timer.Start();

            this.Focus();
            SpawnApple();
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
    }
}