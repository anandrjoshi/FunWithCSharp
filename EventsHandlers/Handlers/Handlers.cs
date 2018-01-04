using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events;

namespace Handlers
{
    public class Handlers
    {
		public void PerformAddInt(int leftOperand, int rightOperand)
		{
			Events.AddIntEventHandler addIntEventHandler = AddIntEvent;
			if (addIntEventHandler != null)
			{
				addIntEventHandler(leftOperand, rightOperand);
			}
		}
	}
}
