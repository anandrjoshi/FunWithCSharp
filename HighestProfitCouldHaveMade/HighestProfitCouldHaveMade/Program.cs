using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestProfitCouldHaveMade
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] todaysApplePrices = {500.1, 499.1, 500.5, 499.4, 500.0, 499.0, 502.1, 498.1, 501.1, 499.9, 
											 501.1, 499.1, 500.5, 499.2, 503.1, 496.1, 502.1, 496.1, 505.1, 499.5,
											 502.1, 499.2, 500.6, 499.4, 503.3, 497.1, 503.1, 497.7, 506.1, 499.4,
											 503.1, 499.3, 500.7, 499.8, 504.2, 498.1, 504.1, 498.8, 503.1, 499.3};

			Console.WriteLine("Enter price at which apple share was bought:");
			
			double price = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Profit made today using iteration: {0}", 
				HighestProfitCouldHaveMade.Classes.HighestProfit.CalculateHighestProfitUsingIteration(price, todaysApplePrices));

			Console.WriteLine("Profit made today using max: {0}",
				HighestProfitCouldHaveMade.Classes.HighestProfit.CalculateHighestProfitUsingMax(price, todaysApplePrices));

			Console.ReadKey();
		}
	}
}
