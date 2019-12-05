using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    public static class TreeTraversals
    {
        public static IList<int> PreorderTraversal(TreeNode root)
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
