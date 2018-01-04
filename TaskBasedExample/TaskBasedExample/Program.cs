using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBasedExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Starting Tasks T1 and T2 and waiting for both to finish.");
			Task T1 = CreateTask1();
			T1.Start();

			Task T2 = CreateTask2();
			T2.Start();

			//This will generally be a spinning wheel.
			while(!T1.IsCompleted && !T2.IsCompleted)
			{
				Console.Write(".");
				System.Threading.Thread.Sleep(100);
			}

			Console.WriteLine("\nT1 and T2 have been executed.");

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Starting threads T3 and T4 and waiting for both to finish.");

			Task T3 = Task.Factory.StartNew(() =>
			{
				Random randomizer = new Random();
				int randomSleepTime = randomizer.Next(100, 5000);

				System.Threading.Thread.Sleep(randomSleepTime);
			});
			
			Task T4 = Task.Factory.StartNew(() =>
			{
				Random randomizer = new Random();
				int randomSleepTime = randomizer.Next(100, 5000);
				System.Threading.Thread.Sleep(randomSleepTime);
			});

			Task.WaitAll(new Task[] { T3, T4 });

			Console.WriteLine("T3 and T4 have been executed.");

			Console.WriteLine("---------------------------------------");

			Console.WriteLine("Starting threads T5 and T6 and T6 waits for T5 to finish.");

			Task T5 = Task.Factory.StartNew(() =>
			{
				Console.WriteLine("Starting T5.");
				Random randomizer = new Random();
				int randomSleepTime = randomizer.Next(100, 5000);

				System.Threading.Thread.Sleep(randomSleepTime);
				Console.WriteLine("Ending T5.");
			});

			Task T6 = Task.Factory.StartNew(() =>
			{
				Console.WriteLine("Starting T6 and waiting for T5.");
				T5.Wait();
				Console.WriteLine("T5 is done executing. Resuming T6");
				Random randomizer = new Random();
				int randomSleepTime = randomizer.Next(100, 5000);
				System.Threading.Thread.Sleep(randomSleepTime);
				Console.WriteLine("T6 is done executing.");
			});

			Task.WaitAll(new Task[] { T6 });

			Console.WriteLine("T5 and T6 have been executed.");

			Console.WriteLine("---------------------------------------");

			Console.WriteLine("Executing T7 to compute sleep time for T8");

			Task<int> T7 = Task.Factory.StartNew(() =>
			{
				Random randomizer = new Random();
				int randomSleepTime = randomizer.Next(100, 5000);
				System.Threading.Thread.Sleep(randomSleepTime);
				Console.WriteLine("T7 Returning {0} as sleeptime.", randomSleepTime);
				return randomSleepTime;
			});

			Task T8 = Task.Factory.StartNew(() =>
			{
				int sleepTime = T7.Result;
				Console.WriteLine("T8 using {0} sleeptime returned by T7.", sleepTime);
				System.Threading.Thread.Sleep(sleepTime);
			});

			Task.WaitAll(new Task[] { T8 });

			Console.WriteLine("T7 and T8 have been executed.");

			Console.WriteLine("---------------------------------------");

			Console.ReadKey();
		}

		static public Task CreateTask1()
		{
			Random randomizer = new Random();
			int randomSleepTime = randomizer.Next(100, 5000);

			return new Task(() => 
			{
				//Console.WriteLine("Sleeping thread for task T1 for {0}", randomSleepTime);
				System.Threading.Thread.Sleep(randomSleepTime);
				//Console.WriteLine("Awaking Task1 thread.");
			});

		}

		static public Task CreateTask2()
		{
			Random randomizer = new Random();
			int randomSleepTime = randomizer.Next(100, 5000);

			return new Task(() =>
			{
				//Console.WriteLine("Sleeping thread for task T2 for {0}", randomSleepTime);
				System.Threading.Thread.Sleep(randomSleepTime);
				//Console.WriteLine("Awaking Task2 thread.");
			});

		}
	}
}
