/* ==============================================================================
 * 功能描述：AddStringsSln  
 * 创 建 者：gz
 * 创建日期：2017/5/17 8:59:06
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    /// <summary>
    /// AddStringsSln
    /// </summary>
    public class AddStringsSln
    {
        public string AddStrings(string num1, string num2)
        {
            StringBuilder sb = new StringBuilder();
            int carryBit = 0; //carry bit 
            for (int i = num1.Length - 1, j = num2.Length - 1;
                i >= 0 || j >= 0 || carryBit == 1; i--, j--) //think: num1=3, num2=9
            {
                int x = i < 0 ? 0 : charToInt(num1[i]);
                int y = j < 0 ? 0 : charToInt(num2[j]);
                sb.Append((x + y + carryBit) % 10);
                carryBit = (x + y + carryBit) / 10;
            }
            char[] chars = sb.ToString().Reverse().ToArray();
            return new string(chars);
        }

        private int charToInt(char c)
        {
            return c - '0';
        }

    }
}
