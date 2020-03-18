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
            LongestIncreasingSubsequence test = new LongestIncreasingSubsequence();
            Console.WriteLine(test.LengthOfLIS(new Int32[] { }));
            Console.WriteLine(test.LengthOfLIS(null));
            Console.WriteLine(test.LengthOfLIS(new Int32[] { 1, 3, 6, 7, 9, 4, 10, 5, 6 }));


            Console.ReadKey();

        }
    }
}
