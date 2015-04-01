using System;
using System.Collections.Generic;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoLineup : EntityData
    {
        public string TeamId { get; set; }
        public string StartingPitcherId { get; set; }
        //public ICollection<DtoLineupBatter> Batters { get; set; }
    }
}