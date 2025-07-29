using AdventureGame.Helpers;
using AdventureGame.Interfaces;
using AdventureGame.GridLocations.Deaths;
using System;

namespace AdventureGame.GridLocations
{
    class EE : IGridLocation
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public EE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;
            Console.WriteLine("The cave continues.");
            NewDirection();
        }

        public void NewDirection()
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
