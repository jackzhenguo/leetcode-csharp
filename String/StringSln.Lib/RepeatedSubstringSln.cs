using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSln.Lib
{
    public class RepeatedSubstringSln
    {
        //        Given a non-empty string check if it can be constructed by taking a substring of it and appending multiple copies of the substring together. You may assume the given string consists of lowercase English letters only and its length will not exceed 10000.

        //Example 1:
        //Input: "abab"

        //Output: True

        //Explanation: It's the substring "ab" twice.

        //Example 2:
        //Input: "aba"

        //Output: False

        //Example 3:
        //Input: "abcabcabcabc"

        //Output: True

        //Explanation: It's the substring "abc" four times. (And the substring "abcabc" twice.)

        public bool RepeatedSubstringPattern(string s)
        {
            for (int i = s.Length / 2; i > 0; i--)
            {
                if (s.Length % i != 0)
                    continue;
                string prefix = s.Substring(0, i); //可能的重复子串
                string strsub = s.Substring(i); //去掉以上可能的重复子串后
                int index = strsub.IndexOf(prefix);
                if (index != 0)
                    continue;
                else //表明紧接着字符串匹配上
                {
                    //用这个子串重复s.Length/i次，若与原串相等，便为true。
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < s.Length / i; j++)
                        sb.Append(prefix);
                    if (sb.ToString() == s)
                        return true;
                }

            }
            return false;
        }
    }
}
