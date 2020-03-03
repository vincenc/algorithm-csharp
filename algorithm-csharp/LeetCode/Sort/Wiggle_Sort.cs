/* https://leetcode.com/problems/wiggle-sort/
 * 
 * Runtime: 244 ms, faster than 96.77% of C# online submissions for Wiggle Sort.
 * Memory Usage: 33.1 MB, less than 100.00% of C# online submissions for Wiggle Sort.
 * 
 * use heap sort for reorder in-place
 * step 1 order
 * step 2 swap nodes without head and tail
 * 
 * 0 1 2 3 4 5 =>
 * 0 2 1 4 3 5
 * 
 * time O(nlogn)
 * space O(1)
 */

using System;

namespace algorithm_csharp
{
    class Wiggle_Sort
    {
        public void WiggleSort(int[] nums)
        {
            //Array.Sort(nums);
            HeapSort(nums);
            for (int i = 1; i < nums.Length - 1; i += 2)
            {
                swap(nums, i, i + 1);
            }
        }

        private static void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public static void HeapSort(int[] nums)
        {
            int _length = nums.Length;

            for (int i = _length / 2 - 1; i >= 0; i--) // heapfy from leaf's parent
            {
                maxHeapify(nums, i, _length);
            }

            for (int i = _length - 1; i > 0; i--)
            {
                swap(nums, 0, i);                      // moving tree root(max) to tail
                _length--;
                maxHeapify(nums, 0, _length);          // re heapfy
            }
        }

        private static void maxHeapify(int[] nums, int root, int length)
        {
            int _left = 2 * root + 1,
                _right = 2 * root + 2,
                _max;

            if (_left < length && nums[_left] > nums[root])
                _max = _left;
            else
                _max = root;

            if (_right < length && nums[_right] > nums[_max])
                _max = _right;

            if (_max != root)
            {
                swap(nums, _max, root);
                maxHeapify(nums, _max, length);// new roots, need check this subtree
            }
        }



        private static void mergeSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int _middle = (left + right) / 2;
                mergeSort(nums, left, _middle);
                mergeSort(nums, _middle + 1, right);
                merge(nums, left, _middle, right);
            }
        }

        private static void merge(int[] nums, int left, int middle, int right)
        {
            int[] _temp = new int[nums.Length];
            for (int i = left; i <= right; i++)
            {
                _temp[i] = nums[i];
            }

            int _tempLeft = left; // left region start
            int _tempRight = middle + 1; // right region start
            int _current = left;

            while (_tempLeft <= middle && _tempRight <= right)
            {
                if (_temp[_tempLeft] <= _temp[_tempRight])
                {
                    nums[_current] = _temp[_tempLeft];
                    _tempLeft++;
                }
                else
                {
                    nums[_current] = _temp[_tempRight];
                    _tempRight++;
                }
                _current++;
            }

            int _remaining = middle - _tempLeft; // left include middle, would be one more item than right
            for (int i = 0; i <= _remaining; i++)
            {
                nums[_current + i] = _temp[_tempLeft + i];
            }
        }

        public static void MergeSort(int[] nums)
        {
            mergeSort(nums, 0, nums.Length - 1);
        }

        public static void QuickSort(int[] nums)
        {
            quickSort(nums, 0, nums.Length - 1);
        }

        private static void quickSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int _pivot = partition(nums, left, right);
                quickSort(nums, left, _pivot - 1);
                quickSort(nums, _pivot + 1, right);
            }
        }

        private static int partition(int[] nums, int left, int right)
        {
            int _pivot = nums[right];          // use tail as pivot to partition
            int i = left-1;
            for (int j = left; j < right; j++) //move small to left partition
            {
                if (nums[j] < _pivot)
                {
                    i++;
                    swap(nums, i, j);
                }
            }
            i++;
            swap(nums, i, right);              //move pivot to middle of two partition
            return i;
        }
    }
}
