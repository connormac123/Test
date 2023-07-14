using System;

namespace RetroShooter.Score
{
    public class Score
    {
        public int Value { get; set; }

        public Score()
        {
            Value = 0;
        }

        public void AddPoints(int points)
        {
            Value += points;
        }
    }
}                       