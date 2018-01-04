using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateImplementations
{
    public static class DelegateImplementation
    {
		public static int PerformIntAddition(int leftOperand, int rightOperand)
		{
			return leftOperand + rightOperand;
		}

		public static int PerformIntSubtraction(int leftOperand, int rightOperand)
		{
			return leftOperand - rightOperand;
		}

		public static int PerformIntMultiplication(int leftOperand, int rightOperand)
		{
			return leftOperand * rightOperand;
		}

		public static int PerformIntDivision(int leftOperand, int rightOperand)
		{
			if(rightOperand != 0)
			{
				return leftOperand / rightOperand;
			}
			else
			{
				return 0;
			}
		}
	}
}
