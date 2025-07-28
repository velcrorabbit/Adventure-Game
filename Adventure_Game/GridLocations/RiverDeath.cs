using Adventure_Game;
using Adventure_Game.Helpers;
using System;

namespace Adventure_Game.GridLocations
{
    class RiverDeath
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public RiverDeath(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public RiverDeath() { SquareEntered(); }

        private void SquareEntered()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sadly you never learned to swim, and as the water closes \n over your head you think back to all the places you still haven't been.");
            new EndGame(LocalPlayerInfo).Restart();
        }
    }
}
