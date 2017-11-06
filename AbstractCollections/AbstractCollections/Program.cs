using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCollections
{
	class Program
	{
		static void Main(string[] args)
		{
			Mammals mammals = new Mammals();
			mammals.PreLoadMammals();

			//In order to print mammals, reptiles, birds and insects below piece of code needs to be duplicated.
			//In order to avoid this implementing a single function that prints the animal.
			//foreach(string mammal in mammals)
			//{
			//	Console.WriteLine("Our Zoo has " + mammal);
			//}

			PrintAnimals(mammals);

			Birds birds = new Birds();
			PrintAnimals(birds);

			Insects insects = new Insects();
			insects.PreloadInsects();
			PrintAnimals(insects);

			Reptiles reptiles = new Reptiles();
			reptiles.PreLoadReptiles();
			PrintAnimals(reptiles);

			Console.ReadKey();
		}

		private static void PrintAnimals(Animals animals)
		{
			foreach(string animal in animals)
			{
				Console.WriteLine("Our Zoo has " +animal);
			}
		}
	}
}
