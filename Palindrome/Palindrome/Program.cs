using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter input string:");
			string inputString = Console.ReadLine();

			bool isStringPalindrome = Palindrome.Classes.Palindrome.CheckPalindromeString(inputString);
			string outputString = isStringPalindrome ? "is Palindrome" : "is not Plaindrome";

			Console.WriteLine("Input string {0} : {1}", inputString, outputString);

			Console.WriteLine("Enter input int:");
			int inputInt = Convert.ToInt32(Console.ReadLine());

			bool isIntPalindrome = Palindrome.Classes.Palindrome.CheckPalindromeInt(inputInt);
			outputString = isIntPalindrome ? "is Palindrome" : "is not Plaindrome";

			Console.WriteLine("Input int {0} : {1}", inputInt, outputString);
			Console.ReadKey();
		}
	}
}
