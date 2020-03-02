/* https://leetcode.com/problems/reverse-linked-list/
 * 
 * Runtime: 80 ms, faster than 99.56% of C# online submissions for Reverse Linked List.
 * Memory Usage: 24.5 MB, less than 8.00% of C# online submissions for Reverse Linked List.
 * 
 * There are two solutions 1.recersice and 2.iterative
 * 
 */

namespace algorithm_csharp
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class ReverseLinkedList
    {
        ListNode newHead;
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            /*
             * recursive         
             */
            //ListNode child = head.next;
            //newHead = ReverseList(child);
            //child.next = head;
            //head.next = null;
            //return newHead;

            /*
             *  iterative        
             */
            ListNode _preNode = head,  _curNode = head.next , _nextNode = null;            
            _preNode.next = null;            
            while (_curNode != null)
            {
                _nextNode = _curNode.next;//keep for next curNode

                _curNode.next = _preNode;//change link pointer

                _preNode = _curNode;//move to next
                _curNode = _nextNode;//move to next
            }
            return _preNode;
        }
    }
}
