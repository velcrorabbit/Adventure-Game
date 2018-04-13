using Adventure_Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game.GridLocations
{
    class DF
    {
        private PlayerInfo LocalPlayerInfo;
        public DF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }
        public DF() { squareEntered(); }
        private void squareEntered()
        {
            Console.WriteLine("A large chest stands in front of you, there is a bored looking fairy sitting on it.");
            Console.WriteLine("She turns to you, 'Please tell me you have the password' she says.");
            Console.WriteLine("Do you have the password? y/n");
            string input = Console.ReadLine();
            if (input == "y")
                hasPassword();
            if (input == "n")
                NoPassword();
            else
                new Error().displayErrorMessage();
        }

        private void NewDirection()
        {
            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();
            if (DirectionsHelper.isEast(direction))
                new PitDeath();
            else if (DirectionsHelper.isNorth(direction))
                Console.WriteLine("You bump into the cave wall");
            else if (DirectionsHelper.isWest(direction))
                Console.WriteLine("You bump into the cave wall");
            else if (DirectionsHelper.isSouth(direction))
                new DE();
            else
            {
                new Error().displayErrorMessage();
                NewDirection();
            }
        }
        private void hasPassword()
        {
            Console.WriteLine("The fairly looks doubltfull. Please say the password.");
            string password = Console.ReadLine();
            if (password == "ADEBLEC")
                Winner();
            else
                NoPassword();

        }
        private void NoPassword()
        {
            Console.WriteLine("The fairy looks angry. 'Theif! Leave my cave at once and don't come back until you have the passowrd!'");
        }
        private void Winner()
        {
            Console.WriteLine("The fairy jumps off the chest as it springs open revealing a pile of glowing treasure.");
            Console.WriteLine("Congraduations! You've found the treasure and won the game!");
            new EndGame().restart();                
        }

    }
}
