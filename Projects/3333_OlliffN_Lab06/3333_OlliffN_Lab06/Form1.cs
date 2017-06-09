//Nikkolas Olliff
//000212872
//11/02/2015
//11/02/2015
//Calculate Hospital Fees
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_OlliffN_Lab06
{
    public partial class Form1 : Form
    {
        private int BASE_CHARGE = 350;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            daysSpentTextBox.Clear();
            medicationChargeTextBox.Clear();
            surgicalChargesTextBox.Clear();
            labFeesTextBox.Clear();
            physRehabTextBox.Clear();

            stayChargesLabel.Text = "";
            miscChargesLabel.Text = "";
            totalLabel.Text = "";

            daysSpentTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int daysSpent;
            decimal medicationCharges, surgicalCharges, labFee, physRehab, stayCharge, miscCharge, totalCharge;

            if (int.TryParse(daysSpentTextBox.Text, out daysSpent))
            {
                if (daysSpent >= 0)
                {
                    if (decimal.TryParse(medicationChargeTextBox.Text, out medicationCharges))
                    {
                        if (medicationCharges >= 0)
                        {
                            if (decimal.TryParse(surgicalChargesTextBox.Text, out surgicalCharges))
                            {
                                if (surgicalCharges >= 0)
                                {
                                    if (decimal.TryParse(labFeesTextBox.Text, out labFee))
                                    {
                                        if (labFee >= 0)
                                        {
                                            if (decimal.TryParse(physRehabTextBox.Text, out physRehab))
                                            {
                                                if (physRehab >= 0)
                                                {
                                                    stayCharge = CalcStayCharges(daysSpent);
                                                    miscCharge = CalcMiscCharges(medicationCharges, surgicalCharges, labFee, physRehab);
                                                    totalCharge = CalcTotalCharges(stayCharge, miscCharge);

                                                    stayChargesLabel.Text = stayCharge.ToString("C");
                                                    miscChargesLabel.Text = miscCharge.ToString("C");
                                                    totalLabel.Text=totalCharge.ToString("C");
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Enter a number greater than 0");
                                                    physRehabTextBox.Clear();
                                                    physRehabTextBox.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Invalid Input");
                                                physRehabTextBox.Clear();
                                                physRehabTextBox.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter a number greater than 0");
                                            labFeesTextBox.Clear();
                                            labFeesTextBox.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid Input");
                                        labFeesTextBox.Clear();
                                        labFeesTextBox.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter a number greater than 0");
                                    surgicalChargesTextBox.Clear();
                                    surgicalChargesTextBox.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Input");
                                surgicalChargesTextBox.Clear();
                                surgicalChargesTextBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter a number greater than 0");
                            medicationChargeTextBox.Clear();
                            medicationChargeTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input");
                        medicationChargeTextBox.Clear();
                        medicationChargeTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Enter a number greater than 0");
                    daysSpentTextBox.Clear();
                    daysSpentTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
                daysSpentTextBox.Clear();
                daysSpentTextBox.Focus();
            }
        }
        private decimal CalcStayCharges(decimal days)
        {
            return days * BASE_CHARGE;
        }
        private decimal CalcMiscCharges(decimal med,decimal surg, decimal labFee,decimal rehab)
        {
            return med + surg + labFee + rehab;
        }
        private decimal CalcTotalCharges(decimal stay, decimal misc) 
        {
            return misc + stay;
        }
    }
}
