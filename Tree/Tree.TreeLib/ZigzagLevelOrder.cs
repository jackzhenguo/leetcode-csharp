using System;
using System.Collections.Generic;
using System.Text;

 //103. Binary Tree Zigzag Level Order Traversal
namespace leetcodeTest
{
   public class Solution {
    private int lineno; //从二层开始按行号编号

    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
            if (root == null)
                return new List<IList<int>>();
            IList<IList<int>> rtn = new List<IList<int>>{new List<int> {root.val}}; //第一层
            var tmp = zigzagLevelOrder(new List<TreeNode> { root }); //tmp: 第二层~叶子层
            if (tmp != null && tmp.Count > 0)
            {
                foreach (var item in tmp)
                    rtn.Add(item);
            }
            return rtn;
    }
        //第二层到叶子层: right to left; left to right; ...
        private IList<IList<int>> zigzagLevelOrder(IList<TreeNode> curLevel)
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
            if(lineno%2==0) //反转本层
             {
                List<int> tmp = nextn.Select(r => r.val).ToList();
                tmp.Reverse();
                rtn.Add(tmp);
             }
            else 
              rtn.Add(nextn.Select(r=>r.val).ToList()); //正序

            ++lineno;
            var children = zigzagLevelOrder(nextn);
            if (children != null && children.Count > 0)
            {
                foreach (var item in children)
                    rtn.Add(item);
            }
            return rtn;
        }
}
}
