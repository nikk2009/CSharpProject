/*
 * Nikkolas Olliff
 * 000212872
 * 09/21/2015
 * 09/21/2015
 * Calculating tax and tip
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_Ch03Ex01_Start
{
    public partial class Form1 : Form
    {



        private decimal overallTotal = 0;

        private int totalOrders = 0;
 

        

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

            chargeTextBox.Clear();
            salesTaxLabel.Text = "";
            subtotalLabel.Text = "";
            tipLabel.Text = "";
            totalLabel.Text = "";


            chargeTextBox.Focus();
            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // implement simple exception handling with try-catch statement

            try
            {
                // declare named constants

                const decimal TAX = .0825m;
                const decimal TIP_PERCENTAGE = .2m;


                // declare variables (there should be a variable for each input and output control on the form)

                decimal foodCharge, salesTax,subTotal,tip,total,average;


                // conversion of Text property of chargeTextBox value using appropriate Parse method

               foodCharge = decimal.Parse(chargeTextBox.Text);
           

                // calculations for sales tax, subtotal, tip, and total

               salesTax = foodCharge * TAX;
               subTotal = salesTax + foodCharge;
               tip = subTotal * TIP_PERCENTAGE;
               total = foodCharge + salesTax + tip;

                // accumulate total charges

               overallTotal += total;

                // count overall orders

               totalOrders++;

                // calculate average order

               average = overallTotal / totalOrders;

                // display output for sales tax, subtotal, tip, total, overall total, overall orders, and average order

                salesTaxLabel.Text = salesTax.ToString("c");
                subtotalLabel.Text = subTotal.ToString("c");
                tipLabel.Text = tip.ToString("c");
                totalLabel.Text = total.ToString("c");

                overallTotalLabel.Text = overallTotal.ToString("c");
                overallOrdersLabel.Text = totalOrders.ToString();
                averageOrderLabel.Text = average.ToString("c");
            }
            catch(Exception ex)
            
            {
                // display Default Message of the Exception class in a MessageBox

                MessageBox.Show(ex.Message);

                // set focus to chargeTextBox control and clear it
                chargeTextBox.Focus();
                chargeTextBox.Clear();
                
            }
        }        
    }
}
