/* ==============================================================================
 * 功能描述：ContainsDuplicateIISln  
 * 创 建 者：gz
 * 创建日期：2017/5/3 18:25:02
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array.Lib
{
    /// <summary>
    /// ContainsDuplicateIISln
    /// </summary>
    public class ContainsDuplicateIISln
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>(); //元素值，索引
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    if (Math.Abs(i - dict[nums[i]]) <= k)
                        return true;
                    dict.Remove(nums[i]); //移调
                    dict.Add(nums[i], i);//添加最新的
                    continue;
                }
                dict.Add(nums[i], i);
            }
            return false;
        }

    }
}
