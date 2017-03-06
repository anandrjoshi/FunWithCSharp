using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequenceOfGivenInts.Classes
{
	public static class LongestSubSeqenceInt
	{
		public static int[] GetLongestSubSequence(int[] originalSequence, int[] inputSequence)
		{
			List<int> longestSubsequence = new List<int>();
			int lastSequenceEndingIndex = 0;

			while (lastSequenceEndingIndex < originalSequence.Length-1)
			{
				List<int> tempSequence =  new List<int>();
				for (int i = lastSequenceEndingIndex; i < originalSequence.Length; i++)
				{
					if(inputSequence.Contains(originalSequence[i]))
					{
						tempSequence.Add(originalSequence[i]);	
					}
					else
					{
						lastSequenceEndingIndex = i+1;
						break;
					}
				}

				if(longestSubsequence.Count < tempSequence.Count)
				{ 
					longestSubsequence = tempSequence; 
				}
			}

			return longestSubsequence.ToArray();
		}
	}
}
