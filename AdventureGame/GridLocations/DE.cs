using AdventureGame.Helpers;
using AdventureGame.Interfaces;
using System;

namespace AdventureGame.GridLocations
{
    class DE : IGridLocation
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public DE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        private void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;

            Console.WriteLine("The cave continues.");
            NewDirection();
        }

        private void NewDirection()
        {
            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();
            if (DirectionsHelper.IsEast(direction))
                new EE(LocalPlayerInfo);
            else if (DirectionsHelper.IsNorth(direction))
                new DF(LocalPlayerInfo);
            else if (DirectionsHelper.IsWest(direction))
            {
                Console.WriteLine("You bump into the cave wall");
                NewDirection();
            }
            else if (DirectionsHelper.IsSouth(direction))
            {
                Console.WriteLine("You bump into the cave wall");
                NewDirection();
            }
            else
            {
                new Error().displayErrorMessage();
                NewDirection();
            }
        }
    }
}
