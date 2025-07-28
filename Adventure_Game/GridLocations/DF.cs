using Adventure_Game.Helpers;
using System;


namespace Adventure_Game.GridLocations
{
    class DF
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public DF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        private void SquareEntered()
        {
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

        private void NewDirection()
        {
            Console.WriteLine("Choose a direction.");

            string direction = Console.ReadLine();

            if (DirectionsHelper.isEast(direction))
                new PitDeath(LocalPlayerInfo);
            else if (DirectionsHelper.isNorth(direction))
            {
                Console.WriteLine("You bump into the cave wall");
                NewDirection();
            }
            else if (DirectionsHelper.isWest(direction))
            {
                Console.WriteLine("You bump into the cave wall");
                NewDirection();
            }
            else if (DirectionsHelper.isSouth(direction))
                new DE(LocalPlayerInfo);
            else
            {
                new Error().displayErrorMessage();
                NewDirection();
            }
        }

        private void HasPassword()
        {
            Console.WriteLine("The fairy looks doubltfull. But you carefully say the password");
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
            Console.WriteLine("The fairy looks angry. 'Theif! Leave my cave at once and don't come back until you have the passowrd!'");
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
