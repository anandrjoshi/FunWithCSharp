using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCollections
{
	public class Mammals : Animals, IEnumerable<string>
	{
		private List<string> _mammals;
		public List<string> ListOfMammals
		{
			get
			{
				return _mammals;
			}
			set
			{
				_mammals = value;
			}
		}

		public Mammals()
		{
			_mammals = new List<string>();
		}

		public void PreLoadMammals()
		{
			_mammals.Clear();

			_mammals.Add("Elephant");
			_mammals.Add("Panda");
			_mammals.Add("Red Panda");
			_mammals.Add("Giraffe");
			_mammals.Add("Zebra");
			_mammals.Add("Rhino");
			_mammals.Add("Lion");
			_mammals.Add("Tiger");
			_mammals.Add("Leopard");
			_mammals.Add("Kangaroo");
			_mammals.Add("Bison");

		}
		
		public override IEnumerator<string> GetEnumerator()
		{
			foreach (string mammal in _mammals)
			{
				yield return mammal;
			}
		}
	}
}
