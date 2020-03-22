using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_csharp
{
    //LRUCache cache = new LRUCache(2 /* capacity */ );
    //cache.put(1, 1);
    //cache.put(2, 2);    2 head
    //cache.get(1);       1 head
    //cache.put(3, 3);    remove tail 2 , 3 head
    //cache.get(2);       2 => -1
    //cache.put(4, 4);    4 head 3 2 1
    //cache.get(1);       // returns -1 (not found)
    //cache.get(3);       3 head 4 tail
    //cache.get(4);       3 head 3 tail

    class LRUCache
    {
        int m_capacity;
        int m_size;
        Dictionary<int, DoubleLinkedListNode> cache = new Dictionary<int, DoubleLinkedListNode>();

        DoubleLinkedListNode virtualHead;
        DoubleLinkedListNode virtualTail;

        private class DoubleLinkedListNode
        {
            public DoubleLinkedListNode Pre;
            public DoubleLinkedListNode Next;
            public int Key { get; set; }
            public int Value { get; set; }

            public DoubleLinkedListNode()
            {
            }
            public DoubleLinkedListNode(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }

        private void MoveToHead(DoubleLinkedListNode node)
        {
            RemoveNode(node);
            InsertNodeToHead(node);
        }

        private void RemoveNode(DoubleLinkedListNode node)
        {
            DoubleLinkedListNode pre = node.Pre;
            DoubleLinkedListNode next = node.Next;

            pre.Next = next;
            next.Pre = pre;
        }

        private void InsertNodeToHead(DoubleLinkedListNode node)
        {
            node.Pre = virtualHead;
            node.Next = virtualHead.Next;

            virtualHead.Next.Pre = node;
            virtualHead.Next = node;
        }

        private void AddNodeToTail(DoubleLinkedListNode node)
        {
            node.Pre = virtualTail.Pre;
            node.Next = virtualTail;

            virtualTail.Pre = node;
            virtualTail.Pre.Next = node;
        }

        private DoubleLinkedListNode RemoveTailNode()
        {
            var removed = virtualTail.Pre;
            removed.Pre.Next = virtualTail;
            removed.Next.Pre = removed.Pre;

            removed.Pre = null;
            removed.Next = null;

            return removed;
        }

        public LRUCache(int capacity)
        {
            m_capacity = capacity;
            virtualHead = new DoubleLinkedListNode();
            virtualTail = new DoubleLinkedListNode();
            virtualHead.Next = virtualTail;
            virtualTail.Pre = virtualHead;
        }

        public int Get(int key)
        {
            if (cache.ContainsKey(key))
            {
                DoubleLinkedListNode result =
                    cache[key];
                MoveToHead(result);
                return result.Value;
            }
            else
            {
                DoubleLinkedListNode newHead = new DoubleLinkedListNode(key, key);
                return -1;
            }

        }

        public void Put(int key, int value)
        {
            if (cache.ContainsKey(key))
            {
                var node = cache[key];
                node.Value = value;
                MoveToHead(node);
            }
            else
            {
                if (m_size == m_capacity)
                {
                    var removed = RemoveTailNode();
                    cache.Remove(removed.Key);
                    m_size--;
                }

                DoubleLinkedListNode newNode = new DoubleLinkedListNode(key, value);
                cache[key] = newNode;
                InsertNodeToHead(newNode);
                m_size++;
            }
        }
    }


}
