// Program Name:    TrapezoidAreaWithError_Detection

// Author:          Anant Agarwal

// Date:            24 Mar 20

// Description:     Mini-Project 2 Part 1
//                      This program calculates the area of a Trapezoid using Area = ((a+b)/2)*h
//                      It will prompts user for the long- and short-side length (a, b) then the height (h).
//                      Program will check if the entered values are non-zero and positive.
//                      In case of any negative or zero entry, program will exit.
//                      If all entries are valid, program will proceed to Area calculation.
//                      There were no compilation errors in the program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidAreaErrorDetection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring the global variables
            double trapSide1;     // store the user input for first parallel side length
            double trapSide2;     // store the user input for second parallel side length
            double trapHeight;    // store the user input for the height length
            double trapArea;      // calculated value for the area

            Console.Write("Enter the length of parallel side one: ");                   // Asking the user for side length 1
            trapSide1 = Double.Parse(Console.ReadLine());
            if ((trapSide1 < 0) || (trapSide1 == 0))                                    //Checking value for zero or negative entry
            {
                Console.WriteLine($"***Error: {trapSide1} is an invalid entry, side length should be a positive value.");   //Output error message
                return;                                                                                                     //Exiting the program
            }
                       
            Console.Write("Enter the length of parallel side two: ");                   // Asking the user for side length 2
            trapSide2 = Double.Parse(Console.ReadLine());
            if ((trapSide2 == 0) || (trapSide2 < 0))                                    //Checking value for zero or negative entry
            {
                Console.WriteLine($"***Error: {trapSide2} is an invalid entry, side length should be a positive value.");   //Output error message
                return;                                                                                                     //Exiting the program
            }

            Console.Write("Enter the distance between parallel sides (height): ");      // Asking the user for height
            trapHeight = Double.Parse(Console.ReadLine());
            if ((trapHeight == 0) || (trapHeight < 0))                                  //Checking value for zero or negative entry
            {
                Console.WriteLine($"***Error: {trapHeight} is an invalid entry, height should be a positive number.");      //Output error message
                return;                                                                                                     //Exiting the program
            }

            // calulate the Trapezoid area using the standard formula A = ((long side + shor side)/2)*(height)
            trapArea = ((trapSide1 + trapSide2) / 2) * trapHeight;

            // output the result
            Console.WriteLine("The area of the trapezoid is " + trapArea);
        }
    }
}
