/*
 * Nikkolas Olliff
 * 000212872
 * 09/23/2015
 * 09/23/2015
 * Averageing test scores
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_Tutorial_0401_Start  
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Clear();
            test2TextBox.Clear();
            test3TextBox.Clear();
            averageLabel.Text = "";

            test1TextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // declare named constant
                const double HIGH_SCORE = 95.0;

                // declare local variables
                double test1, test2, test3, average;

                // get the test scores from the text boxes

                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // calculate the average test score

                average = (test1 + test2 + test3) / 3.0;

                // display the average, rounded to 1 decimal places

                averageLabel.Text = average.ToString("n1");

                // if the average is a high score congratulate the user

               if(average>=HIGH_SCORE)
                   MessageBox.Show("Congratulations! Great Job!");
                // ** ENTER CODE HERE **
            }
            catch(Exception ex)
            {
                // display the default error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
