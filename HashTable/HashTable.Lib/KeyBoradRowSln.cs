/* ==============================================================================
 * 功能描述：KeyBoradRowSln  
 * 创 建 者：gz
 * 创建日期：2017/5/9 12:44:32
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.


//American keyboard


//Example 1:
//Input: ["Hello", "Alaska", "Dad", "Peace"]
//Output: ["Alaska", "Dad"]
namespace HashTable.Lib
{
    /// <summary>
    /// KeyBoradRowSln
    /// </summary>
    public class KeyBoradRowSln
    {
        public string[] FindWords(string[] words)
        {
            int[] hash = new int[123];
            char[] chs1 = {'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'};
            foreach (var ch in chs1)
            {
                hash[Convert.ToInt32(ch)] = 1; //q
                hash[Convert.ToInt32(ch)-32] = 1; //Q
            }
            chs1 = new[] {'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'};
            foreach (var ch in chs1)
            {
                hash[Convert.ToInt32(ch)] = 2;
                hash[Convert.ToInt32(ch) - 32] = 2;
            }
            chs1 = new[] {'z', 'x', 'c', 'v', 'b', 'n', 'm'};
            foreach (var ch in chs1)
            {
                hash[Convert.ToInt32(ch)] = 3;
                hash[Convert.ToInt32(ch) - 32] = 3;
            }
            List<string> rtn = new List<string>();
            foreach (var word in words)
            {
                if(string.IsNullOrEmpty(word)) continue;
                int row = hash[word[0]];
                bool allflag = true;
                foreach (var ch in word)
                {
                    if (hash[ch] != row)
                    {
                        allflag = false;
                        break;
                    }
                }
                if(allflag==true) rtn.Add(word);
            }
            return rtn.ToArray();
        }

    }
}
