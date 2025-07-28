using Adventure_Game;
using Adventure_Game.Helpers;
using System;


namespace Adventure_Game.GridLocations
{
    class PitDeath
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
