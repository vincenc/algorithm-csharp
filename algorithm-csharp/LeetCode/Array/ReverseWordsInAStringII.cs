/* https://leetcode.com/problems/reverse-words-in-a-string-ii/
 * Runtime: 420 ms, faster than 59.06% of C# online submissions for Reverse Words in a String II.
 * Memory Usage: 38.5 MB, less than 25.00% of C# online submissions for Reverse Words in a String II.
 * 
 * use built in function to do
 */
using System.Linq;

namespace algorithm_csharp.LeetCode.Array
{
    public class ReverseWordsInAStringII
    {
        public void ReverseWords(char[] s)
        {
            if (s == null) return;
            if (s.Length == 0 || s.Length == 1) return;

            string _s = string.Concat(s);

            // split by empty
            var arr = _s.Split(' ');
            if (arr.Length == 0) return;
            if (arr.Length == 1) return;

            var reverseArr = arr.Reverse();
            // reverse array => for from end
            _s = string.Join(" ", reverseArr);

            for (int i = 0; i < s.Length; i++)
            {
                s[i] = _s[i];
            }            
        }
    }
}
