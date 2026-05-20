using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form2 : Form
    {
        public static int difficulty = 1;
        int PlayerScore = 0;

        int PlayerX = 400;
        int PlayerY = 400;

        int PlayerSpeed = 0;

        int AppleX;
        int AppleY;

        string direction = "right";

        public Form2()
        {
            InitializeComponent();

            if (difficulty == 0)
            {
                PlayerSpeed = 10;
            }
            else if (difficulty == 1)
            {
                PlayerSpeed = 12;
            }
            else if (difficulty == 2)
            {
                PlayerSpeed = 14;
            }
            else if (difficulty == 3)
            {
                PlayerSpeed = 18;
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
        }
    }
}