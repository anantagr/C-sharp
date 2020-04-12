using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_and_foreach_with_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "10 20 30, 40 ";

            char[] delimiter = { ','  ,   ' '  ,   '\t' };

            string[] tokens = testString.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            foreach (string number in tokens)
            {
                int value = int.Parse(number);
                Console.WriteLine(value);
            }
        }
    }
}
