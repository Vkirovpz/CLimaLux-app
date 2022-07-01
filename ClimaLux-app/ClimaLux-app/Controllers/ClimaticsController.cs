using ClimaLux_app.Models.Climatics;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using ClimaLux_Services.Climatics;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ClimaLux_Services.Climatics.Models;

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

        [HttpGet]
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

        [HttpPost]
        public async Task<IActionResult> Create(NewClimaticVM clima)
        {
            if (!ModelState.IsValid)
            {
                var climaDropdownsData = await _climatics.GetNewClimaticDropdownsValues();

                ViewBag.Brands = new SelectList(climaDropdownsData.Brands, "Id", "Name");
                ViewBag.Categories = new SelectList(climaDropdownsData.Categories, "Id", "Name");
                ViewBag.BtuPowers = new SelectList(climaDropdownsData.BtuPowers, "Id", "Power");
                ViewBag.EnergyClassCoolings = new SelectList(climaDropdownsData.EnergyClassCoolings, "Id", "CoolClass");
                ViewBag.EnergyClassHeatings = new SelectList(climaDropdownsData.EnergyClassHeatings, "Id", "HeatClass");
                ViewBag.RoomSizes = new SelectList(climaDropdownsData.RoomSizes, "Id", "Size");

                return View(clima);
            }

            var climaToAdd = new NewClimaticSM()
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

            await _climatics.AddNewCliamticAsync(climaToAdd);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var clima = await _climatics.GetClimaticByIdAsync(id);
            if (clima == null) return View("Not found");

            var response = new NewClimaticVM()
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
            var climaDropdownsData = await _climatics.GetNewClimaticDropdownsValues();

            ViewBag.Brands = new SelectList(climaDropdownsData.Brands, "Id", "Name");
            ViewBag.Categories = new SelectList(climaDropdownsData.Categories, "Id", "Name");
            ViewBag.BtuPowers = new SelectList(climaDropdownsData.BtuPowers, "Id", "Power");
            ViewBag.EnergyClassCoolings = new SelectList(climaDropdownsData.EnergyClassCoolings, "Id", "CoolClass");
            ViewBag.EnergyClassHeatings = new SelectList(climaDropdownsData.EnergyClassHeatings, "Id", "HeatClass");
            ViewBag.RoomSizes = new SelectList(climaDropdownsData.RoomSizes, "Id", "Size");

            return View(response);
        }

        public async Task<IActionResult> Details(int id)
        {
            var clima = await _climatics.GetClimaticByIdAsync(id);

            var climaDetails = new NewClimaticVM()
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

            return View(climaDetails);
        }
    }
}
