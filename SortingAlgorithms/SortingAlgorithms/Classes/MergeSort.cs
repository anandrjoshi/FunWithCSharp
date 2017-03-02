using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Classes
{
	public class MergeSort
	{
		public static int[] SortIntegers(int[] arrayOfInts)
		{
			return DoMergeSort(arrayOfInts);
		}

		private static int[] DoMergeSort(int[] arrayOfInts)
		{
			if (arrayOfInts.Length > 1)
			{
				int[] lowerHalf = GetHalf(arrayOfInts, 0, arrayOfInts.Length/2);
				int[] upperHalf = GetHalf(arrayOfInts, arrayOfInts.Length/2, arrayOfInts.Length);

				lowerHalf = DoMergeSort(lowerHalf);
				upperHalf = DoMergeSort(upperHalf);

				return Merge(lowerHalf, upperHalf);
			}
			return arrayOfInts;
		}

		private static int[] Merge(int[] lowerHalf, int[] upperHalf)
		{
			List<int> sortedArrayOfInts = new List<int>();

			while (lowerHalf.Length > 0 && upperHalf.Length > 0)
			{
				if (lowerHalf[0] > upperHalf[0])
				{
					sortedArrayOfInts.Add(upperHalf[0]);
					upperHalf = RemoveAtZeroPosition(upperHalf);
				}

				else
				{
					sortedArrayOfInts.Add(lowerHalf[0]);
					lowerHalf = RemoveAtZeroPosition(lowerHalf);
				}
			}

			while (lowerHalf.Length > 0)
			{
				sortedArrayOfInts.Add(lowerHalf[0]);
				lowerHalf = RemoveAtZeroPosition(lowerHalf);
			}

			while (upperHalf.Length > 0)
			{
				sortedArrayOfInts.Add(upperHalf[0]);
				upperHalf = RemoveAtZeroPosition(upperHalf);
			}
			return sortedArrayOfInts.ToArray();
		}

		private static int[] RemoveAtZeroPosition(int[] half)
		{
			if (half.Length > 1)
			{
				int[] remainingHalf = new int[half.Length-1];
				for (int i = 1; i < half.Length; i++)
				{
					remainingHalf[i - 1] = half[i];
				}

				return remainingHalf;
			}
			return new int[0];
		}

		private static int[] GetHalf(int[] arrayOfInts, int low, int high)
		{
			List<int> newListInt = new List<int>();

			for (int i = low; i < high; i++)
			{
				newListInt.Add(arrayOfInts[i]);
			}

			return newListInt.ToArray();
		}
	}
}
