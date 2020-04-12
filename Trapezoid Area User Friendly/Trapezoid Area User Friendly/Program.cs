// Program Name:    TrapezoidAreaUser_Friendly

// Author:          Anant Agarwal

// Date:            25 Mar 20

// Description:     Mini-Project 3 Part 1
//                      This program calculates the area of a Trapezoid using Area = ((a+b)/2)*h
//                      It will prompts user for the long- and short-side length (a, b) then the height (h).
//                      A Do-While loop will check if the entered values are non-zero and positive.
//                      In case of any negative or zero entry, user will be re-promted to enter a correct value.
//                      If all length and height entries are valid, program will proceed to Area calculation.
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
            //Declaring the variables
            double trapSide1;     // store the user input for first parallel side length
            double trapSide2;     // store the user input for second parallel side length
            double trapHeight;    // store the user input for the height length
            double trapArea;      // calculated value for the area

            //Asking user for lenghts
            do
            {
                Console.Write("Enter the length of parallel side one: ");
                trapSide1 = Double.Parse(Console.ReadLine());
                
                //Loop to check value for zero or negative entry
                if ((trapSide1 < 0) || (trapSide1 == 0))
                {
                    Console.WriteLine($"***Error: {trapSide1} is an invalid entry, side length should be a positive number.");   //Output error message
                }
            }
            while ((trapSide1 < 0) || (trapSide1 == 0));

            do
            {
                Console.Write("Enter the length of parallel side two: ");
                trapSide2 = Double.Parse(Console.ReadLine());
                if ((trapSide2 == 0) || (trapSide2 < 0))
                {
                    Console.WriteLine($"***Error: {trapSide2} is an invalid entry, side length should be a positive number.");
                }
            }
            while ((trapSide2 == 0) || (trapSide2 < 0));

            do
            {
                Console.Write("Enter the distance between parallel sides (height): ");
                trapHeight = Double.Parse(Console.ReadLine());
                if ((trapHeight == 0) || (trapHeight < 0))
                {
                    Console.WriteLine($"***Error: {trapHeight} is an invalid entry, height should be a positive number.");
                }
            }
            while ((trapHeight == 0) || (trapHeight < 0));

            // calulate the Trapezoid area using the standard formula A = ((long side + short side)/2)*(height)
            trapArea = ((trapSide1 + trapSide2) / 2) * trapHeight;

            // output the result
            Console.WriteLine("The area of the trapezoid is " + trapArea);
        }
    }
}
