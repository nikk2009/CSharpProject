// Revised 10/26/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3333_Ch06_Exercise01_Start
{
    public partial class Form1 : Form
    {
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
            // clear form and reset focus

            fatGramsTextBox.Clear();
            carbGramsTextBox.Clear();
            fatCaloriesLabel.Text = "";
            carbCaloriesLabel.Text = "";
            totalCaloriesLabel.Text = "";
            calorieIntakeLabel.Text = "";
            fatGramsTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // declare local variables

            int fatGrams,
                carbGrams,
                caloriesFromFat,
                caloriesFromCarbs,
                totalCalories;
            
            string calorieIntake;

            // validate input for appropriate data type and accuracy of grams of fat and grams of carbohydrates

             if (int.TryParse(fatGramsTextBox.Text, out fatGrams))
            {
                if (fatGrams > 0)
                {
                    if (int.TryParse(carbGramsTextBox.Text, out carbGrams))
                    {
                        if (carbGrams > 0)
                        {
                            // call FatCalories method passing grams of fat as an argument and assigning returned value to appropriate local variable

                            caloriesFromFat = FatCalories(fatGrams);

                            // call CarbCalories method passing grams of carbohydrates as an argument and assigning returned value to appropriate local variable


                            caloriesFromCarbs = CarbCalories(carbGrams);

                            // call totalCalories method passing calories from fat and calories from carbohydrates as arguments and assigning returned value to appropriate local variable

                            totalCalories = TotalCalories(caloriesFromCarbs, caloriesFromFat);
                            
            
                            // call DetermineCalorieIntake method passing total calories as an argument and assigning returned value to the appropriate local variable

                            calorieIntake = DetermineCalorieIntake(totalCalories);


                            // display output
                            fatCaloriesLabel.Text = caloriesFromFat.ToString();
                            carbCaloriesLabel.Text = caloriesFromCarbs.ToString();
                            totalCaloriesLabel.Text = totalCalories.ToString();
                            calorieIntakeLabel.Text = calorieIntake;

                        }
                        else
                        {
                            MessageBox.Show("Carb Grams must be greater than zero.");
                            carbGramsTextBox.Clear();
                            carbGramsTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Carb Grams is invalid. Must be an integer.");
                        carbGramsTextBox.Clear();
                        carbGramsTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Fat Grams must be greater than zero.");
                    fatGramsTextBox.Clear();
                    fatGramsTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Fat Grams is invalid. Must be an integer");
                fatGramsTextBox.Clear();
                fatGramsTextBox.Focus();
            }     
        }

        // FatCalories method


        private int FatCalories(int fatGram)
        {
            return fatGram * 9;
        }


        // CarbCalories method

        private int CarbCalories(int carbGram) 
        {
            return carbGram * 4;
        }


        // TotalCalories method

        private int TotalCalories(int carb, int fat) 
        {
            return carb + fat;
        }


        // DetermineCalorieIntake method

        private string DetermineCalorieIntake(int calories) 
        {
            if (calories > 2000) 
            {
                return "Exceeded";
            }
            else if (calories < 1500) 
            {
                return "Too Little";
            }
            else
            {
               return "Appropriate";
            }
        }
    }
}
