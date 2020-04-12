using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welcome_to_c_sharp
{
	class Program
	{
		static void Main(string[] args)
		{
			string userName;    // where user's response from keyboard is stored

			//ask the user for their name
			Console.Write("Please enter your name: ");
			userName = Console.ReadLine();

			//combine the name with a greeting and output

			string greeting = "Hello there" + userName + ", Welcome to C# Programming!";
			Console.WriteLine(greeting);
		}
	}
}
