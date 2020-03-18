// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/submissions/
//
// Runtime: 92 ms, faster than 87.08% of C# online submissions for Best Time to Buy and Sell Stock.
// Memory Usage: 25.5 MB, less than 9.52% of C# online submissions for Best Time to Buy and Sell Stock.
//
//
// use dynamic programming to get max result from start and reuse those result for later 
// f1 => sell   => f1(x) = max(f1(x-1), f2(x-1) + todayPrice)
// f2 => not sell cost => f2(x) = max( f2(x-1) , todayPrice * -1)


using System;

namespace algorithm_csharp
{
    class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int _length = prices == null ? 0 : prices.Length;
            if (_length == 0) return maxProfit;

            // 7,1,5,3,6,4
            // f1 = max sell profit => f1(0) = 0 , f1(1) = 0 , f1(2) = 4 , f1(3) = max(4, f2(2) + 3)
            // f2 = min not sell profit => f2(0) = -7 , f2(1) = -1 , f2(2) = -1 , f2(3) = max( last buy not sell, this time buy)
            // can not buy twice => f2 will be current min cost

            int[] f1 = new int[_length]; // sell profit
            int[] f2 = new int[_length]; // not sell profit

            for (int i = 0; i < _length; i++)
            {
                if (i == 0)
                {
                    f1[0] = 0;
                    f2[0] = -1 * prices[0];
                }
                else
                {
                    f1[i] = Math.Max(f1[i - 1], f2[i - 1] + prices[i]);
                    f2[i] = Math.Max(f2[i - 1], -1 * prices[i]);
                }
            }
            return f1[_length - 1];
        }
    }
}
