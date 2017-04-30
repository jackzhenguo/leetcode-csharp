using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSln.Lib
{
    //    Given an arbitrary ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.

    //Each letter in the magazine string can only be used once in your ransom note.

    //Note: 
    //You may assume that both strings contain only lowercase letters.

    //canConstruct("a", "b") -> false
    //canConstruct("aa", "ab") -> false
    //canConstruct("aa", "aab") -> true
    //canConstruct("fffbfg","effjfggbffjdgbjjhhdegh") ->true
    public class RansomNoteSln
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (magazine == null && ransomNote == null) return true;
            if (magazine == null) return false;

            //magazine字符串整理为字典
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var item in magazine)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else dict.Add(item, 1);
            }

            foreach (var item in ransomNote)
            {
                if (!dict.ContainsKey(item))//未出现直接返回false
                    return false;
                dict[item]--;
                if (dict[item] == 0) //为0后，移除
                    dict.Remove(item);
            }

            return true;
        }
    }
}
