using AdventureGame.Helpers;
using System;

namespace AdventureGame.GridLocations.Landmarks
{
    internal class Pond
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public Pond(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        private void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;

            Console.WriteLine("You wade into the pond, the water is cold, and deeper than you thought, the shiny object is further in");
            Console.WriteLine("Do you want to continue? y/n");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                Console.WriteLine("The water becomes too deep to walk, you flail your arms and legs and somehow propel yourself down to the object, it's a sword! Pick it up? y/n");
                input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You pick up the sword, it feels good in your hands. Holding your new weapon, you swim back to the shore");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    LocalPlayerInfo.HasSword = true;
                }
                else if (input == "n")
                {
                    Console.WriteLine("You leave the sword and swim back to the shore.");
                }
                else
                {
                    new Error();
                }
                Console.WriteLine("Your adventure in the pond leaves you with a new found confidence in the water.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You have learned to swim.");
                Console.ForegroundColor = ConsoleColor.Gray;
                LocalPlayerInfo.CanSwim = true;

            }
            else if (input == "n")
            {
                Console.WriteLine("As the water reaches higher, you turn back to the shore.");

            }
            else
                new Error();
            new GD(LocalPlayerInfo);
        }
    }
}
