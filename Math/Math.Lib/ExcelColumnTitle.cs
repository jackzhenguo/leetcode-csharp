/* ==============================================================================
 * 功能描述：Class1  
 * 创 建 者：gz
 * 创建日期：2017/5/23 12:49:30
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
    /// <summary>
    /// ExcelColumnTitle
    /// </summary>
    public class ExcelColumnTitle
    {
        public string ConvertToTitle(int n)
        {
            //A~Z:26
            //AA~ZZ:26*26
            //...
            if (n == 1) return "A";
            char[] chdict = {'A','B','C','D','E','F','G','H','I','J','K', 'L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};        
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                n--; //beacuse our chdict's index begins Zero.
                sb.Append(chdict[n % 26]);
                n = n / 26;
            }
            IEnumerable<char> rtnchars = sb.ToString().Reverse();
            sb.Clear();
            foreach (var ch in rtnchars) sb.Append(ch);               
            return sb.ToString();
        }

    }
}
