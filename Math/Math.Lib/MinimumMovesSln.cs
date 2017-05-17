using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeTest
{
    //    Given a non-empty integer array of size n, find the minimum number of moves required to make all array elements equal, where a move is incrementing n - 1 elements by 1.

    //Example:

    //Input:
    //[1,2,3]

    //    Output:
    //3

    //Explanation:
    //Only three moves are needed(remember each move increments two elements):

    //[1,2,3]  =>  [2,3,3]  =>  [3,4,3]  =>  [4,4,4]
    //[1,3,3]  =>  [3,3,5]  =>  [5,5,5]
    public class MinimumMovesSln
    {
        public int MinMoves(int[] nums)
        {
            //assume moving m times, so m*(n-1) + sum_init = n * (min+m) // min+m is the final number
            //sum = n*min + m => m = sum - n* min;
            int min = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min) min = nums[i];
                sum += nums[i];
            }
            return sum - nums.Length * min;
        }

    }
}
