using Adventure_Game.GridLocations;
using Adventure_Game.Helpers;
using System;

namespace Adventure_Game
{
    internal class HG
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public HG(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public HG() { SquareEntered(); }

        private void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;
            Console.WriteLine("A large river flows in front of you, it looks very deep.");
            NewDirection();
        }

        private void NewDirection()
        {
            Console.WriteLine("Where do you want to go?");
            string direction = Console.ReadLine().ToLower();

            if (DirectionsHelper.isEast(direction))
            {
                Console.WriteLine("IG");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.isNorth(direction))
                new RiverDeath();
            else if (DirectionsHelper.isWest(direction))
                new FF();
            else if (DirectionsHelper.isSouth(direction))
                new GE();
            else
                new Error().displayErrorMessage();
        }
    }
}