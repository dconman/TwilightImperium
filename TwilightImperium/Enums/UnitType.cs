namespace TwilightImperium.Enums
{
    using System;

    [Flags]
    internal enum UnitType
    {
        None = 0,
        Carrier     = 1 << 0,
        Cruiser     = 1 << 1,
        Destroyer   = 1 << 2,
        Dreadnought = 1 << 3,
        Fighter     = 1 << 4,
        Flagship    = 1 << 5,
        Infantry    = 1 << 6,
        PDS         = 1 << 7,
        SpaceDock   = 1 << 8,
        WarSun      = 1 << 9
    }

    internal static class UnitCategories
    {

        public const UnitType GroundForce = UnitType.Infantry;
        public const UnitType Structure = UnitType.PDS | UnitType.SpaceDock;

        public const UnitType Ship = UnitType.Carrier | UnitType.Cruiser | UnitType.Destroyer | UnitType.Dreadnought |
                                     UnitType.Fighter | UnitType.Flagship | UnitType.WarSun;

        public const UnitType Stackable = UnitType.Infantry | UnitType.Fighter;
    }
}
