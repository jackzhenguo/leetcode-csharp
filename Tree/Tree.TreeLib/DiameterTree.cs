using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    public class DiameterTree
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
                return 0;
            int max = Math.Max(nodeDiameter(root), DiameterOfBinaryTree(root.left));
            return Math.Max(max, DiameterOfBinaryTree(root.right));
        }

        private int nodeDiameter(TreeNode node)
        {
            if (node == null)
                return 0;
            int sum=0;
            if (node.left != null)
                sum += node.left.Height;
            if (node.right != null)
                sum += node.right.Height;
            return sum;
        }


    }
}




