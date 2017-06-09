//Nikkolas Olliff
//000212872
//10/12/2015
//10/12/2015
//Calculate discount rate on software packages
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_OlliffN_Lab04
{
    public partial class Form1 : Form
    {
        private const decimal PACKAGE_COST = 99;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal totalPuchase;
            decimal discountTotal;
            decimal discount;
            decimal subtotal;
            int packages;
            if (int.TryParse(packageTextBox.Text, out packages))
            {
                if (packages > 0)
                {
                    if (packages >= 100)
                    {
                        discount = .5m;
                    }
                    else if (packages >= 50)
                    {
                        discount = .4m;
                    }
                    else if (packages >= 20)
                    {
                        discount = .3m;
                    }
                    else if (packages >= 10)
                    {
                        discount = .2m;
                    }
                    else
                    {
                        discount = 0;
                    }

                    
                    subtotal = PACKAGE_COST * packages;
                    discountTotal = subtotal * discount;
                    totalPuchase = subtotal - discountTotal;
                    discountLabel.Text = discount.ToString("p");
                    discountTotalLabel.Text = discountTotal.ToString("C");
                    subtotalLabel.Text = subtotal.ToString("C");
                    totalLabel.Text = totalPuchase.ToString("C");

                }
                else 
                {
                    MessageBox.Show("Please enter a larger number");
                }
            }
            else 
            {
                MessageBox.Show("Please enter a whole number");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            packageTextBox.Clear();
            totalLabel.Text = "";
            discountLabel.Text = "";

            packageTextBox.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
