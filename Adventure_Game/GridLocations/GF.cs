﻿using System;

namespace Adventure_Game
{
    class GF
    {
        public void squareEntered()
        {
            Console.WriteLine("The trees continue, you see a crudely painted wooden sign nailed to one, it reads: ");
            Console.WriteLine("LARGE ANGRY BEAR, DO NOT CONTINUE");
            Console.WriteLine("Where do you want to go?");
            string direction = Console.ReadLine().ToLower();

            if (DirectionsHelper.isEast(direction))
                new HF().squareEntered();
            else if (DirectionsHelper.isNorth(direction))
            {
                Console.WriteLine("GG");
                new Incomplete().displayIncompleteMessage();
            }
            else if (DirectionsHelper.isWest(direction))
                new FF().squareEntered();
            else if (DirectionsHelper.isSouth(direction))
                new GE().squareEntered();
            else
                new Error().displayErrorMessage();
        }
    }
}
