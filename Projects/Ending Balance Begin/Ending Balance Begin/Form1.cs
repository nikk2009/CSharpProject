// Revised 10/12/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ending_Balance_Begin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // constant for the monthly interest rate

            const decimal INTEREST_RATE = 0.005m;

            // local variables

            decimal balance;    // the account balance
            int months;         // the number of months
            int count = 1;      // loop counter, initialized with 1

            // get the starting balance

            if(decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                // get the number of months

                if(int.TryParse(monthsTextBox.Text, out months))
                {
                    // clear the list box

                    /*** INSERT CODE HERE AFTER LIST BOX IS ADDED ***/

                    // the following loop calculates the ending balance

                    /*** INSERT CODE HERE ***/

                    // display the ending balance

                    endingBalanceLabel.Text = balance.ToString("c");
                }
                else
                {
                    // invalid number of months entered

                    MessageBox.Show("Invalid value for months");
                    monthsTextBox.Clear();
                    monthsTextBox.Focus();
                }
            }
            else
            {
                // invalid number of months entered

                MessageBox.Show("Invalid value for starting balance");
                startingBalTextBox.Clear();
                startingBalTextBox.Focus();
            }            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear text boxes and label

            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";

            // clear the list box

            /*** INSERT CODE HERE ***/

            // reset focus

            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
