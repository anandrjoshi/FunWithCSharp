using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinimumGeneticMutation
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> geneBank = ReadGeneBank();

			Console.WriteLine("Enter start gene sequence:");
			string startSequence = Console.ReadLine();

			Console.WriteLine("Enter end gene sequence:");
			string endSequence = Console.ReadLine();

			Console.WriteLine("{0}, {1}", startSequence, endSequence);

			string[] temp = geneBank.ToArray();

			int numberOfMutations = CalcutateMutations(startSequence, endSequence, temp);
			Console.ReadKey();
		}

		private static List<string> ReadGeneBank()
		{
			List<string> geneBank = new List<string>();
			const Int32 BufferSize = 128;
			using (var fileStream = File.OpenRead(@"G:\CSharp\CSharp\MinimumGeneticMutation\ConsoleApplication1\ConsoleApplication1\GeneBank.txt"))
			using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
			{
				String line;
				while ((line = streamReader.ReadLine()) != null)
				{
					geneBank.Add(line);
				}
			}
			return geneBank;
		}

		private static int CalcutateMutations(string startSequence, string endSequence, string[] geneBank)
		{
			StringBuilder currentSequence = new StringBuilder(startSequence);
			int mutations = 0;
			
			if(!ValidateInputs(startSequence, endSequence, geneBank))
			{
				Console.WriteLine("Invalid inputs.");
				return -1;
			}
			for (int i = startSequence.Length -1; i >= 0 ; i--)
			{
				if(startSequence[i] != endSequence[i])
				{
					currentSequence.Remove(i, 1);
					currentSequence.Insert(i, endSequence[i]);

					foreach(string sequence in geneBank)
					{
						if(String.Compare(sequence, currentSequence.ToString()) == 0)
						{
							mutations++;
							break;
						}
					}

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

		private static bool ValidateInputs(string startSequence, string endSequence, string[] geneBank)
		{
			if(startSequence.Length != endSequence.Length)
			{
				return false;
			}
			else if(geneBank.Length == 0)
			{
				return false;
			}
			else if(startSequence.Length != 8)
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
