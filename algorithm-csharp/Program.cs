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
            MaximumSubarray test = new MaximumSubarray();
            Console.WriteLine(test.MaxSubArray(new Int32[] { }));
            Console.WriteLine(test.MaxSubArray(null));
            Console.WriteLine(test.MaxSubArray(new Int32[] { -2, 1, -3, 4, -1 }));
            Console.WriteLine(test.MaxSubArray(new Int32[] { 2, 2, -3, 4, -1 }));
            Console.WriteLine(test.MaxSubArray(new Int32[] { -1, 2, -3, 4, -1 }));
            Console.WriteLine(test.MaxSubArray(new Int32[] { -1, -2, -3, -4, -1 }));
            Console.WriteLine(test.MaxSubArray(new Int32[] { -1, -2, -3, 0, -1 }));
            Console.WriteLine(test.MaxSubArray(new Int32[] { -1, -2, 9, 0, -1 }));
            Console.WriteLine(test.MaxSubArray(new Int32[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));


            Console.ReadKey();

        }
    }
}
