using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree.Classes
{
	public static class Traversal
	{
		public static void IntInOrderTraversal(Node<int> rootNode, StringBuilder output)
		{
			if (rootNode.LeftNode != null)
			{
				IntInOrderTraversal(rootNode.LeftNode, output);
			}

			output.Append(rootNode.Value);
			output.Append(" ");

			if (rootNode.RightNode != null)
			{
				IntInOrderTraversal(rootNode.RightNode, output);
			}
		}

		public static void IntPreOrderTraversal(Node<int> rootNode, StringBuilder output)
		{
			output.Append(rootNode.Value);
			output.Append(" ");

			if (rootNode.LeftNode != null)
			{
				IntPreOrderTraversal(rootNode.LeftNode, output);
			}

			if (rootNode.RightNode != null)
			{
				IntPreOrderTraversal(rootNode.RightNode, output);
			}
		}

		public static void IntPostOrderTraversal(Node<int> rootNode, StringBuilder output)
		{
			if (rootNode.LeftNode != null)
			{
				IntPostOrderTraversal(rootNode.LeftNode, output);
			}

			if (rootNode.RightNode != null)
			{
				IntPostOrderTraversal(rootNode.RightNode, output);
			}

			output.Append(rootNode.Value);
			output.Append(" ");

		}
	}
}
