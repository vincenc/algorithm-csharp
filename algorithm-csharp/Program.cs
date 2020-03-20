using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WildcardMatching test = new WildcardMatching();
            Console.WriteLine(test.IsMatch("adceb","*a*b"));
            //short  s or p lengh = 0 , 1 , 2 ,3
            Console.WriteLine(test.IsMatch("aaaabaabaabbbabaabaabbbbaabaaabaaabbabbbaaabbbbbbabababbaabbabbbbaababaaabbbababbbaabbbaabbaaabbbaabbbbbaaaabaaabaabbabbbaabababbaabbbabababbaabaaababbbbbabaababbbabbabaaaaaababbbbaabbbbaaababbbbaabbbbb",
                "**a*b*b**b*b****bb******b***babaab*ba*a*aaa***baa****b***bbbb*bbaa*a***a*a*****a*b*a*a**ba***aa*a**a*"));
            Console.WriteLine(test.IsMatch("a", "a*"));
            Console.WriteLine(test.IsMatch("aa","*"));
            Console.WriteLine(test.IsMatch("ab", "*?*?*"));
            Console.WriteLine(test.IsMatch("abbabbbaabaaabbbbbabbabbabbbabbaaabbbababbabaaabbab",
                "*aabb***aa**a******aa*"));
            Console.WriteLine(test.IsMatch("", "*"));
            Console.WriteLine(test.IsMatch("", "a"));
            Console.WriteLine(test.IsMatch("a", ""));
            Console.WriteLine(test.IsMatch(null, "a"));
            Console.WriteLine(test.IsMatch("a", null));
            Console.WriteLine(test.IsMatch("", "aa"));
            Console.WriteLine(test.IsMatch("aa", ""));
            Console.WriteLine(test.IsMatch(null, "aa"));
            Console.WriteLine(test.IsMatch("aa", null));
            Console.WriteLine(test.IsMatch("aa", "a"));
            Console.WriteLine(test.IsMatch("aa", "aa"));
            Console.WriteLine(test.IsMatch("aa", "aaa"));
            Console.WriteLine(test.IsMatch("a", "a"));
            Console.WriteLine(test.IsMatch("a", "aa"));
            Console.WriteLine(test.IsMatch("a", "aaa"));
            Console.WriteLine(test.IsMatch("aa", "a"));
            Console.WriteLine(test.IsMatch("aa", "aa"));
            Console.WriteLine(test.IsMatch("aa", "aaa"));            
            Console.WriteLine(test.IsMatch("aa", "a"));
            Console.WriteLine(test.IsMatch("aaa", "a"));
            Console.WriteLine(test.IsMatch("a", "aa"));            
            Console.WriteLine(test.IsMatch("aaa", "aa"));
            Console.WriteLine(test.IsMatch("a", "aaa"));
            Console.WriteLine(test.IsMatch("aa", "aaa"));

            //star position  index = 0, -1  or continous star  or all star
            Console.WriteLine(test.IsMatch("aa", "*aa"));
            Console.WriteLine(test.IsMatch("aa", "a*a"));
            Console.WriteLine(test.IsMatch("aa", "aa*"));
            Console.WriteLine(test.IsMatch("aa", "*"));
            Console.WriteLine(test.IsMatch("aa", "**"));
            Console.WriteLine(test.IsMatch("aa", "***"));
            Console.WriteLine(test.IsMatch("aa", "*a"));
            Console.WriteLine(test.IsMatch("aa", "a*"));
            Console.WriteLine(test.IsMatch("aa", "*b"));
            Console.WriteLine(test.IsMatch("aa", "b*"));
            Console.WriteLine(test.IsMatch("aaa", "*aa"));
            Console.WriteLine(test.IsMatch("aaa", "a*a"));
            Console.WriteLine(test.IsMatch("aaa", "aa*"));
            Console.WriteLine(test.IsMatch("aaa", "*"));
            Console.WriteLine(test.IsMatch("aaa", "**"));
            Console.WriteLine(test.IsMatch("aaa", "***"));
            Console.WriteLine(test.IsMatch("aaa", "*a"));
            Console.WriteLine(test.IsMatch("aaa", "a*"));
            Console.WriteLine(test.IsMatch("aaa", "*b"));
            Console.WriteLine(test.IsMatch("aaa", "b*"));
            Console.WriteLine(test.IsMatch("ab", "*aa"));
            Console.WriteLine(test.IsMatch("ab", "a*a"));
            Console.WriteLine(test.IsMatch("ab", "aa*"));
            Console.WriteLine(test.IsMatch("ab", "*"));
            Console.WriteLine(test.IsMatch("ab", "**"));
            Console.WriteLine(test.IsMatch("ab", "***"));
            Console.WriteLine(test.IsMatch("ab", "*a"));
            Console.WriteLine(test.IsMatch("ab", "a*"));
            Console.WriteLine(test.IsMatch("ab", "*b"));
            Console.WriteLine(test.IsMatch("ab", "b*"));
            Console.WriteLine(test.IsMatch("a", "*aa"));
            Console.WriteLine(test.IsMatch("a", "a*a"));
            Console.WriteLine(test.IsMatch("a", "aa*"));
            Console.WriteLine(test.IsMatch("a", "*"));
            Console.WriteLine(test.IsMatch("a", "**"));
            Console.WriteLine(test.IsMatch("a", "***"));
            Console.WriteLine(test.IsMatch("a", "*a"));
            Console.WriteLine(test.IsMatch("a", "a*"));
            Console.WriteLine(test.IsMatch("a", "*b"));
            Console.WriteLine(test.IsMatch("a", "b*"));

            //? position index = 0 , -1 or continous ? or all ?
            Console.WriteLine(test.IsMatch("aa", "?aa"));
            Console.WriteLine(test.IsMatch("aa", "a?a"));
            Console.WriteLine(test.IsMatch("aa", "aa?"));
            Console.WriteLine(test.IsMatch("aa", "?"));
            Console.WriteLine(test.IsMatch("aa", "??"));
            Console.WriteLine(test.IsMatch("aa", "???"));
            Console.WriteLine(test.IsMatch("aa", "?a"));
            Console.WriteLine(test.IsMatch("aa", "a?"));
            Console.WriteLine(test.IsMatch("aa", "?b"));
            Console.WriteLine(test.IsMatch("aa", "b?"));
            Console.WriteLine(test.IsMatch("aaa", "?aa"));
            Console.WriteLine(test.IsMatch("aaa", "a?a"));
            Console.WriteLine(test.IsMatch("aaa", "aa?"));
            Console.WriteLine(test.IsMatch("aaa", "?"));
            Console.WriteLine(test.IsMatch("aaa", "??"));
            Console.WriteLine(test.IsMatch("aaa", "???"));
            Console.WriteLine(test.IsMatch("aaa", "?a"));
            Console.WriteLine(test.IsMatch("aaa", "a?"));
            Console.WriteLine(test.IsMatch("aaa", "?b"));
            Console.WriteLine(test.IsMatch("aaa", "b?"));
            Console.WriteLine(test.IsMatch("ab", "?aa"));
            Console.WriteLine(test.IsMatch("ab", "a?a"));
            Console.WriteLine(test.IsMatch("ab", "aa?"));
            Console.WriteLine(test.IsMatch("ab", "?"));
            Console.WriteLine(test.IsMatch("ab", "??"));
            Console.WriteLine(test.IsMatch("ab", "???"));
            Console.WriteLine(test.IsMatch("ab", "?a"));
            Console.WriteLine(test.IsMatch("ab", "a?"));
            Console.WriteLine(test.IsMatch("ab", "?b"));
            Console.WriteLine(test.IsMatch("ab", "b?"));
            Console.WriteLine(test.IsMatch("a", "?aa"));
            Console.WriteLine(test.IsMatch("a", "a?a"));
            Console.WriteLine(test.IsMatch("a", "aa?"));
            Console.WriteLine(test.IsMatch("a", "?"));
            Console.WriteLine(test.IsMatch("a", "??"));
            Console.WriteLine(test.IsMatch("a", "???"));
            Console.WriteLine(test.IsMatch("a", "?a"));
            Console.WriteLine(test.IsMatch("a", "a?"));
            Console.WriteLine(test.IsMatch("a", "?b"));
            Console.WriteLine(test.IsMatch("a", "b?"));
            // p longer than s
            Console.WriteLine(test.IsMatch("a", "a*"));
            Console.WriteLine(test.IsMatch("a", "a?"));
            Console.WriteLine(test.IsMatch("a", "ab"));

            // s longer than p            
            Console.WriteLine(test.IsMatch("aaa", "a*"));
            Console.WriteLine(test.IsMatch("aaa", "a?"));
            Console.WriteLine(test.IsMatch("aaa", "a"));
            
            //other            
            Console.WriteLine(test.IsMatch("adceb", "*a*b"));
            Console.WriteLine(test.IsMatch("adceb", "***"));
            Console.WriteLine(test.IsMatch("adceb", "?**"));
            Console.WriteLine(test.IsMatch("adceb", "?*c"));
            Console.WriteLine(test.IsMatch("acdcb", "a*c?b"));

            Console.ReadKey();

        }
    }
}
