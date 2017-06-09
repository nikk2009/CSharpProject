using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Variable_Demo_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            // Declare a string variable to hold the full name.

            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            // Combine the names, with a space between them. Assign the
            // result to the fullName variable.

            string fullName = firstName + " " + lastName;

            // Display the fullName variable in the fullNameLabel control.

            fullNameLabel.Text = fullName;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the firstNameTextBox and lastNameTextBox controls

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();

            // Clear the fullNameLabel control

            fullNameLabel.Text = "";

        }
    }
}
