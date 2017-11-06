using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
	public class MyGenericList<T> where T : IComparable
	{
		private List<T> collection;

		public MyGenericList()
		{
			collection = new List<T>();
		}

		public void Add(T item)
		{
			collection.Add(item);
		}

		public T First<T>()
		{
			if (collection.Count == 0)
			{
				throw new Exception("Collection has no items.");
			}
			else if(collection.Count == 1)
			{
				return collection.First(); 
			}

		}
	}
}
