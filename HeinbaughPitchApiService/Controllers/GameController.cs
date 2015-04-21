using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.AppService;
using HeinbaughPitchApiService.DataObjects;
using HeinbaughPitchApiService.Models;
using GamedayContext = HeinbaughPitchApiService.Models.GamedayContext;

namespace HeinbaughPitchApiService.Controllers
{
    public class GameController : TableController<DtoGame>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            var context = new GamedayContext();
            DomainManager = new GameDomainModel(context, Request, Services);
            
        }

        // GET tables/Game
        public IQueryable<DtoGame> GetAllDtoGame()
        {
            return Query(); 
        }

        // GET tables/Game/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<DtoGame> GetDtoGame(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Game/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<DtoGame> PatchDtoGame(string id, Delta<DtoGame> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Game
        public async Task<IHttpActionResult> PostDtoGame(DtoGame item)
        {
            DtoGame current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Game/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteDtoGame(string id)
        {
             return DeleteAsync(id);
        }

    }
}