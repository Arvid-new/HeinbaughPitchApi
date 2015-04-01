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
        public virtual DtoHitResult Result { get; set; }
        public string BatterId { get; set; }
        public string PitcherId { get; set; }
    }
}