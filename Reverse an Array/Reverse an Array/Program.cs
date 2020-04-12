// Program Name:    Reverse an Array

// Author:          Anant Agarwal

// Date:            10 Apr 2020

// Description:     Mini-Project 5 Part 1
//                      This program will generate and display 5 random number between 1 and 1000.
//                      Also display the same numbers in reverse order.

//                  There were no compilation errors in the program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Declaring variables
            const int ARRAY_SIZE    = 5;                    //Storing size of the Array
            int[] myRandomNumbers   = new int[ARRAY_SIZE];  //Declaring integar Array type
            const int RAND_MIN      = 1;                    //Storing minimum limit on random numbers
            const int RAND_MAX      = 1000;                 //Storing maximum limit on random numbers

            //Storing data in Array
            System.Random randomNum = new System.Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                myRandomNumbers[i] = randomNum.Next(RAND_MIN, RAND_MAX);
            }

            //Displaying Array data
            Console.Write("Randome number list: ");
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.Write($"\t{myRandomNumbers[i]}");
            }
            Console.WriteLine();

            //Displaying Array data in reverse order
            Console.Write("Reverse number list: ");
            for (int i = ARRAY_SIZE - 1; i > -1; i--)
            {
                Console.Write($"\t{myRandomNumbers[i]}");
            }
            Console.WriteLine("\nThank you, have a good day."); //Comment before exiting the program
        }
    }
}
