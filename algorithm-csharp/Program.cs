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
            int[] array = new[] {3,5,2,1,6,4};
            //Wiggle_Sort.MergeSort(array);
            Wiggle_Sort.QuickSort(array);
            Console.WriteLine(string.Join(",",array));
            Console.ReadKey();
        }
    }
}
