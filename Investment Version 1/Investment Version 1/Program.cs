// Program Name:    Investment Version 1

// Author:          Anant Agarwal

// Date:            25 Mar 20

// Description:     Mini-Project 3 Part 2
//                      This program will demontratre the use of while loop statement
//                      In this program, we will generate a compound interest table for an initial principal amount 
//                      and a fixed annual interest rate.

//                      We will ask the user to enter following information :
//                      1. Amount initially invested $$
//                      2. Annual interest rate %
//                      3. Number of years the principal is invested for

//                  We will use the following compound interest formula to calculate the interest generated and new principal amount
//                  at the end of every year.
//                  Formula:    Year(nth + 1) = Year(n) * (1 + i)
//                  where       Year(n+1)   is the value of the investment($$) at the beginning of year,
//                              Year(n)     is the value of the investment($$) at the beginning of year n,
//                              i           is the interest rate expressed as a decimal value (i.e. 3.75% = 0.0375)

//                  Based on the following information, program will generate output as under: 
//                      Year                            Balance ($$)
//                       1                                  $___
//                       2                                  $___
//                       3                                  $___
//                       4                                  $___

//                      There were no compilation errors in the program

//  Assumption:     User will enter an integral value for number of years
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Investment_Version_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variable
            double principalAmount;     //Stores the Principal amount $$ entered by the user
            double interestRate;        //Stores the Principal interest rate % entered by the user
            int years;               //Stores number of years of investment entered by the user

            //Asking user principal amount $$
            Console.Write("What is your principal amount invested?: $");
            principalAmount = double.Parse(Console.ReadLine());

            //Checking for negative or zero entries
            while ((principalAmount < 0) || (principalAmount == 0))
            {
                Console.WriteLine($"***Error: ${principalAmount} is an invalid entry, principal amount should be a positive number. Please re-enter.");   //Output error message
                Console.Write("What is your principal amount invested?: $");
                principalAmount = double.Parse(Console.ReadLine());
            }

            //Asking user for interest rate %
            Console.Write("What is the annual interest rate (in percet)?: ");
            interestRate = double.Parse(Console.ReadLine());
            while ((interestRate < 0) || (interestRate == 0))
            {
                Console.WriteLine($"***Error: {interestRate}% is an invalid entry, interest rate should be a positive number. Please re-enter.");   //Output error message
                Console.Write("What is the annual interest rate (in percet)?: ");
                interestRate = double.Parse(Console.ReadLine());
            }

            //Asking user for number of year 
            Console.Write("How many years will this be invested for?: ");
            years = int.Parse(Console.ReadLine());
            while ((years < 0) || (years == 0))
            {
                Console.WriteLine($"***Error: {years} years is an invalid entry, number of years should be a positive number. Please re-enter.");   //Output error message
                Console.Write("How many years will this be invested for?: ");
                years = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Year            Balance");      //Displaying the header of the table as output

            //Staring a For loop to calculate new principal amount for every year
            //We are initializing a local variable "time" as 0 and incrementing it after every loop run by 1 till time 
            //becomes equal to number of year user invested the amount.
            //In every loop run, we are displaying number of years and new principal amount $$ calculated at the end
            //of that year as output

            for(int time = 0; time < years; time ++)
            {
                principalAmount *= (1 + (interestRate / 100));
                Console.WriteLine($"  {time + 1}            ${principalAmount:n2}");
            }
            
            Console.WriteLine("Thank you, have a good day."); //Comment before exiting the program
        }
    }
}
