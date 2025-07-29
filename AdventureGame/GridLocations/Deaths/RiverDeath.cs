using AdventureGame;
using AdventureGame.Helpers;
using System;

namespace AdventureGame.GridLocations.Deaths
{
    internal class RiverDeath
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public RiverDeath(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        private void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sadly you never learned to swim, and as the water closes over your head you think back to all the places you still haven't been.");
            new EndGame(LocalPlayerInfo).Restart();
        }
    }
}
