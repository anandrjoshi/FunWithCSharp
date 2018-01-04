using System;

namespace EventsHandlers
{
    class Program
    {
        static void Main(string[] args)
        {
			Events.Events myEvent = new Events.Events();
			myEvent.PerformIntAction += new Events.Events.IntEventHandler(PerformIntAddition);

			Console.WriteLine(myEvent.OnPerformIntAction(5, 6));
			Console.ReadKey();
        }

		static int PerformIntAddition(int leftOperand, int rightOperand)
		{
			return leftOperand + rightOperand;
		}
    }
}
