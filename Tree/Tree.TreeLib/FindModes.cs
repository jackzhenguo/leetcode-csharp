using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
//    Given a binary search tree (BST) with duplicates, find all the mode(s) (the most frequently occurred element) in the given BST.

//Assume a BST is defined as follows:

//The left subtree of a node contains only nodes with keys less than or equal to the node's key.
//The right subtree of a node contains only nodes with keys greater than or equal to the node's key.
//Both the left and right subtrees must also be binary search trees.
//For example:
//Given BST [1,null,2,2],
//   1
//    \
//     2
//    /
//   2
//return [2].

    //求解二叉搜索树中出现次数最多的元素，答案的空间复杂度为 O(1)。
    //二叉搜索树的中序遍历恰好为元素的从小到大排序，这样相等的元素一定是相邻的。
    //了解了这个知识点，空间复杂度O(1)就可以做到了。
    public class Findmodes
    {
        private int currentVal;
        private int currentCount = 0;
        private int maxCount = 0;
        private int modeCount = 0;
        private int[] modeArray;

        public int[] FindMode(TreeNode root)
        {
            preorder(root); //第一遍中序遍历找出出现次数最多的元素数，可能有多个最大
            modeArray = new int[modeCount];
            modeCount = 0;
            currentCount = 0;
            preorder(root);
            return modeArray;
        }

        /// <summary>
        /// 这种方法只适应于二叉搜索树条件下，查找元素出现的最多次数
        /// </summary>
        /// <param name="val"></param>
        private void getModeValue(int val)
        {
            if (val != currentVal)
            {
                currentVal = val;
                currentCount = 0;
            }
            currentCount++;
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                modeCount = 1;
            }
            else if (currentCount == maxCount)
            {
                if (modeArray != null) //第二遍遍历后，对出现次数最多的元素
                    modeArray[modeCount] = currentVal; //依次赋值给modeArray
                modeCount++;
            }
        }

        /// <summary>
        /// 二叉搜索树，采取中序遍历对值处理
        /// </summary>
        /// <param name="root"></param>
        private void preorder(TreeNode root)
        {
            if (root == null) 
                return;
            preorder(root.left);
            getModeValue(root.val);
            preorder(root.right);
        }
    }
}
