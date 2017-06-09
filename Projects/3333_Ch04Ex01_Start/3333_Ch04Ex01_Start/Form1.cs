// Revised 10/5/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_Ch04Ex01_Start
{
    public partial class Form1 : Form
    {
        // declare private field declaration for accumulating total points initialized to 0 of appropriate data type
        private int totalPoints = 0;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // declare variable for books purchased of appropriate data type
            int books;

            // declare variable for points awarded (for use with if statement version #2 and version #4 and switch statement version #1 and switch statement version #2
            int points;
            
            // if statement to convert text box value of monthsTextBox using TryParse method and assign to output variable

            if(int.TryParse(monthsTextBox.Text,out books))
            {
                // if statement to check the accuracy of the output variable that is greater than or equal to 0

                if(books >= 0)
                {
                    // if statment to determine points awarded version #1
                    // (display points awarded as a string literal in the pointsEarnedLabel)

                    //if (books == 0) 
                    //{
                    //    pointsEarnedLabel.Text = "0"; 
                    //}
                    //else if(books ==1)
                    //{
                    //    pointsEarnedLabel.Text = "5"; 
                    //}
                    //else if(books==2)
                    //{
                    //    pointsEarnedLabel.Text = "15"; 
                    //}
                    //else if(books==3)
                    //{
                    //    pointsEarnedLabel.Text = "30"; 
                    //}
                    //else
                    //{
                    //    pointsEarnedLabel.Text = "60"; 
                    //}

                    // if statement to determine points award version #2
                    // (assign points awarded to a local variable and then display value of local variable in the pointsEarnedLabel after the if statement)

                    //if (books == 0)
                    //{
                    //    points = 0;
                    //}
                    //else if (books == 1)
                    //{
                    //    points = 5;
                    //}
                    //else if (books == 2)
                    //{
                    //    points = 15;
                    //}
                    //else if (books == 3)
                    //{
                    //    points = 30;
                    //}
                    //else
                    //{
                    //    points = 60;
                    //}

                    //pointsEarnedLabel.Text = points.ToString();

                    // if statement selection structure to determine points award version #3 (range of values)                
                    // (assign points awarded to a local variable and then display value of local variable in the pointsEarnedLabel after the if statement)

                    if (books == 0)
                    {
                        points = 0;
                    }
                    else if (books >=1 && books <=5)
                    {
                        points = 5;
                    }
                    else if (books >= 6 && books <= 10)
                    {
                        points = 15;
                    }
                    else if (books >= 11 && books <= 15)
                    {
                        points = 30;
                    }
                    else
                    {
                        points = 60;
                    }

                    totalPoints += points;
                    
                    pointsEarnedLabel.Text = points.ToString();
                    totalPointsLabel.Text = totalPoints.ToString();
                    

                    /* The switch statement lets the value of a variable or an expression
                     * determine which path of execution the program will take.
                     *
                     * The testExpression is a variable or an expression that gives an integer, string,
                     * or bool value. The important thing to remember is that the testExpression CANNOT 
                     * be a floating-point or decimal value.  
                     *          
                     * No fallthrough rule - the only exception to this rule is a case label that does not
                     * contain any statements
                    */

                    // switch statement version #1

                    switch (books) 
                    {
                        case 0:
                            {
                                pointsEarnedLabel.Text = "0";
                                break;
                            }
                        case 1: 
                            {
                                pointsEarnedLabel.Text = "5";
                                break;
                            }
                        case 2:
                            {
                                pointsEarnedLabel.Text = "15";
                                break;
                            }
                        case 3:
                            {
                                pointsEarnedLabel.Text = "30";
                                break;
                            }
                        default: 
                            {
                                pointsEarnedLabel.Text = "60";
                                    break;
                            }
                    }

                    // switch statement version #2

                      

                    // set focus back to months text box and select all contents

                    monthsTextBox.Focus();
                    monthsTextBox.SelectAll();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of books");
                }
            }
            else
            {
                MessageBox.Show("Please enter a whole number");

            }                 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            monthsTextBox.Clear();
            pointsEarnedLabel.Text = "";
            monthsTextBox.Focus();
        }       
    }
}