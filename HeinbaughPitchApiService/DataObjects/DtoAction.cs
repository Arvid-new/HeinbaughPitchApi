using System;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoAction : EntityData
    {
        public int? OccurredOnPitch { get; set; }
        public string Description { get; set; }
        public DateTime? StartTime { get; set; }
        public int? Balls { get; set; }
        public int? Strikes { get; set; }
        public int? Outs { get; set; }
        public string Event { get; set; }

        //Relationships
        public string BatterId { get; set; }
        //public Inning Inning { get; set; }
        //public AtBat AtBat { get; set; } 
    }
}