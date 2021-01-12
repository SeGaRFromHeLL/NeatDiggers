﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeatDiggers.GameServer.Abilities
{
    public class Shuriken : Ability
    {
        int damage;
        int range;
        int consumption;

        public Shuriken(int damage, int range, int consumption)
        {
            this.damage = damage;
            this.range = range;
            this.consumption = consumption;
            Name = AbilityName.Shuriken;
            Description = $"Сурикен на {damage} урона, {range} дальности за {consumption} сброса";
            Type = AbilityType.Active;
        }

        public override bool Use(Room room, GameAction gameAction)
        {
            Player targetPlayer = room.GetPlayer(gameAction.TargetPlayerId);
            if (gameAction.CurrentPlayer.Position.CheckAvailability(targetPlayer.Position, range))
            {
                if (gameAction.CurrentPlayer.Inventory.Drop >= consumption)
                {
                    gameAction.CurrentPlayer.Inventory.Drop -= consumption;
                    targetPlayer.Health -= damage;
                    if (targetPlayer.Health <= 0)
                        targetPlayer.Respawn();
                    return true;
                }
            }
            return false;
        }
    }
}
