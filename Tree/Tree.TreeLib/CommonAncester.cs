using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    public class CommonAncester
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            if (p == root || q == root) //等于root，则最小祖先一定为root
                return root;
            bool pOnLeft = isOn(root.left, p);
            bool qOnLeft = isOn(root.left, q);
            if (pOnLeft != qOnLeft)
                return root;
            if (pOnLeft == true && qOnLeft == true)
                return LowestCommonAncestor(root.left, p, q);
            return LowestCommonAncestor(root.right, p, q);
        }
        //位于node上吗
        private bool isOn(TreeNode node, TreeNode goal)
        {
            if (goal == null)
                return true;
            if (node == null)
                return false;
            if (node == goal)
                return true;
            if (isOn(node.left, goal) == true || isOn(node.right, goal) == true)
                return true;
            return false;
        }
    }
}
