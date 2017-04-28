/* ==============================================================================
 * 功能描述：TwoSum  
 * 创 建 者：gz
 * 创建日期：2017/4/28 18:20:39
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable.Lib
{
    //Given an array of integers, return indices of the two numbers such that they add up to a specific target.

    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// <summary>
    /// TwoSum
    /// </summary>
    public class TwoSumSln
    {

        #region 公有方法

        public int[] TwoSum1(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                    return new int[] { dict[target - nums[i]], i };
                else
                {
                    if (!dict.ContainsKey(nums[i])) //同一个元素不能用两次
                        dict.Add(nums[i], i);
                }

            }
            return null;
        }

        //暴力版本
        public int[] TwoSum2(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return null;

        }

        #endregion

    }
}
