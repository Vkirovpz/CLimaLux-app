using ClimaLux_Data.Entities;
using ClimaLux_Services.Base;
using ClimaLux_Services.Climatics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaLux_Services.Climatics
{
    public interface IClimaticsService : IEntityBaseRepository<Climatic>
    {
        Task<NewClimaticDropdownsSM> GetNewClimaticDropdownsValues();
    }
}
