using AdventureGame.Helpers;
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

        private void SquareEntered()
        {
            throw new NotImplementedException();
        }
    }
}
