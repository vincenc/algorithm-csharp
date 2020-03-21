/*
 * https://leetcode.com/problems/valid-palindrome/
 * 
 * Runtime: 72 ms, faster than 95.71% of C# online submissions for Valid Palindrome.
 * Memory Usage: 25.3 MB, less than 9.52% of C# online submissions for Valid Palindrome.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_csharp
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (s == null) return false;
            if (s.Length <= 1) return true;

            s = s.ToLower();
            //check should it put in stack
            var trimNotAlphbet = s.Where(n => (n >= 'a' && n <= 'z') || (n >= '0' && n <= '9')).Select(n => n);
            s = string.Concat(trimNotAlphbet);
            // aa  2/2 = 1   0   1
            // aaa 3/2 = 1   1   2
            Stack<char> checker = new Stack<char>();
            //start to pop at mid point => check length first => replace empty non alphanumeric
            for (int i = 0; i < s.Length / 2; i++)//O(n)
            {
                checker.Push(s[i]);
            }

            for (int i = (s.Length + 1) / 2; i < s.Length; i++)//O(n)
            {
                bool temp = checker.Pop() == s[i];
                if (temp == false) return temp;
            }
            return true;
        }
    }
}
