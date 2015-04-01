using System;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoHit : EntityData
    {
        public decimal? XLocation { get; set; }
        public decimal? YLocation { get; set; }
        public HitType HitType { get; set; }

        //Relationships
        //public virtual HitResult Result { get; set; }
        //public virtual Batter Batter { get; set; }
        //public Guid? BatterId { get; set; }

        //public virtual BatterSeason BatterSeason { get; set; }
        //public virtual PitcherSeason PitcherSeason { get; set; }
        //public virtual Pitcher Pitcher { get; set; }
        //public Guid? PitcherId { get; set; }
    }
}