using System.Collections.Generic;

namespace BinaryTreeTraversal
{
     public class PreorderTraversal : ITraversal
    {
        public IList<int> TraversalStrategy(TreeNode root)
        {
            IList<int> resultList = new List<int>();
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
