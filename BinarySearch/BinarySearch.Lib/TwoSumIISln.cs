using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Lib
{
    //    Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.

    //The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.

    //You may assume that each input would have exactly one solution and you may not use the same element twice.

    //Input: numbers={2, 7, 11, 15}, target=9
    //Output: index1=1, index2=2
    public class TwoSumIISln
    {
         public int[] TwoSum(int[] num, int target)
        {
            //因为一定存在解，所以不做边界检查
            int left = 0, right = num.Length - 1;
            while (left < right)
            {
                int v = num[left] + num[right];
                if (v == target)
                    return new int[2] { left + 1, right + 1 };
                else if (v > target)
                    right--;
                else
                    left++;
            }
            return new int[] { };
        }

    }
}
