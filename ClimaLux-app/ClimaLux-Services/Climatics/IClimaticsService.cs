using ClimaLux_Data.Entities;
using ClimaLux_Services.Climatics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaLux_Services.Climatics
{
    public interface IClimaticsService
    {
        Task<IEnumerable<NewClimaticSM>> GetAllAsync();
        Task<Climatic> GetByIdAsync(int id);
        Task AddAsync(NewClimaticSM climatic);
        Task UpdateAsync(int id, NewClimaticSM climatic);
        Task DeleteAsync(int id);
        
        
    }
}
