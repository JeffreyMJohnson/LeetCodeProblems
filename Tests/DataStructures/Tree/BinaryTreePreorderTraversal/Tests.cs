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
  }
}