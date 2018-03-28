using Adventure_Game.GridLocations;
using System;

namespace Adventure_Game
{
    class HF
    {
        public void squareEntered()
        {
            var inventory = new Inventory();

            inventory.HasBook = true;
            
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

            newDirection(inventory);
            
        }


        private void newDirection(Inventory inventory)
        {
            Console.WriteLine("Choose a direction");
            string direction = Console.ReadLine();

            if (DirectionsHelper.isEast(direction))
                new IF().squareEntered();
            else if (DirectionsHelper.isNorth(direction))
                new HG().squareEntered();
            else if (DirectionsHelper.isWest(direction))
                new GF().squareEntered();
            else if (DirectionsHelper.isSouth(direction))
                new HE().squareEntered();
            else
            {
                new Error().displayErrorMessage();
                newDirection(inventory);
            }
        }
    }
}
