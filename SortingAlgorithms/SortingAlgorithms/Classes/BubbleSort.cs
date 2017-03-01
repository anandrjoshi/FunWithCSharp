using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Classes
{
	public static class BubbleSort
	{
		public static void SortIntegers(int[] arrayOfInts)
		{
			int length = arrayOfInts.Length;

			while (length > 0)
			{
				for (int i = 1; i < arrayOfInts.Length; i ++)
				{
					if (arrayOfInts[i - 1] > arrayOfInts[i])
					{
						int temp = arrayOfInts[i - 1];
						arrayOfInts[i - 1] = arrayOfInts[i];
						arrayOfInts[i] = temp;
					}
				}
				length--;
			}
		}
	}
}
