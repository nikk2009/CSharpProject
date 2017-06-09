// Revised 9/23/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Two_Numbers_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Local variables
            int first, second, sum;

            // validate TextBox values using TryParse method
            if(int.TryParse(firstTextBox.Text,out first))
            {
                if(int.TryParse(secondTextBox.Text,out second))
                {
                    sum = first + second;
                    MessageBox.Show("The total is " + sum);
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear the form

            firstTextBox.Clear();
            secondTextBox.Clear();

            // set the focus

            firstTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close the program

            this.Close();
        }

       
    }
}
