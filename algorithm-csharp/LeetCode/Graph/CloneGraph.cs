/*
 * https://leetcode.com/problems/clone-graph/
 * 
 * Runtime: 240 ms, faster than 95.45% of C# online submissions for Clone Graph.
 * Memory Usage: 31 MB, less than 50.00% of C# online submissions for Clone Graph.
 * 
 * DFS to each point
 * use hash old , new pairs to prevent endless process
 */
using System.Collections.Generic;

namespace algorithm_csharp.LeetCode.Graph
{
    class CloneGraphs
    {
        public Node CloneGraph(Node node)
        {
            if (node == null) return node;
            if (node.neighbors == null || node.neighbors.Count == 0) return new Node(node.val);
            //DFS or BFS

            //DFS by recursive
            // make node
            // make children
            // ralate to children
            Dictionary<Node, Node> oldNewPairs = new Dictionary<Node, Node>();

            return DFSTraversalCopy(node,oldNewPairs);
        }

        public Node DFSTraversalCopy(Node inputNode, Dictionary<Node, Node> oldNewPairs)
        {
            Node copyFromInputNode = null;

            if (oldNewPairs.ContainsKey(inputNode))
            {
                return oldNewPairs[inputNode];
            }
            else
            {
                //copy value
                copyFromInputNode = new Node(inputNode.val);

                // save visited prevent endless
                oldNewPairs[inputNode] = copyFromInputNode;

                //copy relation
                for (int i = 0; i < inputNode.neighbors.Count; i++)
                {
                    copyFromInputNode.neighbors.Add(
                        DFSTraversalCopy(inputNode.neighbors[i], oldNewPairs)
                        );
                }

                return copyFromInputNode;
            }

        }

        public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }
    }
}
