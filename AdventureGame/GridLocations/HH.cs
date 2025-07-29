using AdventureGame.Helpers;
using AdventureGame.Interfaces;
using System;


namespace AdventureGame.GridLocations
{
    class HH : IGridLocation
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public HH(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public void SquareEntered()
        {
            throw new NotImplementedException();
        }

        public void NewDirection()
        {
        }
    }
}
