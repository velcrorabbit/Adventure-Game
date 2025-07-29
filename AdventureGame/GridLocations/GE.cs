using AdventureGame.Helpers;
using AdventureGame.Interfaces;
using System;
using System.Security.AccessControl;

namespace AdventureGame.GridLocations
{
    class GE : IGridLocation
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public GE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public void SquareEntered() { 

            LocalPlayerInfo.TilesEntered += 1;
            Console.WriteLine("The forest continues. Choose a direction");
            NewDirection();
            
        }

        public void NewDirection()
        {
           
            string direction = Console.ReadLine();

            if (DirectionsHelper.IsEast(direction))
                new HE(LocalPlayerInfo);
            else if (DirectionsHelper.IsNorth(direction))
                new GF(LocalPlayerInfo);
            else if (DirectionsHelper.IsWest(direction))
                new FE(LocalPlayerInfo);
            else if (DirectionsHelper.IsSouth(direction))
                new GD(LocalPlayerInfo);
            else
                new Error().displayErrorMessage();
                NewDirection();

        }
    }
}
