using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("My Dictionary");
			MyDictionary<int, int> intDict = new MyDictionary<int, int>();

			intDict.Insert(0, 5);
			intDict.Insert(1, 4);
			intDict.Insert(2, 3);
			intDict.Insert(3, 6);
			intDict.Insert(4, 7);
			//intDict.Insert(4, 1);

			foreach(Tuple<int, int> kvp in intDict)
			{
				Console.WriteLine(String.Format("Key: {0} :: Value {1}", kvp.Item1, kvp.Item2));
			}

			int value;
			bool found = intDict.GetValueByKey(3, out value);
			Console.WriteLine(String.Format("Value at key 3 is {0}, value found = {1}", value, found));
			found = intDict.GetValueByKey(10, out value);
			Console.WriteLine(String.Format("Value key 10 found = {0}", found));
			Console.WriteLine("------------------------------------------");

			MyDictionary<int, string> intStringDict = new MyDictionary<int, string>();

			intStringDict.Insert(0, "First");
			intStringDict.Insert(1, "Second");
			intStringDict.Insert(2, "Third");
			intStringDict.Insert(3, "Fourth");
			intStringDict.Insert(4, "Fifth");
			intStringDict.Insert(5, "Sixth");

			foreach (Tuple<int, string> kvp in intStringDict)
			{
				Console.WriteLine(String.Format("Key: {0} :: Value {1}", kvp.Item1, kvp.Item2));
			}

			Console.WriteLine("------------------------------------------");


			MyDictionary<string, string> stringStringDict = new MyDictionary<string, string>();

			stringStringDict.Insert("Zero", "First");
			stringStringDict.Insert("One", "Second");
			stringStringDict.Insert("Two", "Third");
			stringStringDict.Insert("Three", "Fourth");
			stringStringDict.Insert("Four", "Fifth");
			stringStringDict.Insert("Five", "Sixth");

			foreach (Tuple<string, string> kvp in stringStringDict)
			{
				Console.WriteLine(String.Format("Key: {0} :: Value {1}", kvp.Item1, kvp.Item2));
			}

			Console.WriteLine("------------------------------------------");

			Console.WriteLine("Removing Key Five...");
			stringStringDict.RemoveKey("Five");

			foreach (Tuple<string, string> kvp in stringStringDict)
			{
				Console.WriteLine(String.Format("Key: {0} :: Value {1}", kvp.Item1, kvp.Item2));
			}

			Console.WriteLine("------------------------------------------");

			Console.WriteLine("Removing Key Four...");
			stringStringDict.RemoveKey("Four");

			foreach (Tuple<string, string> kvp in stringStringDict)
			{
				Console.WriteLine(String.Format("Key: {0} :: Value {1}", kvp.Item1, kvp.Item2));
			}

			Console.WriteLine("------------------------------------------");

			Console.WriteLine("Removing Key Three...");
			stringStringDict.RemoveKey("Three");

			foreach (Tuple<string, string> kvp in stringStringDict)
			{
				Console.WriteLine(String.Format("Key: {0} :: Value {1}", kvp.Item1, kvp.Item2));
			}

			Console.WriteLine("------------------------------------------");

			Console.WriteLine("Removing Key Two...");
			stringStringDict.RemoveKey("Two");

			foreach (Tuple<string, string> kvp in stringStringDict)
			{
				Console.WriteLine(String.Format("Key: {0} :: Value {1}", kvp.Item1, kvp.Item2));
			}

			Console.WriteLine("------------------------------------------");

			Console.WriteLine("Removing Key One...");
			stringStringDict.RemoveKey("One");

			foreach (Tuple<string, string> kvp in stringStringDict)
			{
				Console.WriteLine(String.Format("Key: {0} :: Value {1}", kvp.Item1, kvp.Item2));
			}

			Console.WriteLine("------------------------------------------");

			Console.WriteLine("Removing Key Zero...");
			stringStringDict.RemoveKey("Zero");

			foreach (Tuple<string, string> kvp in stringStringDict)
			{
				Console.WriteLine(String.Format("Key: {0} :: Value {1}", kvp.Item1, kvp.Item2));
			}
			Console.WriteLine("------------------------------------------");

			Console.WriteLine("Removing Key Zero...");
			stringStringDict.RemoveKey("Zero");

			foreach (Tuple<string, string> kvp in stringStringDict)
			{
				Console.WriteLine(String.Format("Key: {0} :: Value {1}", kvp.Item1, kvp.Item2));
			}
			Console.WriteLine("------------------------------------------");

			stringStringDict.Insert("Zero", "First");
			foreach (Tuple<string, string> kvp in stringStringDict)
			{
				Console.WriteLine(String.Format("Key: {0} :: Value {1}", kvp.Item1, kvp.Item2));
			}
			Console.WriteLine("------------------------------------------");

			Console.WriteLine("Press any key to contiue...");
			Console.ReadKey();
		}
    }
}
