/*
 * https://leetcode.com/problems/reverse-words-in-a-string/
 * Runtime: 88 ms, faster than 78.00% of C# online submissions for Reverse Words in a String.
 * Memory Usage: 24.9 MB, less than 14.29% of C# online submissions for Reverse Words in a String.
 * 
 * use built in function to do
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_csharp
{
    public class ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            if (s == null) return s;
            // split by empty
            var arr = s.Split(' ');
            if (arr.Length == 0) return string.Empty;
            if (arr.Length == 1) return s;

            var reverseArr = arr.Where(n => n.Length != 0).Reverse();
            // reverse array => for from end
            return string.Join(" ", reverseArr);
        }        
    }
}
