// Revised 9/18/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_Tutorial_0402_Start
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
            hoursWorkedTextBox.Clear();
            hourlyPayRateTextBox.Clear();
            grossPayLabel.Text = "";

            hoursWorkedTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // declare named constants
                const decimal BASE_HOURS = 40M;
                const decimal OT_MULTIPLIER = 1.5M;

                // declare local variables

                decimal hoursWorked;
                decimal hourlyPayRate;
                decimal basePay;
                decimal overtimeHours;
                decimal overtimePay;
                decimal grossPay;

                // get the hours worked and hourly pay rate

                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                // determine the gross pay
                if (hoursWorked > BASE_HOURS)
                {
                    basePay = hourlyPayRate * BASE_HOURS;

                    overtimeHours = hoursWorked - BASE_HOURS;

                    overtimePay = overtimeHours * hourlyPayRate * OT_MULTIPLIER;

                    grossPay = basePay + overtimePay;


                }
                else 
                {
                    grossPay = hoursWorked * hourlyPayRate;         
                }

                grossPayLabel.Text = grossPay.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
