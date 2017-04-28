/* ==============================================================================
 * 功能描述：Solution  
 * 创 建 者：gz
 * 创建日期：2017/4/28 18:18:07
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable.Lib
{
    /// <summary>
    /// Solution
    /// </summary>
    public class SingleOneSln
    {

        #region 公有方法
        //Given an array of integers, every element appears twice except for one. Find that single one.
        public static int SingleNumber1(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();
            foreach (int item in nums)
            {
                if (hash.Contains(item))
                    hash.Remove(item);
                else
                    hash.Add(item);
            }
            return hash.Min();
        }

        public static int SingleNumber2(int[] nums)
        {
            int rslt = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                rslt ^= nums[i];
            }
            return rslt;
        }



        #endregion

    }
}
