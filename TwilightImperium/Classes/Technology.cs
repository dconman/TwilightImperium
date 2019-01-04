namespace TwilightImperium.Classes
{
    using System.Collections.Generic;
    using TwilightImperium.Enums;

    internal class Technology : Card
    {
        internal TechType Type;
        internal IEnumerable<TechType> Prerequisites;
        internal Faction Faction;
        internal bool Basic;
    }
}