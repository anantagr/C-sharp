// Program Name:    TechnicalSupport_Program

// Author:          Anant Agarwal

// Date:            24 Mar 20

// Description:     Mini-Project 2 Part 2
//                      This program will demontratre the use of Nested if Statement
//                      In this program, we are developing a Technical support Program
//                      that a user could run to assist in computer repair.
//                      The user will be asked if the computer beeps on startup and if the hard drive spins.
//                      Based on user's reponse, the required solution will be presented.
//                      There were no compilation errors in the program

//  Assumption:     User will reply only with upper case "Y" or "N".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Support_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Char computerBeep;      //Stores user's response if the computer beeps on startup (Y/N)
            Char driveSpin;         //Stores user's response if the hard drive spins (Y/N)

            //Asking User if the computer beeps on startup
            Console.Write("Does your computer beep when powered on? Enter Y or N: ");
            computerBeep = Char.Parse(Console.ReadLine());

            //Asking User if the hard drive is spinning
            Console.Write("Does your computer hard drive spins when powered on? Enter Y or N: ");
            driveSpin = Char.Parse(Console.ReadLine());

            if (computerBeep == 'Y')        //Condition
            {
                if (driveSpin == 'Y')       //Condition
                {
                    Console.WriteLine("Please contact Tech Support.");  //Solution output to the user
                }
                else
                {
                    Console.WriteLine("Please check drive cables.");
                }       
            }
            else
            {
                if (driveSpin == 'Y')       //Condition
                {
                    Console.WriteLine("Please check the speaker contacts.");
                }
                else
                {
                    Console.WriteLine("Please bring your computer to repair center.");
                  
                }
            }

            Console.WriteLine("Thank you, have a good day."); //Comment before exiting the program
        }
    }
}
