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
using Action = Gameday.Data.Action;

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
                m.CreateMap<DtoAction, Action>();
                m.CreateMap<DtoHit, Hit>();
                m.CreateMap<DtoBatterSeason, BatterSeason>();
                m.CreateMap<DtoHitResult, HitResult>();
                m.CreateMap<DtoSeason, Season>();
                m.CreateMap<DtoPickoff, Pickoff>();
                m.CreateMap<DtoLineup, Lineup>();
                m.CreateMap<DtoTeam, Team>();
                m.CreateMap<DtoDivision, Division>();
                m.CreateMap<DtoLeague, League>();
                m.CreateMap<DtoUmpire, Umpire>();
                m.CreateMap<DtoGame, Game>();
               // m.CreateMap<DtoLineupBatter, LineupBatter>();
                m.CreateMap<DtoInning, Inning>();
                m.CreateMap<DtoAtBat, AtBat>();
                m.CreateMap<DtoRunner, Runner>();
                m.CreateMap<DtoPitch, Pitch>();
                
                //outgoing
                m.CreateMap<Pitcher, DtoPitcher>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()))
                    .ForMember(d => d.PitchTypes, map => map.MapFrom(x => x.PitchesThrown))
                    .ForMember(d => d.SeasonStats, map => map.MapFrom(x => x.PitcherSeasons));
                m.CreateMap<Batter, DtoBatter>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()))
                    .ForMember(d => d.PositionsPlayed, map => map.MapFrom(x => x.PositionsPlayed))
                    .ForMember(d => d.Actions, map => map.MapFrom(x => x.Actions))
                    .ForMember(d => d.Hits, map => map.MapFrom(x => x.Hits))
                    .ForMember(d => d.BatterSeasons, map => map.MapFrom(x => x.BatterSeasons));
                m.CreateMap<PitchType, DtoPitchType>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()))
                    .ForMember(d => d.PitchName, map => map.MapFrom(x => x.Name));
                m.CreateMap<PitcherSeason, DtoPitcherSeason>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<Position, DtoPosition>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<Action, DtoAction>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()))
                    .ForMember(d => d.BatterId, map => map.MapFrom(x => x.BatterId.ToString()))
                    .ForMember(d => d.AtBatId, map => map.MapFrom(x => x.AtBat.Id.ToString()))
                    .ForMember(d => d.InningId, map => map.MapFrom(x => x.Inning.Id.ToString()));
                m.CreateMap<Hit, DtoHit>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()))
                    .ForMember(d => d.BatterId, map => map.MapFrom(x => x.BatterId.HasValue ? x.BatterId.ToString() : string.Empty)) // Use this line for nullable GUIDs
                    .ForMember(d => d.PitcherId, map => map.MapFrom(x => x.PitcherId.HasValue ? x.PitcherId.ToString() : string.Empty));
                m.CreateMap<BatterSeason, DtoBatterSeason>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<HitResult, DtoHitResult>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<Season, DtoSeason>()
                   .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<Pickoff, DtoPickoff>()
                   .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()))
                   .ForMember(d => d.PitcherId, map => map.MapFrom(x => x.PitcherId.ToString()));
                m.CreateMap<Lineup, DtoLineup>()
                    .ForMember(d => d.StartingPitcherId, map => map.MapFrom(x => x.StartingPitcherId.HasValue ? x.StartingPitcherId.ToString() : string.Empty))
                    .ForMember(d => d.TeamId, map => map.MapFrom(x => x.Team.Id.ToString()))
                   // .ForMember(d => d.Batters, map => map.MapFrom(x => x.Batters))
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<Team, DtoTeam>()
                    .ForMember(d => d.DivisionId, map => map.MapFrom(x => x.DivisionId.ToString()))
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<Division, DtoDivision>()
                    .ForMember(d => d.LeagueId, map => map.MapFrom(x => x.LeagueId.ToString()))
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<League, DtoLeague>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<Umpire, DtoUmpire>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<Game, DtoGame>()
                    .ForMember(d => d.HomeTeamId, map => map.MapFrom(x => x.HomeTeamId.HasValue ? x.HomeTeamId.ToString() : string.Empty))
                    .ForMember(d => d.AwayTeamId, map => map.MapFrom(x => x.AwayTeamId.HasValue ? x.AwayTeamId.ToString() : string.Empty))
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<GameType, DtoGameType>()
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<LineupBatter, DtoLineupBatter>()
                    .ForMember(d => d.LineupId, map => map.MapFrom(x => x.Lineup.Id.ToString()))
                   // .ForMember(d => d.BatterId, map => map.MapFrom(x => x.Batter.Id.ToString()))
                    //.ForMember(d => d.PlayerStatusCodeId, map => map.MapFrom(x => x.PlayerStatusCodeId.HasValue ? x.PlayerStatusCodeId.ToString() : string.Empty))
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<Inning, DtoInning>()
                    .ForMember(d => d.GameId, map => map.MapFrom(x => x.GameId.HasValue ? x.GameId.ToString() : string.Empty))
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<AtBat, DtoAtBat>()
                    .ForMember(d => d.InningId, map => map.MapFrom(x => x.Inning.Id.ToString()))
                    .ForMember(d => d.BatterId, map => map.MapFrom(x => x.Batter.Id.ToString()))
                    .ForMember(d => d.PitcherId, map => map.MapFrom(x => x.Pitcher.Id.ToString()))
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<Runner, DtoRunner>()
                    .ForMember(d => d.BatterId, map => map.MapFrom(x => x.Batter.Id.ToString()))
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));
                m.CreateMap<Pitch, DtoPitch>()
                    .ForMember(d => d.AtBatId, map => map.MapFrom(x => x.AtBat.Id.ToString()))
                    .ForMember(d => d.PitchTypeId, map => map.MapFrom(x => x.PitchType.Id.ToString()))
                    .ForMember(d => d.BatterId, map => map.MapFrom(x => x.Batter.Id.ToString()))
                    .ForMember(d => d.PitcherId, map => map.MapFrom(x => x.Pitcher.Id.ToString()))
                    .ForMember(d => d.Id, map => map.MapFrom(x => x.Id.ToString()));


            });
        }
    }
}

