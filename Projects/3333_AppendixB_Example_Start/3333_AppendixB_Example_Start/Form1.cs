using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_AppendixB_Example_Start
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
            if (snacksComboBox.SelectedIndex != -1)
            {
                snackLabel.Text = snacksComboBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Select a snack");
                snacksComboBox.Focus();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool noDuplicate = true;

            if (snacksComboBox.Text != "")
            {
                foreach (string snack in snacksComboBox.Items)
                {
                    if (snack.ToUpper() == snacksComboBox.Text.ToUpper())
                    {
                        noDuplicate = false;
                    }
                }

                if (noDuplicate)
                {
                    snacksComboBox.Items.Add(snacksComboBox.Text);
                    snacksComboBox.Text = "";
                    snacksComboBox.Focus();
                }
                else
                {
                    MessageBox.Show("Snack already exists: " + snacksComboBox.Text);
                    snacksComboBox.Text = "";
                    snacksComboBox.Focus();

                }
            }
            else
            {
                MessageBox.Show("Enter a snack");
                snacksComboBox.Focus();
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (snacksComboBox.SelectedIndex != -1)
            {
                // declare an obejct of the DialogResult

                DialogResult responseDialogResult;

                responseDialogResult = MessageBox.Show("Delete selected item?", "Delete Item",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
                    snacksComboBox.Items.Remove(snacksComboBox.SelectedItem);
                    snacksComboBox.Text = "";
                    snacksComboBox.Focus();
                }
                else
                {
                    snacksComboBox.Text = "";
                    snacksComboBox.Focus();
                    snacksComboBox.SelectedIndex = -1;
                }

            }
            else
            {
                MessageBox.Show("Select a snack");
                snacksComboBox.Focus();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult responseDialogResult;

            responseDialogResult = MessageBox.Show("Delete selected item?", "Delete Item",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (responseDialogResult == DialogResult.Yes)
            {
                snacksComboBox.Items.Clear();
                snacksComboBox.Text = "";
                snacksComboBox.Focus();
            }
            else
            {
                MessageBox.Show("Select a snack");
                snacksComboBox.Focus();
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of snacks: " + snacksComboBox.Items.Count.ToString());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by Nikk Olliff");
        }

        private void visibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (visibleToolStripMenuItem.Checked)
                snackLabel.Visible = true;

            else
                snackLabel.Visible = false;
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayButton_Click(sender, e);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addButton_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteButton_Click(sender, e);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearButton_Click(sender, e);
        }

        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countButton_Click(sender, e);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //declare variable for colorDialog class

            ColorDialog myDialog = new ColorDialog();

            // set color to the existing color of the label

            myDialog.Color = snackLabel.ForeColor;

            if (myDialog.ShowDialog() == DialogResult.OK)
                snackLabel.ForeColor = myDialog.Color;

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutToolStripMenuItem_Click(sender, e);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }
    }
}
