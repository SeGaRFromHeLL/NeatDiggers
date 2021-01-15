﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeatDiggers.GameServer.Items
{
    public class ScopeItem : Item
    {
        public ScopeItem()
        {
            Name = ItemName.Scope;
            Title = "Прицел";
            Description = "Увеличивает дальность дальнего оружия на 1";
            Type = ItemType.Passive;
            WeaponHanded = WeaponHanded.None;
            WeaponType = WeaponType.None;
        }

        public override void Get(Room room, GameAction gameAction)
        {
            gameAction.CurrentPlayer.RangedDistance += 1;
        }

        public override void Drop(Room room, GameAction gameAction)
        {
            gameAction.CurrentPlayer.RangedDistance -= 1;
        }
    }
}
