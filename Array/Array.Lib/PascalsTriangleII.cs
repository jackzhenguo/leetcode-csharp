/* ==============================================================================
 * 功能描述：PascalsTriangleII  
 * 创 建 者：gz
 * 创建日期：2017/4/21 8:24:50
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Given an index k, return the kth row of the Pascal’s triangle.

//For example, given k = 3, 
//Return [1,3,3,1].

//Note: 
//Could you optimize your algorithm to use only O(k) extra space?
namespace Array.Lib
{
    /// <summary>
    /// 119 : Pascal’s Triangle II
    /// </summary>
    public class PascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            if (rowIndex < 0) return new List<int>();
            IList<int> levelList = new List<int>();
            for (int i = 0; i <= rowIndex; i++)
            {
                int k = levelList.Count;
                for (int j = k - 1; j >= 1; j--)  //这个循环是最重要的一部分，巧妙的运用了Pascal三角的特点
                {
                    levelList[j] = levelList[j - 1] + levelList[j];
                }
                levelList.Add(1);
            }
            return levelList;
        }

    }
}
