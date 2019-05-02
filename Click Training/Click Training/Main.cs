using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Trainning

{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void HighestScoreButton_Click(object sender, EventArgs e)
        {
            var HighestScore = new HighestScore();
            HighestScore.Location = this.Location;
            HighestScore.StartPosition = this.StartPosition;
            HighestScore.Size = this.Size;
            HighestScore.BackColor = this.BackColor;
            HighestScore.Show();
            this.Hide();


        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var GamingForm = new GamingForm();
            GamingForm.Location = this.Location;
            GamingForm.StartPosition = this.StartPosition;
            GamingForm.Size = this.Size;
            GamingForm.Show();
            this.Hide();

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
