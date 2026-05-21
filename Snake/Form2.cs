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
        int PlayerSpeed = 0;

        int AppleX;
        int AppleY;
        string direction = "right";

        public Form2()
        {
            InitializeComponent();

            if (difficulty == 0)
            {
                PlayerSpeed = 4;
            }
            else if (difficulty == 1)
            {
                PlayerSpeed = 5;
            }
            else if (difficulty == 2)
            {
                PlayerSpeed = 6;
            }
            else if (difficulty == 3)
            {
                PlayerSpeed = 7;
            }


            this.DoubleBuffered = true;
        }

        private void Tick(object sender, EventArgs e)
        {
            if (direction == "up")
            {
                PlayerY -= PlayerSpeed;
            }
            else if (direction == "down")
            {
                PlayerY += PlayerSpeed;
            }
            else if (direction == "left")
            {
                PlayerX -= PlayerSpeed;
            }
            else if (direction == "right")
            {
                PlayerX += PlayerSpeed;
            }

            this.Invalidate();

            if (PlayerX > this.ClientSize.Width - 140)
            {
                PlayerX = 377;
                PlayerY = 304;
                Timer.Stop();
                try_again.Show();
                Main_menu.Show();
            }
            if (PlayerX < 117)
            {
                PlayerX = 377;
                PlayerY = 304;
                Timer.Stop();
                try_again.Show();
                Main_menu.Show();
            }
            if (PlayerY > this.ClientSize.Height - 50)
            {
                PlayerX = 377;
                PlayerY = 304;
                Timer.Stop();
                try_again.Show();
                Main_menu.Show();
            }
            if (PlayerY < 108)
            {
                PlayerX = 377;
                PlayerY = 304;
                Timer.Stop();
                try_again.Show();
                Main_menu.Show();
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, new Rectangle(PlayerX, PlayerY, 20, 20));
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Timer.Start();
            try_again.Hide();
            Main_menu.Hide();
        }
    }
}