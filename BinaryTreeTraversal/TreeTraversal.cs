using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    public class TreeTraversal
    {
        public ITraversal Traversal { private get; set; }

        public TreeTraversal(ITraversal traversal)
        {
            Traversal = traversal;
        }

        public IList<int> TraverseTree(TreeNode root)
        {
            return root == null ? new List<int>() : Traversal.TraversalStrategy(root);
        }
    }
}
