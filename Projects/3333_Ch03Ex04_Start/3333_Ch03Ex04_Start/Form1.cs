// Implement the following standard Windows application features:

// 1. Keyboard access keys on each button
// 2. AcceptButton property of the form set to calculateButton
// 3. CancelButton property of the form set to the clearButton
// 4. Ensure logical Tab order
// 5. Implement Focus method
// 6. Place output labels in a GroupBox control

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_Ch03Ex04_Start
{
    public partial class Form1 : Form
    {   

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
            concatenatedLabel.Text = "";

            // set the focus to the firstNameTextBox control
            
            firstNameTextBox.Focus();
           
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {            
            
            // declare a constant named FEDERAL_WITHOLDINGS_TAX of decimal data type initialized to .20

            const decimal FEDERAL_WITHOLDINGS_TAX = .20M;

            // declare constant named FEDERAL_INSURANCE_TAX of decimal data type initialized to .10

            const decimal FEDERAL_INSURANCE_TAX = .10M;

            /*** declare local variables ***/

            // declare variables named firstName and lastName of string data type

            string firstName;
            string lastName;
        
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

            grossPay = payRate * hoursWorked;

            // calculate the federal witholdings tax by multiplying the value of gross pay by the FEDERAL_WITHOLDING_TAX constant and assign the result to the fwt variable

            fwt = grossPay * FEDERAL_WITHOLDINGS_TAX;

            // calculate the federal insurance tax by multiplying the value of gross pay by the FEDERAL_INSURANCE_TAX constant and assign the result to the fica variable

            fica = grossPay * FEDERAL_INSURANCE_TAX;

            // calculate the net pay by subtracting the sum of the federal witholding tax and the federal insurance tax from the gross pay and assign the result to the netPay variable                              

            netPay = grossPay - fwt - fica;                
                
            /*** format and display output ***/

            // concatenate the lastName and firstName value in the following format and assign to the Text property of the fullNameLabel: Sharp, Jason (use the variables entered by user)

            fullNameLabel.Text = firstName + " " + lastName;

            // display the gross pay in currency format in the grossPayLabel Text property

            grossPayLabel.Text = grossPay.ToString("C");

            // display the federal witholdings tax amount in currency format in the fwtLabel Text property

            fwtLabel.Text = fwt.ToString("C");

            // display the federal insurance tax amount in currency format in the ficaLabel Text property

            ficaLabel.Text = fica.ToString("C");

            // display the net pay in currency format in the netPayLabel Text property

            netPayLabel.Text = netPay.ToString("C");

            // display the following concatenated string in the concatenatedLabel Text property: The net pay for Jason Sharp is: $1000.00 (use the variables entered by the user)

            concatenatedLabel.Text = "The net pay for " + fullNameLabel.Text + " is: " + netPayLabel.Text;
            
        }
    }
}
