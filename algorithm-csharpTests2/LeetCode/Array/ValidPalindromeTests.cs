using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithm_csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_csharp.Tests
{
    [TestClass]
    public class ValidPalindromeTests
    {
        [DataTestMethod()]
        [DataRow("A man, a plan, a canal: Panama", true)]
        public void IsPalindromeTest(string v1, bool v2)
        {
            ValidPalindrome test = new ValidPalindrome();
            Assert.AreEqual(test.IsPalindrome(v1), v2);
        }
    }
}
