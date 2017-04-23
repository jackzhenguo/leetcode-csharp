using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    public class SortArrayToBalanced
    {
        //Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
        //nums = [1 2 3 4 5]
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
                return null;
            return subTree(nums, 0, nums.Length-1);

        }

        private TreeNode subTree(int[] nums, int begin, int end)
        {
            if (begin > end)
                return null;
            int mid = begin + (end - begin) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left = subTree(nums, begin,  mid-1);
            root.right = subTree(nums, mid + 1, end);
            return root;
        }

    }
}
