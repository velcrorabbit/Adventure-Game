﻿using System;
using AdventureGame.Helpers;
using AdventureGame.Interfaces;
using AdventureGame.GridLocations.Deaths;

namespace AdventureGame.GridLocations
{
    class IF : IGridLocation
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public IF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;
            Console.WriteLine("There is a cliff, below you is the sea, to the north you can hear a waterfall.");
            NewDirection();
        }

        public void NewDirection()
        {
            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();

            if (DirectionsHelper.IsEast(direction))
                new CliffDeath(LocalPlayerInfo).SquareEntered();
            else if (DirectionsHelper.IsNorth(direction))
            {
                Console.WriteLine("IG");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.IsWest(direction))
                new HF(LocalPlayerInfo);
            else if (DirectionsHelper.IsSouth(direction))
            {
                Console.WriteLine("IE");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else
                new Error().displayErrorMessage();
        }
    }
}
