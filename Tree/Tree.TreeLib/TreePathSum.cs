using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    //    You are given a binary tree in which each node contains an integer value.

    //Find the number of paths that sum to a given value.

    //The path does not need to start or end at the root or a leaf, but it must go downwards (traveling only from parent nodes to child nodes).

    //The tree has no more than 1,000 nodes and the values are in the range -1,000,000 to 1,000,000.

    //Example:

    //root = [10,5,-3,3,2,null,11,3,-2,null,1], sum = 8

    //      10
    //     /  \
    //    5   -3
    //   / \    \
    //  3   2   11
    // / \   \
    //3  -2   1

    //Return 3. The paths that sum to 8 are:

    //1.  5 -> 3
    //2.  5 -> 2 -> 1
    //3. -3 -> 11
   public class TreePathSum
    {
       public int PathSum(TreeNode root, int sum)
       {
           int cnt = onePathSum(root, sum);
           if (root != null)
               cnt += PathSum(root.left, sum) + PathSum(root.right, sum);
           return cnt;
       }

       private int onePathSum(TreeNode root, int sum)
       {
           if (root == null)
               return 0;
           int cnt = 0;
           if (root.val == sum)
               cnt = 1;
           //求以root为根的路径val和等于sum的
           cnt += onePathSum(root.left, sum - root.val);
           cnt += onePathSum(root.right, sum - root.val);
           return cnt;
       }




    }

}
