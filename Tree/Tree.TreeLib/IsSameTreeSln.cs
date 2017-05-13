using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeTest
{
	//572. Subtree of Another Tree
    public class IsSameTreeSln
    {
        // Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null) return false;
            if (isSame(s, t)) return true;
            //s.left-tree和t-tree是不是相等树？
            //s.right-tree和t-tree是不是相等树？
            return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }
        //判断s-tree和t-tree是不是相等树
        private bool isSame(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;
            if (s == null || t == null) return false;
            return s.val == t.val &&
                   isSame(s.left, t.left) &&
                   isSame(s.right, t.right);
        }


    }
}
