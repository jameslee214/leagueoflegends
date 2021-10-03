﻿using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.YamlDatabase.Controller
{
    public class ClashCupApi : LolDbContext
    {
        public List<ClashTabs> GetClashTabs()
        {
            var items = from s in Db.ClashTabs
                        select new ClashTabs
                        {
                            Seq = s.Seq,
                            Name = s.Name
                        };

            return items.ToList();
        }

        public List<ClashCups> GetClashCups()
        {
            var items = from s in Db.ClashCups
                        select new ClashCups
                        {
                            Seq = s.Seq,
                            Name = s.Name
                        };

            return items.ToList();
        }

        public List<ClashTiers> GetClashTiers()
        {
            var items = from s in Db.ClashTiers
                        select new ClashTiers
                        {
                            Seq = s.Seq,
                            Name = s.Name
                        };

            return items.ToList();
        }

        public List<ClashTierDetails> GetClashTierDetails(int seq)
        {
            var items = from s in Db.ClashTierDetails
                        where s.ParentSeq == seq
                        select new ClashTierDetails
                        {
                            Seq = s.Seq,
                            ParentSeq = s.ParentSeq,
                            Id = s.Id,
                            Name = s.Name,
                            SubName = s.SubName,
                            Time = s.Time
                        };

            return items.ToList();
        }
    }
}