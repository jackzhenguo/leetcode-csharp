using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers.Lib
{
    //    Write a function that takes a string as input and reverse only the vowels of a string.

    //Example 1:

    //Given s = "hello", return "holle".
    //1
    //1
    //Example 2:


    //Given s = "leetcode", return "leotcede".
    public class ReverseVowelsSln
    {
        public class Solution
        {
            private List<char> vowels = new List<char> { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            private char[] chars;

            public string ReverseVowels(string s)
            {
                chars = s.ToCharArray();
                int lo = 0;
                int hi = s.Length - 1;
                while (lo < hi)
                    reverseVowels(ref lo, ref hi);
                return new string(chars);
            }

            public void reverseVowels(ref int lo, ref int hi)
            {
                for (int i = lo; i <= hi; i++, lo++)
                {
                    if (vowels.Contains(chars[i]))
                        break;
                }
                for (int i = hi; i >= lo; i--, hi = i)
                {
                    if (vowels.Contains(chars[i]))
                        break;
                }

                if (lo < hi)
                {
                    if (chars[lo] != chars[hi])//交换字符
                    {
                        char tmp = chars[lo];
                        chars[lo] = chars[hi];
                        chars[hi] = tmp;
                    }
                    ++lo;
                    --hi;
                }
            }
        }


    }
}
