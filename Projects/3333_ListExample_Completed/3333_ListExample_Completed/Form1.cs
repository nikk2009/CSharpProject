using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_ListExample_Completed
{
    public partial class Form1 : Form
    {
        // field-level declaration of List object for storing strings

        List<string> namesList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // exit the program

            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // declare local variable

            string name;

            // validate that name text box is not blank

            if (nameTextBox.Text != "")
            {
                // assign Text property of name text box to local variable

                name = nameTextBox.Text;

                // add the name to the list

                namesList.Add(name);

                // add the name to the list box control

                nameListBox.Items.Add(name);

                // clear the name text box and set focus

                nameTextBox.Clear();
                nameTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a name.");
                nameTextBox.Focus();
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // declare local variable

            string message = "";

            // display the items in the list

            foreach (string name in namesList)
            {
                message += name + "\n";
            }

            MessageBox.Show(message);
        }

        private void countButton_Click(object sender, EventArgs e)
        {   // dispay the number of items in the list

            MessageBox.Show("The list has " + namesList.Count + " objects stored in it.");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear list

            namesList.Clear();

            // clear list box

            nameListBox.Items.Clear();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (nameListBox.SelectedIndex != -1)
            {
                // remove item from list

                namesList.RemoveAt(nameListBox.SelectedIndex);

                // remove item from list box

                nameListBox.Items.Remove(nameListBox.SelectedItem);
            }
            else 
            {
                MessageBox.Show("Select a name");
                nameListBox.Focus();
            }
        }
    }
}
