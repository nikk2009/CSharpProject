using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_OlliffN_Lab07
{
    public partial class Form1 : Form
    {



        List<int> scoreList = new List<int>();

        private int totalScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            decimal scoreAverage;
            int score;




            if (int.TryParse(scoresTextBox.Text, out score))
            {
                if (score >= 0 && score <= 100)
                {
                    scoreList.Add(score);

                    totalScore += score;

                    scoreAverage = totalScore / scoreList.Count;

                    totalScoreLabel.Text = totalScore.ToString();
                    scoreCountLabel.Text = scoreList.Count.ToString();
                    scoreAverageLabel.Text = scoreAverage.ToString();

                    scoresTextBox.Clear();
                    scoresTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Enter a score between 0 and 100.");
                    scoresTextBox.Focus();
                    scoresTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Invalid score.");
                scoresTextBox.Focus();
                scoresTextBox.Clear();
            }


        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string message = "";

            foreach (int score in scoreList)
            {
                message += score.ToString() + "\n";
            }
            MessageBox.Show(message, "Scores");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            scoreList.Clear();

            scoresTextBox.Clear();

            totalScoreLabel.Text = "";
            scoreCountLabel.Text = "";
            scoreAverageLabel.Text = "";

            totalScore = 0;

            scoresTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
