﻿using System;
using AdventureGame.Helpers;
using AdventureGame.Interfaces;

namespace AdventureGame.GridLocations
{
    class GF : IGridLocation
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public GF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;
            Console.WriteLine("The trees continue, you see a crudely painted wooden sign nailed to one, it reads: ");
            Console.WriteLine("LARGE ANGRY BEAR, DO NOT CONTINUE");
            Console.WriteLine("Where do you want to go?");
            NewDirection();
        }

        public void NewDirection()
        {
            string direction = Console.ReadLine().ToLower();

            if (DirectionsHelper.IsEast(direction))
                new HF(LocalPlayerInfo);
            else if (DirectionsHelper.IsNorth(direction))
            {
                Console.WriteLine("GG");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.IsWest(direction))
                new FF(LocalPlayerInfo);
            else if (DirectionsHelper.IsSouth(direction))
                new GE(LocalPlayerInfo);
            else
                new Error().displayErrorMessage();
        }
    }
}
