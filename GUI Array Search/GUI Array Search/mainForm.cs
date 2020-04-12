// Program Name:    GUI array Search

// Author:          Anant Agarwal

// Date:            11 Apr 2020

// Description:     Mini-Project 5 Part 3
//                      This program will auto generate an array of 10 random integars and prompt user to enter numeric
//                      value.
//                      If that value is found in the array, program will print the value along with its index number.
//                      If not found, program will print the value with a "NOT found" message.
//                      If a non-integar value (alphabets,alphanumeric or decimals) is entered by user, program will
//                      prompt an error screen and ask user to re-enter.

//                   There were no compilation errors in the program

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Array_Search
{
    public partial class mainForm : Form
    {   
        //declaring variables
        const int ARRAY_SIZE    = 10;                   //stores the size of the array
        const int RAND_MIN      = 10;                   //stores the minimum range of the array
        const int RAND_MAX      = 100;                  //stores the maximum range of the array
        int[] myRandomNumbers   = new int[ARRAY_SIZE];  //declare an array to store values

        public mainForm()
        {
            InitializeComponent();
        }

        //As we load the main form, the array will run and stores random numbers in it/
        //It will also display those numbers in the textbox
        private void mainForm_Load(object sender, EventArgs e)
        {            
            System.Random random = new System.Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                myRandomNumbers[i] = random.Next(RAND_MIN, RAND_MAX);
            }

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                randomNumberListTextBox.AppendText((myRandomNumbers[i].ToString()) + "   ");
            }

            //After displaying the number, control will go to second textbox to enter the value to check
            indexNumberTextBox.Select();
        }

        //Clicking the search button will run this method. It will check the following:
            //  1)  If there is a non - integral entry in the textbox   ----> Pops a message box with error warning and ask 
            //                                                                user to re-enter
            //  2)  If there is a good value                            ----> Check if the value is present in array or not 
            //                                                                and print response accordingly
        private void searchButton_Click(object sender, EventArgs e)
        {
                if (!int.TryParse(indexNumberTextBox.Text, out int indexValue))
                {
                    MessageBox.Show($"***Error - Non-integral value entered. Please re-enter.");
                    indexNumberTextBox.Select();
                    return;
                }
                else
                {
                    resultLabel.Visible = true;
                    for (int i = 0; i < ARRAY_SIZE; i++)
                    {
                        if (myRandomNumbers[i] == indexValue)
                        {
                            resultLabel.Text = $"The value of {indexValue} is found at index {i}";
                            indexNumberTextBox.Select();
                            break;
                        }
                        else
                        {
                            resultLabel.Text = $"The value of {indexValue} was NOT found";
                            indexNumberTextBox.Select();
                        }
                    }
                }
        }

        //This method deletes the result everytime textbox value is altered. 
        private void indexNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            resultLabel.Visible = false;
        }
    }
}
