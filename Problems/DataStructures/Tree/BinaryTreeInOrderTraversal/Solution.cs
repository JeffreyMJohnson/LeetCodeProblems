/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

using System.Collections.Generic;

namespace Problems.DataStructures.Tree.BinaryTreeInOrderTraversal
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

    public class Solution
    {
        private static List<int> _resultList;

        public IList<int> InOrderTraversal(TreeNode root, bool useRecursive = false)
        {
            _resultList = new List<int>();
            if (useRecursive)
            {
                InOrderRecursive(root);
            }
            else
            {
              InOrderIterative(root);
            }
            return _resultList;

        }

        private void InOrderRecursive(TreeNode root)
        {
            if (root == null) return;

            InOrderRecursive(root.left);
            _resultList.Add(root.val);
            InOrderRecursive(root.right);
        }

        private void InOrderIterative(TreeNode root)
        {
            if (root == null) return;

            var stack = new Stack<TreeNode>();
            var leftHasBeenTraversed = new HashSet<TreeNode>();

            stack.Push(root);
            while (stack.Count > 0)
            {
                
                var current = stack.Pop();

                if (!leftHasBeenTraversed.Contains(current) && current.left != null)
                {
                    leftHasBeenTraversed.Add(current);
                    stack.Push(current);
                    stack.Push(current.left);
                    continue;
                }

                _resultList.Add(current.val);

                if (current.right != null) stack.Push(current.right);
                
            }
        }

    }
}
