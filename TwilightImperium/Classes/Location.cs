namespace TwilightImperium.Classes
{
    using System.Collections.Generic;

    internal abstract class Location
    {
        internal Player Controller;
        internal IEnumerable<Unit> Units;
    }
}