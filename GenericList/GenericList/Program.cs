using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
	class Program
	{
		static void Main(string[] args)
		{
			MyGenericList<Flower> flowerList = new MyGenericList<Flower>();
			MyGenericList<Engine> engineList = new MyGenericList<Engine>();

			flowerList.Add(new Flower(5));
			flowerList.Add(new Flower(7));

		}
	}
}
