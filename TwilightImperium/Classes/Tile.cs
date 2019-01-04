namespace TwilightImperium.Classes
{
    using System.Collections.Generic;
    using TwilightImperium.Enums;
    using TwilightImperium.Hex;

    internal class Tile : Location
    {
        public IEnumerable<Planet> Planets;
        public HexCoord Coord;
        public Wormhole Wormholes;
        public Anomaly Anomaly;
    }
}
