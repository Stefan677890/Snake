namespace Snake
{
    public partial class Board : Form
    {
        int PlayerScore = 0;

        int playerX = 400;
        int playerY = 400;

        int PlayerSpeedX = 4;

        int AppleX;
        int AppleY;


        public Board()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Timer.Start();
            MessageBox.Show("Start");
        }

        private void Difficulty_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program jest zamykany...");
            Close();
        }
    }
}
