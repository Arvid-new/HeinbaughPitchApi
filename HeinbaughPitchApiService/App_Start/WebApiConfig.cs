using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using System.Web.UI.WebControls;
using AutoMapper;
using Gameday.Data;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.AppService.Config;
using HeinbaughPitchApiService.DataObjects;
using HeinbaughPitchApiService.Models;

namespace HeinbaughPitchApiService
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            AppServiceExtensionConfig.Initialize();
            
            // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
            Mapper.Initialize(m =>
            {
                //incoming
                m.CreateMap<DtoPitcher, Pitcher>();
                m.CreateMap<DtoBatter, Batter>();
                m.CreateMap<DtoPitchType, PitchType>()
                    .ForMember(d => d.PitchersWhoHavePitch, map => map.MapFrom(x => x.PitcherId));
                m.CreateMap<DtoPitcherSeason, PitcherSeason>();
                m.CreateMap<DtoPosition, Position>();
                
                //outgoing
                m.CreateMap<Pitcher, DtoPitcher>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()))
                    .ForMember(d => d.PitchTypes, map => map.MapFrom(x => x.PitchesThrown))
                    .ForMember(d => d.SeasonStats, map => map.MapFrom(x => x.PitcherSeasons));
                m.CreateMap<Batter, DtoBatter>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()))
                    .ForMember(d => d.PositionsPlayed, map => map.MapFrom(x => x.PositionsPlayed));
                m.CreateMap<PitchType, DtoPitchType>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()))
                    .ForMember(d => d.PitchName, map => map.MapFrom(x => x.Name));
                m.CreateMap<PitcherSeason, DtoPitcherSeason>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<Position, DtoPosition>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
            });
            Database.SetInitializer(new HeinbaughPitchApiInitializer());
        }
    }

    public class HeinbaughPitchApiInitializer : ClearDatabaseSchemaIfModelChanges<HeinbaughPitchApiContext>
    {
        protected override void Seed(HeinbaughPitchApiContext context)
        {
            //List<TodoItem> todoItems = new List<TodoItem>
            //{
            //    new TodoItem { Id = Guid.NewGuid().ToString(), Text = "First item", Complete = false },
            //    new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Complete = false },
            //};

            //foreach (TodoItem todoItem in todoItems)
            //{
            //    context.Set<TodoItem>().Add(todoItem);
            //}

            //base.Seed(context);
        }
    }
}

