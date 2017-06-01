using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            HammingDistanceSln sln = new HammingDistanceSln();
            int d = sln.HammingDistance(1, 8);
        }
    }
}
