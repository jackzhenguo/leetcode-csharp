using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
//    Invert a binary tree.

//     4
//   /   \
//  2     7
// / \   / \
//1   3 6   9
//to
//     4
//   /   \
//  7     2
// / \   / \
//9   6 3   1
    public class InvertTree
    {
        public TreeNode Invert(TreeNode root)
        {
            if (root == null)
                return null;
            var tmp = root.left;
            root.left = root.right;
            root.right = tmp;
            Invert(root.left);
            Invert(root.right);
            return root;
        }
    }
}
