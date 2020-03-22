using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_csharp.LeetCode.Tree.Traversal.Postorder
{
    public class LowestCommonAncestorofaBinarySearchTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return root;
            if (root.right == null && root.left == null) return null;
            bool temp = false;
            return PostOrderTraversal(root, p, q, ref temp);
        }

        private TreeNode PostOrderTraversal(TreeNode root, TreeNode p, TreeNode q, ref bool found)
        {
            TreeNode res = null;
            bool left = false, right = false;
            if (root.left != null)
            {
                res = PostOrderTraversal(root.left, p, q, ref left);
            }
            if (res != null) return res;
            if (root.right != null)
            {
                res = PostOrderTraversal(root.right, p, q, ref right);
            }
            if (res != null) return res;

            if (root.val == p.val || root.val == q.val)
            {
                found = true;
                if (left == true || right == true)
                {
                    return root;
                }
            }


            if (left == true && right == true)
                return root;
            else
            {
                if (left || right)
                {
                    found = true;
                }
                return null;
            }
        }


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }


}
