using System;
using System.Data.Entity;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.OData;
using Gameday.Data;
using HeinbaughPitchApiService.DataObjects;
using Microsoft.Azure.Mobile.Server;

namespace HeinbaughPitchApiService.Models
{
    public class BatterDomainModel : MappedEntityDomainManager<DtoBatter, Batter>
    {

        public override SingleResult<DtoBatter> Lookup(string id)
        {
            var batterId = GetKey<Guid>(id);
            return LookupEntity(p => p.Id == batterId);
        }

        public override Task<DtoBatter> UpdateAsync(string id, Delta<DtoBatter> patch)
        {
            throw new System.NotImplementedException("Updates are not supported via the Mobile API");
        }

        public override Task<bool> DeleteAsync(string id)
        {
            throw new System.NotImplementedException("Deletes are not supported via the Mobile API");
        }

        public BatterDomainModel(DbContext context, HttpRequestMessage request, ApiServices services) 
            : base(context, request, services)
        {
        }

        public BatterDomainModel(DbContext context, HttpRequestMessage request, ApiServices services, bool enableSoftDelete) 
            : base(context, request, services, enableSoftDelete)
        {
        }
    }
}