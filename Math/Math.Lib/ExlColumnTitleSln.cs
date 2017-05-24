using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
    //    Given a positive integer, return its corresponding column title as appear in an Excel sheet.

    //For example:

    //    1 -> A
    //    2 -> B
    //    3 -> C
    //    ...
    //    26 -> Z
    //    27 -> AA
    //    28 -> AB 
    public class ExlColumnTitleSln
    {
        public string ConvertToTitle(int n)
        {
            //A~Z:26
            //AA~ZZ:26*26
            //...
            if (n == 0) return "A";
            char[] chdict = new char[]{'A','B','C','D','E','F','G','H','I','J','K',
            'L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                if (n % 26 == 0)
                    sb.Append('Z'); 
                else sb.Append(chdict[n % 26 - 1]);
                n = n / 26;
            }
            IEnumerable<char> rtnchars = sb.ToString().Reverse();
            sb.Clear();
            foreach (var ch in rtnchars)
                sb.Append(ch);
            return sb.ToString();
        }
    }
}
