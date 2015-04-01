using System;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoLineupBatter : EntityData
    {
        public int LineupOrder { get; set; }
        //Relationships
        public DtoBatter Batter { get; set; }
        public DtoLineup Lineup { get; set; }
        public DtoPosition Position { get; set; }
        //public PlayerStatusCode PlayerStatusCode { get; set; }
        public string PlayerStatusCodeId { get; set; } 
    }
}