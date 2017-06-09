/*
 * Nikkolas Olliff
 * 000212872
 * Wednesday, August 26th
 * Wednesday, August 26th
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

namespace _3333_OlliffN_Ch02Ex01
{
    public partial class latinBox : Form
    {
        public latinBox()
        {
            InitializeComponent();
        }

        private void sinisterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Left");
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Center");
        }

        private void dexterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Right");
        }
    }
}
