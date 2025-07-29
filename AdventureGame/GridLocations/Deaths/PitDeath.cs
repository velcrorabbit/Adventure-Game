using AdventureGame;
using AdventureGame.Helpers;
using System;


namespace AdventureGame.GridLocations.Deaths
{
    internal class PitDeath
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public PitDeath(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        private void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You trip an fall into a dark pit.");
            new EndGame(LocalPlayerInfo).Restart();
        }
    }
}
