/*
 * Nikkolas Olliff
 * 000212872
 * 9/16/2015
 * 9/21/2015
 * Calculating ticket sales totals
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_OlliffN_Lab03
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void calculateRevButton_Click(object sender, EventArgs e)
        {
            try
            {
                const int A_CLASS_PRICE = 15;
                const int B_CLASS_PRICE = 12;
                const int C_CLASS_PRICE = 9;

                int aClassInt = A_CLASS_PRICE * int.Parse(aClassTextBox.Text);
                int bClassInt = B_CLASS_PRICE * int.Parse(bClassTextBox.Text);
                int cClassInt = C_CLASS_PRICE * int.Parse(cClassTextBox.Text);
                int totalClass = aClassInt + bClassInt + cClassInt;

                aClassLabel.Text = aClassInt.ToString("C");
                bClassLabel.Text = bClassInt.ToString("C");
                cClassLabel.Text = cClassInt.ToString("C");
                totalLabel.Text = totalClass.ToString("C");
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }

            aClassTextBox.Focus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            aClassTextBox.Clear();
            bClassTextBox.Clear();
            cClassTextBox.Clear();
            
            aClassLabel.Text = "";
            bClassLabel.Text = "";
            cClassLabel.Text = "";
            totalLabel.Text = "";

            aClassTextBox.Focus();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }

}

