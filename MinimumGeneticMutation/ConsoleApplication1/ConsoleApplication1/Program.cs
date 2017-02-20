using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumGeneticMutation
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter start gene sequence:");
			string startSequence = Console.ReadLine();

			Console.WriteLine("Enter end gene sequence:");
			string endSequence = Console.ReadLine();

			Console.WriteLine("{0}, {1}", startSequence, endSequence);

			Console.ReadKey();
		}
	}
}
