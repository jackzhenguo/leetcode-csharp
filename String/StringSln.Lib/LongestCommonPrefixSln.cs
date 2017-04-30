using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSln.Lib
{
    public class LongestCommonPrefixSln
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";
            if (strs.Length == 1)
                return strs[0];

            string longestPrefix = firstTwoStrs(strs);
            if (longestPrefix.Length == 0)
                return "";
            int i = 2;
            while (i < strs.Length)
            {
                if (strs[i].IndexOf(longestPrefix) != 0)
                {
                    longestPrefix =
                    longestPrefix.Substring(0, longestPrefix.Length - 1);
                    i = 1;
                    if (longestPrefix.Length == 0)
                        return "";
                }
                i++;
            }
            return longestPrefix;
        }

        //头两个字符串的公共串
        private string firstTwoStrs(string[] strs)
        {
            if (strs.Length < 2) return "";
            StringBuilder sb = new StringBuilder();
            int len = strs[0].Length < strs[1].Length ? strs[0].Length : strs[1].Length;
            for (int i = 0; i < len; i++)
            {
                if (strs[0][i] == strs[1][i])
                    sb.Append(strs[0][i]);
                else
                    break;
            }
            return sb.ToString();
        }
    }
}
