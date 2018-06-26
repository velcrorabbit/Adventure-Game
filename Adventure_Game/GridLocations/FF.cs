using Adventure_Game;
using Adventure_Game.Helpers;
using System;

namespace Adventure_Game
{
    class FF
    {
        private PlayerInfo LocalPlayerInfo;
        public FF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }
        public FF() { squareEntered(); }
        private void squareEntered()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There is a large angry bear in front of you, you try and defend yourself, " +
                "but it's a bear. You are quickly torn to shreds. Sorry, but I did try to warn you.");
            new EndGame().Restart();
        }
    }
}
