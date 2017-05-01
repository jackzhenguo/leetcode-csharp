using Array.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] para= new int[]{8,9};
            PlusOneSln posln = new PlusOneSln();
            int[] ints = posln.PlusOne(para);
        }
    }
}
