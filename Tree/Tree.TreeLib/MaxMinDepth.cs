using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    public class MaxMinDepth
    {

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }

        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
        
    }
}
