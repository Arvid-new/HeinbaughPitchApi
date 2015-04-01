using System;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoPickoff : EntityData
    {
        public string Description { get; set; }

        //Relationships
        public string PitcherId { get; set; }
    }
}