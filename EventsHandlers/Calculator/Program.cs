using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Events.Events myEvent = new Events.Events();
			myEvent.PerformIntAction += new Events.IntEventHandler(
				DelegateImplementations.DelegateImplementation.PerformIntAddition);

			Console.WriteLine(String.Format("Performing Addition = {0}",myEvent.OnPerformIntAction(5, 6)));

			myEvent.PerformIntAction -= DelegateImplementations.DelegateImplementation.PerformIntAddition;

			myEvent.PerformIntAction += new Events.IntEventHandler(
				DelegateImplementations.DelegateImplementation.PerformIntSubtraction);

			Console.WriteLine(String.Format("Performing Subtraction = {0}", myEvent.OnPerformIntAction(11, 6)));

			myEvent.PerformIntAction -= DelegateImplementations.DelegateImplementation.PerformIntSubtraction;

			myEvent.PerformIntAction += new Events.IntEventHandler(
				DelegateImplementations.DelegateImplementation.PerformIntMultiplication);

			Console.WriteLine(String.Format("Performing Multiplication = {0}", myEvent.OnPerformIntAction(5, 6)));

			myEvent.PerformIntAction -= DelegateImplementations.DelegateImplementation.PerformIntMultiplication;

			myEvent.PerformIntAction += new Events.IntEventHandler(
				DelegateImplementations.DelegateImplementation.PerformIntDivision);

			Console.WriteLine(String.Format("Performing Division = {0}", myEvent.OnPerformIntAction(5, 2)));

			myEvent.PerformIntAction -= DelegateImplementations.DelegateImplementation.PerformIntDivision;

			Console.ReadKey();
		}

		
	}
}
