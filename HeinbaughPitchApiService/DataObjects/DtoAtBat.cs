using System;
using System.Collections.Generic;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;
using Action = System.Action;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoAtBat : EntityData
    {
        public int? AtBatNumber { get; set; }
        public string Description { get; set; }
        public int? Balls { get; set; }
        public int? Strikes { get; set; }
        public int? Outs { get; set; }
        public DateTime? StartTime { get; set; }
        public string Event { get; set; }

        //Relationships
        public string InningId { get; set; }
        public virtual ICollection<Pitch> Pitches { get; set; }
        public virtual ICollection<DtoAction> Actions { get; set; }
        public virtual ICollection<DtoRunner> Runners { get; set; }
        public virtual ICollection<DtoPickoff> Pickoffs { get; set; }
        public string PitcherId { get; set; }
        public string BatterId { get; set; }
    }
}