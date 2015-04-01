using System;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoLineupBatter : EntityData
    {
        //public int LineupOrder { get; set; }
        public string LineupId { get; set; }
       // public string BatterId { get; set; }
        //Relationships
       // public DtoPosition Position { get; set; }
        //public PlayerStatusCode PlayerStatusCode { get; set; }
      //  public string PlayerStatusCodeId { get; set; } 
    }
}