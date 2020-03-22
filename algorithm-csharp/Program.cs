using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] builds = new int[5][] {
            //    new int []{ 19,24,8},
            //    new int []{ 5,12,12},
            //    new int []{ 2,9,10},
            //    new int []{ 3,7,5},                
            //    new int []{ 15,20,10}

            //};

            //TheSkylineProblem sky = new TheSkylineProblem();
            //sky.GetSkyline(builds);

            ReorganizeStrings test = new ReorganizeStrings();
            Console.WriteLine(test.ReorganizeString("aaab"));

            Console.ReadKey();

        }
    }
}
