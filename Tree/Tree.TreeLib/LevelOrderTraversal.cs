/* ==============================================================================
 * 功能描述：LevelOrderTraversal  
 * 创 建 者：gz
 * 创建日期：2017/4/19 12:23:31
 * ==============================================================================*/

using System.Collections.Generic;
using System.Linq;

//Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).

//For example:
//Given binary tree [3,9,20,null,null,15,7],
//    3
//   / \
//  9  20
//    /  \
//   15   7
//return its bottom-up level order traversal as:
//[
//  [15,7],
//  [9,20],
//  [3]
//]

namespace Tree.TreeLib
{
    /// <summary>
    /// 107. Binary Tree Level Order Traversal II
    /// </summary>
    public class LevelOrderTraversal
    {

        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var rtn = LevelOrderUp(root);
           
            if (rtn != null && rtn.Count > 0)
            {
                List<IList<int>> rtn2 = new List<IList<int>>(); 
                rtn2.AddRange(rtn); 
                rtn2.Reverse();  //Ilist.Reverse() failure!
                return rtn2;
            }
            return new List<IList<int>>();
        }

        public IList<IList<int>> LevelOrderUp(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();
            IList<IList<int>> rtn = new List<IList<int>>{new List<int> {root.val}};
            var tmp = getNextLevel(new List<TreeNode> { root });
            if (tmp != null && tmp.Count > 0)
            {
                foreach (var item in tmp)
                    rtn.Add(item);
            }
            return rtn;
        }

        private IList<IList<int>> getNextLevel(IList<TreeNode> curLevel)
        {
            if (curLevel == null || curLevel.Count == 0)
                return null;
            IList<IList<int>> rtn= new List<IList<int>>();
            List<TreeNode> nextn = new List<TreeNode>();
            foreach (var item in curLevel)
            {
                if (item.left != null)
                    nextn.Add(item.left);
                if (item.right != null)
                    nextn.Add(item.right);
            }
            if (nextn.Count == 0)
                return null;
            rtn.Add(nextn.Select(r => r.val).ToList());
            var children = getNextLevel(nextn);
            if (children != null && children.Count > 0)
            {
                foreach (var item in children)
                    rtn.Add(item);
            }
            return rtn;
        }
    }
}
