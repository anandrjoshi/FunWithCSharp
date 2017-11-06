using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
	public class Engine : IComparable
	{
		public int EngineCapacity { get; set; }

		public Engine(int engineCapacity)
		{
			EngineCapacity = engineCapacity;
		}

		public int CompareTo(object obj)
		{
			if (obj == null) return 1;

			Engine engine = obj as Engine;
			return EngineCapacity.CompareTo(engine.EngineCapacity);
		}
	}
}
