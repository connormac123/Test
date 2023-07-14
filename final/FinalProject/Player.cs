namespace RetroShooter.Player
{
    public class Player
    {
        // Add a reference to the Game object
        private RetroShooter.Game.Game game;

        public int Health { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
        public int Lives { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        // Add a constructor that takes a Game object as a parameter
        public Player(RetroShooter.Game.Game game)
        {
            this.game = game;
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
            // Call the Shoot method on the Game object
            game.Shoot();
        }
    }
}

