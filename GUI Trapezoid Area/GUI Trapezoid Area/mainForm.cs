// Program Name:    GUI Trapezoid Area

// Author:          Anant Agarwal

// Date:            10 April 20

//Description:      Mini-Project 4 Part 1
//                      The intent of this application is to calculate area of a Trapezoid.
//                      User will be asked to enter the parallel lenghts and height.
//                      Program will check if the entered values are non-zero and positive.
//                      If all values are good, area will be calculated and displayed to the user.

//Information provided by the user:
//                  Trapezoid area = ((long side + short side)/2)*(height)

//Assumption :      Values entered will be in meter.

//There were no compilation errors in the program




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Trapezoid_Area
{
    public partial class mainForm : Form
    {
        // Following method will take the length value and check to make sure it is a positive interal entry.
        // If not, user will be asked to re-enter.
        //This method will also check if all three good values have been entered to calculate area.
        //If not, appropriate error will be popped up to the user
        public bool goodValue(string prompt, out double value)
        {
            if (!double.TryParse(prompt, out value))
            {
                if (prompt.Length == 0)
                {
                    MessageBox.Show("***Error - Please enter all the values");
                    return false;
                }
                else
                {
                    MessageBox.Show("***Error - Non-integral value entered, Please re-enter");
                    return false;
                }
            }

            if ((value < 0) || (value == 0))
            {
                MessageBox.Show($"***Error: {value} is an invalid entry. Please enter a positive value");
                return false;
            }

            return true;
        }

        //declaring variables
        double parellelSideLength1;     // store the user input for first parallel side length
        double parellelSideLength2;     // store the user input for second parallel side length
        double height;                  // store the user input for the height length
        double trapArea;                // calculated value for the area

        public mainForm()
        {
            InitializeComponent();
        }

        //Clicking the Quit button will exit the application.
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Clicking "Calculate" button will validate lengths using goodValue method and then
        //calculate and display area to the user.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!goodValue(parellelSide1textBox.Text, out parellelSideLength1))
            {
                parellelSide1textBox.Select();
                return;
            }
            
            if (!goodValue(parellelSide2textBox.Text, out parellelSideLength2))
            {
                parellelSide2textBox.Select();
                return;
            }
            
            if (!goodValue(heightTextBox.Text, out height))
            {
                heightTextBox.Select();
                return;
            }
            
            // calulate the Trapezoid area using the standard formula A = ((long side + short side)/2)*(height)
            trapArea = ((parellelSideLength1 + parellelSideLength2) / 2) * height;

            resultLabel.Text = $"The area of the trapezoid is: {trapArea} m sq.";
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
