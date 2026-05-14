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
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void Difficulty_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program is being close...");
            Close();
        }

        private void Tick(object sender, EventArgs e)
        {

        }
    }
}
