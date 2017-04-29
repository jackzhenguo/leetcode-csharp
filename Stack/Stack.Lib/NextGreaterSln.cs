using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Lib
{
    //    You are given two arrays (without duplicates) nums1 and nums2 where nums1’s elements are subset of nums2. Find all the next greater numbers for nums1’s elements in the corresponding places of nums2.

    //The Next Greater Number of a number x in nums1 is the first greater number to its right in nums2. If it does not exist, output -1 for this number.

    //Example 1:

    //Input: nums1 = [4,1,2], nums2 = [1,3,4,2].
    //Output: [-1,3,-1]
    //Explanation: 
    //For number 4 in the first array, you cannot find the next greater number for it in the second array, so output -1. 
    //For number 1 in the first array, the next greater number for it in the second array is 3. 
    //For number 2 in the first array, there is no next greater number for it in the second array, so output -1. 
    //Example 2:

    //Input: nums1 = [2,4], nums2 = [1,2,3,4].
    //Output: [3,-1]
    //Explanation: 
    //For number 2 in the first array, the next greater number for it in the second array is 3. 
    //For number 4 in the first array, there is no next greater number for it in the second array, so output -1.

    //Note: 
    //All elements in nums1 and nums2 are unique. The length of both 
    //nums1 and nums2 would not exceed 1000.
    public class NextGreaterSln
    {
        // map from x to next greater element of x
        private Dictionary<int, int> _dict = new Dictionary<int, int>();
        public int[] NextGreaterElement(int[] findNums, int[] nums)
        {
            preProcess(nums);

            for (int i = 0; i < findNums.Length; i++)
            {
                if (_dict.ContainsKey(findNums[i]))
                    findNums[i] = _dict[findNums[i]];
                else findNums[i] = -1;
            }
            return findNums;
        }

        private void preProcess(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var num in nums)
            {
                while (stack.Count > 0 && stack.Peek() < num)
                    _dict.Add(stack.Pop(), num);
                stack.Push(num);
            }
        }
    }
}
