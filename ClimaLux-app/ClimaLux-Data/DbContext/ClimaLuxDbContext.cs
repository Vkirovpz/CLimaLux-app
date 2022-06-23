using ClimaLux_Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaLux_Data.DbContext
{
    public class ClimaLuxDbContext: IdentityDbContext<ApplicationUser>
    {
        public ClimaLuxDbContext(DbContextOptions<ClimaLuxDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Climatic> Climatics { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BtuPower> BtuPowers { get; set; }
        public DbSet<RoomSize> RoomSizes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<EnergyClassCooling> EnergyClassCoolings { get; set; }
        public DbSet<EnergyClassHeating> EnergyClassHeatings { get; set; }
    }
}
