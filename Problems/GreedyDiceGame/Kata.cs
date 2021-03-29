using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.GreedyDiceGame
{
    public static class Kata
    {
        public static int Score(int[] dice)
        {
            var counts = new Dictionary<int, int>();
            var score = 0;
            foreach (var die in dice)
            {
                if (!counts.ContainsKey(die)) counts[die] = 1;
                else ++counts[die];
            }

            foreach (var die in counts.Keys)
            {
                var count = counts[die];

                if(count >= 3)
                {
                    var tripleScore = die == 1 ? 1000 : die * 100;
                    score += tripleScore;

                    count -= 3;
                }

                if(die == 1)
                {
                    score += count * 100;
                }

                if(die == 5)
                {
                    score += count * 50;
                }
            }

            return score;
        }
    }
}
    