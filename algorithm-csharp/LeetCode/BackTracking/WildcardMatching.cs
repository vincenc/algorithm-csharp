/* 
 * https://leetcode.com/problems/wildcard-matching/
 * Runtime: 76 ms, faster than 96.59% of C# online submissions for Wildcard Matching.
 * Memory Usage: 25.8 MB, less than 100.00% of C# online submissions for Wildcard Matching.
 * 
 * use backTrack to recursive test diffrent situation for n x *
 * some situation need keep run backTrack so return null
 * some situation is real result so not null
 * 
 */

namespace algorithm_csharp
{
    class WildcardMatching
    {
        public bool IsMatch(string s, string p)
        {
            p = cleanContinueStar(p);
            if (p == "*") return true;
            if (s.Length == 0 && p.Length == 0) return true;
            if (p.Length == 0) return false;
            bool? _result = backTrack(s, p, 0, 0);// > 1; 
            return _result.HasValue ? _result.Value : false;
        }

        private bool? backTrack(string s, string p, int indexS, int indexP)
        {
            // S is End
            if (indexS == s.Length && indexP == p.Length) return true;//scan to both end
            if (indexS == s.Length && p[indexP] == '*' && indexP + 1 == p.Length) return true;
            if (indexS == s.Length && (p[indexP] != '*' || (indexP + 1 != p.Length && p[indexP + 1] != '*'))) return false;

            // continous recursive not *
            if (s[indexS] == p[indexP] || p[indexP] == '?')
            {
                if (indexP + 1 == p.Length && indexS + 1 != s.Length) return null; //s = aaab   p = *ab => need continous so null
                return backTrack(s, p, indexS + 1, indexP + 1);
            }
            // continous recursive *
            if (p[indexP] == '*')
            {
                if (indexP + 1 == p.Length) return true;
                for (int k = 0; k <= s.Length - indexS; ++k)
                {
                    bool? _temp = backTrack(s, p, indexS + k, indexP + 1);
                    if (_temp.HasValue) return _temp; // has valut mean S is End
                }
            }
            return null;//s = aaab   p = *ab => need continous so null
        }
        private string cleanContinueStar(string p)
        {
            while (p.Contains("**"))
            {
                p = p.Replace("**", "*");
            }
            return p;
        }
    }
}
