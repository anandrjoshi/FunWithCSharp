using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCollections
{
	public class Insects : Animals, IEnumerable<string>
	{
		private ArrayList _insects;

		public ArrayList ArrayListOfInsects
		{
			get
			{
				return _insects;
			}
			set
			{
				_insects = value;
			}
		}

		public Insects()
		{
			_insects = new ArrayList();
		}

		public void PreloadInsects()
		{
			_insects.Add("Beetle");
			_insects.Add("Butterfly");
			_insects.Add("Fire Ant");
			_insects.Add("Bee");
			_insects.Add("Ladybug");
			_insects.Add("Dragonfly");
			_insects.Add("Cricket");
			_insects.Add("Grasshopper");
			_insects.Add("Mantis");
			_insects.Add("Cicades");
		}

		override public IEnumerator<string> GetEnumerator()
		{
			foreach (string insect in _insects)
			{
				yield return insect;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
