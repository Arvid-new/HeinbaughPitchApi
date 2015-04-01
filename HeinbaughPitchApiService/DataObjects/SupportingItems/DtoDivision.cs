using System;
using System.Collections.Generic;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoDivision : EntityData
    {
        public string Name { get; set; }

        //Relationships
        public string LeagueId { get; set; }
        public virtual ICollection<DtoTeam> Teams { get; set; } 
    }
}