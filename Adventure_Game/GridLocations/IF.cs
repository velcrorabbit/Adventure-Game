using System;
using Adventure_Game.GridLocations;
using Adventure_Game.Helpers;

namespace Adventure_Game
{
    class IF
    {
        private PlayerInfo LocalPlayerInfo;
        public IF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }
        public IF() { squareEntered(); }
        public void squareEntered()
        {
            Console.WriteLine("There is a cliff, below you is the sea, to the north you can hear a waterfall.");
            NewDirection();
        }

        internal void NewDirection()
        {
            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();

            if (DirectionsHelper.isEast(direction))
                new CliffDeath();
            else if (DirectionsHelper.isNorth(direction))
            {
                Console.WriteLine("IG");
                new Incomplete().displayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.isWest(direction))
                new HF();
            else if (DirectionsHelper.isSouth(direction))
            {
                Console.WriteLine("IE");
                new Incomplete().displayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else
                new Error().displayErrorMessage();
        }
    }
}
