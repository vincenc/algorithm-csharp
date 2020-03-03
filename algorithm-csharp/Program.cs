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
            //int[] array = new[] {3,5,2,1,6,4};
            ////Wiggle_Sort.MergeSort(array);
            //Wiggle_Sort.QuickSort(array);
            //Console.WriteLine(string.Join(",",array));

            LogSystem log = new LogSystem();
            log.Put(1, "2017:01:01:23:59:59");
            log.Put(2, "2017:01:01:22:59:59");
            log.Put(3, "2016:01:01:00:00:00");

            Console.WriteLine(string.Join(",",log.Retrieve("2016:01:01:01:01:01", "2017:01:01:23:00:00", "Year")));
            Console.WriteLine(string.Join(",", log.Retrieve("2016:01:01:01:01:01", "2017:01:01:23:00:00", "Hour")));

            Console.ReadKey();
        }
    }
}
