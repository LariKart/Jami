using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MatchingGame.;
namespace MatchingGame
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Menu newForm = new Menu();
            newForm.Show();
            this.Hide();

        }

        public void label1_Click(object sender, EventArgs e)
        {
            int time;
        }
    }
}
