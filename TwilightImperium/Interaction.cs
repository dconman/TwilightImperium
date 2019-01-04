namespace TwilightImperium
{
using System;
using System.Collections.Generic;
using TwilightImperium.Classes;
using TwilightImperium.Hex;

    class Interaction
    {
        public T Choice<T>(Player player, IEnumerable<T> options)
        {
            throw new NotImplementedException();
        }

        public HexCoord ChooseTile(Player player, IDictionary<HexCoord, Tile> board)
        {
            throw new NotImplementedException();
        }
    }
}
