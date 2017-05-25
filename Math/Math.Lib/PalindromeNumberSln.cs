/* ==============================================================================
 * 功能描述：PalindromeNumberSln  
 * 创 建 者：gz
 * 创建日期：2017/5/24 13:01:57
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
    /// <summary>
    /// PalindromeNumberSln
    /// </summary>
    public class PalindromeNumberSln
    {
        public bool IsPalindrome(int x)
        {
            int palindromex = 0, tmp = x;
            int sumbit = 0;
            //calcuate bit count
            while (tmp > 0)
            {
                sumbit++;
                tmp /= 10;
            }
            tmp = x;
            while (tmp > 0)
            {
                palindromex += tmp % 10 * (int)System.Math.Pow(10, --sumbit);
                tmp /= 10;
            }
            return palindromex == x;
        }

    }
}
