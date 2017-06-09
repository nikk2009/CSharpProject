// Revised 4/1/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_Ch07_Ex02_List_Start_Validation
{
    public partial class Form1 : Form
    {
        // declare a list of decimal

        

        // declare field for accumulator

        private decimal totalSales = 0.0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // declare local variables

            decimal sale;
            decimal salesAverage = 0;
            int count = 0;

            // convert Text property sales text box
                        
            if (decimal.TryParse(salesTextBox.Text, out sale))
            {
                if (sale > 0)
                {
                    // add to the sales list

                    

                    // accumulation of sales amount

                   

                    // determine the number of items in the list using Count property

                    

                    // calculate the average

                   

                    // display output

                    totalSalesLabel.Text = totalSales.ToString("c");
                    salesCountLabel.Text = count.ToString();
                    salesAverageLabel.Text = salesAverage.ToString("c");

                    // clear text box

                    salesTextBox.Clear();

                    // place focus back to text box

                    salesTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Sales must be greater than or equal to zero.");
                    salesTextBox.Focus();
                    salesTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Sales invalid.");
                salesTextBox.Focus();
                salesTextBox.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear items from sales list

                    
            
            // clear text boxes

            salesTextBox.Clear();
            totalSalesLabel.Text = "";
            salesCountLabel.Text = "";
            salesAverageLabel.Text = "";

            // reset accumulator to zero

           

            // set focus to text box

            salesTextBox.Focus();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // declare local string variable

            string salesString = "";

            // sort the sales list using the Sort method of the List class

            
           
            // utilize foreach loop

            

            // display string in message box

           

            // set focus to text box

            salesTextBox.Focus();
        }
    }
}
