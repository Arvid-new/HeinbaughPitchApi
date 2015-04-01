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
    public class GameDomainModel : MappedEntityDomainManager<DtoGame, Game>
    {
        public GameDomainModel(DbContext context, HttpRequestMessage request, ApiServices services) 
            : base(context, request, services)
        {
        }

        public GameDomainModel(DbContext context, HttpRequestMessage request, ApiServices services, bool enableSoftDelete) 
            : base(context, request, services, enableSoftDelete)
        {
        }

        public override SingleResult<DtoGame> Lookup(string id)
        {
            var gameId = GetKey<Guid>(id);
            return LookupEntity(p => p.Id == gameId);

        }

        public override Task<DtoGame> UpdateAsync(string id, Delta<DtoGame> patch)
        {
            throw new System.NotImplementedException("Updates are not supported via the Mobile API");

        }

        public override Task<bool> DeleteAsync(string id)
        {
            throw new System.NotImplementedException("Deletes are not supported via the Mobile API");

        }
    }
}