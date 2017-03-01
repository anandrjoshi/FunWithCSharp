using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Classes
{
	public class SelectionSort
	{
		public static void SortIntegers(int[] arrayOfInts)
		{
			for(int j = 0; j < arrayOfInts.Length-1; j++)
			{
				int currentSmallestPosition = j;
				for (int i = j+1; i < arrayOfInts.Length; i++)
				{
					if (arrayOfInts[i] < arrayOfInts[currentSmallestPosition])
					{
						currentSmallestPosition = i;
					}
				}

				if (j != currentSmallestPosition)
				{
					int temp = arrayOfInts[j];
					arrayOfInts[j] = arrayOfInts[currentSmallestPosition];
					arrayOfInts[currentSmallestPosition] = temp;
				}
			}
		}
	}
}
