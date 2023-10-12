using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MatchingGame.Form1;

namespace MatchingGame
{
    public partial class Form3 : Form
    {
        public string stats {  get; set; }

        public Form3()
        {
            InitializeComponent();
          
              
            }
        

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            time.Text = stats.ToString();
        }
    }
}
