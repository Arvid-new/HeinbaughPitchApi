using System;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.OData;
using Gameday.Data;
using HeinbaughPitchApiService.DataObjects;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.Models
{
    public class PitcherDomainModel : MappedEntityDomainManager<DtoPitcher, Pitcher>
    {
        public PitcherDomainModel(DbContext context, HttpRequestMessage request, ApiServices services) 
            : base(context, request, services)
        {
        }

        public PitcherDomainModel(DbContext context, HttpRequestMessage request, ApiServices services, bool enableSoftDelete) 
            : base(context, request, services, enableSoftDelete)
        {
        }

        public override SingleResult<DtoPitcher> Lookup(string id)
        {
            var pitcherId = GetKey<Guid>(id);
            return LookupEntity(p => p.Id == pitcherId);
        }

        public override Task<DtoPitcher> UpdateAsync(string id, Delta<DtoPitcher> patch)
        {
            throw new System.NotImplementedException("Updates are not supported via the Mobile API");
        }

        public override Task<bool> DeleteAsync(string id)
        {
            throw new System.NotImplementedException("Deletes are not supported via the Mobile API");
        }
    }
}