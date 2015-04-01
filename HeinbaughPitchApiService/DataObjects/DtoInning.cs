using System;
using System.Collections.Generic;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;
using Action = Gameday.Data.Action;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoInning : EntityData
    {
        public int? InningNumber { get; set; }
        public bool? IsTopOfInning { get; set; }

        //Relationships
        public string GameId { get; set; }

        public virtual ICollection<DtoAtBat> AtBats { get; set; }
        public ICollection<DtoAction> Actions { get; set; } 
    }
}