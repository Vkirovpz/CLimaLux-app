using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaLux_Data.Entities
{
    public class Climatic
    {
        public int Id { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Price { get; set; }

        [Url]
        public string ImageUrl { get; set; }

        public  string Origin { get; set; }

        public string CoolAgent { get; set; }

        public string NoiseLevelInside { get; set; }

        public string NoiseLevelOutside { get; set; }

        public string CoolingKWPower { get; set; }

        public string HeatingKWPower { get; set; }

        public string Waranty { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public int RoomSizeId { get; set; }

        public RoomSize RoomSize { get; set; }

        public int BtuPowerId { get; set; }

        public BtuPower BtuPower { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int EnergyClassCoolingId { get; set; }

        public EnergyClassCooling EnergyClassCooling { get; set; }

        public int EnergyClassHeatingId { get; set; }

        public EnergyClassHeating EnergyClassHeating { get; set; }

    }
}
