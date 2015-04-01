using System;
using System.Collections.Generic;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoLineup : EntityData
    {
        public DtoTeam Team { get; set; }
       // public virtual ICollection<LineupBatter> Batters { get; set; }
        public string StartingPitcherId { get; set; } 
    }
}