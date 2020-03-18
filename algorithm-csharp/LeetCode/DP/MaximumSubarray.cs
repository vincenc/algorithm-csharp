/* https://leetcode.com/problems/maximum-subarray/
 * Runtime: 88 ms, faster than 96.96% of C# online submissions for Maximum Subarray.
 * Memory Usage: 25.5 MB, less than 10.00% of C# online submissions for Maximum Subarray.
 * 
 * O(n) oneway check group start and end
 * if this group sum is negative and smaller than new num than renew group from num
 * 
 */

using System;

namespace algorithm_csharp
{
    class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            //-2,1,-3,4,-1,2,1,-5,4
            int _length = nums == null ? 0 : nums.Length;
            int maxResult = int.MinValue;
            if (_length == 0) return 0;

            int currentSum = 0; // if current sum is nag and < current => give up current sum
            for (int i = 0; i < _length; i++)
            {
                if (currentSum < 0 && currentSum < nums[i])
                    currentSum = 0;
                currentSum += nums[i];
                maxResult = Math.Max(currentSum, maxResult);
            }

            return maxResult;
        }
    }
}
