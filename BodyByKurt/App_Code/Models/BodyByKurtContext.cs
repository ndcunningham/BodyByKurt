using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using BodyByKurt.Models.Mapping;

namespace BodyByKurt.Models
{
    public class BodyByKurtContext : DbContext
    {
        static BodyByKurtContext()
        {
            Database.SetInitializer<BodyByKurtContext>(null);
        }

		public BodyByKurtContext()
			: base("Name=BodyByKurtContext")
		{
		}

        public DbSet<Award> Awards { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Tip> Tips { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AwardMap());
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new DietMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TipMap());
        }
    }
}
