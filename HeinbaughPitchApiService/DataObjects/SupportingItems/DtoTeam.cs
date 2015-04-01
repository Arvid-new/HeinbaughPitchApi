using System;
using System.Collections.Generic;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoTeam : EntityData
    {
        public string TeamCode { get; set; }
        public string FileCode { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Abbreviation { get; set; }
        public string City { get; set; }

        //Relationships
        public string DivisionId { get; set; }
        //[InverseProperty("HomeTeam")]
        //public virtual ICollection<Game> HomeGames { get; set; }
        //[InverseProperty("AwayTeam")]
        //public virtual ICollection<Game> AwayGames { get; set; } 
    }
}