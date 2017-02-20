using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithNumbers
{
	class Program
	{
		public delegate void PrintSequence(int[] sequence);
		public delegate int[] GenerateSequence(int number);

		static void Main(string[] args)
		{
			
			do
			{
				Console.Clear();
				Console.WriteLine("Enter the number of inputs for the sequence:");
				string input = Console.ReadLine();
				int n;

				Int32.TryParse(input, out n);

				GenerateSequence fibonaccisequenceHandler = GenerateFibonacciSequence;
				GenerateSequence triangleSequenceHandler = GenerateTriangleSequence;
				int[] fibonacciSequence = fibonaccisequenceHandler(n);
				int[] triangleSequence = triangleSequenceHandler(n);
				
				PrintSequence printFibonacciSequenceHandler = PrintFibonacciSequence;
				printFibonacciSequenceHandler(fibonacciSequence);

				PrintSequence printTriangleSequenceHandler = PrintTriangleSequence;
				printTriangleSequenceHandler(triangleSequence);

				Console.WriteLine("DO you want to continue(y/n).");


			} while (string.Compare(Console.ReadLine(), "y") == 0);
		}

		private static void PrintTriangleSequence(int[] sequence)
		{
			Console.WriteLine("Triangle sequence for first {0} numbers is:", sequence.Count());

			foreach (int i in sequence)
			{
				Console.WriteLine(i);
			}
		}

		private static int[] GenerateTriangleSequence(int number)
		{
			int[] triangleSequence = new int[number];

			if (number == 1)
			{
				triangleSequence[0] = 1;
				return triangleSequence;
			}
			else if (number == 2)
			{
				triangleSequence[0] = 1;
				triangleSequence[1] = 3;
				return triangleSequence;
			}
			else if (number > 2)
			{
				for (int i = 1; i <= number; i++)
				{
					triangleSequence[i-1] = i*(i+1)/2;
				}
				return triangleSequence;
			}
			else
			{
				Console.WriteLine("Incorrect input.");
				return null;
			}
		}

		private static void PrintFibonacciSequence(int[] sequence)
		{
			Console.WriteLine("Fibonacci sequence for first {0} numbers is:", sequence.Count());

			foreach (int i in sequence)
			{
				Console.WriteLine(i);
			}
		}

		private static int[] GenerateFibonacciSequence(int n)
		{
			int[] fibonacciSequence = new int[n];
			
			if(n == 1)
			{
				fibonacciSequence[0] = 1;
				return fibonacciSequence;
			}
			else if(n == 2)
			{
				fibonacciSequence[0] = 1;
				fibonacciSequence[1] = 1;
				return fibonacciSequence;
			}
			else if(n > 2)
			{
				fibonacciSequence[0] = 1;
				fibonacciSequence[1] = 1;
				for(int i = 2; i < n; i++)
				{
					fibonacciSequence[i] = fibonacciSequence[i-1] + fibonacciSequence[i-2]; 
				}
				return fibonacciSequence;
			}
			else
			{
				Console.WriteLine("Incorrect input.");
				return null;
			}
		}
	}
}
