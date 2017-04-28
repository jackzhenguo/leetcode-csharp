/* ==============================================================================
 * 功能描述：Boomerangs  
 * 创 建 者：gz
 * 创建日期：2017/4/28 18:24:56
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Given n points in the plane that are all pairwise distinct, a “boomerang” is a tuple of points (i, j, k) such that the distance between i and j equals the distance between i and k (the order of the tuple matters).

//Find the number of boomerangs. You may assume that n will be at most 500 and coordinates of points are all in the range [-10000, 10000] (inclusive).

//Example:

//Input:
//[[0,0],[1,0],[2,0]]

//Output:
//2

//Explanation:
//The two boomerangs are [[1,0],[0,0],[2,0]] and [[1,0],[2,0],[0,0]]
namespace HashTable.Lib
{
    /// <summary>
    /// Boomerangs
    /// </summary>
    public class Boomerangs
    {


        #region 公有方法
        public static int NumberOfBoomerangs(int[,] points)
        {
            Dictionary<double, int> dict = new Dictionary<double, int>();
            int len = points.GetUpperBound(0);
            int rtnCnt = 0;
            for (int i = 0; i <= len; i++)
            {
                //3点变2点
                for (int j = 0; j <= len; j++)
                {
                    if (i == j) continue;
                    double d = distance(points[i, 0], points[j, 0], points[i, 1], points[j, 1]);
                    if (dict.ContainsKey(d))
                        dict[d]++;
                    else dict.Add(d, 1);
                }
                foreach (var item in dict)
                {
                    if (item.Value > 1)
                    {
                        //如果找到了value个，因为有顺序，所以排序
                        rtnCnt += item.Value * (item.Value - 1);
                    }
                }
                dict.Clear();
            }
            return rtnCnt;
        }

        private static double distance(int x1, int x2, int y1, int y2)
        {
            int x = x1 - x2;
            int y = y1 - y2;

            return Math.Sqrt(x * x + y * y);
        }
        #endregion

    }
}
