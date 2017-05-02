using Array.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveElementSln sln = new RemoveElementSln();
            int cnt = sln.RemoveElement(new int[] { 3, 2, 2, 3 }, 3);
        }
    }
}
