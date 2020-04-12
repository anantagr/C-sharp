//  Demonstration Code of a hypotenuse calculator using a method to get data from user
//
//  Author:     Scott D. Thornton - All Rights Reserved
//              December 2018
//
//  Purpose:    Teaching example - SAIT CPRG 200 (Manpower)
//
//  Description:    The purpose of this application is to show where duplicated code can be
//                  parameterized and turned into a method. This application is a refactoring 
//                  of a previous example that essentially duplicated code 

using System;

namespace hypotenuseWithMethods

{
    class Program
    {
        static double getValue(string prompt, string error)
        {
            double legLength;
            bool haveGoodValue = false;

            do
            {
                Console.Write(prompt);
                //                value = double.Parse(Console.ReadLine());
                if (double.TryParse(Console.ReadLine(), out legLength))
                {
                    //means I have a valid number
                    if (legLength <= 0)
                    {
                        Console.WriteLine(error);
                    }
                    else
                    {
                        haveGoodValue = true;
                    }
                }

                else
                {
                    Console.WriteLine("You have entered a non numeric number");
                }
            } while ( ! haveGoodValue );

            return legLength;
        }

        static void Main(string[] args)
        {
            double leg1;            // variable to hold the length of one of the legs of the right triangle
            double leg2;            // variable to hold the length of the other leg of the right triangle
            double hypotenuse;      // gets the calculated value of the hypotenuse

            // get the leg lengths
            leg1 = getValue("Enter the length of leg one: ", "***Length of leg 1 must be positive.");
            leg2 = getValue("Enter the length of leg two: ", "***Length of leg 2 must be positive.");

            // use the aqrt method in the Math class to calculate the hypotenuse
            hypotenuse = Math.Sqrt(leg1 * leg1 + leg2 * leg2);

            Console.WriteLine($"The length of the hypotenuse is {hypotenuse:F2}");
        }
    }
}
