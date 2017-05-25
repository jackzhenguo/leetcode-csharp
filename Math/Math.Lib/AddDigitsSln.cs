using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// // Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.

// // For example:

// // Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. Since 2 has only one digit, return it.

// // Follow up: 
// // Could you do it without any loop/recursion in O(1) runtime?
namespace Math.Lib
{
    public class AddDigitsSln
    {
        public int AddDigits(int num) {
        return num - 9*Convert.ToInt32((num-1)/9);
    }
    }

}
