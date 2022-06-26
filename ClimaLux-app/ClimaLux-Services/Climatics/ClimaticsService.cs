using ClimaLux_Data.DbContext;
using ClimaLux_Data.Entities;
using ClimaLux_Services.Base;
using ClimaLux_Services.Climatics.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ClimaLux_Services.Climatics
{
    public class ClimaticsService : EntityBaseRepository<Climatic>, IClimaticsService
    {
        private readonly ClimaLuxDbContext _context;

        public ClimaticsService(ClimaLuxDbContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<NewClimaticDropdownsSM> GetNewClimaticDropdownsValues()
        {
            var response = new NewClimaticDropdownsSM()
            {
                Brands = await _context.Brands.OrderBy(n => n.Name).ToListAsync(),
                Categories = await _context.Categories.OrderBy(n => n.Name).ToListAsync(),
                BtuPowers = await _context.BtuPowers.OrderBy(n => n.Power).ToListAsync(),
                EnergyClassCoolings = await _context.EnergyClassCoolings.OrderBy(n => n.CoolClass).ToListAsync(),
                EnergyClassHeatings = await _context.EnergyClassHeatings.OrderBy(n => n.HeatClass).ToListAsync(),
                RoomSizes = await _context.RoomSizes.OrderBy(n => n.Size).ToListAsync(),

            };

            return response;
        }
    }
}
