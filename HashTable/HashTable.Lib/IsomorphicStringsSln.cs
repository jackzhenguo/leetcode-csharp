using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable.Lib
{
    public class IsomorphicStringsSln
    {
        public bool IsIsomorphic(string s, string t)
        {
            var dict = new Dictionary<char, char>(); //s.char->t.char
            var dict2 = new Dictionary<char, char>(); //t.char->s.char
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]) && dict[s[i]] != t[i] ||
                   dict2.ContainsKey(t[i]) && dict2[t[i]] != s[i])
                    return false;
                dict[s[i]] = t[i];
                dict2[t[i]] = s[i];
            }
            return true;
        }
    }
}
