/* https://leetcode.com/problems/binary-tree-postorder-traversal/
 * 
 * Runtime: 240 ms, faster than 62.58% of C# online submissions for Binary Tree Postorder Traversal.
 * Memory Usage: 30 MB, less than 12.50% of C# online submissions for Binary Tree Postorder Traversal.
 * 
 * postorder traversal =>  left > right > excute
 * 
 */
using System.Collections.Generic;

namespace algorithm_csharp.LeetCode.Tree.Traversal.Postorder
{
    public class BinaryTreePostorderTraversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> _result = new List<int>();
            if (root == null) return _result;
            if (root.left == null && root.right == null)
            {
                _result.Add(root.val);
                return _result;
            }
            postorderTraversal(root, _result);
            return _result;
        }

        private void postorderTraversal(TreeNode cur, List<int> result)
        {
            if (cur == null) return;            
            if (cur.left != null)
                postorderTraversal(cur.left, result);

            if (cur.right != null)
                postorderTraversal(cur.right, result);

            result.Add(cur.val);
        }
    }
}
