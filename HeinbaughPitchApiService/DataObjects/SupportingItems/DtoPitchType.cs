using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoPitchType : EntityData
    {
        public string PitchName { get; set; }
        public string Abbreviation { get; set; }
        public string PitcherId { get; set; }
        public DtoPitcher Pitcher { get; set; }
    }
}