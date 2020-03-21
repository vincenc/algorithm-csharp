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
    public class SpiralMatrixTests
    {
        [DataTestMethod()]
        [DynamicData(nameof(TestDataMethod), DynamicDataSourceType.Method)]
        public void SpiralOrderTest(int[][] v1, int[][] v2)
        {
            var target = v2[0];
            SpiralMatrix test = new SpiralMatrix();
            var check = test.SpiralOrder(v1);
            Assert.AreEqual(target.Length, check.Count);

            for (int i = 0; i < target.Length; i++)
            {
                Assert.AreEqual(target[i], check[i]);
            }
        }

        static IEnumerable<object[]> TestDataMethod()
        {

            var res = new List<object[]>();

            int[][] a = new int[3][]
                            {
                                new int[] { 1,2,3 },
                                new int[] { 4,5,6 },
                                new int[] { 7,8,9 }
                            };

            int[][] c = new int[1][]
                            {
                                new int[] { 1,2,3,6,9,8,7,4,5 }
                            };

            object[] b = new[] { a, c };
            res.Add(b);

            return res;
        }
    }
}