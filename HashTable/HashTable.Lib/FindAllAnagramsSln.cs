using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable.Lib
{
    //    Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.

    //Strings consists of lowercase English letters only and the length of both strings s and p will not be larger than 20,100.

    //The order of output does not matter.

    //Example 1:

    //Input:
    //s: "cbaebabacd" p: "abc"

    //Output:
    //[0, 6]

    //Explanation:
    //The substring with start index = 0 is "cba", which is an anagram of "abc".
    //The substring with start index = 6 is "bac", which is an anagram of "abc".
    //Example 2:

    //Input:
    //s: "abab" p: "ab"

    //Output:
    //[0, 1, 2]

    //Explanation:
    //The substring with start index = 0 is "ab", which is an anagram of "ab".
    //The substring with start index = 1 is "ba", which is an anagram of "ab".
    //The substring with start index = 2 is "ab", which is an anagram of "ab".
    public class FindAllAnagramsSln
    {
        //s = "cbaebabacd", p = "abc"
        public IList<int> FindAnagrams(string s, string p){
            IList<int> rtn = new List<int>();
            int[] hash = new int[123]; //a~z: 97~122
            foreach (var c in p){
                hash[Convert.ToInt32(c)]++; //hash: key:char, value: occuring times
            }
            int eachBeg = 0, eachEnd = 0, count = p.Length;
            while (eachEnd < s.Length){
                char tmpchar = s[eachEnd];
                if (hash[tmpchar] >= 1) 
                    count--;
                hash[tmpchar]--;
                eachEnd++; //every time the eachEnd pointer to move toward right
                if (count == 0) 
                    rtn.Add(eachBeg);
                //reset the hash. 

                if (eachEnd - eachBeg == p.Length){ 
                    char tmp = s[eachBeg];
                    if (hash[tmp] >= 0)
                        count++;
                    hash[tmp]++;
                    eachBeg++;
                }
            }
            return rtn;
        }
    }
}
