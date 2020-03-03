/*
 * https://leetcode.com/problems/permutations/
 *  
 * Runtime: 240 ms, faster than 84.88% of C# online submissions for Permutations.
 * Memory Usage: 31.6 MB, less than 25.00% of C# online submissions for Permutations.
 * 
 * use backtracking(recover last actions) recursively to try all possible permutations
 * use hashset to check that one num will not use again
 * 
 */
using System.Collections.Generic;
using System.Linq;

namespace algorithm_csharp
{
    public class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var _result = new List<IList<int>>();
            var _length = nums == null ? 0 : nums.Length;
            if (_length == 0) return new List<IList<int>>();
            HashSet<int> _visited = new HashSet<int>();
            backTrack(_result, new List<int>(), _visited, nums);

            return _result;
        }
        private void backTrack(List<IList<int>> result, List<int> path, HashSet<int> visited, int[] nums)
        {
            if (path.Count() == nums.Length)
            { 
                result.Add(new List<int>(path));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if(visited.Contains(nums[i])) continue;

                path.Add(nums[i]);
                visited.Add(nums[i]);
                backTrack(result, path, visited , nums);
                path.RemoveAt(path.LastIndexOf(nums[i]));
                visited.Remove(nums[i]);
            }
        }
    }

}
