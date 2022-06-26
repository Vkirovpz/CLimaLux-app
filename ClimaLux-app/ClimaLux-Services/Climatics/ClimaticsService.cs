using ClimaLux_Data.DbContext;
using ClimaLux_Data.Entities;
using ClimaLux_Services.Base;


namespace ClimaLux_Services.Climatics
{
    public class ClimaticsService : EntityBaseRepository<Climatic>, IClimaticsService
    {
        public ClimaticsService(ClimaLuxDbContext context) : base(context) { }
    }
}
