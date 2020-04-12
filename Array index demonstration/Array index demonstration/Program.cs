using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_index_demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 10;
            const int RAND_MIN = 1;
            const int RAND_MAX = 100;
            const int SENTINEL_VALUE = 999;
            int[] myRandomNumbers = new int[ARRAY_SIZE];
            int index;

            System.Random random = new System.Random ();
            for (int i=0; i<ARRAY_SIZE; i++)
            {
                myRandomNumbers[i] = random.Next(RAND_MIN, RAND_MAX);
            }

            for (int i=0; i<ARRAY_SIZE; i++)
            {
                Console.Write($"{myRandomNumbers[i],4}");
            }
            Console.WriteLine();

            //now get an index from the user

            do
            {
                Console.Write("Please enter an index value: ");
                index = int.Parse(Console.ReadLine());
                if (index != SENTINEL_VALUE)
                {
                    try
                    {
                        Console.WriteLine($"The value at index {index} is {myRandomNumbers[index]}");

                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine($"Index out of range, Try again.");
                    }
                }
            }
            while (index != SENTINEL_VALUE);
        }
    }
}
