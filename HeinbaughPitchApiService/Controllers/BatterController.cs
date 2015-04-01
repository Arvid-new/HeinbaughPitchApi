using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.AppService;
using HeinbaughPitchApiService.DataObjects;
using HeinbaughPitchApiService.Models;
using Gameday.Data;

namespace HeinbaughPitchApiService.Controllers
{
    public class BatterController : TableController<DtoBatter>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            var context = new GamedayContext();
            DomainManager = new BatterDomainModel(context, Request, Services);
        }

        // GET tables/Batter
        public IQueryable<DtoBatter> GetAllDtoBatter()
        {
            return Query(); 
        }

        // GET tables/Batter/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<DtoBatter> GetDtoBatter(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Batter/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<DtoBatter> PatchDtoBatter(string id, Delta<DtoBatter> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Batter
        public async Task<IHttpActionResult> PostDtoBatter(DtoBatter item)
        {
            DtoBatter current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Batter/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteDtoBatter(string id)
        {
             return DeleteAsync(id);
        }

    }
}