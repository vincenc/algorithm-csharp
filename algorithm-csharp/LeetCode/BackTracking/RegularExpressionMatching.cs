/* 
 * https://leetcode.com/problems/regular-expression-matching/
 * Runtime: 116 ms, faster than 37.70% of C# online submissions for Regular Expression Matching.
 * Memory Usage: 24.4 MB, less than 25.00% of C# online submissions for Regular Expression Matching.
 * 
 * use backTrack to test continous prefix of *
 *  
 * 
 */
namespace algorithm_csharp
{
    public class RegularExpressionMatching
    {
        public bool IsMatch(string s, string p)
        {
            if (s.Length == 0 && p.Length == 0) return true;
            if (p.Length == 0) return false;
            if (p == ".*") return true;

            bool? _result = backTrack(s, p, 0, 0);
            return _result.HasValue ? _result.Value : false;
        }

        private bool? backTrack(string s, string p, int indexS, int indexP)
        {
            if (indexS == s.Length && indexP == p.Length) return true;
            if (indexS == s.Length && p[p.Length - 1] == '*')
            {
                bool _temp;
                for (int i = 1; i <= p.Length - indexP; i = i + 2)
                {
                    _temp = p[indexP + i] == '*';
                    if (_temp == false) return false;
                }
                return true;
            }
            if (indexS == s.Length && indexP < p.Length) return false;
            if (indexP == p.Length) return null;

            if (s[indexS] == p[indexP] || p[indexP] == '.')
            {
                if (indexS + 1 == s.Length && indexP + 1 == p.Length) return true;

                if (indexP + 1 != p.Length && p[indexP + 1] != '*')
                {
                    return backTrack(s, p, indexS + 1, indexP + 1);                    
                }
            }

            if (indexP + 1 != p.Length && p[indexP + 1] == '*')
            {
                //* can be empty => p+1 s+0
                //.* p+1 s+0~n
                //not .* p+1 s+0~n                
                for (int i = 0; i <= s.Length - indexS; i++) // continue prefix
                {
                    bool? _temp = null;
                    if (i == 0)
                    {
                        _temp = backTrack(s, p, indexS + i, indexP + 2);
                    }
                    else
                    {
                        if (s[indexS + i - 1] == p[indexP] || p[indexP] == '.')
                        {
                            _temp = backTrack(s, p, indexS + i, indexP + 2);
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (_temp.HasValue) return _temp;
                }
            }
            return null;
        }
    }
}
