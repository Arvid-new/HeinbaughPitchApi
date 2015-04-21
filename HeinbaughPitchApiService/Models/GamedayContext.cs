using System.Data.Entity;
using Autofac.Core;
using Gameday.Data;

namespace HeinbaughPitchApiService.Models
{
    public interface IGamedayContext
    {
        void Save();
        DbSet<Action> Actions { get; set; }
        DbSet<AtBat> AtBats { get; set; }
        DbSet<Game> Games { get; set; }
        DbSet<Hit> Hits { get; set; }
        DbSet<Inning> Innings { get; set; }
        DbSet<Lineup> Lineups { get; set; }
        DbSet<Pickoff> Pickoffs { get; set; }
        DbSet<Pitch> Pitches { get; set; }
        DbSet<Runner> Runners { get; set; }
        DbSet<Season> Seasons { get; set; }
        //Players Folder
        DbSet<Pitcher> Pitchers { get; set; }
        DbSet<Batter> Batters { get; set; }
        DbSet<BatterSeason> BatterSeasons { get; set; }
        DbSet<PitcherSeason> PitcherSeasons { get; set; }
        DbSet<Position> Positions { get; set; }

        //Supporting Items
        DbSet<GameType> GameTypes { get; set; }
        DbSet<Division> Divisions { get; set; }
        DbSet<HitResult> HitResults { get; set; }
        DbSet<League> Leagues { get; set; }
        DbSet<PitchType> PitchTypes { get; set; }
        DbSet<PlayerStatusCode> PlayerStatusCodes { get; set; }
        DbSet<Stadium> Stadiums { get; set; }
        DbSet<Team> Teams { get; set; }
        DbSet<Umpire> Umpires { get; set; }
    }
    public class GamedayContext : DbContext, IGamedayContext
    {
        private const string connectionStringName = "Name=MS_TableConnectionString";


        public GamedayContext()
            : base(connectionStringName)
        {
            
            Database.SetInitializer<GamedayContext>(null);
            //Database.SetInitializer(new GamedayInitializer());
            Database.Initialize(true);
        }
        //Games
        public void Save()
        {
            SaveChanges();
        }

        public DbSet<Action> Actions { get; set; }
        public DbSet<AtBat> AtBats { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Hit> Hits { get; set; }
        public DbSet<Inning> Innings { get; set; }
        public DbSet<Lineup> Lineups { get; set; }
        public DbSet<Pickoff> Pickoffs { get; set; }
        public DbSet<Pitch> Pitches { get; set; }
        public DbSet<Runner> Runners { get; set; }
        public DbSet<Season> Seasons { get; set; }
        //Players Folder
        public DbSet<Pitcher> Pitchers { get; set; }
        public DbSet<Batter> Batters { get; set; }
        public DbSet<BatterSeason> BatterSeasons { get; set; }
        public DbSet<PitcherSeason> PitcherSeasons { get; set; }
        public DbSet<Position> Positions { get; set; }

        //Supporting Items
        public DbSet<GameType> GameTypes { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<HitResult> HitResults { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<PitchType> PitchTypes { get; set; }
        public DbSet<PlayerStatusCode> PlayerStatusCodes { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Umpire> Umpires { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //take the base class and map those properties to each concrete
            //class that inherits
            modelBuilder.Entity<Pitcher>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Pitchers");
            });
            modelBuilder.Entity<Batter>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Batters");
            });
            modelBuilder.Entity<BatterSeason>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("BatterSeasons");
            });
            modelBuilder.Entity<PitcherSeason>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("PitcherSeasons");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
