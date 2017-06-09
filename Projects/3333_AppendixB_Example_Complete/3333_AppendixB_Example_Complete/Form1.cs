using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_AppendixB_Example_Complete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // exit application

            this.Close();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            if(snackComboBox.SelectedIndex != -1)
            {
                snackLabel.Text = snackComboBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Select a snack.");
                snackComboBox.Focus();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // declare flag

            bool noDuplicate = true;

            if(snackComboBox.Text != "")
            {
                foreach(string snack in snackComboBox.Items)
                {
                    if(snack.ToUpper() == snackComboBox.Text.ToUpper())
                    {
                        noDuplicate = false;
                    }
                }

                if(noDuplicate)
                {
                    snackComboBox.Items.Add(snackComboBox.Text);
                    snackComboBox.Text = "";
                    snackComboBox.Focus();
                }
                else
                {
                    MessageBox.Show("Snack already exists: " + snackComboBox.Text);
                    snackComboBox.Text = "";
                    snackComboBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Enter a snack.");
                snackComboBox.Focus();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(snackComboBox.SelectedIndex != -1)
            {
                // declare an object of the DialogResult class

                DialogResult responseDialogResult;

                responseDialogResult = MessageBox.Show("Delete selected item?",
                    "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (responseDialogResult == DialogResult.Yes)
                {
                    // snackComboBox.Items.Remove(snackComboBox.SelectedItem);
                    snackComboBox.Items.RemoveAt(snackComboBox.SelectedIndex);
                }
                else
                {
                    snackComboBox.Text = "";
                    snackComboBox.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Select a snack.");
                snackComboBox.Focus();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // declare an object of the DialogResult class

            DialogResult responseDialogResult;

            responseDialogResult = MessageBox.Show("Clear the combo box?",
                "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (responseDialogResult == DialogResult.Yes)
            {
                snackComboBox.Items.Clear();
                snackComboBox.Text = "";
            }
            else
            {
                snackComboBox.Text = "";
                snackComboBox.SelectedIndex = -1;
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of snacks: " + snackComboBox.Items.Count);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            exitButton_Click(sender, e);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addButton_Click(sender, e);
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayButton_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteButton_Click(sender, e);
        }

        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countButton_Click(sender, e);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearButton_Click(sender, e);
        }

        private void visibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (visibleToolStripMenuItem.Checked)
                snackLabel.Visible = true;
            else
                snackLabel.Visible = false;
        }

        private void exitToolStripButton_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by Dr. J#");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutToolStripMenuItem_Click(sender, e);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            MyDialog.Color = snackLabel.ForeColor;
           
            if (MyDialog.ShowDialog() == DialogResult.OK)
                snackLabel.ForeColor =  MyDialog.Color;            
        }       
    }
}
