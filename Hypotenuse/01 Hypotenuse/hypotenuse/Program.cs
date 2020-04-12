//  Demonstration Code of a hypotenuse calculator
//
//  Author:     Scott D. Thornton - All Rights Reserved
//              December 2018
//
//  Purpose:    Teaching example - SAIT CPRG 200 (Manpower)
//
//  Description:    The purpose of this application is to show where duplicated code can be
//                  parameterized and turned into a method. This application serves no purpose 
//                  other than a vehicle to to start a re-factoring process

using System;

namespace hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            double leg1;            // variable to hold the length of one of the legs of the right triangle
            double leg2;            // variable to hold the length of the other leg of the right triangle
            double hypotenuse;      // gets the calculated value of the hypotenuse


            // get the first leg using a do-while until we get a positive value
            do
            {
                Console.Write("Enter the length of leg one: ");
                leg1 = double.Parse(Console.ReadLine());
                if (leg1 <= 0)
                {
                    Console.WriteLine("***Length of leg 1 must be positive.");
                }
            } while (leg1 <= 0);


            // get the second leg using a do-while until we get a positive value
            do
            {
                Console.Write("Enter the length of leg two: ");
                leg2 = double.Parse(Console.ReadLine());
                if (leg2 <= 0)
                {
                    Console.WriteLine("***Length of leg 2 must be positive.");
                }

            } while (leg2 <= 0);


            // use the aqrt method in the Math class to calculate the hypotenuse
            hypotenuse = Math.Sqrt(leg1 * leg1 + leg2 * leg2);

            Console.WriteLine($"The length of the hypotenuse is {hypotenuse:F2}");

        }
    }
}
