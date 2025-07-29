using AdventureGame.Helpers;
using System;

namespace AdventureGame.GridLocations
{
    class GD : IGridLocation
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public GD(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        private void SquareEntered() {
            LocalPlayerInfo.TilesEntered += 1;
            Console.WriteLine("A large pond sits in a clearing, the sun shining on the water. Something glints under the water in the middle. Enter the pond? y/n");
            string input = Console.ReadLine();

            if (input == "y")
                new Pond(LocalPlayerInfo);
            else if (input == "n")
            {
                Console.WriteLine("The water looks deep, and you never learned to swim, better not risk it.");
                NewDirection();
            }
        }

        private void NewDirection()
        {
           
            string direction = Console.ReadLine();

            if (DirectionsHelper.IsEast(direction))
            {
                Console.WriteLine("HD");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.IsNorth(direction))
                new GE(LocalPlayerInfo);
            else if (DirectionsHelper.IsWest(direction))
            {
                Console.WriteLine("FD");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.IsSouth(direction))
            {
                Console.WriteLine("GC");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else
                new Error().displayErrorMessage();
                NewDirection();
        }
    }
}
