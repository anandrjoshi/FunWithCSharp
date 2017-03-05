using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Classes
{
	public static class Palindrome
	{
		public static bool CheckPalindromeString(string inputString)
		{
			char[] inputASCharArray = inputString.ToCharArray();

			for (int i = 0; i < inputASCharArray.Length / 2; i++)
			{
				if(inputASCharArray[i] != inputASCharArray[inputASCharArray.Length - 1 - i])
				{
					return false;
				}
			}
			return true;
		}

		public static bool CheckPalindromeInt(int inputInt)
		{
			string inputIntAsString = Convert.ToString(inputInt < 0 ? inputInt*-1 : inputInt);
			int length = inputIntAsString.Length;

			int[] arrayOfInts = new int[length];

			for (int i = length; i > 0; i-- )
			{
				arrayOfInts[i-1] = Convert.ToInt32(Convert.ToInt64(inputInt) / Convert.ToInt64(Math.Pow(10, (i - 1))));
				inputInt -= Convert.ToInt32(Convert.ToInt64(arrayOfInts[i - 1]) * Convert.ToInt64(Math.Pow(10, (i - 1))));
			}

			for (int i = 0; i < arrayOfInts.Length/2; i++ )
			{
				if (arrayOfInts[i] != arrayOfInts[arrayOfInts.Length - 1 - i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
