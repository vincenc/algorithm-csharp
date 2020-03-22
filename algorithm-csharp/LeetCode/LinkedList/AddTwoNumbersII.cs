/*
 * https://leetcode.com/problems/add-two-numbers-ii/
 * 
 * Runtime: 104 ms, faster than 88.46% of C# online submissions for Add Two Numbers II.
 * Memory Usage: 27.6 MB, less than 25.00% of C# online submissions for Add Two Numbers II.
 * 
 */
using System;
using System.Text;

namespace algorithm_csharp
{
    public class AddTwoNumbersII
    {
        //Input: (7 -> 2 -> 4 -> 3) + (5 -> 6 -> 4)
        //Output: 7 -> 8 -> 0 -> 7
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            l1 = reverseLinkList(l1);
            l2 = reverseLinkList(l2);

            ListNode cur1 = l1;
            ListNode cur2 = l2;

            ListNode cur = new ListNode(0);
            ListNode res = cur;

            int adToNextDigit = 0;
            while (cur1 != null && cur2 != null)
            {
                cur.next = sumNode(cur1, cur2, ref adToNextDigit);
                cur1 = cur1.next;
                cur2 = cur2.next;
                cur = cur.next;
            }

            if (cur2 == null)
                cur2 = cur1;

            while (cur2 != null)
            {
                cur.next = sumNode(null, cur2, ref adToNextDigit);
                cur2 = cur2.next;
                cur = cur.next;
            }

            if (adToNextDigit > 0)
            {
                cur.next = sumNode(null, null, ref adToNextDigit);
                cur = cur.next;
            }
            Console.WriteLine(res.next);
            return reverseLinkList(res.next);
        }

        private static ListNode sumNode(ListNode cur1, ListNode cur2, ref int adToNextDigit)
        {
            int curDigit = (cur1 == null ? 0 : cur1.val) +
                (cur2 == null ? 0 : cur2.val) +
                adToNextDigit;

            adToNextDigit = 0;

            if (curDigit >= 10)
            {
                adToNextDigit = curDigit / 10;
                curDigit = curDigit % 10;
            }

            return new ListNode(curDigit);
        }

        private ListNode reverseLinkList(ListNode linkedList)
        {
            ListNode cur = linkedList.next;
            ListNode next = null;
            ListNode pre = linkedList;
            pre.next = null;
            // 7 , 2, 4, 3
            while (cur != null)
            {
                next = cur.next;
                cur.next = pre;

                pre = cur;
                cur = next;
            }
            return pre;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
            public override string ToString()
            {
                StringBuilder res = new StringBuilder();
                ListNode cur = this;
                while (cur != null)
                {
                    res.Append(cur.val);
                    cur = cur.next;
                }
                return res.ToString();
            }

            public override bool Equals(object obj)
            {
                ListNode compareTo = (ListNode)obj;
                ListNode cur = this;

                while(cur != null && compareTo != null)
                {
                    if (cur.val != compareTo.val)
                    {
                        return false;
                    }
                    cur = cur.next;
                    compareTo = compareTo.next;
                }

                if (cur != null || compareTo != null)
                    return false;

                return true;
            }
        }
    }
}
