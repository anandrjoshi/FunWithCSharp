using System;
using System.Collections.Generic;
using System.Text;
using BinarySearchTree.Classes;

namespace BinarySearchTree
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> inputs = new List<int> { 6, 2, 7, 1, 4, 9, 3, 5, 8 };
			Node<int> rootNode = Classes.BinarySearchTree.GenerateIntBST(inputs);

			StringBuilder output = new StringBuilder();
			Traversal.IntInOrderTraversal(rootNode, output);

			Console.WriteLine("Inorder sequence: {0}", output);

			output.Clear();
			Traversal.IntPreOrderTraversal(rootNode, output);

			Console.WriteLine("Preorder sequence: {0}", output);

			output.Clear();
			Traversal.IntPostOrderTraversal(rootNode, output);

			Console.WriteLine("Postorder sequence: {0}", output);

			Console.ReadKey();
		}
	}
}
