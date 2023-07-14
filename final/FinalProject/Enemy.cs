using System;
using RetroShooter.Game;

namespace RetroShooter.Enemy
{
    public class Enemy
    {
        private RetroShooter.Game.Game game;

        public int Health { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Enemy(RetroShooter.Game.Game game)
        {
            this.game = game;
        }

        public void Shoot()
        {
            // Create a new bullet
            RetroShooter.Bullet.Bullet bullet = new RetroShooter.Bullet.Bullet();
            bullet.X = this.X;
            bullet.Y = this.Y + 1;
            bullet.Damage = this.Damage;

            // Add the bullet to the game
            game.Bullets.Add(bullet);
        }

        public void TakeDamage(int damage)
        {
            // Enemy damage logic here
        }
    }
}
