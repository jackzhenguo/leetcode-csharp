using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;
            if (root.left == null && root.right == null)
                return true;
            if (root.left == null || root.right == null)
                return false;
            if (root.left.val != root.right.val)
                return false;
            TreeNode invertRight=invertTree(root.right);
            return isSameTree(root.left, invertRight);
        }

        //反转
        private TreeNode invertTree(TreeNode root)
        {
            if (root == null)
                return null;
            var tmp = root.left;
            root.left = root.right;
            root.right = tmp;
            invertTree(root.left);
            invertTree(root.right);
            return root;
        }

        //比较树是否相等
        private bool isSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            return p.val == q.val &&
                isSameTree(p.left, q.left) &&
                isSameTree(p.right, q.right);
        }

    }
}
