using AdventureGame;
using AdventureGame.Helpers;
using AdventureGame.Interfaces;
using System;

namespace AdventureGame.GridLocations
{
    class FF : IGridLocation
    {
        private PlayerInfo LocalPlayerInfo;

        public FF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There is a large angry bear in front of you, you try and defend yourself, " +
                "but it's a bear. You are quickly torn to shreds. Sorry, but I did try to warn you.");
            new EndGame(LocalPlayerInfo).Restart();
        }

        public void NewDirection()
        {
        }
    }
}
