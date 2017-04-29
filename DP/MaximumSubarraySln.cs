using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Lib
{
    //    Find the contiguous subarray within an array (containing at least one number) which has the largest sum.

    //For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
    //the contiguous subarray [4,-1,2,1] has the largest sum = 6.
   public class MaximumSubarraySln
    {
       //a simple and fast method
       public int MaxSubArray(int[] nums)
       {
           int premax = nums[0]; //过去最大值
           int curmax = nums[0]; //当前最大值
           for (int i = 1; i < nums.Length; i++)
           {                          
               curmax = Math.Max(nums[i], nums[i] + curmax);
               premax = Math.Max(curmax, premax);
           }
           return premax;
       }
       public int MaxSubArrayTest(int[] nums)
       {
           int premax =nums[0]; //过去最大值
           int curmax = nums[0]; //当前最大值
           Console.WriteLine(string.Format("curmax，premax初始值等于{0}",curmax));
           for(int i=1;i<nums.Length;i++)
           {
               Console.WriteLine(string.Format("遍历值{0}",nums[i]));
               Console.WriteLine(string.Format("当前curmax等于{0}",curmax));
               if (nums[i] + curmax > nums[i])
                   Console.WriteLine(string.Format("cumax接纳遍历值{0}变为{1}", nums[i], curmax+nums[i]));
               else
                   Console.WriteLine(string.Format("curmax舍弃自己后等于遍历值{0}", nums[i]));
               curmax = Math.Max(nums[i], nums[i] + curmax);
               premax = Math.Max(curmax, premax);
               Console.WriteLine(string.Format("记忆数组连续元素的和最大值{0}\n", premax));
           }
           return premax;
       }
    }
}
