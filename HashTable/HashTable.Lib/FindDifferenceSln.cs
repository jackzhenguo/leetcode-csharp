/* ==============================================================================
 * 功能描述：FindDifferenceSln  
 * 创 建 者：gz
 * 创建日期：2017/5/9 13:23:46
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable.Lib
{
    /// <summary>
    /// FindDifferenceSln
    /// </summary>
    public class FindDifferenceSln
    {
        public char FindTheDifference(string s, string t)
        {
            int[] hash = new int[123]; //97~122
            foreach (var ch in s)
                hash[Convert.ToInt32(ch)]++;
            foreach (var ch in t)
            {
                int tmp = Convert.ToInt32(ch);
                hash[tmp]--;
                if (hash[tmp] < 0)
                    return ch;
            }
            return ' ';
        }

    }
}
