using System;

namespace Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Adventure Land, what is your name?");
            string playerName = "";
            playerName = Console.ReadLine();

            if (playerName == "Mark")
                Console.WriteLine("Welcome, ButtFace");
            else
                Console.WriteLine("Welcome " + playerName);
            new HF().squareEntered();


            Console.WriteLine("That's enough adventuring for one day.");
            if (playerName == "Mark")
                Console.WriteLine("Goodbye ButtFace");
            else
                Console.WriteLine("Goodbye " + playerName);
            Console.ReadLine();
        }

        //private static void FF()
        //{
        //    Console.WriteLine("There is a large angry bear in front of you, you try and defend yourself, but it's a bear. You are quickly torn to shreds. Sorry, but I did try to warn you.");
        //    Console.WriteLine("");
        //    HF();
        //}
        //private static void GF()
        //{
        //    Console.WriteLine("The trees continue, you see a crudely painted wooden sign nailed to one, it reads: ");
        //    Console.WriteLine("LARGE ANGRY BEAR, DO NOT CONTINUE");
        //    Console.WriteLine("Where do you want to go?");
        //    string direction = Console.ReadLine().ToLower();

        //    if (direction == "east")
        //        HF();
        //    else if (direction == "north")
        //    {
        //        Console.WriteLine("GG");
        //        Incomplete();
        //    }
        //    else if (direction == "west")
        //        FF();
        //    else if (direction == "south")
        //        GE();
        //    else
        //        Error();
        //}
        //private static void HF()
        //{
        //    Console.WriteLine("You are in a forest, trees stretch in every direction.");
        //    Console.WriteLine("There is a large oak tree in front of you, do you want to climb? y/n");
        //    string input = Console.ReadLine();
        //    if (input == "y")
        //    {
        //        Console.WriteLine("You cimb to the top of the tree, you can see:");
        //        Console.WriteLine("a river to the North,");
        //        Console.WriteLine("a cliff to the East,");
        //        Console.WriteLine("more forest to the West,");
        //        Console.WriteLine("a house to the south.");
        //        Console.WriteLine("you climb down feeling more confident in where you want to go. Choose a direction.");
        //    }
        //    if (input == "n")
        //    {
        //        Console.WriteLine("Your mother always warned you of the dangers of trees, you decide to continue on blindly. Choose a direction.");
        //    }

        //    string direction = Console.ReadLine();

        //    if (direction == "east")
        //        IF();
        //    else if (direction == "north")
        //    {
        //        Console.WriteLine("HG");
        //        Incomplete();
        //    }
        //    else if (direction == "west")
        //        GF();
        //    else if (direction == "south")
        //        HE();
        //    else
        //        Error();
        //}
        //private static void IF()
        //{
        //    Console.WriteLine("There is a cliff, below you is the sea, to the north you can hear a waterfall.");
        //    string direction = Console.ReadLine();

        //    if (direction == "east")
        //        CliffDeath();
        //    else if (direction == "north")
        //    {
        //        Console.WriteLine("IG");
        //        Incomplete();
        //    }
        //    else if (direction == "west")
        //        HF();
        //    else if (direction == "south")
        //    {
        //        Console.WriteLine("IE");
        //        Incomplete();
        //    }
        //    else
        //        Error();
        //}
        //private static void FE()
        //{
        //    Console.WriteLine("Infront of you is the entrance to a dark cave, do you want to go in? y/n");
        //    string input = Console.ReadLine();

        //    if (input == "y")
        //    {
        //        Console.WriteLine("You bravely walk into the gloom.");
        //        Console.WriteLine("EE");
        //    }
        //    else if (input == "n")
        //    {
        //        Console.WriteLine("You decide to turn back. Choose a direction.");
        //        string direction = Console.ReadLine();
        //        if (direction == "east")
        //            GE();
        //        else if (direction == "north")
        //            FF();
        //        else if (direction == "south")
        //        {
        //            Console.WriteLine("FD");
        //            Incomplete();
        //        }
        //        else
        //            Error();
        //    }
        //    else
        //        Error();
        //}
        //private static void GE()
        //{
        //    Console.WriteLine("The forest continues. Choose a direction");
        //    string direction = Console.ReadLine();

        //    if (direction == "east")
        //        HE();
        //    else if (direction == "north")
        //    {
        //        Console.WriteLine("GF");
        //        Incomplete();
        //    }
        //    else if (direction == "west")
        //        FE();
        //    else if (direction == "south")
        //    {
        //        Console.WriteLine("GD");
        //        Incomplete();
        //    }
        //    else
        //        Error();
        //}
        //private static void HE()
        //{
        //    Console.WriteLine("You come across a small cottage, the door is open and no one seems to be home, do you want to go in? y/n");
        //    string input = Console.ReadLine();

        //    if (input == "y")
        //        House();
        //    else if (input == "n")
        //        Console.WriteLine("Good choice, probably a trap anyway.");

        //    Console.WriteLine("Choose a direction.");
        //    string direction = Console.ReadLine();
        //    if (direction == "east")
        //    {
        //        Console.WriteLine("IE");
        //        Incomplete();
        //    }
        //    else if (direction == "north")
        //        HF();
        //    else if (direction == "south")
        //    {
        //        Console.WriteLine("HD");
        //        Incomplete();
        //    }
        //    else if (direction == "west")
        //        GE();
        //    else
        //        Error();

        //}
        //private static void CliffDeath()
        //{
        //    Console.WriteLine("With a mournfull look to the forest behind you, " +
        //                    "you decide death is preferable to playing this god awfull game. " +
        //                    "You jump into the void and die.");
        //    Console.WriteLine("");
        //    HF();
        //}
        //private static void Error()
        //{
        //    Console.WriteLine("Sorry, I don't understand");
        //    Console.WriteLine("");
        //    HF();
        //}
        //private static void House()
        //{
        //    Console.WriteLine("You enter the house, it looks very empty except for a note on the table with a key.");
        //    Console.WriteLine("Do you want to read it? y/n");
        //    string input = Console.ReadLine();

        //    if (input == "y")
        //        Console.WriteLine("I am leaving to hunt the bear that has haunted these woods for too long. \nIf you find this, I am probably dead." +
        //            "\nThis key opens a chest containing my treasure. I have hidden it in a near by cave." +
        //            "\nIf I am dead, please return my things to my family.");
        //    else if (input == "n")
        //        Console.WriteLine("If only you had learned to read.");

        //    Console.WriteLine("Do you want to take the key? y/n");
        //    string keyInput = Console.ReadLine();

        //    if (keyInput == "y")
        //        Console.WriteLine("You pick up the key and leave the house.");
        //    else if (keyInput == "n")
        //        Console.WriteLine("Being a law-abiding citizen you leave the key where it is.");
        //}
        //private static void Incomplete()
        //{
        //    Console.WriteLine("You fall into a dark empty void, you notice a sign in the sky 'New map! Coming soon to an adventure near you'.");
        //    Console.WriteLine("");
        //    HF();
        //}

    }
}
