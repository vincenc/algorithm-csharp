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

            int[][] a = new int[6][]
                            {
                                new int[] { 1,2,3,4,5,6 },
                                new int[] { 7,8,9,10,11,12 },
                                new int[] { 13,14,15,16,17,18 },
                                new int[] { 19,20,21,22,23,24 },
                                new int[] { 25,26,27,28,29,30 },
                                new int[] { 31,32,33,34,35,36 }
                            };

            int[][] c = new int[1][]
                            {
                                new int[] { 1,2,3,4,5,6,12,18,24,30,36,35,34,33,32,31,
                                    25,19,13,7,8,9,10,11,17,23,29,28,27,26,20,14,15,16,22,21 }
                            };

            object[] b = new[] { a, c };
            res.Add(b);

            return res;
        }
        
    }
}