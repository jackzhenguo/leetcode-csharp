using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    //二叉树的遍历，迭代版
    public class TravesalUsingStack
    {
        public void PreOrder(TreeNode root)
        {
            if (root == null)
                return;
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            Console.WriteLine(root.val);
            while(s.Count>0)
            {
                TreeNode node = (s.Peek as TreeNode).left;


            }
        }

    }
}
