using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.DataObjects
{
    public class DtoGameType : EntityData
    {
        public string Abbreviation { get; set; }
        public string NameValue { get; set; }
    }
}