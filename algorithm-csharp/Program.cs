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
            FindMinimumInRotatedSortedArray test = new FindMinimumInRotatedSortedArray();
            //int[] test1 = new Int32[] { };
            //Console.WriteLine(test.FindMin(test1));

            //int[] test2 = null;
            //Console.WriteLine(test.FindMin(test2));


            int[] test3 = new Int32[] { 2,2,2,0,1 };
            Console.WriteLine(test.FindMin(test3));

            test3 = new Int32[] { 1,1,1,2,3,4,5,0 };
            Console.WriteLine(test.FindMin(test3));

            test3 = new Int32[] { 1, 0 };
            Console.WriteLine(test.FindMin(test3));

            test3 = new Int32[] { 0 ,1 };
            Console.WriteLine(test.FindMin(test3));

            test3 = new Int32[] {  1 };
            Console.WriteLine(test.FindMin(test3));

            test3 = new Int32[] { 1,1 };
            Console.WriteLine(test.FindMin(test3));

            test3 = new Int32[] { 1, 1 ,1 };
            Console.WriteLine(test.FindMin(test3));

            test3 = new Int32[] { 2, 3, 1 };
            Console.WriteLine(test.FindMin(test3));

            test3 = new Int32[] { 2, 3, 3 ,3, 1 };
            Console.WriteLine(test.FindMin(test3));

            test3 = new Int32[] { 2, 3, 3, 3, 3 };
            Console.WriteLine(test.FindMin(test3));

            test3 = new Int32[] { 3, 3, 3, 3 ,2 , 3};
            Console.WriteLine(test.FindMin(test3));




            Console.ReadKey();

        }
    }
}
