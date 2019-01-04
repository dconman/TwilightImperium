namespace TwilightImperium.Classes
{
    using System.Collections.Generic;
    using TwilightImperium.Enums;

    internal class UnitStats
    {
        internal UnitType Type { get; set; }
        internal int Production { get; set; }
        internal int Movement { get; set; }
        internal int Combat { get; set; }
        internal int CombatRolls { get; set; }
        internal int Capacity { get; set; }

        internal bool SpaceCombat { get; set; }
        internal bool GroundCombat { get; set; }

        internal IEnumerable<UnitAbility> Abilities { get; } = new List<UnitAbility>();

        internal Player Owner;
    }
}
