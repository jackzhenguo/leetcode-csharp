/* ==============================================================================
 * 功能描述：ReverseIntegarSln  
 * 创 建 者：gz
 * 创建日期：2017/5/18 13:05:38
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Reverse digits of an integer.

//Example1: x = 123, return 321
//Example2: x = -123, return -321
//Note: 
//The input is assumed to be a 32-bit signed integer. Your function should return 0 when the reversed integer overflows.
namespace Math.Lib
{
    /// <summary>
    /// ReverseIntegarSln
    /// </summary>
    public class ReverseIntegarSln
    {
        public  int Reverse(int x)
        {
            bool isNegative = x < 0;
            long rtn = 0;
            while (x != 0)
            {
                int postBit = x % 10;
                long iterval = rtn * 10 + postBit;
                if (isNegative && iterval < -2147483648) return 0;
                if (iterval > 2147483647) return 0;
                rtn = iterval;
                x /= 10;
            }
            return (int)rtn;
        }

        public  int Reverse2(int x)
        {
            int rtn = 0;

            while (x != 0)
            {
                int postBit = x % 10;
                int iterval = rtn * 10 + postBit; //if happens overflow, result != (newResult - post)/10
                if ((iterval - postBit) / 10 != rtn) //solve the overflow
                {
                    return 0;
                }
                rtn = iterval;
                x = x / 10;
            }
            return rtn;
        }
    }
}
