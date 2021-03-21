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

namespace Problems.DataStructures.Tree.BinaryTreePostOrderTraversal
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

        public IList<int> PostOrderTraversal(TreeNode root, bool useRecursive = true)
        {
            _resultList = new List<int>();
            if (useRecursive)
            {
                PostOrderRecursive(root);
            }
            else
            {
              PostOrderIterative(root);
            }
            return _resultList;

        }

        private void PostOrderRecursive(TreeNode root)
        {
            if (root == null) return;

            PostOrderRecursive(root.Left);
            PostOrderRecursive(root.Right);
            _resultList.Add(root.Val);
        }

        private void PostOrderIterative(TreeNode root)
        {
            if (root == null) return;

            var stack = new Stack<TreeNode>();
            var hasTraversedLeft = new HashSet<TreeNode>();
            var hasTraversedRight = new HashSet<TreeNode>();

            stack.Push(root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if(current.Left != null)
                {
                    if (!hasTraversedLeft.Contains(current))
                    {
                        hasTraversedLeft.Add(current);
                        stack.Push(current);
                        stack.Push(current.Left);
                        continue;
                    }
                }
                else
                {
                    hasTraversedLeft.Add(current);
                }

                if (current.Right != null)
                {
                    if (!hasTraversedRight.Contains(current))
                    {
                        hasTraversedRight.Add(current);
                        stack.Push(current);
                        stack.Push(current.Right);
                        continue;
                    }
                    
                }
                else
                {
                    hasTraversedRight.Add(current);
                }
                _resultList.Add(current.Val);
            }
        }

    }
}
