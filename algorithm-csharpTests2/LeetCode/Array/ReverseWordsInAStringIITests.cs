using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithm_csharp.LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_csharp.Tests
{
    [TestClass]
    public class ReverseWordsInAStringIITests
    {
        [DataTestMethod()]
        [DataRow("the  sky is blue", "blue is sky  the")]
        public void ReverseWordsTest(string v,string v2)
        {
            var c1 = v.ToCharArray();
            var c2 = v2.ToCharArray();
            ReverseWordsInAStringII test = new ReverseWordsInAStringII();
            test.ReverseWords(c1);            
            Assert.AreEqual(c1.Length,c2.Length);

            for (int i = 0; i < c1.Length; i++)
            {
                Assert.AreEqual(c1[i],c2[i]);
            }
        }
    }
}