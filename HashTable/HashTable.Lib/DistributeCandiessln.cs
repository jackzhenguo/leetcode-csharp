/* ==============================================================================
 * 功能描述：DistributeCandies  
 * 创 建 者：gz
 * 创建日期：2017/5/11 13:38:38
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Given an integer array with even length, where different numbers in this array represent different kinds of candies. 
//Each number means one candy of the corresponding kind. You need to distribute these candies equally 
//in number to brother and sister. Return the maximum number of kinds of candies the sister could gain.

//Example 1:
//Input: candies = [1,1,2,2,3,3]
//Output: 3
//Explanation:
//There are three different kinds of candies (1, 2 and 3), and two candies for each kind.
//Optimal distribution: The sister has candies [1,2,3] and the brother has candies [1,2,3], too. 
//The sister has three different kinds of candies. 
//Example 2:
//Input: candies = [1,1,2,3]
//Output: 2
//Explanation: For example, the sister has candies [2,3] and the brother has candies [1,1]. 
//The sister has two different kinds of candies, the brother has only one kind of candies. 
namespace RandomizedCollection
{
    /// <summary>
    /// DistributeCandies [1,1,1,1]
    /// </summary>
    public class DistributeCandiessln
    {
        public int DistributeCandies(int[] candies)
        {
            int n = candies.Length;
            HashSet<int> kinds = new HashSet<int>();
            foreach (var item in candies)
            {
                if (!kinds.Contains(item))
                    kinds.Add(item);
            }
            if (kinds.Count > n/2)
                return n/2; //糖果要均分，所以种类再多，也只能分到n/2种
            return kinds.Count; //种类较少，妹妹最多分到kinds.Count种，如[1,1,1,1], 返回1
        }

    }
}
