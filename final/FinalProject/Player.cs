using System;

namespace RetroShooter.Player
{
    public class Player
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
        public int Lives { get; set; }
        public int X { get; set; } // Add this
        public int Y { get; set; } // Add this

        public Player()
        {
            // Initialize player attributes here
        }

        public void Move(int x, int y)
        {
            // Move the player here
            X = x;
            Y = y;
        }

        public void Shoot()
        {
            // Player shooting logic here
        }
    }
}
