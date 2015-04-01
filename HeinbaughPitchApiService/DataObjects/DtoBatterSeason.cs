using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoBatterSeason : EntityData
    {
        public int? Singles { get; set; }
        public int? Doubles { get; set; }
        public int? Triples { get; set; }
        public int? HomeRuns { get; set; }
        public int? StolenBases { get; set; }
        public int? CaughtStealing { get; set; }
        public int? AtBats { get; set; }
        public int? PlateAppearances { get; set; }
        public int? Walks { get; set; }
        public int? Strikeouts { get; set; }

        //Relationships
       // public virtual Batter Batter { get; set; }
       // public virtual Season Season { get; set; }
        public int? HitIntoDoublePlay { get; set; }
 
    }
}