using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToInt
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter number as string:");
			string text = Console.ReadLine();

			int integer = ConvertStringToInt(text);

			Console.WriteLine("Int value = {0}", integer);

			Console.ReadKey();
		}

		private static int ConvertStringToInt(string text)
		{
			char[] input = text.Trim().ToCharArray();
			Array.Reverse(input);

			int returnValue = 0;
			int multiplier = 1;

			foreach (char c in input)
			{
				int unicode = c;
				if(unicode > 47 && unicode < 58)
				{
					returnValue += (unicode - 48) * multiplier;
					multiplier *= 10;
				}
				else if(unicode == 45)
				{
					returnValue *= -1;
				}
				else if (unicode == 43)
				{
					returnValue *= 1;
				}
				else
				{
					throw new ArgumentNullException("Invalid input.");
				}
			}

			return returnValue;
		}

		
	}
}
