/*
 *Nikkolas Olliff
 *000212872
 *09/09/2015
 *09/09/2015
 *Reads full name and title and outputs it
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program3_1_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formatOneButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string title = titleTextBox.Text;

            outputLabel.Text = title + " " + firstName + " " + middleName + " " + lastName;
        }

        private void formatTwoButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string title = titleTextBox.Text;

            outputLabel.Text =  firstName + " " + middleName + " " + lastName;
        }

        private void formatThreeButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string title = titleTextBox.Text;

            outputLabel.Text = firstName + " " + lastName;
        }

        private void formatFourButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string title = titleTextBox.Text;

            outputLabel.Text = lastName + ", " + firstName + " " + middleName + ", " + title;
        }

        private void formatFiveButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string title = titleTextBox.Text;

            outputLabel.Text = lastName + ", " + firstName + " " + middleName;
        }

        private void formatSixButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string title = titleTextBox.Text;

            outputLabel.Text = lastName + ", " + firstName;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            middleNameTextBox.Clear();
            titleTextBox.Clear();

            outputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
