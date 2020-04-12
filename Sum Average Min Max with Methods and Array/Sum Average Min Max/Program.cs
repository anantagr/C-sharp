// Program Name:    Sum Average Min Max

// Author:          Anant Agarwal

// Date:            11 Apr 2020

// Description:     Mini-Project 5 Part 2
//                      This program will ask user to enter 10 decimal values between 0 and 100.
//                      Program will then display all the values enter along with the following:
//                          1) Sum of all the numbers
//                          2) Average of all the numbers
//                          3) Minimum of all the numbers
//                          4) Maximum of all the numbers

//                   There were no compilation errors in the program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Average_Min_Max
{
    class Program
    {
        // Following method will prompt user to enter a value and then method will check the value is a decimal between
        // 0 and 100.
        //If not, appropriate error message will be prompted back to user and asked to re-enter
        static decimal goodValue(string prompt)
        {
            //declaring variables
            decimal userValue;              //Stores the value entered by the user.
            bool    haveGoodValue = false;  

            do
            {
                Console.Write(prompt);

                //Checks if the value entered is a decimal number
                if (decimal.TryParse(Console.ReadLine(), out userValue))
                {
                    //Checks if the number is between 0 and 100
                    if ((userValue < 0) || (userValue > 100))
                    {
                        Console.WriteLine("Please enter a value between 0 and 100");
                    }
                    
                    else
                    {
                        haveGoodValue = true;
                    }
                }

                else
                {
                    Console.WriteLine("***Error: Non-integral entry, please re-enter");
                }
            } while (!haveGoodValue);

            return userValue; //returns good value to the main program
        }

        static void Main(string[] args)
        {
            //Declaring variables
            const int ARRAY_SIZE    = 10;       //Stores the size of Array
            decimal minNum          = 0;        //Stores minimum number entered by user
            decimal maxNum          = 100;      //Stores maximum number entered by user
            decimal sum             = 0;        //Stores sum of all the numbers entered by user
            decimal average;                    //Stores average of all the number entered by the user
            
            decimal[] userNumbers   = new decimal[ARRAY_SIZE]; //Declaring the aaray

            Console.WriteLine ("Please enter 10 values between 0 and 100:");
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                userNumbers[i] = goodValue($"Value #{i + 1}: ");    //Calling goodValue method to validate value entered
                sum           += userNumbers[i];
                if (i == 0)
                {
                    minNum = userNumbers[i];
                    maxNum = userNumbers[i];
                }
    
                if (userNumbers[i] < minNum)
                {
                    minNum = userNumbers[i];
                }

                if (userNumbers[i] > maxNum)
                {
                    maxNum = userNumbers[i];
                }
            }

            average = sum / ARRAY_SIZE;                 //Calculating average

            Console.Write("Value Entered: ");
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.Write($"{userNumbers[i], 4}");  //Displaying all the numbers.
            }

            //Displaying sum, average, minimum and maximum values
            Console.WriteLine($"\nTotal:      {sum}");
            Console.WriteLine($"Mean:       {average}");
            Console.WriteLine($"Minimum:    {minNum}");
            Console.WriteLine($"Maximum:    {maxNum}");

            Console.WriteLine("Thank you, have a good day."); //Comment before exiting the program
        }
    }
}
