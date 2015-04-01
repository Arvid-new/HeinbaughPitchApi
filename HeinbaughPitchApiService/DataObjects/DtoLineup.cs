using System;
using System.Collections.Generic;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoLineup : EntityData
    {
        public DtoTeam Team { get; set; }
        public string StartingPitcherId { get; set; }
        public virtual ICollection<DtoLineupBatter> Batters { get; set; }
        public virtual Pitcher StartingPitcher { get; set; }
    }
}