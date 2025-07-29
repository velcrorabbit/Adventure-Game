using AdventureGame.GridLocations;
using AdventureGame.Helpers;
using System;

namespace AdventureGame
{
    class EE : IGridLocation
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public EE(PlayerInfo playerInfo)
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
                new FE(LocalPlayerInfo);
            else if (DirectionsHelper.IsNorth(direction))
                new PitDeath(LocalPlayerInfo);
            else if (DirectionsHelper.IsWest(direction))
                new DE(LocalPlayerInfo);
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
