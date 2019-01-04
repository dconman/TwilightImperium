namespace TwilightImperium.Classes
{
    using TwilightImperium.Enums;

    internal class Unit
    {
        internal UnitType Type;
        internal Player Controller;
        internal Location Location;
        internal Faction Faction => Controller?.Faction ?? Faction.None;
        internal UnitStats Stats => Controller?.UnitStats[Type];

        internal int Quantity = 1;
        
    }
}