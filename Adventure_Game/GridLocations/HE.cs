﻿using System;

namespace Adventure_Game
{
    class HE
    {
        public void squareEntered()
        {
            Console.WriteLine("You come across a small cottage, the door is open and no one seems to be home, do you want to go in? y/n");
            string input = Console.ReadLine();

            if (input == "y")
                new House().squareEnterered();
            else if (input == "n")
                Console.WriteLine("Good choice, probably a trap anyway.");

            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();
            if (DirectionsHelper.isEast(direction))
            {
                Console.WriteLine("IE");
                new Incomplete().displayIncompleteMessage();
            }
            else if (DirectionsHelper.isNorth(direction))
                new HF().squareEntered();
            else if (DirectionsHelper.isSouth(direction))
            {
                Console.WriteLine("HD");
                new Incomplete().displayIncompleteMessage();
            }
            else if (DirectionsHelper.isWest(direction))
                new GE().squareEntered();
            else
                new Error().displayErrorMessage();

        }
    }
}
