using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeTest
{
    public class UniqueBSTSln
    {
        // Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0)
                return new List<TreeNode>();
            return binaryTrees(1, n);
        }
        private IList<TreeNode> binaryTrees(int start, int end)
        {
            IList<TreeNode> rtn = new List<TreeNode>();
            if (start > end)
            {
                rtn.Add(null); //care it
                return rtn;
            }
            for (int i = start; i <= end; i++)
            {
                IList<TreeNode> lefts = binaryTrees(start, i - 1);
                IList<TreeNode> rights = binaryTrees(i + 1, end);
                foreach (var leftNode in lefts)
                {
                    foreach (var rightNode in rights)
                    {
                        TreeNode root = new TreeNode(i);
                        root.left = leftNode;
                        root.right = rightNode;
                        rtn.Add(root);
                    }
                }
            }
            return rtn;
        }


    }
}
