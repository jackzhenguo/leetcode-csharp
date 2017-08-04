using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
	// Given a roman numeral, convert it to an integer.

// Input is guaranteed to be within the range from 1 to 3999.
    public class Solution
    {
		public int RomanToInt(string s) {
				Dictionary<char, int> T = new Dictionary<char, int>{
									   { 'I' , 1 },
									   { 'V' , 5 },
									   { 'X' , 10 },
									   { 'L' , 50 },
									   { 'C' , 100 },
									   { 'D' , 500 },
									   { 'M' , 1000 } 
				};

				int sum = T[s[s.Length-1]];
				for (int i = s.Length - 2; i >= 0; --i)
				{
					if (T[s[i]] < T[s[i + 1]])
					{
						sum -= T[s[i]];
					}
					else
					{
						sum += T[s[i]];
					}
				}

				return sum;
		}
    }

}
