namespace TwilightImperium.Classes
{
    using System.Collections.Generic;
    using TwilightImperium.Hex;

    internal class GameState
    {
        public Player Speaker;
        public IList<Player> Players = new List<Player>();
        public IDictionary<HexCoord, Tile> Board = new Dictionary<HexCoord, Tile>();
        public bool CustodiansPresent = true;
    }
}
