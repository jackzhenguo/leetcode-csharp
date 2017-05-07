using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable.Lib
{
    public class WordPattenSln
    {
        //pattern = "abba", str = "dog cat cat dog"
        public bool WordPattern(string pattern, string str){
            string[] words = str.Split(' ');
            if (pattern.Length != words.Length) return false;
            Dictionary<char, string> patternDict = new Dictionary<char, string>();
            Dictionary<string, char> wordsDict = new Dictionary<string, char>();
            for (int i = 0; i < pattern.Length; i++){
                if(patternDict.ContainsKey(pattern[i]) && patternDict[pattern[i]]!=words[i] ||
                   wordsDict.ContainsKey(words[i]) && wordsDict[words[i]]!=pattern[i] )
                    return false;
                patternDict[pattern[i]] = words[i];
                wordsDict[words[i]] = pattern[i];
            }
            return true;
        }
    }
}
