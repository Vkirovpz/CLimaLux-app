using ClimaLux_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaLux_Services.Climatics.Models
{
    public class NewClimaticDropdownsSM
    {
        public NewClimaticDropdownsSM()
        {
            Brands = new List<Brand>();
            BtuPowers = new List<BtuPower>();
            Categories = new List<Category>();
            EnergyClassCoolings = new List<EnergyClassCooling>();
            EnergyClassHeatings = new List<EnergyClassHeating>();
            RoomSizes = new List<RoomSize>();
        }

        public List<Brand> Brands { get; set; }
        public List<BtuPower> BtuPowers { get; set; }
        public List<Category> Categories { get; set; }
        public List<EnergyClassCooling> EnergyClassCoolings { get; set; }
        public List<EnergyClassHeating> EnergyClassHeatings { get; set; }
        public List<RoomSize> RoomSizes { get; set; }
    }
}
