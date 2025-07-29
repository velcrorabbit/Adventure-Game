using AdventureGame.Interfaces;
using AdventureGame.Helpers;
using System;

namespace AdventureGame.GridLocations
{
    class HF : IGridLocation
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public HF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        private void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;

            Console.WriteLine("You are in a forest, trees stretch in every direction.");
            Console.WriteLine("There is a large oak tree in front of you, do you want to climb? y/n");

            string input = Console.ReadLine();

            if (input == "y")
            {
                Console.WriteLine("You cimb to the top of the tree, you can see:");
                Console.WriteLine("- A river to the North,");
                Console.WriteLine("- A cliff to the East,");
                Console.WriteLine("- More forest to the West,");
                Console.WriteLine("- A house to the south.");
                Console.WriteLine("You climb down feeling more confident in where you want to go.");
            }
            if (input == "n")
                Console.WriteLine("Your mother always warned you of the dangers of trees, you decide to continue on blindly.");

            if (input == "fin")
                new EndGame(LocalPlayerInfo).Restart();

            NewDirection();
        }

        private void NewDirection()
        {
            Console.WriteLine("Choose a direction");
            string direction = Console.ReadLine();

            if (DirectionsHelper.IsEast(direction))
                new IF(LocalPlayerInfo);
            else if (DirectionsHelper.IsNorth(direction))
                new HG(LocalPlayerInfo);
            else if (DirectionsHelper.IsWest(direction))
                new GF(LocalPlayerInfo);
            else if (DirectionsHelper.IsSouth(direction))
                new HE(LocalPlayerInfo);
            else
            {
                new Error().displayErrorMessage();
                NewDirection();
            }
        }
    }
}
