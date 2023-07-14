using System;
using RetroShooter.Game;

namespace RetroShooter.Renderer
{
    public class Renderer
    {
        public void Render(RetroShooter.Game.Game game)
        {
            // Clear the screen
            Console.Clear();

            // Render the player
            Console.SetCursorPosition(game.Player.X, game.Player.Y);
            Console.Write("@");

            // Render the enemies
            foreach (var enemy in game.Enemies)
            {
                Console.SetCursorPosition(enemy.X, enemy.Y);
                Console.Write("E");
            }

            // Render the bullets
            foreach (var bullet in game.Bullets)
            {
                Console.SetCursorPosition(bullet.X, bullet.Y);
                Console.Write("*");
            }

            // Render the upgrades
            foreach (var upgrade in game.Upgrades)
            {
                Console.SetCursorPosition(upgrade.X, upgrade.Y);
                Console.Write("U");
            }

            // Render the score
            Console.SetCursorPosition(0, 0);
            Console.Write("Score: " + game.Score.Value);

            // Render the UI
            game.UI.Render();
        }
    }
}
