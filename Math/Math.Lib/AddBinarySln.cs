/* ==============================================================================
 * 功能描述：AddBinary  
 * 创 建 者：gz
 * 创建日期：2017/5/23 12:57:28
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
    // Given two binary strings, return their sum (also a binary string).
    //For example,
    //a = "11"
    //b = "1"
    //Return "100".
    /// <summary>
    /// AddBinary
    /// </summary>
    public class AddBinarySln
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int carry = 0, acnt = a.Length, bcnt = b.Length;
            for (int i = acnt - 1, j = bcnt - 1; i >= 0 || j >= 0 || carry == 1; i--, j--){           
                int sum2 = 0;
                if (i < 0 && j < 0){ //overflow solving               
                    sb.Append(carry);
                    carry = 0;
                    continue;
                }
                //discuss three conditions according to i and j
                if (i < 0) sum2 = b[j] - '0';
                else if (j < 0) sum2 = a[i] - '0';
                else sum2 = a[i] - '0' + b[j] - '0';
                if (sum2 + carry < 2){
                    sb.Append(sum2 + carry);
                    carry = 0;
                }
                else {
                    sb.Append(sum2 + carry - 2);
                    carry = 1;
                }
            }
            //reverse the sb
            IEnumerable<char> rtnchars = sb.ToString().Reverse();
            sb.Clear();
            foreach (var ch in rtnchars) sb.Append(ch);
            return sb.ToString();
        }
    }
}
