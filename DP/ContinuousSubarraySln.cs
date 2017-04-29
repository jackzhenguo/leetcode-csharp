using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Lib
{
    //    Given a list of non-negative numbers and a target integer k, write a function to check if the array has a continuous subarray of size at least 2 that sums up to the multiple of k, that is, sums up to n*k where n is also an integer.

    //Example 1:

    //Input: [23, 2, 4, 6, 7],  k=6
    //Output: True
    //Explanation: Because [2, 4] is a continuous subarray of size 2 and sums up to 6.

    //Example 2:

    //Input: [23, 2, 6, 4, 7],  k=6
    //Output: True
    //Explanation: Because [23, 2, 6, 4, 7] is an continuous subarray of size 5 and sums up to 42.
    //    Note: 
    //The length of the array won’t exceed 10,000. 
    //You may assume the sum of all the numbers is in the range of a signed 32-bit integer.
    public class ContinuousSubarraySln
    {
        private int[] _nums;
        private int _len;
        public bool CheckSubarraySum(int[] nums, int k)
        {
            _nums = nums;
            _len = nums.Length;
            calculator();
            for (int i = 0; i < _len; i++)
                for (int j = i + 1; j < _len; j++)
                {
                    if (k == 0) //取余时一定注意，k不能为0！
                    {
                        if (rangeSum(i, j) == 0)
                            return true;
                    }
                    else
                    {
                        if (rangeSum(i, j) % k == 0)
                            return true;
                    }
                }
            return false;
        }

        private void calculator()
        {
            for (int i = 1; i < _len; i++)
                _nums[i] += _nums[i - 1];
        }

        private int rangeSum(int i, int j)
        {
            if (i == 0)
                return _nums[j];
            return _nums[j] - _nums[i - 1];
        }
    }
}
