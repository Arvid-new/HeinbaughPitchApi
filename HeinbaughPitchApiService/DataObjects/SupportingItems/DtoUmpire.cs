using System.Collections.Generic;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoUmpire : EntityData
    {
        public int GamedayId { get; set; }
        public string Name { get; set; }

        //Relationships
        //public virtual ICollection<Game> GamesAtHome { get; set; }
        //public virtual ICollection<Game> GamesAtFirst { get; set; }
        //public virtual ICollection<Game> GamesAtSecond { get; set; }
        //public virtual ICollection<Game> GamesAtThird { get; set; } 
    }
}