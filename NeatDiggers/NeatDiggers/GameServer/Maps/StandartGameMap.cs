﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeatDiggers.GameServer.Maps
{
    public class StandartGameMap : GameMap
    {
        public StandartGameMap()
        {
            string[] map =
                @"NEDEEESEEEDEN
NEEEENENEEEEN
NNNNENENENNNN
EDENENNNENEDE
EEEEEEEEEEEEE
ENNNEDEDENNNE
SEENEEFEENEES
ENNNEDEDENNNE
EEEEEEEEEEEEE
EDENENNNENEDE
NNNNENENENNNN
NEEEENENEEEEN
NEDEEESEEEDEN".Replace("\r", "").Split('\n');
            Width = 13;
            Height = 13;
            SpawnPoints = new List<Vector>();
            Map = new Cell[Width, Height];
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (map[y][x] == 'N')
                        Map[x, y] = Cell.None;
                    else if (map[y][x] == 'E')
                        Map[x, y] = Cell.Empty;
                    else if (map[y][x] == 'D')
                        Map[x, y] = Cell.Digging;
                    else if (map[y][x] == 'F')
                        Map[x, y] = Cell.Flag;
                    else if (map[y][x] == 'W')
                        Map[x, y] = Cell.Wall;
                    else if (map[y][x] == 'S')
                    {
                        Map[x, y] = Cell.Empty;
                        SpawnPoints.Add(new Vector(x, y));
                    }
                }
            }
        }
    }
}