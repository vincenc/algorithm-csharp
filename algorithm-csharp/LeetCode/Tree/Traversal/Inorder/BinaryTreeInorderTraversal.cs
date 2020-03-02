/* https://leetcode.com/problems/binary-tree-inorder-traversal/
 * Runtime: 232 ms, faster than 91.41%
 * Memory Usage: 29.8 MB, less than 16.67%
 * 
 * inorder traversal => left > excute cur > right
 */
using System.Collections.Generic;

namespace algorithm_csharp
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();            
            if (root == null) return result;
            if (root.left == null && root.right == null)
            {
                result.Add(root.val);
                return result;
            }            
            inorderTraversal(root, result);
            return result;
        }
        
        private void inorderTraversal(TreeNode cur, List<int> result)
        {
            if (cur == null) return;
            if (cur.left != null)
                inorderTraversal(cur.left, result);

            result.Add(cur.val);

            if (cur.right != null)
                inorderTraversal(cur.right, result);
        }
    }
}
