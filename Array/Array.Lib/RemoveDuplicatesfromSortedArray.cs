/* ==============================================================================
 * 功能描述：ThirdMaximumNumber  
 * 创 建 者：gz
 * 创建日期：2017/4/21 8:25:57
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Given a non-empty array of integers, return the third maximum number in this array. If it does not exist, return the maximum number. The time complexity must be in O(n).

//Example 1: 
//Input: [3, 2, 1]

//Output: 1

//Explanation: The third maximum is 1. 
//Example 2: 
//Input: [1, 2]

//Output: 2

//Explanation: The third maximum does not exist, so the maximum (2) is returned instead. 
//Example 3: 
//Input: [2, 2, 3, 1]

//Output: 1

//Explanation: Note that the third maximum here means the third maximum distinct number. 
//Both numbers with value 2 are both considered as second maximum.
namespace Array.Lib
{
    /// <summary>
    /// #414 : Third Maximum Number
    /// </summary>
    public class ThirdMaximumNumber
    {
        public int GetThirdMax(int[] a)
        {
            int first = a.Max();
            int[] a2 = a.Where(r => r != first).ToArray();
            if (a2.Length == 0)
                return first;
            int second = a2.Max();
            int[] a3 = a2.Where(r => r != second).ToArray();
            if (a3.Length == 0)
                return first;
            return a3.Max();
        }

    }
}
