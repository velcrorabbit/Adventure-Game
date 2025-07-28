using Adventure_Game.GridLocations;
using Adventure_Game.Helpers;
using System;

namespace Adventure_Game
{
    class EE
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public EE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public EE() { SquareEntered(); }

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
            if (DirectionsHelper.isEast(direction))
                new FE(LocalPlayerInfo);
            else if (DirectionsHelper.isNorth(direction))
                new PitDeath(LocalPlayerInfo);
            else if (DirectionsHelper.isWest(direction))
                new DE(LocalPlayerInfo);
            else if (DirectionsHelper.isSouth(direction))
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
