using System;
using System.Collections.Generic;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoGame : EntityData
    {
        public int? GamedayId { get; set; }
        public DateTime? GameLocalStartTime { get; set; }
        public DateTime? EasternStartTime { get; set; }
        public DateTime? GameDate { get; set; }
        public string AwayTeamId { get; set; }
        public string HomeTeamId { get; set; }

        //Relationships
        public virtual DtoGameType GameType { get; set; }
        public virtual DtoLineup HomeTeamLineup { get; set; }
        public virtual DtoLineup AwayTeamLineup { get; set; }
        public virtual DtoUmpire HomePlateUmpire { get; set; }
        public virtual DtoUmpire FirstBaseUmpire { get; set; }
        public virtual DtoUmpire SecondBaseUmpire { get; set; }
        public virtual DtoUmpire ThirdBaseUmpire { get; set; }
        public virtual ICollection<DtoInning> Innings { get; set; } 
    }
}