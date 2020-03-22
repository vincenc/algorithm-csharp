using System;
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
    public class PopulatingNextRightPointersinEachNodeIITests
    {
        [DataTestMethod()]
        [DynamicData(nameof(TestDataMethod), DynamicDataSourceType.Method)]
        public void SpiralOrderTest(int[][] v1, int[][] v2)
        { 
        }

        static IEnumerable<object[]> TestDataMethod()
        {

            var res = new List<object[]>();

            PopulatingNextRightPointersinEachNodeII.Node head = new PopulatingNextRightPointersinEachNodeII.Node();
            head.val = 1;
            PopulatingNextRightPointersinEachNodeII.Node cur = head;

            cur.left = new PopulatingNextRightPointersinEachNodeII.Node(2);
            cur.right = new PopulatingNextRightPointersinEachNodeII.Node(3);

            cur.left.left = new PopulatingNextRightPointersinEachNodeII.Node(4);
            cur.left.right = new PopulatingNextRightPointersinEachNodeII.Node(5);

            cur.right.right = new PopulatingNextRightPointersinEachNodeII.Node(7);


            //object[] b = new[] { a, c };
            //res.Add(b);

            return res;
        }
    }
}
