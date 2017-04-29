using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers.Lib
{
    //    Given an array nums, write a function to move all 0’s to the end of it while maintaining the relative order of the non-zero elements.

    //For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0].
    //    Note: 
    //1. You must do this in-place without making a copy of the array. 
    //2. Minimize the total number of operations.
    public class MoveZeroesSln
    {
        public class Solution
        {
            public void MoveZeroes(int[] nums)
            {
                int i, j = 0; //j始终指向非零数
                for (i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0)
                    {
                        while (i < nums.Length && nums[i] == 0)
                            i++;
                        if (i < nums.Length)
                            nums[j++] = nums[i];//找到num[i]不为0
                    }
                    else
                        nums[j++] = nums[i];
                }
                //[0,j)为非零数，[j,nums.Length)应全清零。
                for (int k = j; k < nums.Length; k++)
                    nums[k] = 0;

            }
        }
    }
}
