using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Trainning
{
    public partial class GamingForm : Form
    {
        int score = 0;
        public GamingForm()
        {
            InitializeComponent();
        }

        private void GamingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RedPoint_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int newPositionX = random.Next(this.ClientRectangle.Width - 25);
            int newPositionY = 200+random.Next(this.ClientRectangle.Height-225);
            this.RedPoint.Location = new Point(newPositionX,newPositionY);
            score += 1;
            clickScore.Text = score.ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string tempNum = this.RemainingTime.Text;
            this.RemainingTime.Text = (int.Parse(tempNum) - 1).ToString();
            if(this.RemainingTime.Text == 0.ToString())
            {
                timer1.Stop();
                ChangeRanking(score);
                MessageBox.Show("Your Score Is： " + score.ToString());
                this.Hide();
                var HighestScore = new HighestScore();
                HighestScore.Show();
            }
        }

        private void ChangeRanking(int NewScore)
        {
            StreamReader sd = new StreamReader("score.txt");
            string[] scoreFromTxt = new string[10];
            try
            {
                int n = 0;
                string CurrentScore;
                while ((CurrentScore = sd.ReadLine()) != null)
                {
                    scoreFromTxt[n] = CurrentScore;
                    n++;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Fill IO has a problem");
            }
            for (int i = 0; i < 10; i++)
            {
                string tempText = scoreFromTxt[i];
                string[] tempLine = scoreFromTxt[i].Split(' ');
                string DateAndTime = tempLine[0];
                string Score = tempLine[1];
                if(NewScore >= int.Parse(Score))
                {
                    for (int a = 0; a < 9 - i; a++)
                    {
                        scoreFromTxt[i + a + 1] = scoreFromTxt[i + a];
                    }
                    scoreFromTxt[i] = DateTime.Now.ToString("MM/dd/yyyy").Replace(" ", string.Empty) + " " + NewScore.ToString();
                    break;
                }
            }
            sd.Close();
            StreamWriter sw = new StreamWriter("score.txt");
            foreach(string s in scoreFromTxt)
            {
                sw.WriteLine(s);
            }
            sw.Close();
        }
    }
}
