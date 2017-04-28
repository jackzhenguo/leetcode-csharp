/* ==============================================================================
 * 功能描述：LongestPalindrome  
 * 创 建 者：gz
 * 创建日期：2017/4/28 18:28:39
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Given a string which consists of lowercase or uppercase letters, find the length of the longest palindromes that can be built with those letters.

//This is case sensitive, for example “Aa” is not considered a palindrome here.

//Note: 
//Assume the length of given string will not exceed 1,010.

//Example:

//Input:
//"abccccdd"

//Output:
//7

//Explanation:
//One longest palindrome that can be built is "dccaccd", whose length is 7.
namespace HashTable.Lib
{
    /// <summary>
    /// LongestPalindrome
    /// </summary>
    public class LongestPalindrome
    {

        #region 公有方法
        //借助哈希表，或字典，求某个字符出现的个数，若为偶数，则取字符串中此字符所有个数，
        //若为奇数，个数减1即可，只保留一个奇数不减去1。
        public int NumberOfPalindrome(string s)
        {
            HashSet<int> hash = new HashSet<int>();
            int count = 0;
            foreach (var item in s)
            {
                if (hash.Contains(item))
                {
                    hash.Remove(item); //配对成功，
                    count++;           //count加1
                }
                else
                    hash.Add(item);
            }
            return hash.Count > 0 ? count * 2 + 1 : count * 2;
        }

        public int NumberOfPalindrome2(string s)
        {
            Dictionary<char, int> dict = s.GroupBy(item => item).ToDictionary(g => g.Key, g => g.ToArray().Count());
            int rtn = dict.Where(item => item.Value % 2 == 0).Sum(item => item.Value);
            var oddList = dict.Where(item => item.Value % 2 == 1);
            int oddCount = oddList.Count();
            if (oddCount > 0)
                return rtn + oddList.Sum(r => r.Value) - oddCount + 1;
            return rtn;
        }

        #endregion

    }
}
