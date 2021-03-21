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
using System;

namespace Problems.DataStructures.Tree.BinaryTreePreorderTraversal
{
    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.Val = val;
            this.Left = left;
            this.Right = right;
        }
    }

    public class Solution
    {
        private static List<int> _resultList;

        public IList<int> PreorderTraversal(TreeNode root, bool useRecursive = false)
        {
            _resultList = new List<int>();
            if (useRecursive)
            {
                PreOrderRecursive(root);
            }
            else
            {
              PreOrderIterative(root);
            }
            return _resultList;

        }

        private void PreOrderRecursive(TreeNode root)
        {
            if (root == null) return;

            _resultList.Add(root.Val);
            PreOrderRecursive(root.Left);
            PreOrderRecursive(root.Right);
        }

        private void PreOrderIterative(TreeNode root)
        {
            if (root == null) return;

            var stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                _resultList.Add(current.Val);
                if (current.Right != null) stack.Push(current.Right);
                if (current.Left != null) stack.Push(current.Left);
                
            }
        }

    }
}
