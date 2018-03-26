﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game.GridLocations
{
    class DF
    {
        public void squareEntered()
        {
            Console.WriteLine("A large chest stands in front of you, there is a bored looking fairy sitting on it.");
            Console.WriteLine("She turns to you, 'Please tell me you have the password' she says.");
            Console.WriteLine("Do you have the password? y/n");
            string input = Console.ReadLine();
            if (input == "y")
                hasPassword();
            if (input == "n")
                noPassword();
            else
                new Error().displayErrorMessage();
        }

        private void newDirection()
        {
            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();
            if (DirectionsHelper.isEast(direction))
                new PitDeath().squareEntered();
            else if (DirectionsHelper.isNorth(direction))
                Console.WriteLine("You bump into the cave wall");
            else if (DirectionsHelper.isWest(direction))
                Console.WriteLine("You bump into the cave wall");
            else if (DirectionsHelper.isSouth(direction))
                new DE().squareEntered();
            else
            {
                new Error().displayErrorMessage();
                newDirection();
            }
        }
        private void hasPassword()
        {
            Console.WriteLine("The fairly looks doubltfull. Please say the password.");
            string password = Console.ReadLine();
            if (password == "ADEBLEC")
                winner();
            else
                noPassword();

        }
        public void noPassword()
        {
            Console.WriteLine("The fairy looks angry. 'Theif! Leave my cave at once and don't come back until you have the passowrd!'");
        }
        public void winner()
        {
            Console.WriteLine("The fairy jumps off the chest as it springs open revealing a pile of glowing treasure.");
            Console.WriteLine("Congraduations! You've found the treasure and won the game!");
            Console.WriteLine("Would you like to keep playing? y/n");
            string input = Console.ReadLine();
            if (input == "y")
                newDirection();
            else if (input == "n")
            {
                Console.WriteLine("That's enough adventuring for one day.");
                Console.WriteLine("Goodbye.");
                Console.ReadLine();
            }
                
        }

    }
}