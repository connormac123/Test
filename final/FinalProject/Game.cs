using System;
using System.Collections.Generic;

namespace RetroShooter.Game
{
    public class Game
    {
        public RetroShooter.Player.Player Player { get; set; }
        public List<RetroShooter.Enemy.Enemy> Enemies { get; set; }
        public List<RetroShooter.Bullet.Bullet> Bullets { get; set; }
        public List<RetroShooter.Upgrade.Upgrade> Upgrades { get; set; }
        public RetroShooter.Score.Score Score { get; set; }
        public RetroShooter.UI.UI UI { get; set; }
        public RetroShooter.Renderer.Renderer Renderer { get; set; }

        private Random random = new Random();

      


        public Game()
        {
            // Initialize other game objects here
            Player = new RetroShooter.Player.Player();
            Player.Lives = 3;

            Enemies = new List<RetroShooter.Enemy.Enemy>();

            Bullets = new List<RetroShooter.Bullet.Bullet>();

            Upgrades = new List<RetroShooter.Upgrade.Upgrade>();

            Score = new RetroShooter.Score.Score();

            UI = new RetroShooter.UI.UI();

            Renderer = new RetroShooter.Renderer.Renderer();

            RetroShooter.Enemy.Enemy enemy = new RetroShooter.Enemy.Enemy(this);
            Enemies.Add(enemy);

        }

        public void Start()
        {
            // Start the game here

            // Start the game loop
            while (true)
            {
                // Update the game state
                Update();

                // Render the game
                Renderer.Render(this);

                // Wait for the next frame
                System.Threading.Thread.Sleep(16);
            }
        }

        public void Update()
        {
            // Move the player based on user input
            if (Console.KeyAvailable)
            {
                // Move the player based on user input
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            Player.X = Math.Max(0, Player.X - 1);
                            break;
                        case ConsoleKey.RightArrow:
                            Player.X = Math.Min(Console.WindowWidth - 1, Player.X + 1);
                            break;
                        case ConsoleKey.UpArrow:
                            Player.Y = Math.Max(0, Player.Y - 1);
                            break;
                        case ConsoleKey.DownArrow:
                            Player.Y = Math.Min(Console.WindowHeight - 1, Player.Y + 1);
                            break;
                    }
                }

            }

            
            // Move the enemies
            foreach (var enemy in Enemies)
            {
                enemy.Y += 1;
                enemy.Y = Math.Min(Console.WindowHeight - 1, enemy.Y);
            }

            // Move the bullets
            for (int i = Bullets.Count - 1; i >= 0; i--)
            {
                RetroShooter.Bullet.Bullet bullet = Bullets[i];
                bullet.Y -= 1;
                if (bullet.Y < 0)
                {
                    // Bullet has moved off the top of the screen
                    // Remove it from the game
                    Bullets.RemoveAt(i);
                }
            }
            
            // Move the upgrades
            for (int i = Upgrades.Count - 1; i >= 0; i--)
            {
                RetroShooter.Upgrade.Upgrade upgrade = Upgrades[i];
                upgrade.Y += 1;
                if (upgrade.Y >= Console.WindowHeight)
                {
                    // Upgrade has moved off the bottom of the screen
                    // Remove it from the game
                    Upgrades.RemoveAt(i);
                }
            }

            // Check for collisions between bullets and enemies
            for (int i = Bullets.Count - 1; i >= 0; i--)
            {
                RetroShooter.Bullet.Bullet bullet = Bullets[i];
                for (int j = Enemies.Count - 1; j >= 0; j--)
                {
                    RetroShooter.Enemy.Enemy enemy = Enemies[j];
                    if (bullet.X == enemy.X && bullet.Y == enemy.Y)
                    {
                        // Bullet hit enemy
                        Bullets.RemoveAt(i);
                        Enemies.RemoveAt(j);
                        Score.Value += 100;
                        break;
                    }
                }
            }

            // Spawn new enemies at random intervals
            if (random.NextDouble() < 0.05)
            {
                RetroShooter.Enemy.Enemy enemy = new RetroShooter.Enemy.Enemy(this);
                enemy.X = random.Next(0, Console.WindowWidth);
                enemy.Y = 0;
                Enemies.Add(enemy);
            }

            // Spawn new power-ups at random intervals
            if (random.NextDouble() < 0.01)
            {
                RetroShooter.Upgrade.Upgrade upgrade = new RetroShooter.Upgrade.Upgrade("someType", 42);
                upgrade.X = random.Next(0, Console.WindowWidth);
                upgrade.Y = 0;
                Upgrades.Add(upgrade);
            }
        }

        public static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
        }
    }
}



