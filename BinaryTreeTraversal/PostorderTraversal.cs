using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    public class PostorderTraversal : ITraversal
    {
        public IList<int> TraversalStrategy(TreeNode root)
        {
            var resultList = new List<int>();
            var nodeBuffer = new Stack<TreeNode>();

            nodeBuffer.Push(root);
            while (nodeBuffer.Count != 0)
            {
                root = nodeBuffer.Pop();
                resultList.Add(root.Val);
                if (root.Left != null) nodeBuffer.Push(root.Left);
                if (root.Right != null) nodeBuffer.Push(root.Right);
            }

            resultList.Reverse();

            return resultList;
        }
    }
}
