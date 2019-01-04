namespace TwilightImperium.Hex
{
    using System.Collections.Generic;
    using System.Linq;

    public static class HexCoordsExtensionMethods
    {
        public static HexCoord Sum(this IEnumerable<HexCoord> l) => l.Aggregate(new HexCoord(0, 0, 0), (current, hexCoord) => current + hexCoord);
    }
}