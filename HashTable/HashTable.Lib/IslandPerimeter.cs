/* ==============================================================================
 * 功能描述：TwoSum  
 * 创 建 者：gz
 * 创建日期：2017/4/28 18:20:39
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable.Lib
{
    //Given an array of integers, return indices of the two numbers such that they add up to a specific target.

    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// <summary>
    /// TwoSum
    /// </summary>
    public class TwoSumSln
    {

      public int LandPerimeter(int[,] grid)
       {
           int rtn=0;
           for(int i=0; i<=grid.GetUpperBound(0);i++)
           {
               for(int j=0;j<=grid.GetUpperBound(1);j++)
               {
                   if (grid[i, j] == 1)
                       rtn +=4-surroundingIsland(grid,i,j);
               }
           }
           return rtn;
       }

       //获取某个网格周围的网格数（[0,4]）
       //noy: y向网格索引（行）
       //nox：x向网格索引（列）
       private int surroundingIsland(int[,] grid, int noy, int nox)
       {
           int rtnCnt=0;
           if (nox > 0)
           {
               if (grid[noy, nox - 1] == 1)
                   rtnCnt++;
           }
           if (nox < grid.GetUpperBound(1))//nox小于（列）最大索引吗
           {
               if (grid[noy, nox + 1] == 1)
                   rtnCnt++;
           }
           if (noy > 0)
           {
               if (grid[noy - 1, nox] == 1)
                   rtnCnt++;
           }
           if(noy<grid.GetUpperBound(0))//noy小于最大（行）索引吗
           {
               if (grid[noy + 1, nox] == 1)
                   rtnCnt++;
           }
           return rtnCnt;
       }

    }
}
