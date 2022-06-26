using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClimaLux_app.Models.Climatics
{
    public class NewClimaticVM
    {
        public int Id { get; set; }

        [Display(Name = "Модел")]
        [Required]
        public string Model { get; set; }

        [Display(Name = "Описание")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Цена")]
        [Required]
        public Decimal Price { get; set; }

        [Display(Name = "Снимка")]
        [Required]
        [Url]
        public string ImageUrl { get; set; }

        [Display(Name = "Произход")]
        [Required]
        public string Origin { get; set; }

        [Display(Name = "Хладилен агент")]
        [Required]
        public string CoolAgent { get; set; }

        [Display(Name = "Ниво шум вътрешно тяло")]
        [Required]
        public string NoiseLevelInside { get; set; }

        [Display(Name = "Ниво шум външно тяло")]
        [Required]
        public string NoiseLevelOutside { get; set; }

        [Display(Name = "Консумирана мощност на охлаждане(kW)")]
        [Required]
        public string CoolingKWPower { get; set; }

        [Display(Name = "Консумирана мощност на отопление(kW)")]
        [Required]
        public string HeatingKWPower { get; set; }

        [Display(Name = "Гаранция")]
        [Required]
        public string Waranty { get; set; }

        [Display(Name = "Марка")]
        [Required]
        public int BrandId { get; set; }

        [Display(Name = "Помещение")]
        [Required]
        public int RoomSizeId { get; set; }

        [Display(Name = "Мощност")]
        [Required]
        public int BtuPowerId { get; set; }

        [Display(Name = "Категория")]
        [Required]
        public int CategoryId { get; set; }

        [Display(Name = "Енергиен клас охлаждане")]
        [Required]
        public int EnergyClassCoolingId { get; set; }

        [Display(Name = "Енергиен клас отопление")]
        [Required]
        public int EnergyClassHeatingId { get; set; }

    }
}
