using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable.Lib
{
    public class PrimesCountSln
    {
        public int CountPrimes(int n)
        {
            int rtncnt = 0;
            bool[] notPrimes = new bool[n];
            for (int i = 2; i < n; i++)
            {
                if (notPrimes[i]) continue;
                rtncnt++;
                for (int j = 2; i * j < n; j++)
                {
                    notPrimes[i * j] = true;
                }
            }
            return rtncnt;
        }
    }
}
