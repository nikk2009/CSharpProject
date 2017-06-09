// Revised 11/9/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_ArrayExample_Completed
{
    public partial class Form1 : Form
    {
        /** declare fields which have class level scope and lifetime **/

        // declare index field

        private int index = 0;


        // declare size declarator for array

        private const int SIZE = 6;

        // field-level declaration of an array for storing strings

        private string[] nameArray = new string[SIZE]{"","","","","",""};
        
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
            try
            {
                // validate that name text box is not blank

                if (nameTextBox.Text != "")
                {
                    // assign Text property of name text box to element in the nameArray

                    nameArray[index] = nameTextBox.Text; 

                    // add element to the list box

                    
               
                    // increment the index field

                    index++;

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
            catch(IndexOutOfRangeException ex)
            {
                // display system message

                MessageBox.Show(ex.Message + " Please clear array to continue");

                // clear text box and set focus

                nameTextBox.Clear();
                nameTextBox.Focus();
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {        
            // display the elements in the array in the list box

            for (int i = 0; i < nameArray.Length; i++) 
            {
                nameListBox.Items.Add(nameArray[i]);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // reset the value of the elements in the array to 0

            for (int i = 0; i < nameArray.Length; i++) 
            {
                nameArray[i] = "";
            }
            index = 0;
            // clear list box

            nameListBox.Items.Clear();
            
        }        
    }
}
