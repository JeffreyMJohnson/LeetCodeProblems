using System;

namespace Problems.DiameterOfBinaryTree
{
    public class Solution
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        /*
         * Given a binary tree, you need to compute the length of the diameter of the tree.
         * The diameter of a binary tree is the length of the longest path between any two
         * nodes in a tree. This path may or may not pass through the root.
         */

        /*
         * The diameter of a tree T is the largest of the following quantities:
                the diameter of T’s left subtree.
                the diameter of T’s right subtree.
                the longest path between leaves that goes through the root of T (this can be computed from the heights of the subtrees of T)

        post order
        left, right visit root
         */

        private int GetDepth(TreeNode root)
        {
            //depth of tree == max(depth left subtree, depth right subtree) + 1
            if (root == null)
            {
                return 0;
            }

            var left = GetDepth(root.left);
            var right = GetDepth(root.right);

            ans = Math.Max(ans, left + right + 1);
            
            return Math.Max(left, right) + 1;
        }

        private int ans;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            ans = 1;
            GetDepth(root);
            return ans - 1;
        }
    }
}
