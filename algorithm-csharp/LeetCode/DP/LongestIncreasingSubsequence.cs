/* https://leetcode.com/problems/longest-increasing-subsequence
 * 
 * Runtime: 100 ms, faster than 84.46% of C# online submissions for Longest Increasing Subsequence.
 * Memory Usage: 24 MB, less than 25.00% of C# online submissions for Longest Increasing Subsequence.
 * 
 * use DP to solve this question
 * 
 * time O(n^2)
 * space O(n)
 * 
 */
using System;

namespace algorithm_csharp
{
    class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            int _length = nums == null ? 0 : nums.Length;
            if (_length == 0) return 0;

            int _maxLength = 0;

            int[] dp = new int[_length];
            dp[0] = 1;
            //10, 9, 2, 5, 3, 7, 101, 18
            //1, 3, 6, 7, 9, 4, 10, 5, 6
            for (int tail = 0; tail < _length; tail++)
            {
                int currentMax = 0;
                for (int current = 0; current < tail; current++)
                {
                    if (nums[tail] > nums[current])
                    {
                        currentMax = Math.Max(currentMax, dp[current]);
                    }
                }
                dp[tail] = currentMax + 1;
                _maxLength = Math.Max(_maxLength, dp[tail]);
            }

            return _maxLength;
        }
    }
}
