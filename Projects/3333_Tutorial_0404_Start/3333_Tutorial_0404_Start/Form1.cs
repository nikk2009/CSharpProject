// Revised 9/18/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_Tutorial_0404_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // declare local variables

            double miles;
            double gallons;
            double mpg;

            // validate the milesTextBox and gallonsTextBox controls               


            if (double.TryParse(milesTextBox.Text, out miles))
            {
                if (double.TryParse(gallonsTextBox.Text, out gallons))
                {
                    mpg = miles / gallons;

                    mpgLabel.Text = mpg.ToString("n1");
                }
                else
                {
                    MessageBox.Show("Invalid input for gallons");
                }
            }
            else 
            {
                MessageBox.Show("Invalid input for miles");
            }



        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear the form controls

            milesTextBox.Clear();
            gallonsTextBox.Clear();
            mpgLabel.Text = "";
            
            // set the focus to the first input control

            milesTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close the form

            this.Close();
        }
    }
}
