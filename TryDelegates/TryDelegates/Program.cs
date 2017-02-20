using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDelegates
{
	class Program
	{
		delegate string DateTimeToString(DateTime time);

		static void Main(string[] args)
		{
			DateTimeToString dateFirst = new DateTimeToString(DateFirst);

			DateTimeToString yearFirst = new DateTimeToString(YearFirst);

			Console.WriteLine("Time:" + DateTime.Now);
			Console.WriteLine("DateFirst Time:" + dateFirst(DateTime.Now));
			Console.WriteLine("YearFirst Time:" + yearFirst(DateTime.Now));
			Console.ReadKey();
		}

		public static string DateFirst(DateTime time)
		{
			StringBuilder timeString = new StringBuilder();

			timeString.Append(time.Day);
			timeString.Append("/");
			timeString.Append(time.Month);
			timeString.Append("/");
			timeString.Append(time.Year);
			timeString.Append(" ");

			timeString.Append(time.Hour > 11 ? time.Hour -12 : time.Hour);
			timeString.Append(":");
			timeString.Append(time.Minute);
			timeString.Append(":");
			timeString.Append(time.Second);
			timeString.Append(":");
			timeString.Append(time.Hour < 11 ? "AM" : "PM");

			return timeString.ToString();
		}

		public static string YearFirst(DateTime time)
		{
			StringBuilder timeString = new StringBuilder();

			timeString.Append(time.Year);
			timeString.Append("/");
			timeString.Append(time.Month);
			timeString.Append("/");
			timeString.Append(time.Day);
			timeString.Append(" ");

			timeString.Append(time.Hour > 11 ? time.Hour - 12 : time.Hour);
			timeString.Append(":");
			timeString.Append(time.Minute);
			timeString.Append(":");
			timeString.Append(time.Second);
			timeString.Append(":");
			timeString.Append(time.Hour < 11 ? "AM" : "PM");

			return timeString.ToString();
		}
	}
}
