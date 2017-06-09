//Nikkolas Olliff
//000212872  
//10/12/2015
//10/19/2015
//Calcualtes distance traveled
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_OlliffN_Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            decimal mph, hours, distance;
            int count = 1;
            if (decimal.TryParse(mphTextBox.Text, out mph))
            {
                if (decimal.TryParse(hoursTextBox.Text, out hours))
                {
                    if (mph >= 1 && mph <= 180)
                    {
                        if (hours >= 1 && hours <= 50)
                        {
                            outputListBox.Items.Clear();
                            while(count<=hours)
                            {
                                distance = mph * count;
                                outputListBox.Items.Add("After hour " + count + " the distance is " + distance);
                                count++;
                            }
                        }
                        else 
                        {
                            MessageBox.Show("Enter a number between 1 and 50");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Enter a number between 1 and 180");
                    }
                }
                else 
                {
                    MessageBox.Show("Invalid input");
                }
            }
            else 
            {
                MessageBox.Show("Invalid input");
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
