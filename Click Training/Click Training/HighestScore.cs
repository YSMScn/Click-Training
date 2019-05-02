using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Click_Trainning
{
    public partial class HighestScore : Form
    {
        public HighestScore()
        {
            InitializeComponent();
            StreamReader sd = new StreamReader("score.txt");
            string[] score = new string[10];
            
            try
            {
                int n = 0;
                string CurrentScore;
                while((CurrentScore = sd.ReadLine()) != null)
                {
                    score[n] = CurrentScore;
                    n++;
                }
                //MessageBox.Show("GOOD");
            }
            catch(Exception e)
            {
                MessageBox.Show("Fill IO has a problem");
            }
            sd.Close();
            SetLabel(score);
        }

        private void SetLabel(string[] text)
        {
            Label[] DNTArray = { DT1, DT2, DT3, DT4, DT5, DT6, DT7, DT8, DT9, DT10 };
            Label[] ScoreArray = { Score1, Score2, Score3, Score4, Score5, Score6, Score7, Score8, Score9, Score10 };

            for (int i = 0; i < 10; i++)
            {
                string tempText = text[i];
                string[] tempLine = text[i].Split(' ');
                string DateAndTime = tempLine[0];
                string Score = tempLine[1];
                DNTArray[i].Text = DateAndTime;
                ScoreArray[i].Text = Score;
            }
        }
        private void HighestScore_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
