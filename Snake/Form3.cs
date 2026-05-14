using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            Form2.difficulty = 1;
            Form2 gameForm = new Form2();
            gameForm.Show();
            this.Hide();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            Form2.difficulty = 2;
            Form2 gameForm = new Form2();
            gameForm.Show();
            this.Hide();
        }

        private void Extreme_Click(object sender, EventArgs e)
        {
            Form2.difficulty = 3;
            Form2 gameForm = new Form2();
            gameForm.Show();
            this.Hide();
        }

        private void Secret_Click(object sender, EventArgs e)
        {
            Form2.difficulty = 4;
            Form2 gameForm = new Form2();
            gameForm.Show();
            this.Hide();
        }
    }
}
