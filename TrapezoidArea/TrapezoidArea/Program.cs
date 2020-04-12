// Program Name:    TrapezoidAreaVer1.0

// Author:          Anant Agarwal

// Date:            24 Mar 20

// Description:     Mini-Project 1
//                      This program calculates the area of a Trapezoid using Area = ((a+b)/2)*h
//                      It will prompts user for the long- and short-side length (a, b) then the height (h).
//                      After entering the values, area of the Trapezoid will be calculated
//                      There were no compilation errors in the program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring the variables
            double trapSide1;     // store the user input for first parallel side length
            double trapSide2;     // store the user input for second parallel side length
            double trapHeight;      // store the user input for the height length
            double trapArea;        // calculated value for the area

            // Asking the user for the height and side lengths 
            Console.Write("Enter the length of parallel side one: ");
            trapSide1 = Double.Parse(Console.ReadLine());

            Console.Write("Enter the length of parallel side two: ");
            trapSide2 = Double.Parse(Console.ReadLine());

            Console.Write("Enter the distance between parallel sides (height): ");
            trapHeight = Double.Parse(Console.ReadLine());

            // calulate the Trapezoid area using the standard formula A = ((long side + shor side)/2)*(height)
            trapArea = ((trapSide1 + trapSide2) / 2) * trapHeight;

            // output the result
            Console.WriteLine("The area of the trapezoid is " + trapArea);
        }
    }
}