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
            BestTimeToBuyAndSellStock test = new BestTimeToBuyAndSellStock();
            Console.WriteLine(test.MaxProfit(new Int32[] { }));
            Console.WriteLine(test.MaxProfit(null));
            Console.WriteLine(test.MaxProfit(new Int32[] { 7, 1, 5, 3, 6, 4 }));
            Console.WriteLine(test.MaxProfit(new Int32[] { 0, 1, 5, 3, 6, 9 }));
            Console.WriteLine(test.MaxProfit(new Int32[] { 3, 2, 1, 3, 6, 9 }));
            Console.WriteLine(test.MaxProfit(new Int32[] { 3, 2, 1, 9, 6, 0 }));

            Console.ReadKey();

        }
    }
}
