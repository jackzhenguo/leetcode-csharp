/* ==============================================================================
 * 功能描述：BinaryTreePaths  
 * 创 建 者：gz
 * 创建日期：2017/4/21 12:19:13
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Given a binary tree, return all root-to-leaf paths.

//For example, given the following binary tree:

//   1
// /   \
//2     3
// \
//  5
//All root-to-leaf paths are:

//["1->2->5", "1->3"]

namespace Tree.TreeLib
{
    /// <summary>
    /// BinaryTreePaths
    /// </summary>
    public class BinaryTreePath
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            if(root==null)
                return new List<string>();
            IList<string> rtn = new List<string>() {root.val+"->"};
            if (root.left == null && root.right == null) //叶子节点
                return new List<string>(root.val);
            if (root.left != null)
            {
                rtn[0] += BinaryTreePaths(root.left);
            }
            if (root.right != null)
            {
                rtn.Add(root.val + "->" + BinaryTreePaths(root.right));
            }

            return rtn;
        }

    }
}
