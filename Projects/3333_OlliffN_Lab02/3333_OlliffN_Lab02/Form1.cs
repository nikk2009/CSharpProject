/*
 *Nikkolas Olliff
 *000212872
 *09/02/2015
 *09/14/2015
 *Displays the name of cards
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

namespace _3333_OlliffN_Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardBackAceClubs_Click(object sender, EventArgs e)
        {
            cardAceClubs.Visible = true;
            cardAceDiamonds.Visible = false;
            cardAceHearts.Visible = false;
            cardEightHearts.Visible = false;
            cardEightClubs.Visible = false;

            cardBackAceClubs.Visible = false;
            cardBackAceDiamonds.Visible = true;
            cardBackAceHearts.Visible = true;
            cardBackEightHearts.Visible = true;
            cardBackEightClubs.Visible = true;

            cardOutputLabel.Text = "Ace of Clubs";
        }

        private void cardBackAceDiamonds_Click(object sender, EventArgs e)
        {
            cardAceClubs.Visible = false;
            cardAceDiamonds.Visible = true;
            cardAceHearts.Visible = false;
            cardEightHearts.Visible = false;
            cardEightClubs.Visible = false;

            cardBackAceClubs.Visible = true;
            cardBackAceDiamonds.Visible = false;
            cardBackAceHearts.Visible = true;
            cardBackEightHearts.Visible = true;
            cardBackEightClubs.Visible = true;

            cardOutputLabel.Text = "Ace of Diamonds";
        }

        private void cardBackAceHearts_Click(object sender, EventArgs e)
        {
            cardAceClubs.Visible = false;
            cardAceDiamonds.Visible = false;
            cardAceHearts.Visible = true;
            cardEightHearts.Visible = false;
            cardEightClubs.Visible = false;

            cardBackAceClubs.Visible = true;
            cardBackAceDiamonds.Visible = true;
            cardBackAceHearts.Visible = false;
            cardBackEightHearts.Visible = true;
            cardBackEightClubs.Visible = true;

            cardOutputLabel.Text = "Ace of Hearts";
        }

        private void cardBackEightHearts_Click(object sender, EventArgs e)
        {
            cardAceClubs.Visible = false;
            cardAceDiamonds.Visible = false;
            cardAceHearts.Visible = false;
            cardEightHearts.Visible = true;
            cardEightClubs.Visible = false;

            cardBackAceClubs.Visible = true;
            cardBackAceDiamonds.Visible = true;
            cardBackAceHearts.Visible = true;
            cardBackEightHearts.Visible = false;
            cardBackEightClubs.Visible = true;

            cardOutputLabel.Text = "Eight of Hearts";
        }

        private void cardBackEightClubs_Click(object sender, EventArgs e)
        {
            cardAceClubs.Visible = false;
            cardAceDiamonds.Visible = false;
            cardAceHearts.Visible = false;
            cardEightHearts.Visible = false;
            cardEightClubs.Visible = true;

            cardBackAceClubs.Visible = true;
            cardBackAceDiamonds.Visible = true;
            cardBackAceHearts.Visible = true;
            cardBackEightHearts.Visible = true;
            cardBackEightClubs.Visible = false;

            cardOutputLabel.Text = "Eight of Clubs";
        }

        private void cardAceClubs_Click(object sender, EventArgs e)
        {
            cardAceClubs.Visible = false;
            cardBackAceClubs.Visible = true;

            cardOutputLabel.Text = "";
        }

        private void cardAceDiamonds_Click(object sender, EventArgs e)
        {
            cardAceDiamonds.Visible = false;
            cardBackAceDiamonds.Visible = true;

            cardOutputLabel.Text = "";
        }

        private void cardAceHearts_Click(object sender, EventArgs e)
        {
            cardAceHearts.Visible = false;
            cardBackAceHearts.Visible = true;

            cardOutputLabel.Text = "";
        }

        private void cardEightHearts_Click(object sender, EventArgs e)
        {
            cardEightHearts.Visible = false;
            cardBackEightHearts.Visible = true;

            cardOutputLabel.Text = "";
        }

        private void cardEightClubs_Click(object sender, EventArgs e)
        {
            cardEightClubs.Visible = false;
            cardBackEightClubs.Visible = true;

            cardOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
