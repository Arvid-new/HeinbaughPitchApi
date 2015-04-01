using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.UI.WebControls;
using Gameday.Data;
using HeinbaughPitchApiService.DataObjects;
using HeinbaughPitchApiService.Models;
using Microsoft.Azure.Mobile.Server;
using GamedayContext = HeinbaughPitchApiService.Models.GamedayContext;

namespace HeinbaughPitchApiService.Controllers
{
    public class PitcherController : TableController<DtoPitcher>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            var context = new GamedayContext();
            DomainManager = new PitcherDomainModel(context, Request, Services);
        }

        public IQueryable<DtoPitcher> GetAllPitchers()
        {
            return Query();
        }
    }
}
