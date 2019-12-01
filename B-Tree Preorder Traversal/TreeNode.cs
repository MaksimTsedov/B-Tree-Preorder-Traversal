using System;
using System.Collections.Generic;
using System.Text;

namespace B_Tree_Preorder_Traversal
{
    public class TreeNode : ICloneable
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int x)
        {
            Val = x;
        }

        public object Clone()
        {
            TreeNode clone = new TreeNode(this.Val);
            clone.Left = this.Left;
            clone.Right = this.Right;
            return clone;
        }
    }
}
