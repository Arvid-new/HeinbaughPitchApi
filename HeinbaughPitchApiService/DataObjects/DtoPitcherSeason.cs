using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoPitcherSeason : EntityData
    {
        public int? GamesPlayed { get; set; }
        public int? Wins { get; set; }
        public int? Losses { get; set; }
        public int? Saves { get; set; }
        public int? Shutouts { get; set; }
        public int? Holds { get; set; }
        public int? BlownSaves { get; set; }
        public int? GamesStarted { get; set; }
        public decimal? InningsPitched { get; set; }
        public int? BattersFaced { get; set; }
        public int? Strikeouts { get; set; }
        public int? Walks { get; set; }
        public int? TotalRunsAllowed { get; set; }
        public int? EarnedRuns { get; set; }
        public int? HomeRunsAllowed { get; set; }
        public int? intentionalBasesOnBalls { get; set; }
        public int? HitBatters { get; set; }
        public int? Balks { get; set; }
        public int? WildPitches { get; set; }
        public int? BaserunnersAllowed { get; set; }
        public int? SinglesAllowed { get; set; }
        public int? DoublesAllowed { get; set; }
        public int? TriplesAllowed { get; set; }



        //Relationships
        //public virtual Season Season { get; set; }
      //  public DtoPitcher Pitcher { get; set; }
    }
}