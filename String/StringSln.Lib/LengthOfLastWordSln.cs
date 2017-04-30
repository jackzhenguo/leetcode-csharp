using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSln.Lib
{
    //    Given a string s consists of upper/lower-case alphabets and empty space characters ’ ‘, return the length of last word in the string.

    //If the last word does not exist, return 0.

    //Note: A word is defined as a character sequence consists of non-space characters only.

    //For example,

    //Given s = "Hello World",
    //return 5.
    public class LengthOfLastWordSln
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            if (s == "") return 0;
            for (int i = s.Length - 1; i > 0; i--)
            {
                if (s[i] == ' ')
                    return s.Length - i - 1;
            }
            return s.Length;
        }
        public int LengthOfLastWord2(string s)
        {
            s = s.Trim(); //去掉前，后空格
            if (s == "") return 0;
            string[] splitstring = s.Split(' ');
            string slast = splitstring[splitstring.Length - 1];
            return slast.Length == 0 ? 1 : slast.Length;
        }
    }
}
