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
			int[] arrayOfInts = {22,11,1,23,45,12,34,67,34,89,77,16,01,38,90,56,65,33,17,19,2,9,87,54,93,96,52,77,6,89,32,54,89,44,46,41,76,72,70,86,84,31,07,61,67,63};

			int[] tempArray = arrayOfInts.Clone() as int[];

			Stopwatch watch = DoSortIntegers(BubbleSort.SortIntegers, tempArray);

			Console.WriteLine("Un Sorted Array = {0} ", BuildOutputString(arrayOfInts));
			Console.WriteLine("Sorted Array = {0} ", BuildOutputString(tempArray));
			Console.WriteLine("Time taken = {0} ", watch.ElapsedTicks);

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
