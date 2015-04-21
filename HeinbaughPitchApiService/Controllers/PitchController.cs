using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using AutoMapper.QueryableExtensions;
using Gameday.Data;
using HeinbaughPitchApiService.DataObjects;
using HeinbaughPitchApiService.Models;
using Microsoft.Azure.Mobile.Server;
using CompiledQuery = System.Data.Entity.Core.Objects.CompiledQuery;
using GamedayContext = HeinbaughPitchApiService.Models.GamedayContext;

namespace HeinbaughPitchApiService.Controllers
{
    public class PitchController : TableController<DtoPitch>
    {
        private GamedayContext _context;
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            _context = new GamedayContext();
            DomainManager = new PitchDomainModel(_context, Request, Services);
        }

        public IQueryable<DtoPitch> GetAllPitches()
        {
            var res = Query();
            return res;
        }
    }

    public class PitchApiController : ApiController
    {
        private readonly GamedayContext _context;
        public PitchApiController()
        {
            _context = new GamedayContext();

        }

        [Route("api/Pitch/")]
        public IEnumerable Get()
        {

            var res = _context.Pitches
                .Take(100)
                .Project().To<DtoPitch>().ToList();
            return res;
            var a = new int[3, 4, 5];
        }

        /// <summary>
        /// Returns all pitches thrown by an individual pitcher
        /// </summary>
        /// <param name="guid">ID of the Pitcher to retrieve</param>
        /// <returns>Collection of all pitches thrown by a pitcher</returns>

        [Route("api/Pitch/ByPitcher/{guid}")]
        public IQueryable GetByPitcherId(Guid guid)
        {
            var res = _context.Pitches
                .Where(p => p.PitcherId == guid)
                .Project().To<DtoPitch>();
            return res;
        }

        [EnableQuery(PageSize = 100)]
        [Route("api/Pitch/ByBatter/{guid}")]
        public IEnumerable GetByBatterId(Guid guid)
        {
            var sqlQuery = "Select * From Pitches Where BatterId = {0}";
            var results = _context.Pitches.SqlQuery(sqlQuery, guid);
            var list = new List<Pitch>();
            return list;
            //var res = _context.Pitches
            //    .Take(100)
            //    .Where(p => p.BatterId == guid);
            //// .Project().To<DtoPitch>();
            //return res;
        }
    }
}
