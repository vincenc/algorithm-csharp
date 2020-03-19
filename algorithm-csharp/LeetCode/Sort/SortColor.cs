/*
 * https://leetcode.com/problems/sort-colors/
 * 
 * Runtime: 228 ms, faster than 95.55% of C# online submissions for Sort Colors.
 * Memory Usage: 30 MB, less than 16.67% of C# online submissions for Sort Colors.
 * 
 * there are three type data 0,1,2 , use head side for 0 , tails side for 2  for seperate data
 * 
 */

using System;

namespace algorithm_csharp
{
    class SortColor
    {
        public void SortColors(int[] nums)
        {
            //0,0,2,1,0,1,2,2
            //2,0,2,1,1,0
            int _length = nums == null ? 0 : nums.Length;
            if (_length <= 1) return;

            int _zeroFlag = 0;
            int _twoFlag = _length - 1;
            int _currentPosition = _zeroFlag;

            while (_currentPosition <= _twoFlag)
            {
                while (_twoFlag > 0 && nums[_twoFlag] == 2)
                {
                    _twoFlag--;
                }

                while (_zeroFlag < _length && nums[_zeroFlag] == 0)
                {
                    _zeroFlag++;                    
                }
                
                if (_zeroFlag > _currentPosition) _currentPosition = _zeroFlag;

                if(_currentPosition > _twoFlag) break;                

                if (nums[_currentPosition] == 2)
                {
                    swap(nums,_currentPosition,_twoFlag);                    
                }

                if (nums[_currentPosition] == 0)
                {
                    swap(nums,_currentPosition,_zeroFlag);                    
                }
                
                _currentPosition++;
                
            }

            return;
        }

        private void swap(int[] nums, int index1, int index2)
        {
            int _length = nums == null ? 0 : nums.Length;
            if (_length <= 1) return;
            if (index1 > _length - 1) throw new ArgumentOutOfRangeException(" index1 to big");
            if (index2 > _length - 1) throw new ArgumentOutOfRangeException(" index2 to big");

            int _temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = _temp;
        }
    }
}
