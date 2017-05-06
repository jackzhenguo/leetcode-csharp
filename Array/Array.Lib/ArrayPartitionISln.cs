using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array.Lib
{
    public class ArrayPartitionISln
    {
        //        Given an array of 2n integers, your task is to group these integers into n pairs of integer, say (a1, b1), (a2, b2), …, (an, bn) which makes sum of min(ai, bi) for all i from 1 to n as large as possible.

        //Example 1:
        //Input: [1,4,3,2]

        //Output: 4
        //Explanation: n is 2, and the maximum sum of pairs is 4.
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int rtn = 0;
            for (int i = 0; i < nums.Length; i = i + 2)
                rtn += nums[i];
            return rtn;
        }
    }
}
