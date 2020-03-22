/*
 * https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/
 * 
 * Runtime: 92 ms, faster than 95.65% of C# online submissions for Populating Next Right Pointers in Each Node II.
 * Memory Usage: 26.9 MB, less than 100.00% of C# online submissions for Populating Next Right Pointers in Each Node II.
 * 
 * use level traversal to operate each node
 * 
 */

using System.Collections.Generic;
using System.Linq;

namespace algorithm_csharp
{
    public class PopulatingNextRightPointersinEachNodeII
    {
        public Node Connect(Node root)
        {
            if (root == null) return root;
            if (root.left == null && root.right == null) return root;
            levelTraversal(root);

            return root;
        }

        private void levelTraversal(Node root)
        {
            Queue<Node> _queue = new Queue<Node>();
            _queue.Enqueue(root);

            while (_queue.Any())
            {
                int length = _queue.Count();
                Node cur = _queue.Dequeue();
                addChildrenDoQueue(_queue, cur);

                for (int i = 1; i < length; i++)
                {
                    Node curNext = _queue.Dequeue();
                    cur.next = curNext;
                    cur = curNext;
                    addChildrenDoQueue(_queue, cur);
                }
            }
        }

        private static void addChildrenDoQueue(Queue<Node> _queue, Node cur)
        {
            if (cur.left != null) _queue.Enqueue(cur.left);
            if (cur.right != null) _queue.Enqueue(cur.right);
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
    }
}
