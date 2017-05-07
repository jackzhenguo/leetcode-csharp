using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable.Lib
{
    public class ValidAnagramSln
    {
        public bool IsAnagram(string s, string t)
        {
            int[] hash = new int[123]; //a~z
            if (s.Length != t.Length) return false;
            foreach (var ch in s)
            {
                hash[Convert.ToInt32(ch)]++;
            }
            foreach (var ch in t)
            {
                if (hash[Convert.ToInt32(ch)]-- <= 0)
                    return false;
            }
            return true;
        }
    }
}
