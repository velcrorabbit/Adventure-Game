using Adventure_Game;
using Adventure_Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game.GridLocations
{
    class RiverDeath
    {
        private PlayerInfo LocalPlayerInfo;
        public RiverDeath(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }
        public RiverDeath() { squareEntered(); }
        private void squareEntered()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sadly you never learned to swim, " +
                "and as the water closes \n over your head you think " +
                "back to all the places you still haven't been.");
            new EndGame().restart();
        }
    }
}
