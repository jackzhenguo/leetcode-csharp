/* ==============================================================================
 * 功能描述：FindPairsSln  
 * 创 建 者：gz
 * 创建日期：2017/5/3 16:01:15
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array.Lib
{
    /// <summary>
    /// FindPairsSln
    /// </summary>

    //    Given an array of integers and an integer k, you need to find the number of unique k-diff pairs in the array. 
    //    Here a k-diff pair is defined as an integer pair (i, j), where i and j are both numbers in the array and their absolute difference is k.

    //Example 1:
    //Input: [3, 1, 4, 1, 5], k = 2
    //Output: 2
    //Explanation: There are two 2-diff pairs in the array, (1, 3) and (3, 5).
    //Although we have two 1s in the input, we should only return the number of unique pairs.
    //Example 2:
    //Input:[1, 2, 3, 4, 5], k = 1
    //Output: 4
    //Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and (4, 5).
    //Example 3:
    //Input: [1, 3, 1, 5, 4], k = 0
    //Output: 1
    //Explanation: There is one 0-diff pair in the array, (1, 1).
    public class FindPairsSln
    {
        public int FindPairs(int[] nums, int k)
        {
            int sum = 0;
            if (nums.Length == 0 || nums.Length == 1) return 0;
            System.Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                bool eql = false;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    while (j < nums.Length && nums[j] == nums[i])
                    {
                        j++;
                        eql = true;
                    }
                    if (eql) //找到了相等元素
                    {
                        i = j - 1; //j-1>i=0 //i等于某一块相等元素的末端点
                        if (k == 0)
                        {
                            sum++;
                            break;
                        }
                        eql = false;
                    }
                    while (j + 1 < nums.Length && nums[j + 1] == nums[j])
                        j++; //j等于后一块相等元素的末端点                 
                    if (j < nums.Length && nums[j] - nums[i] > k) //
                        break;
                    if (j < nums.Length && nums[j] - nums[i] == k)
                        sum++;
                }
            }
            return sum;
        }

    }
}
