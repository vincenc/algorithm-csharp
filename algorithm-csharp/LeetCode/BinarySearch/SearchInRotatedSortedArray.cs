/* https://leetcode.com/problems/search-in-rotated-sorted-array/
 * Runtime: 84 ms, faster than 97.74% of C# online submissions for Search in Rotated Sorted Array.
 * Memory Usage: 24.8 MB, less than 11.11% of C# online submissions for Search in Rotated Sorted Array.
 * 
 * intuition
 * use recursive binary search to find the target
 * 
 * time complexity O(logN) 
 * space complexity O(logN) because of recursive
 */

namespace algorithm_csharp
{
    public class SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int _length = nums == null ? 0 : nums.Length;
            // prevent error
            if (_length == 0) return -1;
            if (_length == 1) return nums[0] == target ? 0 : -1;
            if (nums[0] < nums[_length - 1]) // not rotated
            {
                if (target < nums[0] || nums[_length - 1] < target)// outside the range
                {
                    return -1;
                }
            }
            return binarySearch(nums, 0, _length - 1, target);
        }

        /// <summary>
        ///    4 5 6 7 8 9 10  no rotated            : if 7 < target => find right else =>find left
        ///    7 8 9 3 4 5 6   rotated point at left : if 3 < target <= 6 => find right else find left
        ///    4 5 6 7 8 1 2   rotated point at right: if 4 < target < 7  => find left else find right
        /// </summary>                
        private int binarySearch(int[] nums, int left, int right, int target)
        {
            if (right < 0) return -1;
            if (left >= right) return nums[right] == target ? right : -1;
            int midle = (left + right) / 2;
            if (nums[midle] == target) return midle;
            if (nums[right] > nums[left])       // no rotated
            {
                if (nums[midle] < target)
                    return binarySearch(nums, midle + 1, right, target);
                else                
                    return binarySearch(nums, left, midle - 1, target);
            }
            else                                // has rotated
            {
                if (nums[midle] <= nums[right]) // rotated point at left
                {
                    if (nums[midle] <= target && target <= nums[right])
                        return binarySearch(nums, midle + 1, right, target); //find right
                    else
                        return binarySearch(nums, left, midle - 1, target);  //find left
                }
                else                           // rotated point at right => nums[midle] > nums[right]
                {
                    if (nums[left] <= target && target < nums[midle])
                        return binarySearch(nums, left, midle - 1, target);  //find left
                    else
                        return binarySearch(nums, midle + 1, right, target); //find right
                }
            }
        }
    }
}
