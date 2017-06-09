using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fuel_Economy_with_ErrorProvider_Start
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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // declare local variables

            double miles;
            double gallons;
            double mpg;

            // clear any existing errors

            errorProvider1.SetError(milesTextBox, "");
            errorProvider1.SetError(gallonsTextBox, "");

            // validate miles text box
            if (double.TryParse(milesTextBox.Text, out miles))
            {
                // range for miles
                if (miles > 0)
                {
                    // validate gallons text box
                    if (double.TryParse(gallonsTextBox.Text, out gallons))
                    {
                        // calculate mpg
                        mpg = miles / gallons;

                        // display mpg
                        mpgLabel.Text = mpg.ToString("n1");
                    }
                    else
                    {
                        // invalid gallons

                        errorProvider1.SetError(gallonsTextBox, "Gallons must be numeric");
                        gallonsTextBox.Clear();
                        gallonsTextBox.Focus();

                        // select the invalid input
                        

                    }
                }
                else
                {
                    // invalid miles

                    errorProvider1.SetError(milesTextBox, "Miles must be greater than 0");
                  
                    // select the invalid input

                    milesTextBox.Focus();
                    milesTextBox.SelectionStart = 0;
                    milesTextBox.SelectionLength = milesTextBox.Text.Length;

                }
            }
            else
            {
                // invalid miles
                errorProvider1.SetError(milesTextBox, "Miles must be numeric");

                // select the invalid input

                milesTextBox.Focus();
                milesTextBox.SelectAll();

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear controls

            milesTextBox.Clear();
            gallonsTextBox.Clear();
            mpgLabel.Text = "";

            // clear any existing errors


            // set focus to first input text box


        }
    }
}
