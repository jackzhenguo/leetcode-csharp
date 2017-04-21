/* ==============================================================================
 * 功能描述：SearchInsertPosition  
 * 创 建 者：gz
 * 创建日期：2017/4/21 8:21:07
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

//You may assume no duplicates in the array.

//Here are few examples. 
//[1,3,5,6], 5 → 2 
//[1,3,5,6], 2 → 1 
//[1,3,5,6], 7 → 4 
//[1,3,5,6], 0 → 0

namespace Array.Lib
{
    /// <summary>
    /// #35: Search Insert Position
    /// </summary>
    public class SearchInsertPosition
    {

        public int SearchInsert(int[] nums, int target)
        {
            int lo = 0;
            int hi = nums.Length;
            while (lo < hi)
            {
                int mi = (lo + hi) >> 1;
                if (target <= nums[mi]) //目标值不大于中间位置的数时，hi变小
                    hi = mi;
                else if (target > nums[mi]) //大于中间位置的值，lo加1
                    lo = lo + 1;
            }
            return lo;
        }


    }
}
