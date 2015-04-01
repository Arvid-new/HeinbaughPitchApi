using System.Collections.Generic;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoLeague : EntityData
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        //Relationships
        public virtual ICollection<DtoDivision> Divisions { get; set; } 
    }
}