/* ==============================================================================
 * 功能描述：PascalsTriangle  
 * 创 建 者：wack
 * 创建日期：2017/4/21 8:22:58
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Given numRows, generate the first numRows of Pascal’s triangle.

//For example, given numRows = 5, 
//Return

//[
//     [1],
//    [1,1],
//   [1,2,1],
//  [1,3,3,1],
// [1,4,6,4,1]
//]
namespace Array.Lib
{
    /// <summary>
    /// #118: Pascal’s Triangle
    /// </summary>
    public class PascalsTriangle
    {

        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> rtn = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                IList<int> ints = new List<int>();
                ints.Add(1);
                for (int j = 1; j < i; j++)
                {
                    IList<int> intsPreRow = rtn[i - 1];
                    ints.Add(intsPreRow[j - 1] + intsPreRow[j]);
                }
                if (i > 0)
                    ints.Add(1);

                rtn.Add(ints);
            }
            return rtn;
        }

    }
}
