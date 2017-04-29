using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers.Lib
{
    //    Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

    //For example,

    //"A man, a plan, a canal: Panama" is a palindrome.
    //"race a car" is not a palindrome.
    class ValidPalindromeSln
    {
        public bool IsPalindrome(string s)
        {
            int i, j;
            if (s == string.Empty) return true;

            for (i = 0, j = s.Length - 1; i < s.Length && j > 0; i++, j--)
            {
                while (i < s.Length && !isAlphanumeric(s[i]))
                    i++;

                while (i < j && !isAlphanumeric(s[j]))
                    j--;

                if (i >= j) //碰头表示成功！
                    break;

                if (!isEqual(s[i], s[j]))
                    return false;
            }
            return true;
        }

        private bool isAlphanumeric(char c)
        {
            return char.IsLetter(c) || char.IsDigit(c);
        }

        private bool isEqual(char c1, char c2)
        {
            //要做字符和字母的区别对待，数字和字母字符一定不相等。
            if (char.IsDigit(c1) && char.IsLetter(c2))
                return false;
            if (char.IsDigit(c2) && char.IsLetter(c1))
                return false;

            //如果不考虑以上，请参考数字0和字符P的取值。

            if (c1 == c2) return true;

            int c1int = Convert.ToInt32(c1);
            int c2int = Convert.ToInt32(c2);
            return Math.Abs(c1int - c2int) == 32;
        }

    }
}
