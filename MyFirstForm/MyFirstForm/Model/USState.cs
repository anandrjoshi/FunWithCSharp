using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstForm
{
	public class USState : IUSState
	{
		public int ID { get; set; }

		public string State_Abbrev { get; set; }

		public string State_Description { get; set; }
	}
}
