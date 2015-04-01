using System;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoRunner : EntityData
    {
        public Bases StartingBase { get; set; }
        public Bases EndingBase { get; set; }
        public bool? IsScored { get; set; }
        public bool? IsEarnedRun { get; set; }
        public bool? IsRunBattedIn { get; set; }
        public string Event { get; set; }

        //Relationships
        public string BatterId { get; set; }
    }
}