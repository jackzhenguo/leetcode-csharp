/* ==============================================================================
 * 功能描述：UglyNumberSln  
 * 创 建 者：gz
 * 创建日期：2017/5/26 12:23:33
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Given an integer, write a function to determine if it is a power of three.
// Follow up: 
// Could you do it without using any loop / recursion?
namespace Math.Lib
{
    /// <summary>
    /// PowerOfThreeSln
    /// </summary>
    public class PowerOfThreeSln
    {
		public boolean isPowerOfThree(int n) 
		{
			int powcnt = 0;
			if(Math.Pow(3,19)<Int32.MaxValue && Math.Pow(3,20)>Int32.MaxValue)
			   powcnt = 19;
			return ( n>0 &&  Math.Pow(3,19)%n==0);
		}

    }
}
