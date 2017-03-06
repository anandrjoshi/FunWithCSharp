using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequenceOfGivenInts
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] originalSequence = { 1, 2, 2, 3, 2, 4, 5, 5, 3, 3, 4, 3, 2, 4, 1, 5, 6, 5, 3, 5 };
			int[] inputSequence = {2,3,4};

			int[] longestSubSequence =
				LongestSequenceOfGivenInts.Classes.LongestSubSeqenceInt.GetLongestSubSequence(originalSequence, inputSequence);

			string outputString = "";
			foreach(int i in longestSubSequence)
			{
				outputString += i;
				outputString += ",";
			}

			Console.WriteLine("Longest Subsequence: {0}", outputString);
			Console.ReadKey();
		}
	}
}
