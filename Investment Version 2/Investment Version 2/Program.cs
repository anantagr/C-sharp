// Program Name:    Investment Version 2

// Author:          Anant Agarwal

// Date:            25 Mar 20

// Description:     Mini-Project 3 Part 3
//                      This program will demontratre the use of while loop statement
//                      In this program, we will calculate the final value of total investment $$ made by the user over a period of years.
//                      User has invested an initial amount with a different intrest rate % for every year, therefore, this program will
//                      prompt the user to enter every year's interest rate % untill user enter sentinel value of 0% which will
//                      terminate the program and display the final value of user's initial investment $$.
//                      It will also display the average yearly income of the user $/per year

//                      User will be asked to enter following information:                                          
//                      1. Amount initially invested $$
//                      2. Annual interest rate for year 1 in percentage%
//                      3. Annual interest rate for year 2 in percentage% 
//                      4. .....and so on until user enters the sentinel value of interest rate which is 0%

//                      We will use the following compound interest formula to calculate the interest generated and new principal amount
//                      at the end of every year.
//                          Formula:    Year(nth + 1) = Year(n) * (1 + i)
//                          where       Year(n+1)   is the value of the investment($$) at the beginning of year,
//                                      Year(n)     is the value of the investment($$) at the beginning of year n,
//                                      i           is the interest rate expressed as a decimal value (i.e. 3.75% = 0.0375)

//                      Based on the following information, program will generate output as under: 
//                          At the end of ___ years, your investment will be worth $____
//                          Your average yearly income is $___

//                  There were no compilation errors in the program

//  Assumption:     User will not enter the sentinel interest rate of 0% for first year

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment_Version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variable
            double initialPrincipalAmount;      //Stores the Principal amount $$ initiall invested by the user
            double finalPrincipalAmount;        //Stores the final Principal amount $$ calculated at the end of investment
            double interestRate;                //Stores the yearly interest rates entered by the user
            int year = 1;                       //Initializing number of year value

            //Asking user for initial principal amount $$
            Console.Write("What is your principal amount invested?: $");
            initialPrincipalAmount = double.Parse(Console.ReadLine());

            //Checking for negative or zero entries
            while ((initialPrincipalAmount < 0) || (initialPrincipalAmount == 0))
            {
                Console.WriteLine($"***Error: ${initialPrincipalAmount} is an invalid entry, principal amount should be a positive number. Please re-enter.");   //Output error message
                Console.Write("What is your principal amount invested?: $");
                initialPrincipalAmount = double.Parse(Console.ReadLine());
            }
            
            finalPrincipalAmount = initialPrincipalAmount;      //Alotting initial value to Final Principal amount $$
            
            // We will run a do-while loop prompting user to enter interest rate for every year untill user enters sentinel value i.e. 0%
            // We will also run a while loop to ensure the interest rate entered is a non - negative number,
            // else customer will be prompted to re-enter the value
            // After the interest rate is calculated, we will add it to initial Principal amount $$ to calculate new Principal amount $$
            // We will increment the number of year by 1
            do
            {
                Console.Write($"What is the interest rate for year {year}(in percent) ?: ");
                interestRate = double.Parse(Console.ReadLine());
                while (interestRate < 0)
                {
                    Console.WriteLine($"***Error: {interestRate}% is an invalid entry, interest rate should be a positive number. Please re-enter.");   //Output error message
                    Console.Write($"What is the interest rate for year {year} (in percent) ?: ");
                    interestRate = double.Parse(Console.ReadLine());
                }
                finalPrincipalAmount *= (1 + (interestRate / 100));
                year += 1;
            }
            while (interestRate != 0);

            // We will display the number of years user has invested the Principal amount and the final Principal amount $$
            // We will also display the average yearly income $$
            Console.WriteLine($"At the end of {year - 2} years, your investment will be worth ${finalPrincipalAmount:n2}");
            Console.WriteLine($"Your average yearly income is ${(finalPrincipalAmount - initialPrincipalAmount) / (year - 2):n2}.");

            Console.WriteLine("Thank you, have a good day.");   //Comment before exiting the program

        }
    }
}
