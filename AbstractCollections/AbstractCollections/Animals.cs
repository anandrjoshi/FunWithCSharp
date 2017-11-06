using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCollections
{
	public abstract class Animals : IEnumerable<string>
	{
		abstract public IEnumerator<string> GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
		
	}
}
