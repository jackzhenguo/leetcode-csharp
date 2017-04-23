using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    public class BanlancedTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            if (Math.Abs(root.left.Height - root.right.Height) > 1)
                return false;
            return IsBalanced(root.left) && IsBalanced(root.right);
        }


    }
}
