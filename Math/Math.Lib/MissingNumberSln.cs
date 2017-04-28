/* ==============================================================================
 * 功能描述：MissingNumberSln  
 * 创 建 者：gz
 * 创建日期：2017/4/28 19:00:44
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
    /// <summary>
    /// MissingNumberSln
    /// </summary>
    public class MissingNumberSln
    {
        //Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.
        //For example, 
        //Given nums = [0, 1, 3] return 2.
        //Note: 
        //Your algorithm should run in linear runtime complexity. Could you implement it using only constant extra space complexity?
        #region 公有方法

        public class Solution
        {
            public int MissingNumber(int[] nums)
            {
                int xor = 0, i = 0;
                for (i = 0; i < nums.Length; i++)
                {
                    xor = xor ^ i ^ nums[i];
                }
                //最后再和个数i异或，这样所有的索引与下标都异或了，找到缺失元素。
                return xor ^ i;
            }
        }

        #endregion

    }
}
