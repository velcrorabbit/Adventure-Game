using Adventure_Game.GridLocations;
using Adventure_Game.Helpers;
using System;

namespace Adventure_Game
{
    class HF
    {
        private PlayerInfo LocalPlayerInfo;
        public HF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }
        public HF() { squareEntered(); }
        private void squareEntered()
        {
            Console.WriteLine("You are in a forest, trees stretch in every direction.");
            Console.WriteLine("There is a large oak tree in front of you, do you want to climb? y/n");
            string input = Console.ReadLine();
            if (input == "y")
            {
                Console.WriteLine("You cimb to the top of the tree, you can see:");
                Console.WriteLine("a river to the North,");
                Console.WriteLine("a cliff to the East,");
                Console.WriteLine("more forest to the West,");
                Console.WriteLine("a house to the south.");
                Console.WriteLine("you climb down feeling more confident in where you want to go.");
            }
            if (input == "n")
                Console.WriteLine("Your mother always warned you of the dangers of trees, you decide to continue on blindly.");

            newDirection();
            
        }


        private void newDirection()
        {
            Console.WriteLine("Choose a direction");
            string direction = Console.ReadLine();

            if (DirectionsHelper.isEast(direction))
                new IF();
            else if (DirectionsHelper.isNorth(direction))
                new HG();
            else if (DirectionsHelper.isWest(direction))
                new GF();
            else if (DirectionsHelper.isSouth(direction))
                new HE();
            else
            {
                new Error().displayErrorMessage();
                newDirection();
            }
        }
    }
}
