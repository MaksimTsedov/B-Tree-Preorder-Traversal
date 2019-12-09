using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    public class InorderTraversal : ITraversal
    {
        public IList<int> TraversalStrategy(TreeNode root)
        {
            IList<int> resultList = new List<int>();

            var nodeBuffer = new Stack<TreeNode>();
            while (nodeBuffer.Count != 0 || root != null)
            {
                if (root != null)
                {
                    nodeBuffer.Push(root);
                    root = root.Left;
                }
                else
                {
                    root = nodeBuffer.Pop();
                    resultList.Add(root.Val);
                    root = root.Right;
                }
            }

            return resultList;
        }
    }
}
