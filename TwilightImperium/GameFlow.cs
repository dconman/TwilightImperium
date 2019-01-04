namespace TwilightImperium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TwilightImperium.Classes;
    using TwilightImperium.Data;
    using TwilightImperium.Enums;
    using TwilightImperium.Hex;
    using TwilightImperium.Util;

    public class GameFlow
    {
        private GameState game;
        private Interaction interaction;

        public void BeginingOfGame(int numberOfPlayers)
        {
            game = new GameState();
            interaction = new Interaction();
            var factions = EnumUtil.GetValues<Faction>();
            var players = Enumerable.Range(0, numberOfPlayers).Select(i =>
            {
                var player = new Player { Seat = i, Name = $"Player {i + 1}" };
                SetupPlayer(factions, player);
                return player;
            }).ToList();

            game.Players = players;
            game.Speaker = players.First();
        }

        private void SetupPlayer(IList<Faction> factions, Player player)
        {
            var faction = interaction.Choice(player, factions);
            factions.Remove(faction);
            player.Faction = faction;
            player.UnitStats = FactionStartingUnitStats.Stats[faction];
            var startingUnits = FactionStartingUnits.Units[faction];
            foreach (var unitType in EnumUtil.GetValuesReadOnly<UnitType>())
            {
                //if (EnumUtil.Comp(unitType, UnitCategories.Stackable))
            }
        }

        private HexCoord HomeTileLocation(int seat, int numberOfPlayers)
        {
            switch (numberOfPlayers)
            {
                case 3:
                    switch (seat)
                    {
                        case 0:
                            return new HexCoord(3,0,-3);
                        case 1:
                            return new HexCoord(0,-3,3);
                        case 2:
                            return new HexCoord(-3,3,0);
                    }

                    break;
                case 4:
                    switch (seat)
                    {
                        case 0:
                            return new HexCoord(-1,3,-2);
                        case 1:
                            return new HexCoord(3,-1,-2);
                        case 2:
                            return new HexCoord(1,-3,2);
                        case 3:
                            return new HexCoord(-3,1,2);
                    }
                    break;
                case 5:
                    switch (seat)
                    {
                        case 0:
                            return new HexCoord(-1,3,-2);
                        case 1:
                            return new HexCoord(3,0,-3);
                        case 2:
                            return new HexCoord(3,-3,0);
                        case 3:
                            return new HexCoord(0,-3,3);
                        case 4:
                            return new HexCoord(-3,1,2);
                    }
                    break;
                case 6:
                    switch (seat)
                    {
                        case 0:
                            return new HexCoord(0,3,-3);
                        case 1:
                            return new HexCoord(3,0,-3);
                        case 2:
                            return new HexCoord(3,-3,0);
                        case 3:
                            return new HexCoord(0,-3,3);
                        case 4:
                            return new HexCoord(-3,0,3);
                        case 5:
                            return new HexCoord(-3,3,0);
                    }
                    break;
            }
            if (seat >= numberOfPlayers || seat < 0) throw new ArgumentOutOfRangeException(nameof(seat), seat, $"Seat must be less than number of players: ${numberOfPlayers}");
            throw new ArgumentOutOfRangeException(nameof(numberOfPlayers), numberOfPlayers, "Number of players must be between 3 and 6");
        }

    }
}
