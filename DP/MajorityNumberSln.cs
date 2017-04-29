using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Lib
{
//    Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.

//You may assume that the array is non-empty and the majority element always exist in the array.
    public class MajorityNumberSln
    {
        //O(1)空间复杂度
        public int MajorityElement(int[] nums)
        {
            int major = nums[0];
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    count++;
                    major = nums[i];
                }
                else if (major == nums[i])
                    count++;
                else
                    count--; //此消彼长
            }
            return major;
        }

        //hash table version
        public int MajorityElement2(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int majorityElement = nums[0];
            foreach (var item in nums)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                    //注意是大于，而不是 大于或等于
                    if (dict[item] > nums.Length / 2)
                        majorityElement = item;
                }
                else
                    dict.Add(item, 1);
            }
            return majorityElement;
        }

    }
}
