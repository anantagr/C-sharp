using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_sqaure_box_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE    = 9;
            const int RAND_MIN      = 1;
            const int RAND_MAX      = 10;

            int part1;
            int part2;
            int part3;
            int part4;
            int part5;
            int part6;

            List<int> listNumbers = new List<int>();
            int number;
            System.Random rand = new System.Random();

            do
            {


                for (int i = 0; i < ARRAY_SIZE; i++)
                {
                    do
                    {
                        number = rand.Next(RAND_MIN, RAND_MAX);
                        Console.WriteLine("Loop started");

                    } while (listNumbers.Contains(number));
                    listNumbers.Add(number);
                }

                int c = 0;

                Console.WriteLine("Loop 2 started");

                part1 = int.Parse(String.Concat((listNumbers[c].ToString()), (listNumbers[c + 1].ToString())));
                part2 = listNumbers[c + 2];
                part3 = part1 * part2;
                part4 = int.Parse(String.Concat((listNumbers[c + 5].ToString()), (listNumbers[c + 6].ToString())));
                part5 = part3 * part4;
                part6 = int.Parse(String.Concat((listNumbers[c + 7].ToString()), (listNumbers[c + 8].ToString())));

            } while (part5 != part6);
            
            

            for (int i = 0; i < 9; i++)
            {
                Console.Write($"{listNumbers[i],4}");

            }
            Console.WriteLine();
        }
    }
}
