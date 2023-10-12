using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form2 : Form
    {
        public string stats { get; set; }

        public Form2()
        {
            InitializeComponent();
        }



        private void easyButton_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }
        private void mediumButton_Click(object sender, EventArgs e)
        {

        }

        private void hardButton_Click(object sender, EventArgs e)
        {

        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            this.Hide();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the game?", "Quit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
