using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCollections
{
	public class Reptiles : Animals, IEnumerable<string>
	{
		private Dictionary<string, int> _reptilesAndCount;

		public Dictionary<string, int> GetReptiles
		{
			get
			{
				return _reptilesAndCount;
			}
			set
			{
				_reptilesAndCount = value;
			}
		}

		public Reptiles()
		{
			_reptilesAndCount = new Dictionary<string, int>();
		}

		public void PreLoadReptiles()
		{
			_reptilesAndCount.Add("Snake", 10);
			_reptilesAndCount.Add("Lizard", 20);
			_reptilesAndCount.Add("Crocodile", 10);
			_reptilesAndCount.Add("Chameleon", 10);
			_reptilesAndCount.Add("Gecko", 10);
			_reptilesAndCount.Add("Turtle", 10);
			_reptilesAndCount.Add("Tortoise", 10);
			_reptilesAndCount.Add("Alligator", 10);
			_reptilesAndCount.Add("Iguana", 10);
			_reptilesAndCount.Add("Skink", 10);
			_reptilesAndCount.Add("Monitor", 10);
		}

		override public IEnumerator<string> GetEnumerator()
		{
			foreach(KeyValuePair<string, int> kvp in _reptilesAndCount)
			{
				yield return kvp.Key;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
