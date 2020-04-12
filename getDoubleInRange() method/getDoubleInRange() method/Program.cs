// Program Name:    getDoubleInRange() method

// Author:          Anant Agarwal

// Date:            09 Apr 2020

// Description:     Mini-Project 3 Part 1
//                      This program is designed to obtain a double type number from a user that must fall between 
//                      some minimum and maximum values. This demonstrate how to create a method and call it when required.

//Information provided by the user: 
//                  User will be prompted for the following:
//                      1) Minimum percentage for the range.
//                      2) Maximum percentage for the range.
//                      3) Percentage value to check.

//                      There were no compilation errors in the program

//Assumption:       User will not enter a non-numeric value for minimum and maximum percentage range.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getDoubleInRange___method
{
    namespace hypotenuseWithMethods

    {
        class Program
        {
            //In this method, we are taking a percentage value from user and validating the data for non-numeric entry.
            //If the data is good, we are then checking if it is between the max and min range provided by the user and
            //reponsing accourdingly.
            static double getDoubleInRange(string prompt, 
                                           double minValue, 
                                           double maxValue, 
                                           string error)
            {   
                //Derlaring variables
                double myValue;
                bool haveGoodValue = false;

                do
                {
                    Console.Write(prompt);
                    if (double.TryParse(Console.ReadLine(), out myValue))
                    {
                        //means I have a valid number
                        if ((myValue < minValue) || (myValue > maxValue))
                        {
                            Console.WriteLine(error);
                        }
                        else
                        {
                            haveGoodValue = true;
                        }
                    }

                    else
                    {
                        Console.WriteLine("You have entered a non numeric number");
                    }
                } while (!haveGoodValue);

                return myValue;
            }
    
        static void Main(string[] args)
            {
                //declaring variables

                double myValue;         //stores the good value returned from the method
                double minValue;        //stores the minimum value for percentage range
                double maxValue;        //stores the maximum value for percentage range

                Console.Write("Please enter the minimum percentage: ");
                minValue = double.Parse(Console.ReadLine());

                Console.Write("Please enter the maximum percentage: ");
                maxValue = double.Parse(Console.ReadLine());

                //calling the method
                myValue = getDoubleInRange("Enter the minimum percentage range: ",
                                            minValue,
                                            maxValue,
                                            "***Error - Percentage entered is out of range");
                
                //Final output as requested by the user
                Console.WriteLine($"You entered a percentage of {myValue:N2}%");
                Console.WriteLine("Thank you, have a good day."); //Comment before exiting the program
            }
        }
    }
}