using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_area_verison_1
{
	class Program
	{
		static void Main(string[] args)
		{
			double baseLength;		//holds converted response of the user for the base length
			double heightLength;	//
			double area;			//

			// get the base and the height from the user

			Console.Write("Please enter the Base length: ");
			baseLength = double.Parse(Console.ReadLine());

			Console.Write("Please enter the Height length: ");
			heightLength = double.Parse(Console.ReadLine());

			// calculate the area
			area = 0.5 * baseLength * heightLength;

			// output the results
			Console.WriteLine($"A trialgle with base {baseLength} and height {heightLength} has an area of {area} ");

		}
	}
}
