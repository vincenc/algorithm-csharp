/*
 *  https://leetcode.com/problems/3sum/submissions/
 *  
 *  Runtime: 312 ms, faster than 75.35% of C# online submissions for 3Sum.
 *  Memory Usage: 35.6 MB, less than 5.00% of C# online submissions for 3Sum.
 *  
 *  two index strategy that using a sorted array to move two index from left(smallest)  and from right(largest)
 *  if target is larger than move right index smaller
 *  if target is smaller than move left index larger
 *  
 *  need to avoid duplicate situation
 */
using System.Collections.Generic;

namespace algorithm_csharp.LeetCode.Array
{
    public class ThreeSumQuestion
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> _result = new List<IList<int>>();
            if (nums == null || nums.Length == 0) return _result;
            System.Array.Sort(nums);

            for (int _fixedThirdNumIndex = 0; _fixedThirdNumIndex < nums.Length; _fixedThirdNumIndex++)
            {
                if (_fixedThirdNumIndex > 0 && nums[_fixedThirdNumIndex] == nums[_fixedThirdNumIndex - 1]) continue;

                int _left = _fixedThirdNumIndex + 1;
                int _right = nums.Length - 1;
                int _target = 0 - nums[_fixedThirdNumIndex];
                while (_left < _right)
                {                    
                    if (nums[_left] + nums[_right] == _target)
                    {
                        if (_left - 1 == _fixedThirdNumIndex || nums[_left] != nums[_left - 1])
                        {
                            _result.Add(new List<int>() { nums[_fixedThirdNumIndex], nums[_left], nums[_right] });
                        }
                        _right--;
                        _left++;
                    }
                    else
                    {
                        if (nums[_left] + nums[_right] > _target)
                            _right--;
                        else
                            _left++;
                    }
                }
            }
            return _result;
        }
    }
}
