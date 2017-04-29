using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Lib
{
    //    Given an integer array nums, find the sum of the elements between indices i and j (i ≤ j), inclusive.

    //Example:
    //Given nums = [-2, 0, 3, -5, 2, -1]
    //sumRange(0, 2) -> 1
    //sumRange(2, 5) -> -1
    //sumRange(0, 5) -> -3
    //    Note: 
    //1. You may assume that the array does not change. 
    //2. There are many calls to sumRange function.
    public class RangeSumQuerySln
    {
        public class NumArray
        {

            private int[] _nums;
            public NumArray(int[] nums)
            {
                _nums = nums;
                for (int i = 1; i < _nums.Length; i++)
                    _nums[i] += _nums[i - 1];
            }

            public int SumRange(int i, int j)
            {
                if (i == 0)
                    return _nums[j];

                return _nums[j] - _nums[i - 1];
            }
        }
    }
}
