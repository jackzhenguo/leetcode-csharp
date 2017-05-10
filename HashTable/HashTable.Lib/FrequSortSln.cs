/* ==============================================================================
 * 功能描述：FrequSort  
 * 创 建 者：gz
 * 创建日期：2017/5/10 18:05:01
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Given a string, sort it in decreasing order based on the frequency of characters.

//Example 1:

//Input:
//"tree"

//Output:
//"eert"

//Explanation:
//'e' appears twice while 'r' and 't' both appear once.
//So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
//Example 2:

//Input:
//"cccaaa"

//Output:
//"cccaaa"

//Explanation:
//Both 'c' and 'a' appear three times, so "aaaccc" is also a valid answer.
//Note that "cacaca" is incorrect, as the same characters must be together.
//Example 3:

//Input:
//"Aabb"

//Output:
//"bbAa"

//Explanation:
//"bbaA" is also a valid answer, but "Aabb" is incorrect.
//Note that 'A' and 'a' are treated as two different characters.
namespace FrequencySortSln
{
    /// <summary>
    /// FrequSort
    /// </summary>
    public class FrequSortSln
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();
            string[] buckets = new string[s.Length+1]; //索引用作字符个数，最大的个数索引也为最大
            //count char frequency
            foreach (var c in s)
            {
                if (!freq.ContainsKey(c))
                    freq.Add(c, 1);
                else freq[c]++;
            }
            //put char to buckets
            foreach (var item in freq)
            {
                int n = item.Value;
                char c = item.Key;
                StringBuilder builder = new StringBuilder();
                buckets[n] += builder.Append(c, n).ToString();
            }
            StringBuilder builder2 = new StringBuilder();
            //form string
            for (int i = s.Length; i > 0; i--)
            {
                if (buckets[i] != null)
                    builder2.Append(buckets[i]);
            }
            return builder2.ToString();
        }

    }
}
