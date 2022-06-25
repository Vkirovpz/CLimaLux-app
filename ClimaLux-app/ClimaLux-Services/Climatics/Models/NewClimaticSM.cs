using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaLux_Services.Climatics.Models
{
    public class NewClimaticSM
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public Decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string Origin { get; set; }

        public string CoolAgent { get; set; }

        public string NoiseLevelInside { get; set; }

        public string NoiseLevelOutside { get; set; }

        public string CoolingKWPower { get; set; }

        public string HeatingKWPower { get; set; }

        public string Waranty { get; set; }

        public int BrandId { get; set; }

        public int RoomSizeId { get; set; }

        public int BtuPowerId { get; set; }

        public int CategoryId { get; set; }

        public int EnergyClassCoolingId { get; set; }

        public int EnergyClassHeatingId { get; set; }


    }
}
