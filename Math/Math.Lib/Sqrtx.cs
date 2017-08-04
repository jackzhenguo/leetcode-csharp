using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
    public class SqrtSln
    {
        public int MySqrt(int x)
        {
			if(x==0 || x==1)return x;
            int lo = 0, hi = x;
            while (lo - hi < -1)
            {
                //get [lo,hi] middle point,then compare pow2 to x,
                // lo or hi is setted by mid
                //so accelarate the process
                long mid = lo + (hi - lo) / 2; //prevent overflowing
                long pow2 = mid * mid; //prevent overflowing
                if (pow2 < x) lo = (int)mid;
                else if (pow2 > x) hi = (int)mid;
                else return (int)mid;
            }
            return lo;
        }
    }

}
