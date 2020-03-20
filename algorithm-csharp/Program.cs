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
            MedianOfTwoSortedArrays test = new MedianOfTwoSortedArrays();
            //int[] test1 = new Int32[] { };
            //Console.WriteLine(test.FindMin(test1));

            //int[] test2 = null;
            //Console.WriteLine(test.FindMin(test2));


            int[] test3 = new Int32[] { 1, 5, 9, 15, 18 };  //18
            int[] test4 = new Int32[] { 2, 4, 20, 30, 40, 48, 49, 50 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 1, 5, 9, 15, 18, 19 };  //18.5
            test4 = new Int32[] { 2, 4, 20, 30, 40, 48, 49, 50 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 56, 57, 58, 59, 60 };  //48.5
            test4 = new Int32[] { 2, 4, 20, 30, 40, 48, 49 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 56, 57, 58, 59, 60, 61 };  //49
            test4 = new Int32[] { 2, 4, 20, 30, 40, 48, 49 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 1, 3 };  //2
            test4 = new Int32[] { 2 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 1, 2 }; //2.5
            test4 = new Int32[] { 3, 4 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 1, 2 }; //2.5
            test4 = new Int32[] { 3, 4, 5, 6, 7 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 1, 3 };  //2.5
            test4 = new Int32[] { 2, 4 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 1, 3, 5 };  //3
            test4 = new Int32[] { 2, 4 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 1 };  //1.5
            test4 = new Int32[] { 2 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 0, 0 };  //1.5
            test4 = new Int32[] { 0, 0 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 1, 1 };  //1.5
            test4 = new Int32[] { 1, 2 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 2, 2 };  //1.5
            test4 = new Int32[] { 1, 2 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 1, 2 };  //1.5
            test4 = new Int32[] { 2, 2 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 1 };  //1.5
            test4 = new Int32[] { 1 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { };  //1.5
            test4 = new Int32[] { 1 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));


            test3 = new Int32[] { };  //1.5
            test4 = new Int32[] { 2, 3 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));

            test3 = new Int32[] { 1, 1, 1 };  //1.5
            test4 = new Int32[] { 1, 1, 1 };
            Console.WriteLine(test.FindMedianSortedArrays(test3, test4));
            Console.ReadKey();

        }
    }
}
