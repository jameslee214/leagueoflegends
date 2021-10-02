﻿using System.Collections.Generic;

namespace Lol.YamlDatabase.Entites.Schema
{
    public class Items
    {
        public int Seq { get; set; }

        public string Name { get; set; }

        public string Champ { get; set; }

        public int[] MapTypes { get; set; }

        public IEnumerable<MapTypes> MapTypeItems { get; set; }
    }
}