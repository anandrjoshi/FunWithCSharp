using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
	public delegate int IntEventHandler(int leftOperand, int rightOperand);

	public class Events
    {
		public event IntEventHandler PerformIntAction; 

		public int? OnPerformIntAction(int l, int r)
		{
			if(PerformIntAction != null)
			{
				return PerformIntAction(l, r);
			}
			return null;
		}
    }
}
