namespace TwilightImperium.Classes
{
    using System.Collections.Generic;
    using TwilightImperium.Enums;

    internal class Player
    {
        internal Faction Faction;
        internal string Name;
        internal int Initiative;
        internal int Seat;
        internal IDictionary<UnitType,UnitStats> UnitStats;
        internal IList<Unit> Units;
        internal Tile HomeTile;

        internal int ActionCardHandSize = 7;

        internal IList<Technology> Technologies;
        internal IList<ComponentAction> ComponentActions;

        internal IList<ActionCard> ActionCards;
        internal IList<PromisoryNotes> PromisoryNotes;

        internal int StrategyTokens;
        internal int FleetTokens;
        internal int TacticsTokens;

        internal int Commodities;
        internal int TradeGoods;
        internal int CommodityCap;

    }
}