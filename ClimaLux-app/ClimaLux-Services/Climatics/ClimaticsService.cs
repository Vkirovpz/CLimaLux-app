using ClimaLux_Data.DbContext;
using ClimaLux_Data.Entities;
using ClimaLux_Services.Climatics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaLux_Services.Climatics
{
    public class ClimaticsService : IClimaticsService
    {
        private readonly ClimaLuxDbContext _context;

        public ClimaticsService(ClimaLuxDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(NewClimaticSM climatic)
        {
            var newClima = new Climatic()
            {
                Model = climatic.Model,
                Description = climatic.Description,
                Price = climatic.Price,
                ImageUrl = climatic.ImageUrl,
                Origin = climatic.Origin,
                CoolAgent = climatic.CoolAgent,
                NoiseLevelInside = climatic.NoiseLevelInside,
                NoiseLevelOutside = climatic.NoiseLevelOutside,
                CoolingKWPower = climatic.CoolingKWPower,
                HeatingKWPower = climatic.HeatingKWPower,
                Waranty = climatic.Waranty,
                BrandId = climatic.BrandId,
                RoomSizeId = climatic.RoomSizeId,
                BtuPowerId = climatic.BtuPowerId,
                CategoryId = climatic.CategoryId,
                EnergyClassCoolingId = climatic.EnergyClassCoolingId,
                EnergyClassHeatingId = climatic.EnergyClassHeatingId
            };
            await _context.Climatics.AddAsync(newClima);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NewClimaticSM>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Climatic> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, NewClimaticSM climatic)
        {
            throw new NotImplementedException();
        }
    }
}
