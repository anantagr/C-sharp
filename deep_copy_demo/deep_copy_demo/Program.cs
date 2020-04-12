using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deep_copy_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b;

            //to do a deep copy we need
            //  1) first create a new array of same size that of original
            //  2) copy each element indivisually to new array

            //create a new array the same size as a and make b refer to it
            b = new int[a.Length];

            for(int i=0; i<a.Length; i++)
            {
                b[i] = a[i];
            }
        }
    }
}
