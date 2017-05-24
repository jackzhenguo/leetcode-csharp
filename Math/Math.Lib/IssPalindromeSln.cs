using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
    public class IssPalindromeSln
    {
        public bool IsPalindrome(int x)
        {
            int palindromex = 0, tmp = x;
            int sumbit = 0;
            //calcuate bit count
            while (tmp > 0)
            {
                sumbit++;
                tmp /= 10;
            }
            tmp = x;
            //get a number reversely
            while (tmp > 0)
            {
                //if palindromex happens overflow, it would return false;
                palindromex += tmp % 10 * (int)System.Math.Pow(10, --sumbit);               
                tmp /= 10;
            }
            return palindromex == x;
        }
    }
}
