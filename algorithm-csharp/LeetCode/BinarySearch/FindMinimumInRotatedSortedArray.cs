/* 
 * https://leetcode.com/problems/find-minimum-in-rotated-sorted-array
 * 
 * Runtime: 88 ms, faster than 90.84% of C# online submissions for Find Minimum in Rotated Sorted Array
 * Memory Usage: 24.5 MB, less than 8.33% of C# online submissions for Find Minimum in Rotated Sorted Array.
 * 
 * time O(logN) by binary search
 * 
 */

using System;

namespace algorithm_csharp
{
    class FindMinimumInRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            int _length = nums == null ? 0 : nums.Length;
            if (_length == 0) throw new ArgumentException(" array is null or no item in array");
            if (_length == 1) return nums[0];
            if (nums[0] < nums[_length - 1]) return nums[0];

            return bnsMin(nums, 0, _length - 1);
        }

        private int bnsMin(int[] nums, int left, int right)
        {
            if(left > right)
                throw new Exception(" error happend , there should be one min");

            int _middle = (left + right) / 2;
            if (_middle > 0 && nums[_middle - 1] > nums[_middle]) return nums[_middle];
            if (_middle < right && nums[_middle] > nums[_middle + 1]) return nums[_middle + 1];

            if (nums[_middle] > nums[right])
                return bnsMin(nums, _middle + 2, right);
            else
                return bnsMin(nums, left, _middle-1);

        }
    }
}
