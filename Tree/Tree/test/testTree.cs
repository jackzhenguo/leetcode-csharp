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
        object[] objs = new object[] { 1, 2, 3, null, null, 4, 5 };

        public TreeNode buildTreeTest()
        {
            return TreeTools.buildTree(objs);
        }

        public TreeNode buildTreeTest(object[] objs)
        {
            return TreeTools.buildTree(objs);
        }

        public void LevelOrderTraversalTest()
        {
            TreeNode root = buildTreeTest();
            LevelOrderTraversal lvTraversal = new LevelOrderTraversal();
            IList<IList<int>> levelList = lvTraversal.LevelOrderBottom(root);
        }

        public void TreePathsTest()
        {
            testTree test = new testTree();
            TreeNode root = test.buildTreeTest();
            TreePaths path = new TreePaths();
            IList<string> paths = path.BinaryTreePaths(root);
        }

        public void BSTFindModeTest()
        {
            testTree test = new testTree();
            TreeNode root = test.buildTreeTest(new object[] { 2, 1, 3, null, null, 2, 4 });
            Findmodes modes = new Findmodes();
            int[] ints = modes.FindMode(root);
        }

        public void PathSumTest()
        {
            //    2
            //  /  \
            // 1   3
            //     /\
            //    2 4
            TreeNode root = buildTreeTest(new object[] { 10, 5, -3, 3, 2, null, 11, 3, -2, null, 1 });//new object[] { 10, 5, -3, 3, 2, null, 11, 3, -2, null, 1 }
            TreePathSum modes = new TreePathSum();
            int ints = modes.PathSum(root, 8);
        }

        public void LeftLeafSumTest()
        {
            TreeNode root = buildTreeTest(new object[] { 3, 9, 20, null, null, 15, 7 });
            LeftLeafSum llsum = new LeftLeafSum();
            int lsum = llsum.SumOfLeftLeaves(root);
        }

        public void OnePathSumTest()
        {
            TreeNode root = buildTreeTest(new object[] { 3, 9, 20, null, null, 15, 7 });
            OnePathSum onepath = new OnePathSum();
            bool exist = onepath.HasPathSum(root, 3);
        }

        public void BalancedTreeTest()
        {
            TreeNode root = buildTreeTest(new object[] { 3, null, 20, null, null, 15, 7 });
            BanlancedTree test = new BanlancedTree();
            bool exist = test.IsBalanced(root);
        }

        public void SortArrayToBanlancedTest()
        {
            SortArrayToBalanced test = new SortArrayToBalanced();
            TreeNode tree = test.SortedArrayToBST(new int[]{1,2,3});
        }

        public void DiameterTreeTest()
        {
            TreeNode root = buildTreeTest(new object[] { 3, 9, 20, null, null, 15, 7 });
            DiameterTree test = new DiameterTree();
            int diameter = test.DiameterOfBinaryTree(root);
        }

        public void CommonAncesterTest()
        {
            TreeNode root = buildTreeTest(new object[] { 2,null,3});
            CommonAncester ancester = new CommonAncester();
            TreeNode node = ancester.LowestCommonAncestor(root, root, root.right);
        }

        public void IsSymmetricTreeTest()
        {
            TreeNode root = buildTreeTest(new object[] { 1, 2, 2, 3, 5, 4, 3 });
            SymmetricTree test = new SymmetricTree();
            bool sym = test.IsSymmetric(root);
        }

        public void OrderUsingStack()
        {
            TreeNode root = buildTreeTest(new object[] { 1, 2, 3,4,5,6,7 });
            TraversalTreeUsingStack test = new TraversalTreeUsingStack();
            test.PostOrder(root);
        }

    }


}
