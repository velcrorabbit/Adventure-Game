using Adventure_Game;
using Adventure_Game.Helpers;
using System;

namespace Adventure_Game
{
    internal class CliffDeath
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public CliffDeath(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        internal void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("With a mournfull look to the forest behind you, " +
                            "you decide death is preferable to playing this god awfull game. " +
                            "You jump into the void and die.");
            new EndGame(LocalPlayerInfo).Restart();
        }
    }
}
