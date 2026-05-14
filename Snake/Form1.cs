namespace Snake
{
    public partial class Board : Form
    {
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
    }
}
