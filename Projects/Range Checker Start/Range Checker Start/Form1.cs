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

namespace Range_Checker_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable and initialize it with
                // the user's input.
               
                int number = int.Parse(inputTextBox.Text);

                // Check the number's range.

                if (number >= 1 && number <= 10) 
                {
                    MessageBox.Show("This value is the acceptable range");             
                }
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear the text box

            inputTextBox.Clear();

            // set the focus

            inputTextBox.Focus();
        }
    }
}
