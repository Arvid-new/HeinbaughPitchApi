using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoPitcher : EntityData
    {
        public DtoPitcher()
        {
            PitchTypes = new List<DtoPitchType>();
            SeasonStats = new List<DtoPitcherSeason>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Weight { get; set; }
        public int? CareerWins { get; set; }
        public ICollection<DtoPitchType> PitchTypes { get; set; }
        public ICollection<DtoPitcherSeason> SeasonStats { get; set; }
    }
}