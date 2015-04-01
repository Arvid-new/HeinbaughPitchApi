using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoPosition : EntityData
    {
        public int PositionNumber { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
    }
}