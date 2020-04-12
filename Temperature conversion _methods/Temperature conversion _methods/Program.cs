// Program Name:    temperatureConversion with method

// Author:          Anant Agarwal

// Date:            09 Apr 2020

// Description:     Mini-Project 3 Part 2
//                      This program will collect a temperature value from user convert it based on following:
//                      1. If user input temperature in Fahrenheit, program will return the equivalent Celcius temperature.
//                      1. If user input temperature in Celcius, program will return the equivalent Fahrenheit temperature

//Information provided by the user: 
//                  User will be prompted for the following:
//                      1) Input temperature unit (either F for Fahrenheit or C for Celcius)
//                      2) Temperature to be converted
//                      3) Are there any more temperature values (Y for Yes or N for No)

//Formulae for temperature conversion:
//                      1) F = (9/5) * C + 32
//                      2) C = (5/9) * (F - 32)

//                      There were no compilation errors in the program

//Assumption:       User will respond in upper case.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatureAppMain
{
    class Program
    {
        // Following method will take a value in Fahrenheit and returns a value in Celcius
        static double toCelsius(double fahrenheit)
        {
            double celcius;
            celcius = (5 * (fahrenheit - 32) / 9);

            return celcius  ;
        }

        // Following method will take a value in Celcius and returns a value in Fahrenheit
        static double toFahrenheit(double celcius)
        {
            double fahrenheit;
            fahrenheit = ((9 * celcius) / 5) + 32;
    
            return fahrenheit;
        }

        //In following method, we are prompting user for two options:
        //  1) Unit of output temperature value.
        //  2) Are there more values to be converted.
        // User's response is the validated and if user has enetered anything different from expected response, then appropritate
        // error message is shown.
        static char getChoice(string prompt, 
                                char choice1, 
                                char choice2)
        {   
            //Declaring variables
            char unitChoice;                //stores user's response
            bool haveGoodValue = false;
            do
            {
                Console.Write(prompt);
                if (char.TryParse(Console.ReadLine(), out unitChoice))
                {                                                   
                    if ((unitChoice == choice1) || (unitChoice == choice2))  //Checking is user's response is a good value.
                    {
                        haveGoodValue = true;
                    }  
                }
                
                //Based on the response expected from user, there will be a error message displayed accordingly.
                if (choice1 == 'F' && choice2 == 'C')
                {
                    Console.WriteLine("***Must enter one of 'F' or 'C'");   //Error message prompt for user
                }

                else 
                {
                    Console.WriteLine("***Must enter one of 'Y' or 'N'");   //Error message prompt for user
                }

            } while (!haveGoodValue);
            return unitChoice;
        }

        //In this method, we are taking a temperature value from user and validating the data for non-numeric entry.
        //If the data is not good, an error message will be prompted to user for re-entering
        static double getDouble(string prompt)
        {
            //Declaring variables
            double temperatureValue;
            bool haveGoodValue = false;

            do
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out temperatureValue))
                {
                   haveGoodValue = true;
                }

                else
                {
                    Console.WriteLine("*** Input is not a double number. Try again.");
                }
            } while (!haveGoodValue);

            return temperatureValue;
        }

        static void Main(string[] args)
        {
            char inputUnits;   // records the units of the input temperature (either 'F' or 'C')
            char outputUnits;  // gets the letter that represents the output temperature units
            double inputTemp;    // gets the temperature input by the user
            double outputTemp;   // gets the output temperature calculated by the program
            char moreToDo;     // gets the letter 'Y if more temperatures to be converted


            // jump into a do while that asks for input units, and input temperature. 
            // Then based on the input units, the appropriate conversion function is 
            // called to produce the output temperature
            // 
            // the original temperature and its converted value is output, with units, 
            // using an interpolated string.
            //
            // finally the user is asked if they have more to convert and based on that 
            // input, the loop is repeated (or not)

            do
            {
                // get input units and temperature

                inputUnits = getChoice("What is the input temperature units? [F or C] :", 'F', 'C');
                inputTemp = getDouble("Enter temperature to be converted: ");

                if (inputUnits == 'C')           // convert celsius -> to fahrenheit
                {
                    outputTemp = toFahrenheit(inputTemp);
                    outputUnits = 'F';

                }
                else                            // convert fahrenheit -> to celsius
                {
                    outputTemp = toCelsius(inputTemp);
                    outputUnits = 'C';
                }

                // output results

                Console.WriteLine($" {inputTemp}°{inputUnits} =  {outputTemp:N2}°{outputUnits}");

                // ask if more to do

                moreToDo = getChoice("Convert another temperature? [Y or N]? :", 'Y', 'N');
            } while (moreToDo == 'Y');
            
            Console.WriteLine("Thank you, have a good day."); //Comment before exiting the program
        }
    }
}
