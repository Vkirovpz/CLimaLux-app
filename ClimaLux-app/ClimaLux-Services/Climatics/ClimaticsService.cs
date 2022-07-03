using ClimaLux_Data.DbContext;
using ClimaLux_Data.Entities;
using ClimaLux_Services.Base;
using ClimaLux_Services.Climatics.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

        public async Task AddNewCliamticAsync(NewClimaticSM clima)
        {
            var climaToAdd = new Climatic()
            {
                Model = clima.Model,
                Description = clima.Description,
                Price = clima.Price,
                CoolAgent = clima.CoolAgent,
                CoolingKWPower = clima.CoolingKWPower,
                HeatingKWPower = clima.HeatingKWPower,
                ImageUrl = clima.ImageUrl,
                NoiseLevelInside = clima.NoiseLevelInside,
                NoiseLevelOutside = clima.NoiseLevelOutside,
                Origin = clima.Origin,
                Waranty = clima.Waranty,
                BrandId = clima.BrandId,
                CategoryId = clima.CategoryId,
                BtuPowerId = clima.BtuPowerId,
                EnergyClassCoolingId = clima.EnergyClassCoolingId,
                EnergyClassHeatingId = clima.EnergyClassHeatingId,
                RoomSizeId = clima.RoomSizeId
            };
            await _context.Climatics.AddAsync(climaToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<Climatic> GetClimaticByIdAsync(int id)
        {
            var clima = await _context.Climatics
                .Include(b=> b.Brand)
                .Include(c => c.Category)
                .Include(b=> b.BtuPower)
                .Include(ec => ec.EnergyClassCooling)
                .Include(eh => eh.EnergyClassHeating)
                .Include(r=> r.RoomSize)
                .FirstOrDefaultAsync(n => n.Id == id);
            return clima;
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

        public async Task UpdateClimaticAsync(NewClimaticSM clima)
        {
            var dbClima = await _context.Climatics.FirstOrDefaultAsync(n => n.Id == clima.Id);

            if (dbClima != null)
            {
                dbClima.Model = clima.Model;
                dbClima.Description = clima.Description;
                dbClima.Price = clima.Price;
                dbClima.CoolAgent = clima.CoolAgent;
                dbClima.CoolingKWPower = clima.CoolingKWPower;
                dbClima.HeatingKWPower = clima.HeatingKWPower;
                dbClima.ImageUrl = clima.ImageUrl;
                dbClima.NoiseLevelInside = clima.NoiseLevelInside;
                dbClima.NoiseLevelOutside = clima.NoiseLevelOutside;
                dbClima.Origin = clima.Origin;
                dbClima.Waranty = clima.Waranty;
                dbClima.BrandId = clima.BrandId;
                dbClima.CategoryId = clima.CategoryId;
                dbClima.BtuPowerId = clima.BtuPowerId;
                dbClima.EnergyClassCoolingId = clima.EnergyClassCoolingId;
                dbClima.EnergyClassHeatingId = clima.EnergyClassHeatingId;
                dbClima.RoomSizeId = clima.RoomSizeId;

                await _context.SaveChangesAsync();
            }
        }


    }
}
