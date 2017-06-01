/* ==============================================================================
 * 功能描述：HammingDistanceSln  
 * 创 建 者：gz
 * 创建日期：2017/6/1 12:51:10
 * ==============================================================================*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BitManipulation
{
    /// <summary>
    /// HammingDistanceSln
    /// </summary>
    public class HammingDistanceSln
    {
        public int HammingDistance(int x, int y)
        {
            //a and y are different bits, so we think the XOR
            //think:0001(1D)
            //         0100(4D)
            //xor = 0101(1D^4D)
            int dist = 0, xor = x ^ y;
            while (xor > 0)
            {
                //xor & (xor-1): it sets the rightest 1 bit    to   0 bit of xor.  
                ++dist;
                xor = xor & (xor - 1);
            }
            return dist;
        }

    }
}
