using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSln.Lib
{
    public class SegmentNumberSln
    {
        //        Count the number of segments in a string, where a segment is defined to be a contiguous sequence of non-space characters.

        //Please note that the string does not contain any non-printable characters.

        //Example:

        //Input: "Hello, my name is John"
        //Output: 5

        //Input: "          "
        //Output: 0

        //Input: "     a"
        //Output: 1

        //Input: "     a        "
        //Output: 1

        //Input: "     a                b    "
        //Output: 2

        public int CountSegments(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            int i = 0;
            while (i < s.Length && !isValidBegin(s[i]))
                i++;
            if (i == s.Length) //没有有效字符，如"         "
                return 0;
            if (i == s.Length - 1)  //只有一个有效字符，如 "         a"
                return 1;
            while (i < s.Length - 1 && !isValidEnd(s[i], s[i + 1]))
                i++;
            if (i == s.Length - 1)
                return 1; //只有1个有效字符，如"         a              "

            return 1 + CountSegments(s.Substring(i + 1));
        }

        //字符串的第一个片段的首字符，找到有效字符开始
        private bool isValidBegin(char curchar)
        {
            if (curchar != ' ')
                return true;
            return false;
        }


        //判断字符片段的结束
        private bool isValidEnd(char curchar, char afterchar)
        {
            if (curchar != ' ' && afterchar == ' ')
                return true;
            return false;
        }


    }
}
