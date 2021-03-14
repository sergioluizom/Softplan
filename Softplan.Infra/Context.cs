using Microsoft.EntityFrameworkCore;
using Softplan.Infra.EntityConfig;
using Softplan.Model.Entities;
using System.Reflection;

namespace Softplan.Infra
{
    public class Context : DbContext
    {   
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Country> Countrys { get; set; }
        public DbSet<CountryV2> CountrysV2 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CountryConfig).GetTypeInfo().Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OfficialLanguageConfig).GetTypeInfo().Assembly);            
            base.OnModelCreating(modelBuilder);
        }
    }
}
