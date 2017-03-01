using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Classes
{
	public class InsertionSort
	{
		public static void SortIntegers(int[] arrayOfInts)
		{
			for (int i = 1; i < arrayOfInts.Length; i++)
			{
				int currentValue = arrayOfInts[i];

				int j = i - 1;
				while (j >= 0 && arrayOfInts[j] > currentValue)
				{
					int temp = arrayOfInts[j + 1];
					arrayOfInts[j + 1] = arrayOfInts[j];
					arrayOfInts[j] = temp;

					j--;
				}
				arrayOfInts[j + 1] = currentValue;
			}
		}
	}
}
