using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestProfitCouldHaveMade.Classes
{
	public class HighestProfit
	{
		public static double CalculateHighestProfitUsingIteration(double yesterdayPrice, double[] todaysPrices)
		{
			double highestRunningProfit = 0;

			for (int i = 0; i < todaysPrices.Length; i++ )
			{
				if(highestRunningProfit < (todaysPrices[i] - yesterdayPrice))
				{
					highestRunningProfit = (todaysPrices[i] - yesterdayPrice);
				}
			}
			return highestRunningProfit;
		}

		public static double CalculateHighestProfitUsingMax(double yesterdayPrice, double[] todaysPrices)
		{
			double maxDayValue = todaysPrices.Max();

			return maxDayValue-yesterdayPrice;
		}
	}
}
