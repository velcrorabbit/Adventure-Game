using System;
using Adventure_Game.Helpers;

namespace Adventure_Game
{
    class IF
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public IF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public IF() { SquareEntered(); }

        public void SquareEntered()
        {
            Console.WriteLine("There is a cliff, below you is the sea, to the north you can hear a waterfall.");
            NewDirection();
        }

        internal void NewDirection()
        {
            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();

            if (DirectionsHelper.isEast(direction))
                new CliffDeath(LocalPlayerInfo).SquareEntered();
            else if (DirectionsHelper.isNorth(direction))
            {
                Console.WriteLine("IG");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.isWest(direction))
                new HF(LocalPlayerInfo);
            else if (DirectionsHelper.isSouth(direction))
            {
                Console.WriteLine("IE");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else
                new Error().displayErrorMessage();
        }
    }
}
