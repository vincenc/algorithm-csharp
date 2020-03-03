/*
 * https://leetcode.com/problems/subsets/
 * 
 * Runtime: 236 ms, faster than 88.13% of C# online submissions for Subsets.
 * Memory Usage: 30.8 MB, less than 12.50% of C# online submissions for Subsets.
 * 
 * use backtrack to recover last action for next parameter
 * take every recursive result , not just take recursive leaf result
 * 
 */
using System;
using System.Collections.Generic;

namespace algorithm_csharp
{
    public class Subset
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var _result = new List<IList<int>>();
            var _length = nums == null ? 0 : nums.Length;
            if (_length == 0) return new List<IList<int>>();

            backTrack(_result, new List<int>(), nums, 0);

            return _result;
        }

        private void backTrack(List<IList<int>> result, List<int> path, int[] nums, int index)
        {
            //if (index > nums.Length)    //if just want full length path ,add this if
            result.Add(new List<int>(path));

            for (int i = index; i < nums.Length; i++)
            {
                path.Add(nums[i]);
                backTrack(result, path, nums, i + 1);
                path.RemoveAt(path.LastIndexOf(nums[i]));
            }
        }
    }
}
