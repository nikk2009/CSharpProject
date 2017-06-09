/*
 * 1. Create keyboard access keys
 * 2. Assign the AcceptButton property of the form
 * 3. Assign the CancelButton property of the form
 * 4. View and set the logical Tab order
 * 5. Set the Focus
 * 6. Implement a GroupBox control
 * 7. Implement Simple Exception Handling
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_Ch03Ex05_Start
{
    public partial class Form1 : Form
    {       
        /*** private field declarations ***/

        // declare a private field named totalGrossPay of decimal data type initialized to 0.0

        private decimal totalGrossPay = 0.0m;

        // declare a private field named totalFWT of decimal data type initialized to 0.0

        private decimal totalFWT = 0.0m;

        // declare a private field named totalFICA of decimal data type initialized to 0.0

        private decimal totalFICA = 0.0m;

        // declare a private field named totalNetPay of decimal data type initialized to 0.0

        private decimal totalNetPay = 0.0m;

        // declare a private field named totalEmployees of int data type initialized to 0

        private int totalEmployees = 0;
       
        /*** privated field constant declarations ***/

        // declare a private field constant named FEDERAL_WITHOLDINGS_TAX initialized to .20

        private const decimal FEDERAL_WITHOLDINGS_TAX = .20m;

        // declare a private field constant named FEDERAL_INSURANCE_TAX initialized to .10

        private const decimal FEDERAL_INSURANCE_TAX = .10m;
     
        public Form1()
        {
            InitializeComponent();
        }       

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close the application

            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear the TextBox and Label controls on the form

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            hoursWorkedTextBox.Clear();
            payRateTextBox.Clear();

            fullNameLabel.Text = "";
            grossPayLabel.Text = "";
            fwtLabel.Text = "";
            ficaLabel.Text = "";
            netPayLabel.Text = "";            

            // set the focus to the firstNameTextBox control            

            firstNameTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {  
            // implement try-catch statement for input validation displaying the Exceptions's default error message
            try
            {
                /*** declare local variables ***/

                // declare variables named firstName and lastName of string data type

                string firstName, lastName;

                // declare a variable named hoursWorked of int data type

                int hoursWorked;

                // declare variables named payRate, grossPay, fwt, fica, and netPay of decimal data type

                decimal payRate, grossPay, fwt, fica, netPay;

                /*** assign input values from the TextBox controls ***/

                // assign the value of the Text property of the firstNameTextBox to the firstName variable

                firstName = firstNameTextBox.Text;

                // assign the value of the Text property of the lastNameTextBox to the lastName variable

                lastName = lastNameTextBox.Text;

                // assign the value of the Text property of the hoursWorkedTextBox to the hoursWorked variable using the appropriate Parse method

                hoursWorked = int.Parse(hoursWorkedTextBox.Text);

                // assign the value of the Text property of the payRateTextBox to the payRate variable using the appropriate Parse method

                payRate = decimal.Parse(payRateTextBox.Text);

                // calculate the gross pay by multiplying the value of the hoursWorked variable by the payRate variable and assigning the result to the grossPay variable

                grossPay = hoursWorked * payRate;

                // calculate the federal witholding tax amount by multiplying gross pay by FEDERAL_WITHOLDING_TAX and assign the result to the fwt variable

                fwt = grossPay * FEDERAL_WITHOLDINGS_TAX;

                // calculate the federal insurance tax amount by multiplying gross pay by FEDERAL_INSURANCE_TAX and assign the result to the fica variable

                fica = grossPay * FEDERAL_INSURANCE_TAX;

                // calcualate the net pay by subtracting the sum of the tax from the gross pay

                netPay = grossPay - (fwt + fica);

                /*** accumulators and counters ***/

                // accumulate the total gross pay

                totalGrossPay += grossPay;

                // accumulate the total fwt

                totalFWT +=fwt;

                // accumulate the total fica

                totalFICA += fica;

                // count the total number of employees

                ++totalEmployees;

                // accumulate the total net pay

                totalNetPay = totalNetPay + netPay;

                // calculate average net pay

               decimal averageNetPay = totalNetPay / totalEmployees;

                // display output

                fullNameLabel.Text = lastName + ", " + firstName;
                grossPayLabel.Text = grossPay.ToString("c");
                fwtLabel.Text = fwt.ToString("c");
                ficaLabel.Text = fica.ToString("c");
                netPayLabel.Text = netPay.ToString("c");
                concatenatedLabel.Text = "The net pay for " + firstName + " " + lastName + " is: " + netPay.ToString("c");

                totalGrossPayLabel.Text = totalGrossPay.ToString("c");
                totalFWTLabel.Text = totalFICA.ToString("c");
                totalFICALabel.Text = totalFICA.ToString("c");
                totalNetPayLabel.Text = totalNetPay.ToString("c");
                totalEmployeesLabel.Text = totalEmployees.ToString("n0");
                averageNetPayLabel.Text = averageNetPay.ToString("c");  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
