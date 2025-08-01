﻿using AdventureGame.Helpers;
using AdventureGame.Interfaces;
using System;

namespace AdventureGame.GridLocations
{
    class FE : IGridLocation
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public FE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;

            Console.WriteLine("Infront of you is the entrance to a dark cave, do you want to go in? y/n");
            string input = Console.ReadLine();

            if (input == "y")
            {
                Console.WriteLine("You bravely walk into the gloom.");
                new EE(LocalPlayerInfo);
            }
            else if (input == "n")
            {
                Console.WriteLine("You decide to turn back. Choose a direction.");
                NewDirection();
            }
            else
                new Error().displayErrorMessage();
        }

        public void NewDirection()
        {
            string direction = Console.ReadLine();
            if (DirectionsHelper.IsEast(direction)) 
                new GE(LocalPlayerInfo);
            else if (DirectionsHelper.IsNorth(direction))
                new FF(LocalPlayerInfo);
            else if (DirectionsHelper.IsSouth(direction))
            {
                Console.WriteLine("FD");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
        }
    }
}
