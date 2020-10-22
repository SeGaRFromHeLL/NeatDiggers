﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeatDiggersPrototype
{
    enum ItemName
    {
        Empty,
        Vest
    }

    class ItemInfo
    {
        public bool IsOpen;
        public ItemName Name;
    }

    abstract class Item
    {
        bool isOpen;
        ItemName name;

        public Item(ItemName name)
        {
            this.name = name;
        }

        public ItemInfo GetInfo()
        {
            return new ItemInfo
            {
                IsOpen = isOpen,
                Name = name
            };
        }
    }
}
