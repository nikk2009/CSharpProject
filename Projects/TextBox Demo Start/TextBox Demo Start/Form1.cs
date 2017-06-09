using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_Demo_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readInputButton_Click(object sender, EventArgs e)
        {
            // Assign the name entered by the user to the
            // outputLabel control's Text property.
            outputLabel.Text = nameTextBox.Text;
         
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the nameTextBox control

            nameTextBox.Clear();

            // Clear the outputLabel control

            outputLabel.Text = "";
        }
    }
}
