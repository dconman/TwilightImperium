namespace TwilightImperium.Classes
{
    using TwilightImperium.Enums;

    internal class Planet : Location
    {
        internal string Name { get; set; }

        internal int Resources { get; set; }

        internal int Influence { get; set; }

        internal TechType TechType { get; set; }

        internal PlanetTrait Trait { get; set; }

        public Tile System;
    }
}