/* ==============================================================================
 * 功能描述：TreeNode  
 * 创 建 者：gz
 * 创建日期：2017/4/19 12:20:32
 * ==============================================================================*/

using System;
namespace Tree.TreeLib
{
    /// <summary>
    /// TreeNode
    ///  Definition for a binary tree node.
    /// </summary>
    public class TreeNode
    {
        public TreeNode(int x)
        {
            val = x;
        }

        public int val;
        public TreeNode left;
        public TreeNode right;

        public bool isLeaf()
        {
            return left == null && right == null;
        }

        public int Height
        {
            get
            {
                if (this == null)
                    return 0;
                return 1 + Math.Max(height(this.left), height(this.right));
            }
        }
        private int height(TreeNode node)
        {
            if (node == null)
                return 0;
            return 1 + Math.Max(height(node.left), height(node.right));
        }

    }


}
