using Math.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Nthdigit nth = new Nthdigit();
            if(Int32.MaxValue == 2147483647)
            {
                int n = nth.FindNthDigit(2147483647);
            } 
            
        }
    }
}
