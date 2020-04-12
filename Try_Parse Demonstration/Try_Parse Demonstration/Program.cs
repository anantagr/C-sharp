using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Parse_Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.Write("Please enter an integer");

            if (int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine($"Conversion was successful. Integer value is {result}");
            }
            else
            {
                Console.WriteLine($"Conversion was not successful.");
            }
        }
    }
}
