using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Lib
{
    //    You have a total of n coins that you want to form in a staircase shape, where every k-th row must have exactly k coins.

    //Given n, find the total number of full staircase rows that can be formed.

    //n is a non-negative integer and fits within the range of a 32-bit signed integer.
    public class ArrangeCoinsSln
    {
        public int ArrangeCoins(int n)
        {
            int low = 1, high = n;
            while (low < high)
            {
                //mid的类型，一定防止溢出
                int mid = low + (high - low + 1) / 2;
                if ((mid + 1) * mid / 2.0 <= n)
                    low = mid;
                else high = mid - 1;
            }
            return high;
        }
    }
}
