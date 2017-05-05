/* ==============================================================================
 * 功能描述：ThirdMaximumNumber  
 * 创 建 者：gz
 * 创建日期：2017/4/21 8:25:57
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// // Given a binary array, find the maximum number of consecutive 1s in this array.

// // Example 1:

// // Input: [1,1,0,1,1,1]
// // Output: 3
// // Explanation: The first two digits or the last three digits are consecutive 1s.
    // // The maximum number of consecutive 1s is 3.
namespace Array.Lib
{
    /// <summary>
    /// #485. Max Consecutive Ones
    /// </summary>
    public int FindMaxConsecutiveOnes(int[] nums) {
        int ito1=0;
        int max = 0;
        foreach(var item in nums){
            if(item==1){
              ito1++;
              if(max<ito1)
                max = ito1;
            }
            else
              ito1=0;
        }
        return max;
    }
}
