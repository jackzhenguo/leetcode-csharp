using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    public class LeftLeafSum
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
                return 0;
            int sum=0;
            if (root.left!=null && root.isLeaf())//左叶子
                sum += root.left.val;
            sum += SumOfLeftLeaves(root.left);
            sum += SumOfLeftLeaves(root.right);
            return sum;
        }
    }
}
