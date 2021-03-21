using FluentAssertions;
using NUnit.Framework;
using Problems.DataStructures.Tree.BinaryTreePreorderTraversal;

namespace Tests.DataStructures.Tree.BinaryTreePreorderTraversal
{
  public class Tests
  {
    [Test]
    public void TraverseEmptyNode()
    {
      var t = new Solution();
      var result = t.PreorderTraversal(null);
      result.Count.Should().Be(0);
    }

    [Test]
    public void TraverseSingleNode()
    {
      var t = new Solution();
      var root = new TreeNode(1);

      var result = t.PreorderTraversal(root);
      result.Count.Should().Be(1);
    }

    [Test]
    public void TraverseTwoNodesLeft()
    {
      var t = new Solution();
      var root = new TreeNode(1, left: new TreeNode(val: 2));

      var result = t.PreorderTraversal(root);
      result.Count.Should().Be(2);
      result[0].Should().Be(1);
      result[1].Should().Be(2);
    }

    [Test]
    public void TraverseTwoNodesRight()
    {
      var t = new Solution();
      var root = new TreeNode(1, right: new TreeNode(val: 2));

      var result = t.PreorderTraversal(root);
      result.Count.Should().Be(2);
      result[0].Should().Be(1);
      result[1].Should().Be(2);
    }

        [Test]
    public void TraverseThreeNodes()
    {
      var t = new Solution();
      var root = new TreeNode(1, right: new TreeNode(val: 2, left: new TreeNode(3)));

      var result = t.PreorderTraversal(root);
      result.Count.Should().Be(3);
      result[0].Should().Be(1);
      result[1].Should().Be(2);
      result[2].Should().Be(3);
    }

        [Test]
        public void TraverseThreeNodesB()
        {
            var t = new Solution();
            var root = new TreeNode(3, left: new TreeNode(1), right: new TreeNode(val: 2));

            var result = t.PreorderTraversal(root);
            result.Count.Should().Be(3);
            result[0].Should().Be(3);
            result[1].Should().Be(1);
            result[2].Should().Be(2);
        }
    }
}