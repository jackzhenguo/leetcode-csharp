/* ==============================================================================
 * 功能描述：NumberComplementSln  
 * 创 建 者：gz
 * 创建日期：2017/6/2 13:48:57
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace BitManipulation
{
    /// <summary>
    ///#476 NumberComplementSln
    /// </summary>
    public class NumberComplementSln
    {
        public int FindComplement(int num)
        {
            int bits = 1; //num including bits
            while (Math.Pow(2, bits) <= num)
                bits++;
            int sum = (int) Math.Pow(2, bits) - 1;//sum =Pow(2,n)-1: sum of n bits 1
            return  sum - num; //sum - num is the complement

        }

    }
}
