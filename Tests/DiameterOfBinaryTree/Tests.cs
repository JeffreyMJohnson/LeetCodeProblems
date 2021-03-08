using FluentAssertions;
using NUnit.Framework;
using Problems.DiameterOfBinaryTree;

namespace Tests.DiameterOfBinaryTree
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DiameterOfBinaryTreeWithSingleNode()
        {
            var solution = new Solution();

            var treeRoot = new Solution.TreeNode(1);

            var result = solution.DiameterOfBinaryTree(treeRoot);

            result.Should().Be(0);
        }

        [Test]
        public void DiameterOfBinaryTreeWithTwoNodes()
        {
            var solution = new Solution();

            var node2 = new Solution.TreeNode(2);
            var treeRoot = new Solution.TreeNode(1, left:node2);

            var result = solution.DiameterOfBinaryTree(treeRoot);
            result.Should().Be(1);

            treeRoot = new Solution.TreeNode(1, right:node2);

            result = solution.DiameterOfBinaryTree(treeRoot);
            result.Should().Be(1);
        }

        [Test]
        public void DiameterOfBinaryTree()
        {
            var solution = new Solution();

            var node4 = new Solution.TreeNode(4);
            var node5 = new Solution.TreeNode(5);
            var node2 = new Solution.TreeNode(2, left:node4, right: node5);
            var node3 = new Solution.TreeNode(3);
            var treeRoot = new Solution.TreeNode(1, left:node2, right: node3);

            var result = solution.DiameterOfBinaryTree(treeRoot);

            result.Should().Be(3);
        }

        
    }
}