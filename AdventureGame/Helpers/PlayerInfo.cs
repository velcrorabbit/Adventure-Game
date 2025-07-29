namespace AdventureGame.Helpers
{
    class PlayerInfo
    {
        public string PlayerName { get; set; }

        // Equipment        
        public bool HasPassword { get; set; }

        public bool HasSword { get; set; }

        // Abilities
        public bool CanSwim { get; set; }

        // Game state
        public int TilesEntered { get; set; }
    }
}
