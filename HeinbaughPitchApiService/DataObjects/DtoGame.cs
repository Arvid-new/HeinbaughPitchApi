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
        //public virtual Team HomeTeam { get; set; }
        //public virtual Lineup HomeTeamLineup { get; set; }
        //public virtual Team AwayTeam { get; set; }

        //public virtual Lineup AwayTeamLineup { get; set; }
        //public virtual Umpire HomePlateUmpire { get; set; }
        //public virtual Umpire FirstBaseUmpire { get; set; }
        //public virtual Umpire SecondBaseUmpire { get; set; }
        //public virtual Umpire ThirdBaseUmpire { get; set; }
        //public virtual ICollection<Inning> Innings { get; set; } 
    }
}