/* ==============================================================================
 * 功能描述：ContainsItemSln  
 * 创 建 者：gz
 * 创建日期：2017/5/3 15:59:33
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array.Lib
{
    /// <summary>
    /// ContainsItemSln
    /// </summary>
    public class ContainsItemSln
    {
        //Given an array of integers, find if the array contains any duplicates. Your function should return true
        //if any value appears at least twice in the array, and it should return false if every element is distinct.
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var item in nums)
            {
                if (set.Contains(item))
                    return true;
                set.Add(item);
            }
            return false;
        }

    }
}
