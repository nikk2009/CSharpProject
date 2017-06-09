/*
 * Nikkolas Olliff
 * 000212872
 * 08/31/2015
 * 08/31/2015
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

namespace _3333_OlliffN_Ch02Ex02
{
    public partial class translatorBox : Form
    {
        public translatorBox()
        {
            InitializeComponent();
        }

        private void sinisterButton_Click(object sender, EventArgs e)
        {
            translateOutput.Text = "Left";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            translateOutput.Text = "Center";
        }

        private void dexterButton_Click(object sender, EventArgs e)
        {
            translateOutput.Text = "Right";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            translateOutput.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
