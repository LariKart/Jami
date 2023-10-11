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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }



        private void easyButton_Click(object sender, EventArgs e)
        {
            easyStage newForm = new easyStage();
            newForm.Show();
            this.Hide();
        }
        private void mediumButton_Click(object sender, EventArgs e)
        {
            MediumStage newForm = new MediumStage();
            newForm.Show();
            this.Hide();
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            HardMode newForm = new HardMode();
            newForm.Show();
            this.Hide();
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {

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