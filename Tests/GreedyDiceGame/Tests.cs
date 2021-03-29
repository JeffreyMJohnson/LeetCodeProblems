using FluentAssertions;
using NUnit.Framework;
using Problems.GreedyDiceGame;

namespace Tests.GreedyDiceGame
{
    public class Tests
    {
        [Test]
        public void ScoreRollOne()
        {
            var roll = new int[] { 5, 1, 3, 4, 1 };
            var result = Kata.Score(roll);

            result.Should().Be(250);
        }

        [Test]
        public void ScoreRollTwo()
        {
            var roll = new int[] { 1, 1, 1, 3, 1 };
            var result = Kata.Score(roll);

            result.Should().Be(1100);
        }

        [Test]
        public void ScoreRollThree()
        {
            var roll = new int[] { 2, 4, 4, 5, 4 };
            var result = Kata.Score(roll);

            result.Should().Be(450);
        }

    }


}
