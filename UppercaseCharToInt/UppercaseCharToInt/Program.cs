using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppercaseCharToInt
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter characters:");

			string inputString = Console.ReadLine().ToUpper();

			int convertedIntValue = ConvertStringToIntValue(inputString);

			Console.WriteLine(String.Format("int value of {0} is {1}", inputString, convertedIntValue));
			Console.ReadLine();
		}

		private static int ConvertStringToIntValue(string inputString)
		{
			if (inputString.Length == 1)
				return MultiplicationFactor(inputString.ToCharArray().First());

			int rtnVal = 0;
			char[] inputStringCharacters = inputString.ToCharArray();
			Array.Reverse(inputStringCharacters);

			int placeValueCount = 0;
			foreach (char item in inputStringCharacters)
			{
				if(placeValueCount == 0)
				{
					rtnVal = MultiplicationFactor(item);
				}

				rtnVal += MultiplicationFactor(item)*placeValueCount *26;
				placeValueCount ++;
			}

			return rtnVal;
		}

		private static int MultiplicationFactor(char character)
		{
			switch (character)
			{
				case 'A':
					return 1;
				case 'B':
					return 2;
				case 'C':
					return 3;
				case 'D':
					return 4;
				case 'E':
					return 5;
				case 'F':
					return 6;
				case 'G':
					return 7;
				case 'H':
					return 8;
				case 'I':
					return 9;
				case 'J':
					return 10;
				case 'K':
					return 11;
				case 'L':
					return 12;
				case 'M':
					return 13;
				case 'N':
					return 14;
				case 'O':
					return 15;
				case 'P':
					return 16;
				case 'Q':
					return 17;
				case 'R':
					return 18;
				case 'S':
					return 19;
				case 'T':
					return 20;
				case 'U':
					return 21;
				case 'V':
					return 22;
				case 'W':
					return 23;
				case 'X':
					return 24;
				case 'Y':
					return 25;
				case 'Z':
					return 26;
				default:
					return 0;

			}
		}
	}
}
