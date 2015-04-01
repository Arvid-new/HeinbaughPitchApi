using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoPitcher : EntityData
    {
        public DtoPitcher()
        {
            PitchTypes = new List<DtoPitchType>();
            SeasonStats = new List<DtoPitcherSeason>();
        }
        public int? GamedayId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? JerseyNumber { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public DateTime? DateofBirth { get; set; }
        public ThrowingSide ThrowingSide { get; set; }
        public BattingSide BattingSide { get; set; }
        public decimal? CareerBattingAvgAgainst { get; set; }
        public decimal? CareerWhip { get; set; }
        public decimal? CareerEra { get; set; }
        public decimal? CareerInningsPitched { get; set; }
        public int? CareerAtBats { get; set; }
        public int? CareerHitsAllowed { get; set; }
        public int? CareerRunsAllowed { get; set; }
        public int? CareerHomeRunsAllowed { get; set; }
        public int? CareerBaseonBalls { get; set; }
        public int? CareerStrikeouts { get; set; }
        public int? CareerWins { get; set; }
        public int? CareerLosses { get; set; }
        public int? CareerSaves { get; set; }
        public ICollection<DtoPitchType> PitchTypes { get; set; }
//        public ICollection<Lineup> GamesStarted { get; set; }

        public ICollection<DtoPitcherSeason> SeasonStats { get; set; }
        public virtual ICollection<DtoPickoff> Pickoffs { get; set; }
    }
}