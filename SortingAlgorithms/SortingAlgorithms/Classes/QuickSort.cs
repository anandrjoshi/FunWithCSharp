using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Classes
{
	public class QuickSort
	{
		public static void SortIntegers(int[] arrayOfInts)
		{
			DoQuickSort(arrayOfInts, 0, arrayOfInts.Length-1);
		}

		private static void DoQuickSort(int[] arrayOfInts, int low, int high)
		{
			if(low < high)
			{
				int pivot = Partition(arrayOfInts, low, high);
				DoQuickSort(arrayOfInts, low, pivot-1);
				DoQuickSort(arrayOfInts, pivot+1, high);
			}
		}

		private static int Partition(int[] arrayOfInts, int low, int high)
		{
			int pivot = arrayOfInts[low];
			int i = low;

			for(int j = low+1; j < high+1; j++)
			{
				if(arrayOfInts[j] <= pivot)
				{
					i++;
					int temp = arrayOfInts[i];
					arrayOfInts[i] = arrayOfInts[j];
					arrayOfInts[j] = temp;
				}
			}

			int temp1 = arrayOfInts[i];
			arrayOfInts[i] = arrayOfInts[low];
			arrayOfInts[low] = temp1;

			return i ;
		}
	}
}
