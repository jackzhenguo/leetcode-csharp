/* ==============================================================================
 * 功能描述：Class1  
 * 创 建 者：gz
 * 创建日期：2017/5/3 18:55:55
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array.Lib
{
    //Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.

    //Find all the elements of [1, n] inclusive that do not appear in this array.

    //Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
    public class DisappearElementsSln
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> rtn = new List<int>();
            for (int i = 0; i < nums.Length; i++)
                rtn.Add(i + 1);
            return rtn.Except(nums).ToList(); //求差集应用在这个场合效率不好，为充分挖掘题目
        }

        public IList<int> FindDisappearedNumbers2(int[] nums)
        {
            IList<int> rtn = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0)
                    nums[index] = -nums[index];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]>0)
                    rtn.Add(i+1);
            }
            return rtn;
        }

    }
}
