/* ==============================================================================
 * 功能描述：UglyNumberSln  
 * 创 建 者：gz
 * 创建日期：2017/5/26 12:23:33
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
    /// <summary>
    /// UglyNumberSln
    /// </summary>
    public class UglyNumberSln
    {
        public bool IsUgly(int num)
        {
            if (num <= 0) return false;
            if (num == 1) return true;
            while (num >1)
            {
                if(num%2==0)
                  num /= 2;
                else if (num%3 == 0)
                    num /= 3;
                else if (num%5 == 0)
                    num /= 5;
                else return false;
            }
            return true;
        }

    }
}
