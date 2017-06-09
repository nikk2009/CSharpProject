//Nikkolas Olliff
//000212872
//09/30/2015
//09/30/2015
//Sales tax calculator
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_OlliffN_Exam01
{
    public partial class Form1 : Form
    {
        private decimal overallSale = 0.0m;

        public Form1()
        {
           

            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal STATE_SALES_TAX = .08m;
            const decimal COUNTY_SALES_TAX = .04m;

            decimal purchaseAmmount, stateTax, countyTax, totalTax, totalSale;

            try
            {

                purchaseAmmount = decimal.Parse(purchaseTextBox.Text);

                stateTax = purchaseAmmount * STATE_SALES_TAX;
                countyTax = purchaseAmmount * COUNTY_SALES_TAX;
                totalTax = stateTax + countyTax;
                totalSale = purchaseAmmount + totalTax;
                overallSale += totalSale;

                purchaseAmmountLabel.Text = purchaseAmmount.ToString("C");
                salesTaxLabel.Text = stateTax.ToString("C");
                countyTaxLabel.Text = countyTax.ToString("C");
                totalTaxLabel.Text = totalTax.ToString("C");
                totalSaleLabel.Text = totalSale.ToString("C");
                overallSalesLabel.Text = overallSale.ToString("C");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            purchaseTextBox.Clear();

            purchaseAmmountLabel.Text = "";
            salesTaxLabel.Text = "";
            countyTaxLabel.Text = "";
            totalSaleLabel.Text = "";
            totalTaxLabel.Text = "";
            overallSalesLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
