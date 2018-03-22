using System;

namespace Adventure_Game
{
    internal class House
    {

        public void squareEnterered()
        {
            Console.WriteLine("You enter the house, it looks very empty except for a note on the table with a key.");
            Console.WriteLine("Do you want to read it? y/n");
            string input = Console.ReadLine();

            if (input == "y")
                Console.WriteLine("I am leaving to hunt the bear that has haunted these woods for too long. \nIf you find this, I am probably dead." +
                    "\nThis key opens a chest containing my treasure. I have hidden it in a near by cave." +
                    "\nIf I am dead, please return my things to my family.");
            else if (input == "n")
                Console.WriteLine("If only you had learned to read.");

            Console.WriteLine("Do you want to take the key? y/n");
            string keyInput = Console.ReadLine();

            if (keyInput == "y")
                Console.WriteLine("You pick up the key and leave the house.");
            else if (keyInput == "n")
                Console.WriteLine("Being a law-abiding citizen you leave the key where it is.");

        }
    }
}
