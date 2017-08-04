using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
    //    Find the nth digit of the infinite integer sequence 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, ...

    //Note:
    //n is positive and will fit within the range of a 32-bit signed integer (n < 231).

    //Example 1:

    //Input:
    //3

    //Output:
    //3
    //Example 2:

    //Input:
    //11

    //Output:
    //0

    //Explanation:
    //The 11th digit of the sequence 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, ... is a 0, which is part of the number 10.
    public class Nthdigit
    {
        //for this issue, there are two different ways to decribe a number
        //1 element. this is our common way
        //2 Nth digit. this is a new way
        public int FindNthDigit(int n)
        {
            long bas = 9;
            int digits = 1, i = 0;
            //first: getting n which digit is in
            while (n > bas * digits) // prevent overflowing. Since bas is long, so result of bas*digits is auto imporved as long
            {
                n -= (int)(bas * (digits++)); //nth
                i += (int)bas; //number of pasted elements
                bas *= 10; //1 digit->9; 2 digits->90; 3 digits->900, ...   
            }
            //second: Nth digit ->element
            //in all numbers containing digits, pasted numbers
            int pasted = (int)((n - 1) / digits);
            int element = pasted + i + 1;
            //third: once getting the element Nth digits stands,
            //(n-1)%digits of element is solution
            int nth = (n - 1) % digits;
            return element.ToString()[nth] - '0';
        }
    }
}
