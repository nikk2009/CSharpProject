/*
 * Nikkolas Olliff 
 * 000212872   
 * 09/02/2015
 * 09/02/2015
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

namespace _3333_OlliffN_Ch02Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
 
        private void sinisterPicControl_Click(object sender, EventArgs e)
        {
            sinisterPicControl.Visible = false;
            mediumPicControl.Visible = true;
            dexterPicControl.Visible = true;
            sinisterTranslatePic.Visible = true;
            mediumTranslatePic.Visible = false;
            dexterTranslatePic.Visible = false;
            translateOutputLabel.Text = "Left";
        }
             
        private void mediumPicControl_Click(object sender, EventArgs e)
        {
            sinisterPicControl.Visible = true;
            mediumPicControl.Visible = false;
            dexterPicControl.Visible = true;
            sinisterTranslatePic.Visible = false;
            mediumTranslatePic.Visible = true;
            dexterTranslatePic.Visible = false;
            translateOutputLabel.Text = "Center";
        }

        private void dexterPicControl_Click(object sender, EventArgs e)
        {
            sinisterPicControl.Visible = true;
            mediumPicControl.Visible = true;
            dexterPicControl.Visible = false;
            sinisterTranslatePic.Visible = false;
            mediumTranslatePic.Visible = false;
            dexterTranslatePic.Visible = true;
            translateOutputLabel.Text = "Right";
        }

        private void sinisterTranslatePic_Click(object sender, EventArgs e)
        {
            sinisterPicControl.Visible = true;
            sinisterTranslatePic.Visible = false;
            translateOutputLabel.Text = "";
        }

        private void mediumTranslatePic_Click(object sender, EventArgs e)
        {
            mediumPicControl.Visible = true;
            mediumTranslatePic.Visible = false;
            translateOutputLabel.Text = "";
        }

        private void dexterTranslatePic_Click(object sender, EventArgs e)
        {
            dexterPicControl.Visible = true;
            dexterTranslatePic.Visible = false;
            translateOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
