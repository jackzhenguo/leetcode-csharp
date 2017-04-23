using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    //Given a binary tree and a sum, determine if the tree has a root-to-leaf path 
    //such that adding up all the values along the path equals the given sum.

    public class OnePathSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;
            if (root.val == sum && root.isLeaf()) //判断是否加到了叶子
                return true;
            //求以root为根的路径val和等于sum的
            if (HasPathSum(root.left, sum - root.val) == true)
                return true;
            return HasPathSum(root.right, sum - root.val);
        }
    }
}
