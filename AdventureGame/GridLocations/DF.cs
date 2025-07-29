using AdventureGame.Helpers;
using AdventureGame.Interfaces;
using AdventureGame.GridLocations.Deaths;
using System;

namespace AdventureGame.GridLocations
{
    class DF : IGridLocation
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public DF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;
            Console.WriteLine("A large chest stands in front of you, there is a bored looking fairy sitting on it.");
            Console.WriteLine("She turns to you, 'Please tell me you have the password' she says.");
            Console.WriteLine("Do you have the password? y/n");

            string input = Console.ReadLine();

            if (input == "y" && LocalPlayerInfo.HasPassword)
                HasPassword();
            else if (input == "y" && !LocalPlayerInfo.HasPassword)
                GuessedPassword();
            else if (input == "n")
                NoPassword();
            else
                new Error().displayErrorMessage();
        }

        public void NewDirection()
        {
            Console.WriteLine("Choose a direction.");

            string direction = Console.ReadLine();

            if (DirectionsHelper.IsEast(direction))
                new PitDeath(LocalPlayerInfo);
            else if (DirectionsHelper.IsNorth(direction))
            {
                Console.WriteLine("You bump into the cave wall");
                NewDirection();
            }
            else if (DirectionsHelper.IsWest(direction))
            {
                Console.WriteLine("You bump into the cave wall");
                NewDirection();
            }
            else if (DirectionsHelper.IsSouth(direction))
                new DE(LocalPlayerInfo);
            else
            {
                new Error().displayErrorMessage();
                NewDirection();
            }
        }

        private void HasPassword()
        {
            Console.WriteLine("The fairy looks doubtfull. But you carefully say the password");
            Winner();
        }

        private void GuessedPassword()
        {
            Console.WriteLine("The fairy looks doubltfull. 'if this is some cheating bull shit, I'll be mad, say the password'");
            string password = Console.ReadLine();
            if (password == "ADEBLEC")
                Winner();
            else
                NoPassword();
        }

        private void NoPassword()
        {
            Console.WriteLine("The fairy looks angry. 'Thief! Leave my cave at once and don't come back until you have the password!'");
            NewDirection();
        }

        private void Winner()
        {
            Console.WriteLine("The fairy jumps off the chest as it springs open revealing a pile of glowing treasure.");
            Console.WriteLine("Congraduations! You've found the treasure and won the game!");
            new EndGame(LocalPlayerInfo).Restart();                
        }

    }
}
