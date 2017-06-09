using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_Loops_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void whileButton_Click(object sender, EventArgs e)
        {
            // declare a variable to count the loop iterations
            
            int count = 1;
            // create a while loop to display "while" in a message box/list box five times
            
            while (count <= 5) 
            {
                MessageBox.Show("while " + count);

                outputListBox.Items.Add("while "+count);
                count++;
            }

        }

        private void doWhileButton_Click(object sender, EventArgs e)
        {
            // declare a variable to count the loop iterations
            int count = 1;

            // create a do-while loop to display "do while" in a message box/list box five times
            do
            {
                MessageBox.Show("do while");
                outputListBox.Items.Add("do while " + count);
                count++;
            } while (count < 6);

        }

        private void forButton_Click(object sender, EventArgs e)
        {      
            // create a for loop to display "for" in a message box/list box five times
            for (int count = 1; count < 6; count++) 
            {

                MessageBox.Show("for " + count);
                outputListBox.Items.Add("for " + count);

            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();

        }
    }
}
