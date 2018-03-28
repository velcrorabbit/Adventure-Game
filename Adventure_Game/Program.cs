using System;

namespace Adventure_Game
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Adventure Land, what is your name?");
            string playerName = "";
            playerName = Console.ReadLine();

            if (playerName == "Mark")
                Console.WriteLine("This game requires a level of literacy that you do not posses,\n please give the computer to an adult.");
            else if (playerName == "Rachel")
                Console.WriteLine("Welcome oh glorious creator!");
            else
                Console.WriteLine("Welcome, {0}" , playerName);
            new HF().squareEntered();
        }
    }
}
