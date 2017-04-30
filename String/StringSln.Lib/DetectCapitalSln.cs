using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSln.Lib
{
    public class DetectCapitalSln
    {
        //        Given a word, you need to judge whether the usage of capitals in it is right or not.

        //We define the usage of capitals in a word to be right when one of the following cases holds:

        //All letters in this word are capitals, like “USA”. 
        //All letters in this word are not capitals, like “leetcode”. 
        //Only the first letter in this word is capital if it has more than one letter, like “Google”. 
        //Otherwise, we define that this word doesn’t use capitals in a right way.

        //Example 1:
        //Input: "USA"
        //Output: True

        //Example 2:
        //Input: "FlaG"
        //Output: False

        public bool DetectCapitalUse(string word)
        {
            if (string.IsNullOrEmpty(word)) return true;

            char fst = word[0];
            if (charCapital(fst))
            {
                int afterCapital = 0;
                for (int i = 1; i < word.Length; i++)
                {
                    if (charCapital(word[i]))
                        afterCapital++;
                }
                if (afterCapital == 0)
                    return true;//只有首字符大写
                else if (afterCapital == word.Length - 1)
                    return true;//都是大写
                return false;
            }
            else//首字符小写
            {
                int afterCapotal = 0;
                for (int i = 1; i < word.Length; i++)
                {
                    if (charCapital(word[i]))
                        afterCapotal++;
                }
                return afterCapotal == 0 ? true : false;
            }

        }

        private bool charCapital(char ch)
        {
            int chint = Convert.ToInt32(ch);
            if (chint >= 65 && chint <= 90)
                return true;
            return false;
        }
    }
}
