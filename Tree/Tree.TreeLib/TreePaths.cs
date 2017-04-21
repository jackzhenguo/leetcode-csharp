using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    public class TreePaths
    {
            //Given a binary tree, return all root-to-leaf paths.
            //For example, given the following binary tree:
            //   1
            // /   \
            //2     3
            // \
            //  5
            //All root-to-leaf paths are:
            //["1->2->5", "1->3"]
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            if (root == null)
                return new List<string>();
            if (root.left == null && root.right == null)
                return new List<string> { root.val.ToString() };
            IList<string> rtn = new List<string>();
            IList<string> rtnleft =  BinaryTreePaths(root.left);//左子树路径
            foreach(var item in rtnleft)//左子树都继承于根节点
                rtn.Add(root.val + "->" + item);
            IList<string> rtnright = BinaryTreePaths(root.right);
            foreach (var item in rtnright)
                rtn.Add(root.val + "->" + item);
            return rtn;
        }
    }
}
