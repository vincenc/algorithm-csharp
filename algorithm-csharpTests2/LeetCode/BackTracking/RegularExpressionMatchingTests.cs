using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithm_csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_csharp.Tests
{
    [TestClass()]
    public class RegularExpressionMatchingTests
    {
        [DataTestMethod()]
        [DataRow("a", "ab*", true)]
        [DataRow("a", ".", true)]
        [DataRow("aa", ".", false)]
        [DataRow("aa", "..", true)]
        [DataRow("aa", "..*", true)]
        [DataRow("aab", "..*", true)]
        [DataRow("aaa", "..*", true)]
        [DataRow("aaab", "..*", true)]
        [DataRow("aa","a*",true)]
        [DataRow("aab", "a*", false)]
        [DataRow("aa", "a", false)]
        [DataRow("ab", ".*", true)]
        [DataRow("aab", "c*a*b", true)]
        [DataRow("mississippi", "mis*is*p*.", false)]
        public void IsMatchTest(string v,string v2 ,bool r)
        {
            RegularExpressionMatching test = new RegularExpressionMatching();             
            Assert.IsTrue(test.IsMatch(v, v2) == r);
        }
    }
}