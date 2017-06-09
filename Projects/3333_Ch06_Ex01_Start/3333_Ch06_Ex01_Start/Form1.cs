// Revised March 16, 2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_Ch06_Ex01_Start
{
    public partial class Form1 : Form
    { 
        // field constants declaration

        private const decimal FEDERAL_WITHOLDINGS_TAX = .20m;
        private const decimal FEDERAL_INSURANCE_TAX = .08m;
  
        public Form1()
        {
            InitializeComponent();
        }       

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close application
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear form and set focus

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            hoursWorkedTextBox.Text = "";
            payRateTextBox.Text = ""; 
            grossPayLabel.Text = "";
            fwtLabel.Text = "";
            ficaLabel.Text = "";
            netPayLabel.Text = "";            
            hoursWorkedTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // declare variables

            string firstName;
            string lastName;
            int hoursWorked;
            decimal payRate;
            decimal grossPay;
            decimal fwt;
            decimal fica;
            decimal netPay;  
            
            // assign value from text boxes

            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            hoursWorked = int.Parse(hoursWorkedTextBox.Text);
            payRate = decimal.Parse(payRateTextBox.Text);

            // method call for the displayMessage void method which does not pass any arguments

            displayMessage();

            // method call for the displayName void method which passes two arguments

            displayName(firstName, lastName);

            // method call for the value-returning calculateGrossPay method which passes two arguments

            grossPay = calculateGrossPay(hoursWorked, payRate);

            // method call for the value-returning calculateFWT method which passes one argument

            fwt = calculateFWT(grossPay);

            // method call for the value-returning calculateFICA method which passes one argument

            fica = calculateFICA(grossPay);

            // method call for the value-returning calculateNetPay method which passes three arguments

            netPay = calculateNetPay(grossPay, fwt, fica);
            
            // method call for formatting full name value-returning method which passes two arguments

            fullName.Text = formatName(firstName, lastName);
                
            // display output
 
            grossPayLabel.Text = grossPay.ToString("c");
            fwtLabel.Text = fwt.ToString("c");
            ficaLabel.Text = fica.ToString("c");
            netPayLabel.Text = netPay.ToString("c");        
        }

        // displayMessage is a void method

        private void displayMessage()
        {
            MessageBox.Show("Pay Calculator");
        }

        // displayName is a void method which receives two arguments

        private void displayName(string fName,string lName)
        {
            MessageBox.Show(fName + " " + lName);
        }

        // calculateGrossPay is a value-returning method which receives two arguments and returns a value

        private decimal calculateGrossPay(decimal pay, decimal rate) 
        {
            return pay * rate;
        }

        // calculateFWT is a value-returning method which receives one argument and returns a value

        private decimal calculateFWT(decimal gPay) 
        {
            return gPay * FEDERAL_WITHOLDINGS_TAX;           
        }

        // calculateFICA is a value-returning method which receives one argument and returns a value

        private decimal calculateFICA(decimal gpay) 
        {
            return gpay * FEDERAL_INSURANCE_TAX;
        }

        // calculateNetPay is a value-returning method receives three arguments and returns a value

        private decimal calculateNetPay(decimal gPay, decimal iTax, decimal fTax) 
        {
            return gPay - iTax - fTax;
        }

        private string formatName(string fName, string lName) 
        {
            return lName + ", " + fName; 
        }
    }
}
