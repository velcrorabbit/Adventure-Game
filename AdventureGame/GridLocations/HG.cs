using AdventureGame.GridLocations;
using AdventureGame.Helpers;
using System;

namespace AdventureGame
{
    class HG : IGridLocation
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public HG(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

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

            if (DirectionsHelper.IsEast(direction))
            {
                Console.WriteLine("IG");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.IsNorth(direction))
                new RiverDeath(LocalPlayerInfo);
            else if (DirectionsHelper.IsWest(direction))
                new FF(LocalPlayerInfo);
            else if (DirectionsHelper.IsSouth(direction))
                new GE(LocalPlayerInfo);
            else
                new Error().displayErrorMessage();
        }
    }
}