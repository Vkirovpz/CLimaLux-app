using ClimaLux_app.Models.Climatics;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using ClimaLux_Services.Climatics;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace ClimaLux_app.Controllers
{
    public class ClimaticsController : Controller
    {
        private readonly IClimaticsService _climatics;
        public ClimaticsController(IClimaticsService climatics)
        {
            _climatics = climatics;
        }

        public async Task<IActionResult> Index()
        {
            var allClimas = await _climatics.GetAllAsync();
            return View(allClimas);
        }

        
        public async Task<IActionResult> Create()
        {
            var climaDropdownsData = await _climatics.GetNewClimaticDropdownsValues();

            ViewBag.Brands = new SelectList(climaDropdownsData.Brands, "Id", "Name");
            ViewBag.Categories = new SelectList(climaDropdownsData.Categories, "Id", "Name");
            ViewBag.BtuPowers = new SelectList(climaDropdownsData.BtuPowers, "Id", "Power");
            ViewBag.EnergyClassCoolings = new SelectList(climaDropdownsData.EnergyClassCoolings, "Id", "CoolClass");
            ViewBag.EnergyClassHeatings = new SelectList(climaDropdownsData.EnergyClassHeatings, "Id", "HeatClass");
            ViewBag.RoomSizes = new SelectList(climaDropdownsData.RoomSizes, "Id", "Size");

            return View();
        }
    }
}
