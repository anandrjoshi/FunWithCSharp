using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithDelegates
{
	class Program
	{
		public delegate int PerformIntOperationhandler(int leftOperand, int RightOperand);
		public delegate T PerformGenericOperationHandler<T>(T leftOperand, T rightOperand);

		static void Main(string[] args)
		{
			Console.WriteLine("Working with int calculator:");
			Console.WriteLine("-------------------------------------------------------------------------\n");

			Console.WriteLine("Adding      5 and 6 results in " + PerformIntCalculations(AddInts, 5, 6));
			Console.WriteLine("Subtracting 5 and 6 results in " + PerformIntCalculations(SubtractInts, 5, 6));
			Console.WriteLine("Multiplying 5 and 6 results in " + PerformIntCalculations(MultiplyInts, 5, 6));
			Console.WriteLine("Dividing    9 and 6 results in " + PerformIntCalculations(DivideInts, 9, 6));
			Console.WriteLine("Modulo      9 and 6 results in " + PerformIntCalculations(ModInts, 9, 6));
			Console.WriteLine("-------------------------------------------------------------------------\n");

			Console.WriteLine("Working with generic calculator:");
			Console.WriteLine("-------------------------------------------------------------------------\n");

			Console.WriteLine("Adding      3 and 7 results in " + PerformGenericCalculations(AddGeneric, 3, 7));
			Console.WriteLine("Adding      3.1 and 7.3 results in " + PerformGenericCalculations(AddGeneric, 3.1, 7.3));
			Console.WriteLine("Adding      3.4F and 7.5F results in " + PerformGenericCalculations(AddGeneric, 3.4F, 7.5F));

			//Sending AddINts and it is ok because both delegates are acutally same.
			Console.WriteLine("Adding      3 and 7 results in " + PerformGenericCalculations(AddInts, 3, 7));
			Console.ReadKey();
		}

		static int PerformIntCalculations(PerformIntOperationhandler performIntOperation, int leftOperand, int rightOperand)
		{
			return performIntOperation(leftOperand, rightOperand);
		}

		static T PerformGenericCalculations<T>(PerformGenericOperationHandler<T> performOperation, T leftOperand, T rightOperand)
		{
			return performOperation(leftOperand, rightOperand);
		}

		#region Int operations
		static int AddInts(int leftOperand, int rightOperand)
		{
			return leftOperand + rightOperand;
		}

		static int SubtractInts(int leftOperand, int rightOperand)
		{
			return leftOperand - rightOperand;
		}

		static int MultiplyInts(int leftOperand, int rightOperand)
		{
			return leftOperand * rightOperand;
		}

		static int DivideInts(int leftOperand, int rightOperand)
		{
			return leftOperand / rightOperand;
		}

		static int ModInts(int leftOperand, int rightOperand)
		{
			return leftOperand % rightOperand;
		}
		#endregion

	#region Generic Operations
		static bool ValidateDatatypes<T>()
		{
			bool returnVal = false;

			if (typeof(T) == typeof(int) ||
				typeof(T) == typeof(double) ||
				typeof(T) == typeof(long) ||
				typeof(T) == typeof(float))
			{
				returnVal = true;
			}

			return returnVal;
		}

		static T AddGeneric<T>(T leftOperand, T rightOperand)
		{
			if(!ValidateDatatypes<T>())
			{
				throw new Exception("Datatype to perform generic operation cannot be " + typeof(T)
					+ " . Validtypes are int, long, double and float.");
			}

			return (dynamic)leftOperand + (dynamic)rightOperand;
		}
	#endregion	


	}
}
