/* https://leetcode.com/problems/binary-tree-level-order-traversal/
 * Runtime: 248 ms, faster than 51.54% of C# online submissions for Binary Tree Level Order Traversal.
 * Memory Usage: 31 MB, less than 20.00% of C# online submissions for Binary Tree Level Order Traversal.
 * 
 * use queue to keep current level and next level nodes
 * before add next level nodes , count this level nodes for iterative edge
 * 
 */
using System.Collections.Generic;
using System.Linq;

namespace algorithm_csharp
{
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null) return new List<IList<int>>();
            IList<IList<int>> _result = new List<IList<int>>();
            Queue<TreeNode> _queue = new Queue<TreeNode>();
            _queue.Enqueue(root);
            int _curLevelResultLength;
            List<int> _curLevelResult;
            TreeNode _cur;
            while (_queue.Any())
            {
                _curLevelResult = new List<int>();
                _curLevelResultLength = _queue.Count();
                for (int i = 0; i < _curLevelResultLength; i++)
                {
                    _cur = _queue.Dequeue();
                    _curLevelResult.Add(_cur.val);
                    // from left to right
                    if (_cur.left != null)
                        _queue.Enqueue(_cur.left);
                    if (_cur.right != null)
                        _queue.Enqueue(_cur.right);
                }
                _result.Add(_curLevelResult);
            }
            return _result;
        }
    }
}
