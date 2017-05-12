/* ==============================================================================
 * 功能描述：InorderStack  
 * 创 建 者：gz
 * 创建日期：2017/5/12 15:06:49
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

//Given a binary tree, return the inorder traversal of its nodes' values.

//For example:
//Given binary tree [1,null,2,3],
//   1
//    \
//     2
//    /
//   3
//return [1,3,2].

//Note: Recursive solution is trivial, could you do it iteratively?
namespace InorderTreeStackSln
{

    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    /// <summary>
    /// InorderStack
    /// </summary>
    public class InorderStack
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> rtn = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            if (root == null) return rtn;
            s.Push(root);                 
            while (s.Count>0)
            {     
                var tmp = s.Peek();  //tmp可能为null ，因为curNode.right可能为null         
                while (tmp != null) //tmp=null退出循环
                {
                    s.Push(tmp.left);
                    tmp = tmp.left;
                }
                s.Pop(); 
                if (s.Count == 0) 
                    return rtn;
                rtn.Add(s.Peek().val); //访问节点
                TreeNode curNode = s.Pop();
                s.Push(curNode.right);
            }
            return rtn;
        }
    }


}
