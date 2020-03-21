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
    public class ReverseWordsInAStringTests
    {
        [DataTestMethod()]
        [DataRow("the  sky is blue", "blue is sky the")]
        [DataRow("  hello world!  ", "world! hello")]
        [DataRow("a good   example", "example good a")]
        [DataRow("test", "test")]
        [DataRow("a", "a")]
        [DataRow(" ", "")]
        [DataRow(null, null)]
        public void ReverseWordsTest(string v1 , string v2)
        {
            ReverseWordsInAString test = new ReverseWordsInAString();
            Assert.AreEqual(test.ReverseWords(v1),v2);
        }
    }
}