using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.Classes;

namespace SortingAlgorithms
{
	class Program
	{
		public delegate void SortingAlgorithm(int[] arrayOfInts);

		static void Main(string[] args)
		{
			int[] arrayOfInts = {36,35,40,39,30,5,14,13,16,17,18,20,83,84,24,28,27,26,10,90,89,78,67,48,68,97,
									56,45,43,31,22,94,34,43,56,37,98,58,98,87,84,81,71,51,50,42,49,47,75,91,
									64,63,08,84,86,88,31,51,76,87,95,92,66,55,44,33,22,11,88,99,80,60,59,82,
									4,6,7,2,31,51,62,21,32,25,21,29,99,94,76,54,84,03,45,69,87,22,85,53,73,
									11,1,23,45,12,34,67,34,89,77,16,01,38,90,56,65,33,17,19,2,9,87,88,57,74,
									54,93,96,52,77,6,89,32,54,89,44,46,41,76,72,70,86,84,31,07,61,67,63};

			int[] bubbleSortInputArray = arrayOfInts.Clone() as int[];

			Stopwatch watchBubbleSort = DoSortIntegers(BubbleSort.SortIntegers, bubbleSortInputArray);

			Console.WriteLine("Sorted Array with Bubble Sort = {0} ", BuildOutputString(bubbleSortInputArray));
			Console.WriteLine("Time taken for Bubble Sort = {0} ", watchBubbleSort.ElapsedTicks);

			int[] selectionSortInputArray = arrayOfInts.Clone() as int[];

			Stopwatch watchSelectionSort = DoSortIntegers(SelectionSort.SortIntegers, selectionSortInputArray);

			Console.WriteLine("Sorted Array with Selection Sort = {0} ", BuildOutputString(selectionSortInputArray));
			Console.WriteLine("Time taken for Selection Sort = {0} ", watchSelectionSort.ElapsedTicks);

			int[] insertionSortInputArray = arrayOfInts.Clone() as int[];

			Stopwatch watchInsertionSort = DoSortIntegers(InsertionSort.SortIntegers, insertionSortInputArray);

			Console.WriteLine("Sorted Array with Insertion Sort = {0} ", BuildOutputString(insertionSortInputArray));
			Console.WriteLine("Time taken for Insertion Sort = {0} ", watchInsertionSort.ElapsedTicks);

			int[] quickSortInputArray = arrayOfInts.Clone() as int[];

			Stopwatch watchQuickSort = DoSortIntegers(QuickSort.SortIntegers, quickSortInputArray);

			Console.WriteLine("Sorted Array with Quick Sort = {0} ", BuildOutputString(quickSortInputArray));
			Console.WriteLine("Time taken for Quick Sort = {0} ", watchQuickSort.ElapsedTicks);

			Console.ReadKey();
		}

		private static string BuildOutputString(int[] array)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("[ ");

			foreach (int i in array)
			{
				stringBuilder.Append(i);
				stringBuilder.Append(",");
			}

			stringBuilder.Append(" ]");

			return stringBuilder.ToString();
		}

		private static Stopwatch DoSortIntegers(SortingAlgorithm algorithm, int[] arrayInts)
		{
			Stopwatch watch = new Stopwatch();
			watch.Start();
			algorithm(arrayInts);
			watch.Stop();

			return watch;
		}
	}
}
