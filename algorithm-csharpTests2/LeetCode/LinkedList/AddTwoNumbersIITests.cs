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
    public class AddTwoNumbersIITests
    {
        [DataTestMethod()]
        [DynamicData(nameof(TestDataMethod), DynamicDataSourceType.Method)]
        public void AddTwoNumbersTest(AddTwoNumbersII.ListNode v1, AddTwoNumbersII.ListNode v2 , AddTwoNumbersII.ListNode v3  )
        {
            AddTwoNumbersII test = new AddTwoNumbersII();
            var d = test.AddTwoNumbers(v1,v2);
            Console.WriteLine(v3);
            Console.WriteLine(d);

            Assert.AreEqual(v3,d);
        }

        static IEnumerable<object[]> TestDataMethod()
        {

            var res = new List<object[]>();

            AddTwoNumbersII.ListNode a = new AddTwoNumbersII.ListNode(7);
            AddTwoNumbersII.ListNode head = a;
            a.next = new AddTwoNumbersII.ListNode(2);
            a = a.next;
            a.next = new AddTwoNumbersII.ListNode(4);
            a = a.next;
            a.next = new AddTwoNumbersII.ListNode(3);

            a = new AddTwoNumbersII.ListNode(5);
            AddTwoNumbersII.ListNode head2 = a;
            a.next = new AddTwoNumbersII.ListNode(6);
            a = a.next;
            a.next = new AddTwoNumbersII.ListNode(4);

            a = new AddTwoNumbersII.ListNode(7);
            AddTwoNumbersII.ListNode head3 = a;
            a.next = new AddTwoNumbersII.ListNode(8);
            a = a.next;
            a.next = new AddTwoNumbersII.ListNode(0);
            a = a.next;
            a.next = new AddTwoNumbersII.ListNode(7);



            object[] b = new[] { head ,head2 , head3 };
            res.Add(b);

            return res;
        }
    }
}
