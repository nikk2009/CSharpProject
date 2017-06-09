using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_Tutorial_0301_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            // Declare a string variable named output

            string output;


            // Concatenate the input from the text box controls and assign it to the output variable
            // Sample output: Wednesday, September 9, 2015

            output = dayOfWeekTextBox.Text + ", " + monthTextBox.Text + " " + dayOfMonthTextBox.Text + ", " + yearTextBox.Text;


            // Display the output variable in the dateOutputLabel control

            dateOutputLabel.Text = output;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the input text boxes

            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            dayOfMonthTextBox.Clear();
            yearTextBox.Clear();


            // Clear the dateOutputLabel control

            dateOutputLabel.Text = "";


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form

            this.Close();
        }
    }
}
