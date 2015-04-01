using System;
using System.Collections.Generic;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoBatter : EntityData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? JerseyNumber { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }

        public decimal? CareerAverage { get; set; }
        public decimal? CareerOps { get; set; }
        public int? CareerAtBats { get; set; }
        public int? CareerHits { get; set; }
        public int? CareerWalks { get; set; }
        public int? CareerStrikeouts { get; set; }
        public int? CareerRuns { get; set; }
        public int? CareerStolenBases { get; set; }
        public int? CareerCaughtStealings { get; set; }
        public int? CareerHomeRuns { get; set; }
        public int? CareerRunsBattedIn { get; set; }

        public DateTime? DateofBirth { get; set; }
        public ThrowingSide ThrowingSide { get; set; }
        public BattingSide BattingSide { get; set; }

        //Relationships

        //public virtual ICollection<BatterSeason> BatterSeasons { get; set; }
        //public virtual ICollection<Hit> Hits { get; set; }
        //public virtual ICollection<Action> Actions { get; set; }
        //public virtual ICollection<Position> PositionsPlayed { get; set; } 
    }
}