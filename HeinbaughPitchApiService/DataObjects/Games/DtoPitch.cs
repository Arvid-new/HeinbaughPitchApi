using System;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoPitch : EntityData
    {
        public int? GamedayId { get; set; }
        public string Description { get; set; }
        //PitchResult can be B (Ball), S (Strike), or X (Ball in Play)
        public string PitchResult { get; set; }
        public DateTime PitchTime { get; set; }

        //These are non-PitchFxPitches
        public decimal? SimpleX { get; set; }
        public decimal? SimpleY { get; set; }
        public decimal? StartSpeed { get; set; }
        public decimal? EndSpeed { get; set; }

        //Strike Zone Indicators
        public decimal? StrikeZoneTop { get; set; }
        public decimal? StrikeZoneBottom { get; set; }

        //PitchFx Stats
        public decimal? DeltaX { get; set; }
        public decimal? DeltaY { get; set; }
        public decimal? HomePlateX { get; set; }
        public decimal? HomePlateY { get; set; }
        public decimal? MoundX { get; set; }
        public decimal? MoundY { get; set; }
        public decimal? MidlineX { get; set; }
        public decimal? MidlineY { get; set; }
        //vx0
        public decimal? MoundHorizontalSpeed { get; set; }
        //vz0
        public decimal? MoundVerticalSpeed { get; set; }
        public decimal? MoundHorizontalAcceleration { get; set; }
        public decimal? MoundVerticalAcceleration { get; set; }
        public decimal? GreatestDeviation { get; set; }
        public decimal? DistanceFromHomeForGreatestDeviation { get; set; }
        public decimal? AngleofGreatestDeviation { get; set; }
        public int? Nastiness { get; set; }
        public decimal? SpinDirection { get; set; }
        public int? ZoneNumber { get; set; }


        //Relationships
        public string BatterId { get; set; }
        public string PitcherId { get; set; }
        public string AtBatId { get; set; }
        public string PitchTypeId { get; set; }
    }
}