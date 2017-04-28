/* ==============================================================================
 * 功能描述：PerfectNumberSln  
 * 创 建 者：gz
 * 创建日期：2017/4/28 19:08:01
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
    /// <summary>
    /// PerfectNumberSln
    /// </summary>
    public class PerfectNumberSln
    {

        #region 公有方法
        // We define the Perfect Number is a positive integer that is equal to the sum of all its positive divisors except itself.

        //Now, given an integer n, write a function that returns true when it is a perfect number and false when it is not. 
        //Example:

        //Input: 28
        //Output: True
        //Explanation: 28 = 1 + 2 + 4 + 7 + 14
        public bool CheckPerfectNumber(int num)
        {
            int sum = 1;
            int tmp = num;
            if (num == 0 || num == 1)//特别注意边界值 
                return false;
            while (num % 2 == 0)
            {
                num /= 2;
                sum += num + tmp / num;
            }
            return sum == tmp;
        }


        #endregion

    }
}
