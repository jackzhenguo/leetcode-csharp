using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array.Lib
{
    public class RemoveElementSln
    {
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0; //指向不等于元素val
            for (int j = 0; j < nums.Length; j++)
            {
                while (j < nums.Length && nums[j] == val)
                    j++;
                if (i < j && j < nums.Length)
                    nums[i] = nums[j];
                if (j < nums.Length)
                    i++;
            }
            return i;
        }
    }
}
