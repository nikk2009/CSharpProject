//Nikkolas Olliff
//000212872
//11/01/2015
//11/04/2015
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Windows.Forms;

namespace _3333_Ch07_Ex01_Array_Start_Validation
{
    public partial class Form1 : Form
    {
        /** declare fields which have class level scope and lifetime **/

        // field to be used for index

        private int indexField = 0;
        
        // declare an array of type decimal and size 3

        private decimal[] sales = new decimal[3];
        
        // declare field for accumulator

        private decimal totalSales = 0.0m;
                    

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            // declare local variables

            decimal salesAverage;


            // try-catch statement to handle index out of range exception
            try
            {
            //sales[indexField] = Convert.ToDecimal(salesTextBox.Text);
                if (decimal.TryParse(salesTextBox.Text,out sales[indexField]) )
                {
                    if (sales[indexField]>0)
                    {


                        totalSales += sales[indexField];

                        

                        indexField++;

                       

                        salesAverage = totalSales/indexField;

                        

                       totalSalesLabel.Text=totalSales.ToString("C");
                       salesCountLabel.Text=indexField.ToString();
                        salesAverageLabel.Text=salesAverage.ToString("C");

                        

                        salesTextBox.Clear();

                      
                        salesTextBox.Focus();
                        
                    }
                    else
                    {
                        MessageBox.Show("Sales must be greater than zero.");
                        salesTextBox.Focus();
                        salesTextBox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid sales.");
                    salesTextBox.Focus();
                    salesTextBox.Clear();
                }
            }
            catch (IndexOutOfRangeException ex )
            {
                MessageBox.Show(ex.Message + " Please clear array to continue.");
                salesTextBox.Focus();
                salesTextBox.Clear();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // declare local string variable

            string saleString = "";       

            // utilizing for loop based upon Length property of sales array

            Array.Sort(sales);
            for (int i = 0; i < sales.Length; i++)
            {
                saleString += "Sales " + (i + 1) + ": " + sales[i] + "\n";
            }
            // display in message box
            MessageBox.Show(saleString);
                 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // assign zero to each element in the array

            for (int i = 0; i < sales.Length; i++)
            {
                sales[i] = 0.0m;
            }

            
            // clear text boxes
            salesTextBox.Clear();
            totalSalesLabel.Text = "";
            salesCountLabel.Text = "";
            salesAverageLabel.Text = "";
            

            // set focus to sales text box

            salesTextBox.Focus();
 
            // reset total sales

            totalSales = 0.0m;

            // reset index

            indexField = 0;

        }            
    }
}
