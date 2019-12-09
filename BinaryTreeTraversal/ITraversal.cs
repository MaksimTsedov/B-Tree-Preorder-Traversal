using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    public interface ITraversal
    {
        IList<int> TraversalStrategy(TreeNode root);
    }
}
