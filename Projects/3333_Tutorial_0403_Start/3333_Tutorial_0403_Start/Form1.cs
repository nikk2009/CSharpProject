// Revised 9/18/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_Tutorial_0403_Start
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
            salaryTextBox.Clear();
            yearsTextBox.Clear();
            decisionLabel.Text = "";

            salaryTextBox.Focus();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                // declare named constants
                const decimal MINIMUM_SALARY = 40000m;
                const int MINIMUM_YEARS_ON_JOB = 2;

                // declare local variables
                decimal salary;
                int yearsOnJob;

                // get the salary and years on the job

                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                // determine whether the user qualifies
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        decisionLabel.Text = "You qualify for the loan.";
                    }
                    else 
                    {
                        decisionLabel.Text = "Minimum years at current job not met";
                    }
                }
                else
                {
                    decisionLabel.Text="Minimum salary requirement not met.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
