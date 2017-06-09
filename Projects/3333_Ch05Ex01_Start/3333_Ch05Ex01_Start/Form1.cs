// revised 3/4/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_Ch05Ex01_Start
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

            decimal monthlyInvestment;
            decimal yearlyInterestRate;
            int years;
            int months;
            decimal futureValue = 0.0m;
            int count=1;
            decimal monthlyInterestRate;

            
            if(decimal.TryParse(investmentTextBox.Text, out monthlyInvestment)) // validate that monthly investment is numeric
            {
                if (monthlyInvestment > 0) // validate that monthly invesment is greater than zero
                {
                    if (decimal.TryParse(rateTextBox.Text,out yearlyInterestRate)) // validate that yearly interest rate is numeric
                    {
                        if (yearlyInterestRate >0) // validate that yearly interest rate is greater than zero
                        {
                            if (int.TryParse(yearsTextBox.Text, out years)) // validate that years is numeric
                            {
                                if (years > 0) // validate that years is greater than zero
                                {
                                    // convert years to months

                                    months = years * 12;

                                    // convert yearly interest rate to monthly interest rate

                                    monthlyInterestRate = yearlyInterestRate / 12 / 100;

                                    // clear list box

                                    outputListBox.Items.Clear();

                                    // loop to calculate future value and display result by month
                                    while(count<=months)
                                    {
                                        futureValue = (futureValue + monthlyInvestment) * ( 1 + monthlyInterestRate);
                                        outputListBox.Items.Add("Month" + count + " future value is" + futureValue.ToString("C"));
                                        count++;
                                    }
                                   
                                }
                                else
                                {
                                    MessageBox.Show("Years must be greater than zero.");
                                    yearsTextBox.Clear();
                                    yearsTextBox.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Years must be a whole number.");
                                yearsTextBox.Clear();
                                yearsTextBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Yearly Interest Rate must be greater than zero.");
                            rateTextBox.Clear();
                            rateTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yearly Interest Rate must be a floating-point number.");
                        rateTextBox.Clear();
                        rateTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Monthly Investment must be greater than zero.");
                    investmentTextBox.Clear();
                    investmentTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Monthly Investment must be a number.");
                investmentTextBox.Clear();
                investmentTextBox.Focus();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear text boxes

            investmentTextBox.Clear();
            rateTextBox.Clear();
            yearsTextBox.Clear();

            // clear list box

            outputListBox.Items.Clear();

            // set focus

            investmentTextBox.Focus();
        }       
    }
}
