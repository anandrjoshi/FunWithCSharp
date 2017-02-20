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

			int numberOfMutations = CalcutateMutations(startSequence, endSequence);
			Console.ReadKey();
		}

		private static int CalcutateMutations(string startSequence, string endSequence)
		{
			StringBuilder currentSequence = new StringBuilder(startSequence);
			int mutations = 0;
			
			if(!ValidateInputs(startSequence, endSequence))
			{
				Console.WriteLine("Invalid inputs.");
				return -1;
			}
			for (int i = 0; i < startSequence.Length; i++)
			{
				if(startSequence[i] != endSequence[i])
				{
					currentSequence.Remove(i, 1);
					currentSequence.Insert(i, endSequence[i]);

					mutations++;

					Console.WriteLine("CurrentSequence = {0}", currentSequence);
					Console.WriteLine("Mutation Count = {0}", mutations);
				}
				else
				{
					Console.WriteLine("No mutation at position {0}", i);
				}
				
			}
			
			return mutations;
		}

		private static bool ValidateInputs(string startSequence, string endSequence)
		{
			if(startSequence.Length != endSequence.Length)
			{
				return false;
			}
			else if(!ValidateCorrectGenes(startSequence))
			{
				return false;
			}
			else if (!ValidateCorrectGenes(endSequence))
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		private static bool ValidateCorrectGenes(string sequence)
		{
			foreach(char c in sequence)
			{
				if(c == 'A' || c == 'C' || c == 'G' || c == 'T')
				{
					continue;
				}
				return false;
			}
			return true;
		}
	}
}
