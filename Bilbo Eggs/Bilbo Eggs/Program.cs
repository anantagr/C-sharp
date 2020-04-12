// Program Name:    Bilbo's Eggs

// Author:          Anant Agarwal

// Date:            24 Mar 20

// Description:     Mini-Project 2 Part 3
//                      This program will demontratre the use of if-else ladder statement
//                      In this program, we are calculating the wholesale price of the eggs
//                      purchased from Bilbo's wholesale shop
//                      We will ask the user to enter number of eggs purchased and based on that we will
//                      provide following output:
//                      1. Cost per dozen $$ or Cost per egg $$
//                      2. Total bill amount $$

//Information provided by the user: 
//                      Number of Eggs                              Price per dozen
//                      Less than 4 dozen                           $0.50
//                      4 dozen or more but less than 6 dozen       $0.45
//                      6 dozen or more but less than 11 dozen      $0.40
//                      11 dozen or more                            $0.35
//                      Extra eggs                                  1/12 the per dozen price

//                      There were no compilation errors in the program

//  Assumption:     User will enter a positive numeric integar when asked for number of eggs purchased
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bilbo_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring global variables
            int numEggs;            //Stores how many eggs were purchased
            double dozen_eggs;      //Stores dozen value of eggs purchased
            double costPerDozen;    //Storing cost per dozen for eggs bought
            double totalBill;       //Storing total bill calculated

            Console.Write("Please enter number of eggs purchased: ");  //Asking user for number of eggs bought
            numEggs = int.Parse(Console.ReadLine());                   //Storing user input in numEggs

            dozen_eggs = numEggs / 12;                                 //Calculating dozen of eggs bought

            //Finding the right price per dozen based on user table provided
            if(dozen_eggs < 4)
            {
                costPerDozen = 0.50;
            }
            else if (dozen_eggs < 6)
            {
                costPerDozen = 0.45;
            }
            else if (dozen_eggs < 11)
            {
                costPerDozen = 0.40;
            }
            else
            {
                costPerDozen = 0.35;
            }

            totalBill = numEggs * (costPerDozen / 12);      //Calculating the total bill amount

            //Final output as requested by the user
            Console.WriteLine($"Your cost is ${costPerDozen:n2} per dozen or {(costPerDozen / 12):n2} per egg.");
            Console.WriteLine($"Your bill comes to ${totalBill:n2}.");
            Console.WriteLine("Thank you, have a good day."); //Comment before exiting the program
        } 
    }
}
