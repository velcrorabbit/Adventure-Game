using Adventure_Game;
using Adventure_Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game.GridLocations
{
    class PitDeath
    {
        private PlayerInfo LocalPlayerInfo;
        public PitDeath(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }
        public PitDeath() { squareEntered(); }
        private void squareEntered()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You trip an fall into a dark pit.");
            new EndGame().Restart();
        }
    }
}
