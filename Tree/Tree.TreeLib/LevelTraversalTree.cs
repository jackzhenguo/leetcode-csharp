using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    public class LevelTraversalTree
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();
            IList<IList<int>> rtn = new List<IList<int>> { new List<int> { root.val } };
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
            IList<IList<int>> rtn = new List<IList<int>>();
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
