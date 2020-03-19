/*
 * https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii
 * 
 * Runtime: 92 ms, faster than 82.24% of C# online submissions for Find Minimum in Rotated Sorted Array II.
 * Memory Usage: 25 MB, less than 100.00% of C# online submissions for Find Minimum in Rotated Sorted Array II.
 * 
 * if head value = tail value , it will be not able to choose side for bns.
 * so search both sides
 * 
 */

using System;

namespace algorithm_csharp
{
    class FindMinimumInRotatedSortedArrayII
    {
        public int FindMin(int[] nums)
        {
            int _length = nums == null ? 0 : nums.Length;
            if (_length == 0) throw new ArgumentException(" array is null or no item in array");
            if (_length == 1) return nums[0];
            if (nums[0] < nums[_length - 1]) return nums[0];

            if (nums[0] == nums[_length - 1])
                return bnsBothSideMin(nums, 0, _length - 1);
            else
                return bnsMin(nums, 0, _length - 1);
        }

        private int bnsBothSideMin(int[] nums, int left, int right)
        {
            if (left > right)
                return nums[0];

            int _middle = (left + right) / 2;
            if (_middle > 0 && nums[_middle - 1] > nums[_middle]) return nums[_middle];
            if (_middle < right && nums[_middle] > nums[_middle + 1]) return nums[_middle + 1];

            return Math.Min(bnsBothSideMin(nums, _middle + 2, right), bnsBothSideMin(nums, left, _middle - 1));

        }

        private int bnsMin(int[] nums, int left, int right)
        {
            if (left > right)
                throw new Exception(" error happend , there should be one min");

            int _middle = (left + right) / 2;
            if (_middle > 0 && nums[_middle - 1] > nums[_middle]) return nums[_middle];
            if (_middle < right && nums[_middle] > nums[_middle + 1]) return nums[_middle + 1];

            if (nums[_middle] > nums[right])
                return bnsMin(nums, _middle + 2, right);
            else
                return bnsMin(nums, left, _middle - 1);

        }
    }
}
