using Adventure_Game.Helpers;
using System;

namespace Adventure_Game
{
    internal class House
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public House(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        private void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;

            Console.WriteLine("You enter the house, it looks very empty except for a note on the table.");
            Console.WriteLine("Do you want to read it? y/n");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                Console.WriteLine("     I am leaving to hunt the bear that has haunted these woods for too long. " +
                    "\n     If you find this, I am probably dead." +
                    "\n     This magic word opens a chest containing my treasure. " +
                    "\n     I have hidden it in a near by cave." +
                    "\n     If I am dead, please return my things to my family." +
                    "\n                 'ADEBLEC'");
                Console.WriteLine("You leave the house with your new information.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Gained Password");
                Console.ForegroundColor = ConsoleColor.Gray;
                LocalPlayerInfo.HasPassword = true;

            }
            else if (input == "n")
            {
                Console.WriteLine("If only you had learned to read.");
                Console.WriteLine("You leave the house.");
            }
            else
                new Error();
            new HE(LocalPlayerInfo);
        }
    }
}
