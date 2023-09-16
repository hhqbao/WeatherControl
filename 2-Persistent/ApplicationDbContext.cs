using _1_Domain.Models;
using _2_Persistent.Configs;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace _2_Persistent
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<WeatherStation> WeatherStations { get; set; }
        public DbSet<Variable> Variables { get; set; }

        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new WeatherStationConfig());
            builder.ApplyConfiguration(new VariableConfig());

            base.OnModelCreating(builder);
        }
    }
}