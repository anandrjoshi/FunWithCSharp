﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstForm
{
	public interface IUSState
	{
		string State_Abbrev{get; set;}

		int ID { get; set; }
	}
}
