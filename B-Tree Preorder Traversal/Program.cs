using System;
using System.Collections.Generic;

namespace B_Tree_Preorder_Traversal
{
    //TODO: Unit-tests
    //TODO: Some refactoring
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");
        }

        private IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> resultList = new List<int>();

            if (root == null)
            {
                return resultList;
            }

            var nodeBuffer = new Stack<TreeNode>();
            nodeBuffer.Push(root);
            while (nodeBuffer.Count != 0)
            {
                root = nodeBuffer.Pop();
                resultList.Add(root.Val);
                if (root.Right != null) nodeBuffer.Push(root.Right);
                if (root.Left != null) nodeBuffer.Push(root.Left);
            }

            return resultList;
        }
    }
}
