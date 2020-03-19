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
            SortColor test = new SortColor();

            int[] test1 = new Int32[] {};
            test.SortColors(test1);
            Console.WriteLine(test1);            

            int[] test2 = null;
            test.SortColors(test2);
            Console.WriteLine(test2);

            var test3 = new Int32[] { 0, 0, 2, 1, 0, 1, 2, 2 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 0,0 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 1, 1 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 2, 2 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 0, 2 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 2, 0 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 1, 0 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 0, 1 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 2, 1 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 1, 2 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 1, 1 ,0 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 0, 0, 0 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 1, 1, 1 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 2, 2, 2 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 1, 0, 1 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 1 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 0 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));

            test3 = new Int32[] { 2 };
            test.SortColors(test3);
            Console.WriteLine(String.Join(",", test3));


            Console.ReadKey();

        }
    }
}
