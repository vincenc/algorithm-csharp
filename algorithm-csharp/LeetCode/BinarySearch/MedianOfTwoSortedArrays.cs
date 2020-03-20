/* 
 * https://leetcode.com/problems/median-of-two-sorted-arrays/
 * 
 * Runtime: 116 ms, faster than 88.79% of C# online submissions for Median of Two Sorted Arrays.
 * Memory Usage: 27.7 MB, less than 6.25% of C# online submissions for Median of Two Sorted Arrays.
 * 
 * bns to shortest array, check the middle position's status  
 * 
 * num1LeftMax = shortArray[middle]
 * num2LeftMax = longArray[(total items/2) - middle]
 * 
 * num1Left + num2Left = (total items/2)
 * num1Right + num2Right = (total items/2)
 * 
 * if num1LeftMax < num2RightMin and num2LeftMax < num1RightMin => there is one median in these four point
 * 
 */

using System;

namespace algorithm_csharp
{
    class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // O( log(m+n))
            // bns two array
            int _length1 = nums1 == null ? 0 : nums1.Length;
            int _length2 = nums2 == null ? 0 : nums2.Length;
            if (_length1 > _length2) return FindMedianSortedArrays(nums2, nums1);

            int _totalLength = _length1 + _length2;
            int kth = (_totalLength) / 2;
            int midIndex = (_totalLength - 1)/2;

            if (_totalLength % 2 == 1) //odds
            {
                if (_length1 == 0) return nums2[midIndex];

                int a = bnySearchKth(nums1, _length1, nums2, 0, _length1 - 1, kth + 1);
                return a;
            }
            else //even
            {
                if (_length1 == 0) return (nums2[midIndex] + nums2[midIndex + 1]) / 2.0;

                int a = bnySearchKth(nums1, _length1, nums2, 0, _length1 - 1, kth);
                int b = bnySearchKth(nums1, _length1, nums2, 0, _length1 - 1, kth + 1);
                return (a + b) / 2.0;
            }
            throw new Exception(" can not find kth");
        }

        private int bnySearchKth(int[] nums1, int nums1Length, int[] nums2, int left, int right, int k)
        {
            int _middleOfNums1 = (left + right + 1) / 2;
            int _remainKOfNums2 = k - _middleOfNums1 - 2;

            int _num1LeftMax = nums1[_middleOfNums1];
            int _num1RightMin = _middleOfNums1 == nums1.Length - 1 ? int.MaxValue : nums1[_middleOfNums1 + 1];
            int _num2LeftMax = _remainKOfNums2 < 0 ? int.MinValue : nums2[_remainKOfNums2];
            int _num2RightMin = _remainKOfNums2 == nums2.Length - 1 ? int.MaxValue : nums2[_remainKOfNums2 + 1];

            if (_middleOfNums1 == 0 && _num1LeftMax > _num2RightMin) return nums2[k - 1];

            if (_num1LeftMax <= _num2RightMin && _num2LeftMax < _num1RightMin)
                if (_remainKOfNums2 < 0)
                    return Math.Min(nums1[_middleOfNums1], nums2[_remainKOfNums2 + 1]);
                else
                    return Math.Max(nums1[_middleOfNums1], nums2[_remainKOfNums2]);

            if (_num2LeftMax > _num1RightMin) // move right
            {
                return bnySearchKth(nums1, nums1Length, nums2, _middleOfNums1 + 1, right, k);
            }

            if (_num1LeftMax > _num2RightMin) // move left
            {
                return bnySearchKth(nums1, nums1Length, nums2, left, _middleOfNums1 - 1, k);
            }

            return _num2LeftMax;
        }
    }
}
