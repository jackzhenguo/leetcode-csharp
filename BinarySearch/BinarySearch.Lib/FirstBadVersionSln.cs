using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Lib
{
    //    You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

    //Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

    //You are given an API bool isBadVersion(version) which will return whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.
    public class FirstBadVersionSln
    {
        public int FirstBadVersion(int n)
        {
            long lo = 0; //指向好的版本
            long hi = n; //指向坏的版本
            long mid;
            while (hi - lo > 1)
            {
                mid = (lo + hi) >> 1; //写为这样就不怕溢出(lo + (hi-lo)/2)
                if (IsBadVersion(mid))
                    hi = mid;
                else
                    lo = mid;
            }
            return (int)hi;
        }
    }
}
