/* ==============================================================================
 * 功能描述：PowerOfTwo  
 * 创 建 者：gz
 * 创建日期：2017/4/28 18:58:49
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
    //Given an integer, write a function to determine if it is a power of two.
    /// <summary>
    /// PowerOfTwo
    /// </summary>
    public class PowerOfTwoSln
    {

        #region 公有方法
       
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0) return false;
            while (n > 1)
            {
                if (n % 2 > 0) return false;
                n /= 2;
            }
            return true;
        }

        #endregion

    }
}
