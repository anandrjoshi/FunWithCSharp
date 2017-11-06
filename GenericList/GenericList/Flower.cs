using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
	public class Flower : IComparable
	{
		public int Petals { get; set; }

		public Flower(int petals)
		{
			Petals = petals;
		}

		public int CompareTo(object obj)
		{
			if (obj == null) return 1;

			Flower flower = obj as Flower;
			return Petals.CompareTo(flower.Petals);
		}
	}
}
