/* ==============================================================================
 * 功能描述：testBuildTree  
 * 创 建 者：gz
 * 创建日期：2017/4/19 13:06:28
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tree.TreeLib;

namespace Tree.test
{
    /// <summary>
    /// testTree
    /// </summary>
    public class testTree
    {
        object[] objs = new object[] {1, 2, 3, null, null, 4, 5};

        public TreeNode buildTreeTest()
        {
            return TreeTools.buildTree(objs);
        }

        public void LevelOrderTraversalTest()
        {
            TreeNode root = buildTreeTest();
            LevelOrderTraversal lvTraversal = new LevelOrderTraversal();
            IList<IList<int>> levelList = lvTraversal.LevelOrderBottom(root);
        }


    }


}
