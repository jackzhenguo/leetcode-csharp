/* ==============================================================================
 * 功能描述：PreorderStack  
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


    /// <summary>
    /// InorderStack
    /// </summary>
    public class PreorderStack
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> rtn = new List<int>();
            if (root == null) return rtn;

            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            TreeNode tmp = root;
            while (s.Count > 0)
            {
                if (tmp == null)
                    tmp = s.Peek(); 
                rtn.Add(s.Peek().val);
                s.Pop();
                if(tmp.right!=null)
                   s.Push(tmp.right);
                if (tmp.left != null)
                    s.Push(tmp.left);
                tmp = tmp.left;
            }
            return rtn;
        }
    }


}
