using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array.Lib
{
    //    Given a non-negative integer represented as a non-empty array of digits, plus one to the integer.

    //You may assume the integer do not contain any leading zero, except the number 0 itself.

    //The digits are stored such that the most significant digit is at the head of the list.
    public class PlusOneSln
    {
        public int[] PlusOne(int[] digits) 
         {
			int index = digits.Length - 1;
			if(digits[index]<9)
			  {
				  digits[index]++;
				  return digits;
			  }
			if(index==0) return new int[]{1,0}; 
			int i = index;
			while(digits[i]==9)
			{
				digits[i] = 0; //位溢出
				if(i==0) //所有的位溢出
				{
					int [] rtn = new int[index+2];
					rtn[0]=1;
					return rtn;
				}
				i--;
			}
			digits[i]++; //第i位不为9（i > 0）
			return digits;
       }
    }
}
