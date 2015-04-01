using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoHitResult : EntityData
    {
        public HitType HitType { get; set; }
        public string Description { get; set; }
    }
}