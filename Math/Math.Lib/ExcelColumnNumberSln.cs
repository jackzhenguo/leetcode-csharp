using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
    public class ExcelColumnNumberSln
    {
        public int TitleToNumber(string s)
        {
            char[] chs= {'A','B','C','D','E','F','G','H','I','J','K',
            'L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};   
            Dictionary<char,int> dict = new Dictionary<char,int>();
            for(int i=0; i<chs.Length;i++) dict.Add(chs[i],i+1);
            int scnt = s.Length, rtnsum=0;
            for (int i = scnt - 1,j=0; i >= 0; i--,j++)
              rtnsum += dict[s[i]] * (int)System.Math.Pow(26, j);
            return rtnsum;
        }
    }
}
