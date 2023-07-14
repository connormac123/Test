using System;

namespace RetroShooter.Bullet
{
    public class Bullet
    {
        public int Damage { get; set; }
        public int Speed { get; set; }
        public int X { get; set;}
        public int Y { get; set;}

        public Bullet()
        {
            // Initialize bullet attributes here
        }

        public void Move(int x, int y)
        {
            // Move the bullet here
        }
    }
}
