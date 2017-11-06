using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCollections
{
	public class Birds : Animals, IEnumerable<String>
	{
		private string[] _birds;

		public String[] ArrayOfBirds
		{
			get
			{
				return _birds;
			}
			set
			{
				_birds = value;
			}
		}

		public Birds()
		{
			string[] birds = { "Pelican", "Stork", "Penguin", "Seagull", "Kite", "Falcon", "Eagle", "Sparrow"};
			_birds = birds;
		}

		public override IEnumerator<string> GetEnumerator()
		{
			for(int i = 0; i < _birds.Length - 1; i ++)
			{
				yield return _birds[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
