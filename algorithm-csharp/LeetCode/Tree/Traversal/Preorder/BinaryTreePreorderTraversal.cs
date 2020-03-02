/* https://leetcode.com/problems/binary-tree-preorder-traversal/
 * 
 * Runtime: 236 ms, faster than 82.95% of C# online submissions for Binary Tree Preorder Traversal.
 * Memory Usage: 30 MB, less than 11.11% of C# online submissions for Binary Tree Preorder Traversal.
 * 
 * preorder traversal => excute > left > right
 */
using System.Collections.Generic;

namespace algorithm_csharp
{
    public class BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> _result = new List<int>();
            if (root == null) return _result;
            if (root.left == null && root.right == null)
            {
                _result.Add(root.val);
                return _result;
            }
            preorderTraversal(root, _result);
            return _result;
        }

        private void preorderTraversal(TreeNode cur, List<int> result)
        {
            if (cur == null) return;
            result.Add(cur.val);
            if (cur.left != null)
                preorderTraversal(cur.left, result);            

            if (cur.right != null)
                preorderTraversal(cur.right, result);
        }
    }
}
